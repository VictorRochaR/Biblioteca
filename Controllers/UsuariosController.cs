using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult listaDeUsuarios(){
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeEAdm(this);

            return View(new UsuarioService().Listar());
        }

         public IActionResult editarUsuario(int id){
             Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeEAdm(this);
             Usuario u = new UsuarioService().Listar(id);

             return View(u);
         }

         [HttpPost]
          public IActionResult editarUsuario(Usuario uEdit){
              uEdit.senha = Cript.textoCript(uEdit.senha);
              UsuarioService US = new UsuarioService();
              US.editarUsuario(uEdit);

              return RedirectToAction("ListaDeUsuarios");
          }

          public IActionResult registrarUsuarios(int id){
             Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeEAdm(this);

             return View();
         }

        [HttpPost]
           public IActionResult registrarUsuarios(Usuario novoU){
               Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeEAdm(this);

               novoU.senha = Cript.textoCript(novoU.senha);
               UsuarioService US = new UsuarioService();
               US.incluirUsuario(novoU);

               return RedirectToAction("cadastroRealizado");
           }

           public IActionResult excluirUsuario(int id){
               return View(new UsuarioService().Listar(id));
           }

           [HttpPost]
           public IActionResult excluirUsuario(string decisao, int id){
               if(decisao=="EXCLUIR"){
                   ViewData["Mensagem"] = "Exclusão do usuario "+new UsuarioService().Listar(id).nome+" realizada!";
                   new UsuarioService().excluirUsuario(id);
                   return View("ListaDeUsuarios", new UsuarioService().Listar());
               }else {
                   ViewData["Mensagem"] = "Exclusão Cancelada";
                   return View("ListaDeUsuarios", new UsuarioService().Listar());
               }
           }

           public IActionResult cadastroRealizado(){
               Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeEAdm(this);

            return View();
           }

           public IActionResult precisaAdm(){
               Autenticacao.CheckLogin(this);
               return View();
           }
           public IActionResult Sair(){
               HttpContext.Session.Clear();
               return RedirectToAction("Index","Home");
           }
    }
}