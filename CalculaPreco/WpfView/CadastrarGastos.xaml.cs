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
        public Usuario _Usuario { get; set; }

        public CadastrarGastos(Produto p, Usuario u)
        {
            _Produto = p;
            _Usuario = u;
            InitializeComponent();
        }

        public CadastrarGastos()
        {
            
            InitializeComponent();
        }

        private void btnSalvaGastos_Click(object sender, RoutedEventArgs e)
        {
            Gastos g = new Gastos();
            GastosController gc = new GastosController();
            g.Descricao = descricaoGastoTxt.Text;
            g.Valor = double.Parse(valorGastoTxt.Text);
            g.ProdutoID = _Produto.ProdutoID;
            g.UsuarioID = _Produto.UsuarioID;
            gc.Adicionar(g);
            descricaoGastoTxt.Text = null;
            valorGastoTxt.Text = null;

        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            MostraGastos mostraGastos = new MostraGastos(_Usuario);
            mostraGastos.Show();
        }
    }
}
