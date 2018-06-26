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
            Usuario user = new Usuario();
            user = BuscaEmail(email);
           
            if (user.Senha == senha)
            {
                return user;
            }
            else
                return null;
            
        }
        public Usuario BuscaEmail(string email)
        {
            try
            {
                return contexto.Usuarios.Find(email);
            }
            catch (Exception )
            {
                throw new Exception("Email não encontrado!");
                
            }
           
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
