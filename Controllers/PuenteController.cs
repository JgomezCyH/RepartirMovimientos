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
    public class PuenteController
    {
        private readonly ILogger<PuenteController> _logger;
        private readonly DataContext context;
        private readonly puenteContext puenteContext;
        private readonly Otc_BioContexts otc;
        private readonly EmpleadosContext empleadosContexts;
        private readonly ice_BioContexts ice_contetxt;
        private readonly Ntc_BioContexts ntc_BioContexts;
        private readonly Shelter_BioContexts shelter_BioContexts;
        public PuenteController(ILogger<PuenteController> logger, puenteContext puenteContext, Otc_BioContexts otc, EmpleadosContext empleados1, ice_BioContexts ice_contetxt, Ntc_BioContexts ntc_BioContexts, Shelter_BioContexts shelter_BioContexts)
        {
            _logger = logger;
            this.otc = otc;
            this.puenteContext = puenteContext;
            this.ice_contetxt = ice_contetxt;
            this.ntc_BioContexts = ntc_BioContexts;
            this.empleadosContexts = empleados1;
            this.shelter_BioContexts = shelter_BioContexts;
        }

        [HttpGet("ice")]
        public MovimientoIncidesnciaNomina Getice()
        {
            RegistrarMovimientos registrar = new RegistrarMovimientos();
            MovimientoIncidesnciaNomina nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            int idpuente = (int)nomina.Id + 0;
            int idice = registrar.EnviarEncabezadoIce(nomina, puenteContext, ice_contetxt);
            Console.WriteLine(idice);
            DetalleMovimientoIncidenciaNomina[] incidenciaNominas = puenteContext.NominaD.Where(x => x.ID == idpuente).ToArray();
            Empleados[] empleados = empleadosContexts.Empleados.Where(x=>x.ServID== 1).ToArray();


            for (int i = 0; i < incidenciaNominas.Length; i++)
            {
                for (int j = 0; j < empleados.Length; j++)
                {
                    if (empleados[j].Personal == incidenciaNominas[i].Personal)
                    {  
                                incidenciaNominas[i].ID = idice;
                                ice_contetxt.NominaD.Add(incidenciaNominas[i]);
                               ice_contetxt.SaveChanges();
                             
                     }


                    }
                }

            


            return nomina;



        }

        [HttpGet("ntc")]
        public MovimientoIncidesnciaNomina Getntc()
        {
            RegistrarMovimientos registrar = new RegistrarMovimientos();
            MovimientoIncidesnciaNomina nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            int idpuente = (int)nomina.Id + 0;
            int idntc = registrar.EnviarEncabezadoNtc(nomina, puenteContext,ntc_BioContexts);
            Console.WriteLine(idntc);
            DetalleMovimientoIncidenciaNomina[] incidenciaNominas = puenteContext.NominaD.Where(x => x.ID == idpuente).ToArray();
            Empleados[] empleados = empleadosContexts.Empleados.Where(x => x.ServID == 3).ToArray();


            for (int i = 0; i < incidenciaNominas.Length; i++)
            {
                for (int j = 0; j < empleados.Length; j++)
                {
                    if (empleados[j].Personal == incidenciaNominas[i].Personal)
                    {
                        incidenciaNominas[i].ID = idntc;
                        ice_contetxt.NominaD.Add(incidenciaNominas[i]);
                        ice_contetxt.SaveChanges();

                    }


                }
            }




            return nomina;



        }


        [HttpGet("otc")]
        public MovimientoIncidesnciaNomina Getotc()
        {
            RegistrarMovimientos registrar = new RegistrarMovimientos();
            MovimientoIncidesnciaNomina nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            int idpuente = (int)nomina.Id + 0;
            int idotc = registrar.EnviarEncabezadoOtc(nomina, puenteContext,otc);
            Console.WriteLine(idotc);
            DetalleMovimientoIncidenciaNomina[] incidenciaNominas = puenteContext.NominaD.Where(x => x.ID == idpuente).ToArray();
            Empleados[] empleados = empleadosContexts.Empleados.Where(x => x.ServID == 2).ToArray();


            for (int i = 0; i < incidenciaNominas.Length; i++)
            {
                for (int j = 0; j < empleados.Length; j++)
                {
                    if (empleados[j].Personal == incidenciaNominas[i].Personal)
                    {
                        incidenciaNominas[i].ID = idotc;
                        ice_contetxt.NominaD.Add(incidenciaNominas[i]);
                        ice_contetxt.SaveChanges();

                    }


                }
            }




            return nomina;



        }

        [HttpGet("shelter")]
        public MovimientoIncidesnciaNomina Getshelter()
        {
            RegistrarMovimientos registrar = new RegistrarMovimientos();
            MovimientoIncidesnciaNomina nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            int idpuente = (int)nomina.Id + 0;
            int idshelter = registrar.EnviarEncabezadoShelter(nomina, puenteContext, shelter_BioContexts);
            Console.WriteLine(idshelter);
            DetalleMovimientoIncidenciaNomina[] incidenciaNominas = puenteContext.NominaD.Where(x => x.ID == idpuente).ToArray();
            Empleados[] empleados = empleadosContexts.Empleados.Where(x => x.ServID == 4).ToArray();


            for (int i = 0; i < incidenciaNominas.Length; i++)
            {
                for (int j = 0; j < empleados.Length; j++)
                {
                    if (empleados[j].Personal == incidenciaNominas[i].Personal)
                    {
                        incidenciaNominas[i].ID = idshelter;
                        ice_contetxt.NominaD.Add(incidenciaNominas[i]);
                        ice_contetxt.SaveChanges();

                    }


                }
            }




            return nomina;



        }
    }
}