﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class Gastos
    {
        public int GastosID { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int ProdutoID { get; set; }
        public int UsuarioID { get; set; }
    }
}
