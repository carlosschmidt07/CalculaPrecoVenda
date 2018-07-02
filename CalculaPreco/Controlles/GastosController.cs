using Controllers.Base;
using Controlles.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Controlles
{
   public class GastosController : IBaseController<Gastos>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Gastos entity)
        {
            contexto.Gastos.Add(entity);
            contexto.SaveChanges();
        }

        public Gastos BuscarPorID(int id)
        {
            return contexto.Gastos.Find(id);
        }
        
        public void Editar(Gastos entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            Gastos gastos = new Gastos();
            if (gastos != null)
            {
                contexto.Gastos.Remove(gastos);
            }
        }

        public IList<Gastos> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Gastos> ListarTodos()
        {
            return contexto.Gastos.ToList();
        }
        public IList<Gastos> ListarPorUsuario(int id)
        {
            return contexto.Gastos.Where(gas => gas.UsuarioID == id).ToList();
        }
        public IEnumerable<Gastos> BuscaGastosCompra(int id)
        {
            return contexto.Gastos.Where(gas => gas.ProdutoID == id);

        }
        public double SomaGastos(int id)
        {
            IEnumerable<Gastos> valorGastos = BuscaGastosCompra(id);
            double somaValor=0;
            foreach (var valor in valorGastos )
            {

                somaValor = somaValor + valor.Valor;

            }

            return somaValor;


        }
        public void ExcluiGastosCompra(int id)
        {
            IEnumerable<Gastos> gastos = BuscaGastosCompra(id);

            foreach (var gasto in gastos)
            {
                contexto.Gastos.Remove(gasto);
               
            }
            contexto.SaveChanges();
        }
    }
}
