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
    public class STOCKSPEController : ControllerBase
    { 
        BDCINEContext bd = new BDCINEContext();

        // GET: api/Consultas/2011
        [HttpGet("GETSTOCKSPE/{sto_producto}", Name = "GETSTOCKSPE")]
        public List<STOCKSPE> GETSTOCKSPE(int sto_producto)
        {
            var listado = bd.STOCKSPES
                .FromSqlRaw<STOCKSPE>("STOCKSPE {0}", sto_producto)
                .ToList();
            return listado;
        }
    }
}

