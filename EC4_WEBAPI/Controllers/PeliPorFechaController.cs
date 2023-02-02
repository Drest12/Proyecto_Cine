using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EC4_WEBAPI.Models;
namespace EC4_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliPorFechaController : ControllerBase
    {
        BDCINEContext bd = new BDCINEContext();

        // GET: api/Consultas/2018
        [HttpGet("GETPeliPorFecha/{fecha_estreno}", Name = "GETPeliPorFecha")]
        public List<PeliPorFecha> GETPeliPorFecha(int fecha_estreno)
        {
            var listado = bd.peliPorFechas
                .FromSqlRaw<PeliPorFecha>("PeliPorFecha {0}", fecha_estreno)
                .ToList();
            return listado;
        }

    }
}

