using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Entities
{
    public class Empleados 
    {
        public string Personal { get; set; }
        [Key]
        public string Curp { get; set; }
        
        public int ServID { get; set; }
        public string Servidor { get; set; }
    }




}
