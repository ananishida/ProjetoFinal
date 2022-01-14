using CriptografiaSimetricaAndAssimetrica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCadastro.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Acesso(string cpf, string password)
        {
            Contexto context = new Contexto();
            Simetrica a = new Simetrica();
            password = a.EncryptData(password,"atos");

            var usuario = context.Usuario.First(x => x.Cidadao.Cpf == cpf);
            if (usuario.Senha==password)
            {
                HttpContext.Session.SetString("usuarioCpf", cpf);
                return RedirectToAction("Index","Carteirinha");
            }
            else
            {
                ViewBag.erro = "Senha incorreta";
                return View("Index");
            }
            
        }
    }
}
