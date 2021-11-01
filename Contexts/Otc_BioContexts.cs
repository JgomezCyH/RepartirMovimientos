using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Contexts
{
    public class Otc_BioContexts : DbContext
    {
        public Otc_BioContexts(DbContextOptions<Otc_BioContexts> options):base(options)
        {
        }

        public DbSet<MovimientoIncidesnciaNomina> Nomina { get; set; }
        public DbSet<DetalleMovimientoIncidenciaNomina> NominaD { get; set; }
    }
}
