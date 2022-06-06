using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
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
                    controller.HttpContext.Session.SetString("nome",ListaUsuarioEncontrado[0].nome);
                    controller.HttpContext.Session.SetInt32("tipo",ListaUsuarioEncontrado[0].tipo);
                    return true;
                }
            }
        }

        public static void verificaSeAdmExiste(BibliotecaContext bc){
            IQueryable<Usuario> usuEncontrado = bc.usuarios.Where(u => u.login=="admin");

            if(usuEncontrado.ToList().Count()==0){
                Usuario admin = new Usuario();
                admin.login = "admin";
                admin.senha = Cript.textoCript("123");
                admin.tipo = Usuario.ADMIN;
                admin.nome = "Administrator";

                bc.usuarios.Add(admin);
                bc.SaveChanges();
            }
        }

        public static void verificaSeEAdm(Controller controller){
            if((controller.HttpContext.Session.GetInt32("tipo")==Usuario.ADMIN)){
                
            }else{
                controller.Request.HttpContext.Response.Redirect("/Usuarios/precisaAdm");
            }
        }

    }
}