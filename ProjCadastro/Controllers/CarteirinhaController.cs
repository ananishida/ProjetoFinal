using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCadastro.Controllers
{
    public class CarteirinhaController : Controller
    {
        public IActionResult Index()
        {
            Contexto context = new Contexto();
            var cpf = HttpContext.Session.GetString("usuarioCpf");
            var usuarios = context.CarteiraVacina
                .Where(x=>x.cidadao.Cpf==cpf).Include(x=>x.vacinaid).ToList();
            foreach (var item in usuarios)
            {
                item.vacina = context.Vacina.First(x => x.Id == item.vacinaid);
            }
            return View(usuarios);
        }


    }
}
