using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class Produto
    { 
        public int ProdutoID { get; set; }
       
        public string NomeProduto { get; set; }
        
        public int Quantidade { get; set; }
       
        public double precoCompra { get; set; }
       
        public double Lucro { get; set; }

    }
}
