using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                Close();

            }
            else
            {
                MessageBox.Show("Login inválido !");

                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
