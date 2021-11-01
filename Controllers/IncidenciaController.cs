using IncidenciasMixtas.Contexts;
using IncidenciasMixtas.Entities;
using IncidenciasMixtas.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class IncidenciaController
    {
        private readonly ILogger<IncidenciaController> _logger;
        private readonly DataContext context;
        private readonly puenteContext puenteContext;

        public IncidenciaController(ILogger<IncidenciaController> logger, puenteContext puenteContex, DataContext context)
        {
            _logger = logger;
            this.context = context;
            this.puenteContext = puenteContex;
        }


        [HttpGet]
        public IEnumerable<DetalleMovimientoIncidenciaNomina> Get()
        {
            try

            {
                MovimientoIncidesnciaNomina nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
                var id = nomina.Id;
              
                return puenteContext.NominaD.Where(x => x.ID == id).ToList();

            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);

                return puenteContext.NominaD.ToList();
            }


    }
    }
}
