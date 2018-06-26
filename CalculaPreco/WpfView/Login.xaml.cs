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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            UsuariosController uc = new UsuariosController();
            Usuario usuario = new Usuario();
            usuario = uc.LoginUsuario(txtEmail.Text ,txtSenha.Text);
            if (usuario != null)
            {
                Gerenciar gerenciar = new Gerenciar(usuario);

                gerenciar.Show();
            }
            else
            {
                MessageBox.Show("Deu Ruim");
            }
           
        }
    }
}
