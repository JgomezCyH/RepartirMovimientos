using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncidenciasMixtas.Utilidades;

namespace IncidenciasMixtas.Entities
{
    public class ConfiguracionClienteDB
    {
        public int? ConfiguracionClienteDBId { get; set; }
        public string CodigoCliente { get; set; }
        public ETipoCliente Tipo { get; set; }
        public string Host { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
