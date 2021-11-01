using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Contexts
{
    public class IntelisisContext : DbContext
    {
        public IntelisisContext(DbContextOptions<IntelisisContext> options) : base(options)
        {

        }
        public DbSet<ConfiguracionClienteDB> ConfiguracionesCliente { get; set; }
       


    }
}
