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
    public class EmpleadosController
    {
        private readonly ILogger<EmpleadosController> _logger;
        private readonly DataContext context;
        private readonly EmpleadosContext contextEmployees;
        public EmpleadosController(ILogger<EmpleadosController> logger, EmpleadosContext contextEmployees, DataContext context)
        {
            _logger = logger;
            this.context = context;
            this.contextEmployees = contextEmployees;
        }

        [HttpGet]
        public IEnumerable<Empleados> Get()
        {
            
            return contextEmployees.Empleados.ToList();

                }


    }
}
