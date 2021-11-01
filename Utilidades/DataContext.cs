using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Utilidades
{
    public class DataContext
    {
        private SqlConnection sqlCon;
        private SqlTransaction sqlTrans;
        private Guid signCon;
        private Guid signTrans;
        private readonly DBConnection _dBConnection;

        public string CodigoCliente { get; set; }
        public DataContext(DBConnection dBConnection)
        {
            this._dBConnection = dBConnection;
        }
        
        public void OpenConnection(Guid sign)
        {
            if (string.IsNullOrWhiteSpace(this.CodigoCliente))
                throw new InvalidOperationException("No se ha establecido el código del cliente");
            if (this.sqlCon != null)
            {
                if (this.sqlCon.State == ConnectionState.Open)
                    return;
                this.sqlCon = null;
                this.signCon = Guid.Empty;
            }
            this.sqlCon = this._dBConnection.GetNewConnection();
            if (this.sqlCon == null)
                return;
            this.signCon = sign;
            if (this.sqlCon.State == ConnectionState.Open)
                return;
            this.sqlCon.Open();
        }
        public void BeginTransaction(Guid sign)
        {
            if (this.sqlCon == null)
                throw new InvalidOperationException("No existe una conexión disponible en el contexto de datos actual.");
            if (this.sqlTrans != null)
                return;
            this.sqlTrans = this.sqlCon.BeginTransaction();
            this.signTrans = sign;
        }

        public void CommitTransaction(Guid sign)
        {
            if (this.signTrans != sign || this.sqlTrans == null)
                return;
            this.sqlTrans.Commit();
            this.signTrans = Guid.Empty;
            this.sqlTrans.Dispose();
        }

        public void RollbackTransaction(Guid sign)
        {
            if (this.signTrans != sign || this.sqlTrans == null)
                return;
            this.sqlTrans.Rollback();
            this.signTrans = Guid.Empty;
            this.sqlTrans.Dispose();
        }
        public SqlCommand CreateCommand()
        {
            SqlCommand command = this.sqlCon.CreateCommand();
            if (this.sqlTrans != null)
                command.Transaction = this.sqlTrans;
            return command;
        }
        public SqlDataAdapter CreateDataAdapter() => new SqlDataAdapter();
        public ConnectionState ConnectionState => this.sqlCon != null ? (ConnectionState)this.sqlCon.State : ConnectionState.Closed;
        public void CloseConnection(Guid sign)
        {
            if (this.sqlCon == null || this.signCon != sign)
                return;
            this.sqlCon.Close();
            this.sqlCon.Dispose();
            this.signCon = Guid.Empty;
        }

    }
}
