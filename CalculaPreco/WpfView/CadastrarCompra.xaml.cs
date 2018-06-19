using Modelos;
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
    /// Lógica interna para CadastrarCompra.xaml
    /// </summary>
    public partial class CadastrarCompra : Window
    {
        public CadastrarCompra()
        {
            InitializeComponent();
        }

        private void btnGastos_Click(object sender, RoutedEventArgs e)
        {
            //salvar compra
            Produto p = new Produto();
            ProdutoController pc = new ProdutoController();
            p.NomeProduto = nomeProdutoTxt.Text;
            p.Quantidade = int.Parse(qtdeTxt.Text);
            p.precoCompra = double.Parse(valorCopraTxt.Text);
            p.Lucro = double.Parse(LucroTxt.Text);
            pc.Adicionar(p);
            CadastrarGastos cadastrarGastos = new CadastrarGastos(p);
            
            cadastrarGastos.Show();
        }
    }
}
