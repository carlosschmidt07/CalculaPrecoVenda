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



        void CalculaPreco(object sender, RoutedEventArgs e)
        {

            int idCompra = ((Produto)dgCompra.SelectedItem).ProdutoID;            
            CalculaPrecoVenda(idCompra);
        }
        void btnExcluir(object sender, RoutedEventArgs e)
        {
            int idCompra = ((Produto)dgCompra.SelectedItem).ProdutoID;
            
            ProdutoController pc = new ProdutoController();
            pc.Excluir(idCompra);
            
        }

        private void CalculaPrecoVenda(int id)
        {
            ProdutoController pc = new ProdutoController();
            GastosController gc = new GastosController();

            Produto produto = pc.BuscarPorID(id);

           
            double precoFinal = 0;
            double lucro = 0;

            double soma = gc.SomaGastos(produto.ProdutoID);
                  lucro = produto.Lucro / 100;
                  precoFinal = ((produto.precoCompra + somaGastos) / produto.Quantidade) + lucro;
                  MessageBox.Show("Preço de Venda é: (" + precoFinal + ")");
            
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
