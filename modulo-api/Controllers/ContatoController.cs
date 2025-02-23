using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modulo_api.Context;
using modulo_api.Entities;

namespace modulo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController(AgendaContext agendaContext) : Controller
    {
        private readonly AgendaContext agendaContext = agendaContext;

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            agendaContext.Add(contato);
            agendaContext.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {
                id = contato.Id
            }, contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = agendaContext.Contatos.Find(id);
            if (contato == null) return NotFound();
            // 
            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = agendaContext.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = agendaContext.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();
            //
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            // 
            agendaContext.Update(contatoBanco);
            agendaContext.SaveChanges();
            // 
            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = agendaContext.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();
            //
            agendaContext.Contatos.Remove(contatoBanco);
            agendaContext.SaveChanges();
            // 
            return NoContent();
        }
    }
}