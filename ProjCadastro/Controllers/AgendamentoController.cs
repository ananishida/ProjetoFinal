using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjCadastro.Models;
using Repositorio;
using Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCadastro.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            AgendamentoModel model = new AgendamentoModel();
            Contexto context = new Contexto();
            model.ListaVacinas = context.Vacina.ToList();
            model.ListaunidadeAtendimentos = context.UnidadeAtendimento.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Agendamento(string Dia, string Horario, string unidadeatendimento, string tipovacina)
        {
            Contexto context = new Contexto();
            var cpf = HttpContext.Session.GetString("usuarioCpf");
            var user = context.Usuario.First(x=>x.Cidadao.Cpf==cpf);

            var agenda = new Agenda();
            agenda.UnidadeAtendimentoId = int.Parse(unidadeatendimento);
            agenda.vacinaId = int.Parse(tipovacina);
            agenda.usuarioId = user.Id;

            var hm = Horario.Split(':');
            var dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(Dia), int.Parse(hm[0]), int.Parse(hm[1]), 0);
            agenda.dataagendamento = dt;

            context.Agenda.Add(agenda);
            context.SaveChanges();

            var agendamento = new AgendamentoModel();
            agendamento.agenda = agenda;
            agendamento.vacina = context.Vacina.First(x => x.Id == agenda.vacinaId);
            agendamento.unidade = context.UnidadeAtendimento.First(x => x.Id == agenda.UnidadeAtendimentoId);
            agendamento.cidadao = context.Cidadao.First(x => x.Cpf == cpf);



            return View("ConfirmaAgendamento",agendamento);
        }
    }
}
