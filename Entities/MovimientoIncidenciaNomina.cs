using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Entities
{
  
        public class MovimientoIncidesnciaNomina
        {
        public MovimientoIncidesnciaNomina(int? id, string empresa, string mov, string movId, string concepto, string moneda, double tipoCambio, string usuario, string observaciones, string estatus, DateTime fechaEmision, DateTime ultimoCambio, DateTime? fechaOrigen, DateTime fechaRegistro)
        {
            Id = id;
            Empresa = empresa;
            Mov = mov;
            MovId = movId;
            Concepto = concepto;
            Moneda = moneda;
            TipoCambio = tipoCambio;
            Usuario = usuario;
            Observaciones = observaciones;
            Estatus = estatus;
            FechaEmision = fechaEmision;
            UltimoCambio = ultimoCambio;
            FechaOrigen = fechaOrigen;
            FechaRegistro = fechaRegistro;
        }

        public int? Id { get; set; }
            public string Empresa { get; set; }
            public string Mov { get; set; }
            public string MovId { get; set; }
            public string Concepto { get; set; }
            public string Moneda { get; set; } = "Pesos";
            public double TipoCambio { get; set; } = 1;
            public string Usuario { get; set; }
            public string Observaciones { get; set; }
            public string Estatus { get; set; } = "SINAFECTAR";
            public DateTime FechaEmision { get; set; }
            public DateTime UltimoCambio { get; set; }
            public DateTime? FechaOrigen { get; set; } 
            public DateTime FechaRegistro { get; set; }





         //  public List<DetalleMovimientoIncidenciaNomina>? DetallesMovimiento { get; set; }
    }

}
