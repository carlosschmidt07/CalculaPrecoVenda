using Controllers.Base;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlles
{
    class GastosController : IBaseController<Gastos>
    {
        public void Adicionar(Gastos entity)
        {
            throw new NotImplementedException();
        }

        public Gastos BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Gastos entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Gastos> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Gastos> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
