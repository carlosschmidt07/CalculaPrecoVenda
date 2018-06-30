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
   public class ProdutoController : IBaseController<Produto>
    {
        Contexto contexto = new Contexto();
        public void Adicionar(Produto entity)
        {
            contexto.Produtos.Add(entity);
            contexto.SaveChanges();
        }

        public Produto BuscarPorID(int id)
        {
           return contexto.Produtos.Find(id);
        }
       
        public void Editar(Produto entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Produto prod = BuscarPorID(id);
            if (prod != null)
            {
                contexto.Produtos.Remove(prod);
            }
        }

        public IList<Produto> ListarPorNome(string nome)
        {
            return contexto.Produtos.Where(prod => prod.NomeProduto == nome).ToList();
        }

        public IList<Produto> ListarTodos()
        {
            return contexto.Produtos.ToList();
        }
        public IList<Produto> ListarPorUsuario(int id)
        {
            return contexto.Produtos.Where(prod => prod.UsuarioID == id).ToList();
        }
        
    }
}
