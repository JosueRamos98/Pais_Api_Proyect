using Microsoft.AspNetCore.Mvc;
using Pais_Api_Proyect.Services;
using System.Collections.Generic;
using System.Web.Http.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pais_Api_Proyect.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDataService _dataService;
        public ValuesController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var paises = _dataService.Get();
            if (paises != null)
            {
                if (paises.Count > 0)
                {
                    return Ok(paises);
                }
                else
                {
                    return NotFound();
                }

            }
            return NotFound();
        }       
        // GET: api/<ValuesController>


        // GET api/<ValuesController>/5
        [HttpGet("{Nombre}")]
        public IActionResult Get(string Nombre)
        {
            var pais = _dataService.Get(Nombre);
            if (pais != null)
            {
                return Ok(pais);
            }
            return NotFound();
        }


    }
}
