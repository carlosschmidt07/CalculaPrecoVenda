﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class Usuario
    {   [Key]
        public int UsuarioID { get; set; }
        [Required]
        public string  Nome { get; set; }
        [Required]
     
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
