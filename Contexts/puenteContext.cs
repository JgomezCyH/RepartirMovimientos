using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;

namespace IncidenciasMixtas.Contexts
{
    public class puenteContext : DbContext
    {

        public puenteContext(DbContextOptions<puenteContext> options) : base(options)
        {
        }


        public DbSet<MovimientoIncidesnciaNomina> Nomina { get; set; }
        public DbSet<DetalleMovimientoIncidenciaNomina> NominaD { get; set; }
        
            


    }
}
