using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar(){
            using(BibliotecaContext bc = new BibliotecaContext()){
                return bc.usuarios.ToList();
            }
        }

        public Usuario Listar(int id){
            using(BibliotecaContext bc = new BibliotecaContext()){
                return bc.usuarios.Find(id);
            }
        }

        public void incluirUsuario(Usuario novoU){
            using(BibliotecaContext bc = new BibliotecaContext()){
                bc.Add(novoU);
                bc.SaveChanges();
            }
        }

        public void editarUsuario(Usuario usuarioEdit){
            using(BibliotecaContext bc = new BibliotecaContext()){
                Usuario u = bc.usuarios.Find(usuarioEdit.Id);

                u.login = usuarioEdit.login;
                u.nome = usuarioEdit.nome;
                u.senha = usuarioEdit.senha;
                u.tipo = usuarioEdit.tipo;

                bc.SaveChanges();
            }
        }

        public void excluirUsuario(int id){
            using(BibliotecaContext bc = new BibliotecaContext()){
            bc.usuarios.Remove(bc.usuarios.Find(id));
            bc.SaveChanges();
            }
        }

    }
}