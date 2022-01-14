using CriptografiaSimetricaAndAssimetrica;
using Microsoft.AspNetCore.Mvc;
using Repositorio;
using Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCadastro.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario, string confirmarsenha)
        {
            Contexto context = new Contexto();

            if (usuario.Senha==confirmarsenha)
            {
                var Cid = context.Cidadao.Find(usuario.Cidadao.Cpf);
                if (Cid.NomeMae==usuario.Cidadao.NomeMae)
                {

                    Simetrica a = new Simetrica();
                    usuario.Senha = a.EncryptData(usuario.Senha, "atos");

                    usuario.Cidadao = Cid;
                    context.Usuario.Add(usuario);
                    context.SaveChanges();

                }
                else
                {
                    ViewBag.errosenha = "O nome da mãe está incorreto";
                    return View("Index",usuario);
                }
            }
            else
            {
                ViewBag.errosenha = "As duas senhas devem ser iguais!";
                return View("Index", usuario);
            }

            return RedirectToAction("confirmacadastro");
        }
        public IActionResult confirmacadastro()
        {
            return View();
        }
    }
}
