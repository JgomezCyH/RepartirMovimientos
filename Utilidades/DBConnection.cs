using IncidenciasMixtas.Contexts;
using IncidenciasMixtas.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Utilidades
{
    public class DBConnection : RepositoryBase<Empleados>
    {
        /// <summary>
        /// Crea una instancia de la clase
        /// </summary>
        /// <param name="context">Contexto de datos de la base de datos</param>
        public DBConnection(EmpleadosContext context) : base(context)
        
            {
        }
        /// <summary>
        /// Obtiene la cadena de conexión con los parametros configurados para el cliente
        /// </summary>
        /// <param name="codigoCliente">Código del cliente</param>
        /// <returns>Cadena de conexión</returns>
        string GetConnectionString()
        {


            return $"Data Source=34.193.12.24;Initial catalog=CREATIVA_TEST;User ID = sa; Password=Sa123456";
        }
        /// <summary>
        /// Crea una nueva conexión para la base de datos del cliente especificado
        /// </summary>
        /// <param name="codigoCliente">Codigo del cliente</param>
        /// <returns>SqlConnection a la base de datos del cliente</returns>
        public SqlConnection GetNewConnection()
        {
            try
            {
                var connection = new SqlConnection(this.GetConnectionString());
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Ocurrió un error al acceder a la base de datos {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Se detectó una excepción inesperada!!!. {ex.Message}");
            }
        }
        /// <summary>
        /// Crea una conexión a la base de datos con los parametros especificados
        /// </summary>
        /// <param name="host">Servidor que contiene la base de datos</param>
        /// <param name="dataBase">Base de datos a la que se conectara</param>
        /// <param name="user">Usuario con acceso a la base de datos</param>
        /// <param name="password">Contraseña de acceso</param>
        /// <returns>Conexión a la base de datos</returns>
        public SqlConnection GetConnection(string host, string dataBase, string user, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = host;
            builder["Initial Catalog"] = dataBase;
            builder["User id"] = user;
            builder["Password"] = password;
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
