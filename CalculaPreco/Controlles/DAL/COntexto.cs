using System;
using Modelos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlles.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());



        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
    }
}
