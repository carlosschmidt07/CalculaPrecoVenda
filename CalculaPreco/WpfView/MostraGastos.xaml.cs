using Controlles;
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
        public MostraGastos()
        {
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
            dgGastos.ItemsSource = gc.ListarTodos();
            //dgGastos.ItemsSource = pc.ListarTodos();
        }
    }
}
