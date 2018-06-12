using Controllers.Base;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlles
{
    class ProdutoController : IBaseController<Produto>
    {
        public void Adicionar(Produto entity)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
