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
    /// Lógica interna para Gerenciar.xaml
    /// </summary>
    public partial class Gerenciar : Window
    {
        public Usuario _Usuario { get; set; }
        public Gerenciar(Usuario u)
        {
            _Usuario = u;
            InitializeComponent();
        }

        private void btnCadastrarCompra_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCompra cadastrarCompra = new CadastrarCompra();
            cadastrarCompra.Show();
        }

        private void btnMostrarGastos_Click(object sender, RoutedEventArgs e)
        {
            MostraGastos mostraGastos = new MostraGastos();
            mostraGastos.Show();
        }
    }
}
