using Controlles;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para MostraGastos.xaml
    /// </summary>
    public partial class MostraGastos : Window
    {
         public Usuario _Usuario { get; set; }
       
        
        public MostraGastos(Usuario u)
        {
            _Usuario = u; ;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDgGastos();
        }

        private void CarregarDgGastos()
        {
            GastosController gc = new GastosController();
            ProdutoController pc = new ProdutoController();
            dgGastos.ItemsSource = gc.ListarPorUsuario(_Usuario.UsuarioID);
            dgCompra.ItemsSource = pc.ListarPorUsuario(_Usuario.UsuarioID);
            
            //dgGastos.ItemsSource = pc.ListarTodos();
        }
    }
}
