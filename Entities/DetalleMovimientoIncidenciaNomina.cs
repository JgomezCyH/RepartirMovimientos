using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidenciasMixtas.Entities
{


    public class DetalleMovimientoIncidenciaNomina
    {
        public DetalleMovimientoIncidenciaNomina(int? iD, double renglon, string modulo, string personal, decimal? importe, decimal? cantidad, int? horas, string concepto, DateTime fechaD, DateTime fechaA, int? sucursal)
        {
            ID = iD;
            Renglon = renglon;
            Modulo = modulo;
            Personal = personal;
            Importe = importe;
            Cantidad = cantidad;
            Horas = horas;
            Concepto = concepto;
            FechaD = fechaD;
            FechaA = fechaA;
            Sucursal = sucursal;
        }

        public int? ID { get; set; }
        [Key]
        public double Renglon { get; set; }
        public string Modulo { get; set; } = "NOM";
        public string Personal { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Horas { get; set; }
        public string Concepto { get; set; }
        public DateTime FechaD { get; set; }
        public DateTime FechaA { get; set; }
        public int? Sucursal { get; set; }

    }
   
}