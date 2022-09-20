using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqnome.Controllers
{
    //[Route("api")]
    [ApiController]
    [Route("[controller]")]
    public class naointeressaController : Controller
    {
        [HttpGet("{semcursodemoramais}/{osso}")]
        //public IActionResult Index()
        public IEnumerable<Cliente> naosei()
        {
            //return Ok(DateTime.Now.ToShortDateString());
            //return View();
            return Ranges();
        }
        //[HttpGet]
        //public IEnumerable<int> Get()
        //{
        //    return Enumerable.Range(1,10);
        //}
        //public IActionResult Ranges()
        [HttpGet("{osso}")]
        public IEnumerable<Cliente> Ranges()
        {
            var clientes = new List<Cliente>
                                {
                                    new Cliente("fulano", 123),
                                    new Cliente("beltrano", 456)
                                };
            //return Ok(Enumerable.Range(1, 10));
            return clientes;
        }
    }
    public class Cliente{
        public string nome { get; set; }
        public int cpf { get; set; }
        public Cliente(string nome, int cpf) {
            this.nome = nome;
            this.cpf = cpf;
        }

    }
}
