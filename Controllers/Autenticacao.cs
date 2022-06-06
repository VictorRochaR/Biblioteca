using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("user")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificaLogin(string login, string senha, Controller controller){
            using(BibliotecaContext bc = new BibliotecaContext()){
                verificaSeAdmExiste(bc);

                senha = Cript.textoCript(senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.usuarios.Where(u => u.login==login && u.senha==senha);
                List<Usuario>ListaUsuarioEncontrado = UsuarioEncontrado.ToList();

                if(ListaUsuarioEncontrado.Count==0){
                    return false;
                } else{
                    controller.HttpContext.Session.SetString("login",ListaUsuarioEncontrado[0].login);
                    controller.HttpContext.Session.SetString("nome",ListaUsuarioEncontrado[0].login);
                    controller.HttpContext.Session.SetString("tipo",ListaUsuarioEncontrado[0].login);
                    return true;
                }
            }
        }

        public static void verificaSeAdmExiste(BibliotecaContext bc){

        }

    }
}