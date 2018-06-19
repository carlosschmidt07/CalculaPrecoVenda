using System;
using Modelos;
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
using Controlles;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para CadastrarGastos.xaml
    /// </summary>
    public partial class CadastrarGastos : Window
    {
        public Produto _Produto { get; set; }

        public CadastrarGastos(Produto p)
        {
            _Produto = p;
            InitializeComponent();
        }

        private void btnSalvaGastos_Click(object sender, RoutedEventArgs e)
        {
            Gastos g = new Gastos();
            GastosController gc = new GastosController();
            g.Descricao = descricaoGastoTxt.Text;
            g.Valor = double.Parse(valorGastoTxt.Text);
            g.ProdutoID = _Produto.ProdutoID;
            gc.Adicionar(g);
            descricaoGastoTxt.Text = null;
            valorGastoTxt.Text = null;

        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            MostraGastos mostraGastos = new MostraGastos();
            mostraGastos.Show();
        }
    }
}
