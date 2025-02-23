using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace modulo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora() 
        {
            return Ok(new {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            });
        }


        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var message = $"Olá {nome}, seja bem vindo";
            return Ok(new { message });
        }
    }
}