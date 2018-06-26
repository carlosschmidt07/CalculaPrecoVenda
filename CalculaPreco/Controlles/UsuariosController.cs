using System;
using Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Base;
using Controlles.DAL;

namespace Controlles
{
  public  class UsuariosController : IBaseController<Usuario> 
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find(id);
        }
        public Usuario LoginUsuario(string email, string senha)
        {
            IEnumerable<Usuario> user = BuscaEmail(email);
            
            foreach (var usuario in user)
            {
                if (usuario.Senha == senha)
                {
                    return usuario;
                }
               
            }

            return null;
            
            
        }
        public IEnumerable<Usuario> BuscaEmail(string email)
        {
            return contexto.Usuarios.Where(usu => usu.Email == email);

        }
        public void Editar(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Usuario usu = new Usuario();
            if (usu != null)
            {
                contexto.Usuarios.Remove(usu);
            }
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList();
        }

        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
       
        
    }
}
