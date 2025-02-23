using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Context;
using projeto_mvc.Models;

namespace projeto_mvc.Controllers
{
    public class ContatoController(AgendaContext agendaContext) : Controller
    {
        private readonly AgendaContext _agendaContext = agendaContext;
        public IActionResult Index()
        {
            var contatos = _agendaContext.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _agendaContext.Contatos.Add(contato);
                _agendaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            // 
            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _agendaContext.Contatos.Find(id);
            if (contato == null) return RedirectToAction(nameof(Index));
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _agendaContext.Contatos.Find(contato.Id);
            //
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            //
            _agendaContext.Contatos.Update(contatoBanco);
            _agendaContext.SaveChanges();
            // 
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _agendaContext.Contatos.Find(id);
            if (contato == null) return RedirectToAction(nameof(Index));
            // 
            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _agendaContext.Contatos.Find(id);
            if (contato == null) return RedirectToAction(nameof(Index));
            // 
            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _agendaContext.Contatos.Find(contato.Id);
            //
            _agendaContext.Contatos.Remove(contatoBanco);
            _agendaContext.SaveChanges();
            //
            return RedirectToAction(nameof(Index));
        }
    }
}