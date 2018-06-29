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
        public double somaGastos { get; set; }


        public MostraGastos(Usuario u, double soma)
        {
            somaGastos = soma;
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

       

        private void dgCompra_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            ProdutoController pc = new ProdutoController();
            IList<Produto> p = pc.ListarPorUsuario(_Usuario.UsuarioID);
            double precoFinal = 0;
            foreach (var produto in p)
            {
                if (produto.UsuarioID == _Usuario.UsuarioID)
                {
                    precoFinal = ((produto.precoCompra + somaGastos) / produto.Quantidade) * (produto.Lucro/100);
                    
                    
                    MessageBox.Show("Preço de Venda é: (" + precoFinal + ")");
                }
            }
        }
       
    }
}
