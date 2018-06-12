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
    class UsuariosController : IBaseController<Usuario> 
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
