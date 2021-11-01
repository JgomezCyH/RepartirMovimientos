using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Contexts
{
    public class Shelter_BioContexts : DbContext
    {
        public Shelter_BioContexts(DbContextOptions<Shelter_BioContexts> options) : base(options)
        {
        }

        public DbSet<MovimientoIncidesnciaNomina> Nomina { get; set; }
        public DbSet<DetalleMovimientoIncidenciaNomina> NominaD { get; set; }
    }
}
