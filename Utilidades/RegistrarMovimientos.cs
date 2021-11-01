using IncidenciasMixtas.Contexts;
using IncidenciasMixtas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidenciasMixtas.Utilidades
{
    public class RegistrarMovimientos
    {




        public  int EnviarEncabezadoOtc(MovimientoIncidesnciaNomina nomina, puenteContext puenteContext, Otc_BioContexts otc)
        {
            nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            nomina.Id = null;
            nomina.Empresa = "034";
            nomina.FechaOrigen = nomina.FechaRegistro;
            otc.Nomina.Add(nomina);
            otc.SaveChanges();
            MovimientoIncidesnciaNomina nominaotc = otc.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            return (int)nomina.Id;
            
        }
        
        public int EnviarEncabezadoIce(MovimientoIncidesnciaNomina nomina, puenteContext puenteContext, ice_BioContexts otc)
        {
            nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            nomina.Id = null;
            nomina.Empresa = "002";
            nomina.FechaOrigen = nomina.FechaRegistro;
            otc.Nomina.Add(nomina);
            otc.SaveChanges();
            MovimientoIncidesnciaNomina nominaice = otc.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            return (int)nominaice.Id;

        }
        public int EnviarEncabezadoNtc(MovimientoIncidesnciaNomina nomina, puenteContext puenteContext, Ntc_BioContexts otc)
        {
            nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            nomina.Id = null;
            nomina.Empresa = "037";
            nomina.FechaOrigen = nomina.FechaRegistro;
            otc.Nomina.Add(nomina);
            otc.SaveChanges();
            MovimientoIncidesnciaNomina nominantc = otc.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();

            return (int)nominantc.Id;

        }
        
        public int EnviarEncabezadoShelter(MovimientoIncidesnciaNomina nomina, puenteContext puenteContext, Shelter_BioContexts otc)
        {
            nomina = puenteContext.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();
            nomina.Id = null;
            nomina.Empresa = "033";
            nomina.FechaOrigen = nomina.FechaRegistro;
            otc.Nomina.Add(nomina);
            otc.SaveChanges();
            nomina = otc.Nomina.Where(x => x.Mov == "Faltas").OrderBy(x => x.Id).LastOrDefault();

            return (int)nomina.Id;

        }
        
    }
}
