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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UsuariosController uc = new UsuariosController();
                Usuario usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                uc.Adicionar(usuario);
                MessageBox.Show("Deu Boa");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Deu Ruim (" + ex.Message + ")");
            }
        }
    }
}
