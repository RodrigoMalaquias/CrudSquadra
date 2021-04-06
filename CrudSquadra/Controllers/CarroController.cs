using CrudSquadra.Entities;
using CrudSquadra.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _carro;
 
        public CarroController(ICarroService carro)
        {
            _carro = carro;
        }

        [HttpGet]
        public IActionResult TodosCarros()
        {
            return Ok(_carro.RetonarListaCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id)
        {
            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult carroAdd([FromBody] Carro novoCarro)
        {
            return Ok(_carro.AdicionarCarro(novoCarro));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] Carro novoCarro)
        {
            return Ok(_carro.AtualizarCarro(novoCarro));
        }


        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id)
        {
            return Ok(_carro.DeletarCarro(id));
        }
    }
}
