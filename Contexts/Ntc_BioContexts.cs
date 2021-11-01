using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Contexts
{
    public class Ntc_BioContexts : DbContext
    {
        public Ntc_BioContexts(DbContextOptions<Ntc_BioContexts> options) : base(options)
        {
        }

        public DbSet<MovimientoIncidesnciaNomina> Nomina { get; set; }
        public DbSet<DetalleMovimientoIncidenciaNomina> NominaD { get; set; }
    }
}
