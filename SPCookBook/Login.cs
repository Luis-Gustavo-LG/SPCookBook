using SPCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCookBook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CarregarDados();
        }

        string email;
        string senha;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text.Trim();
            senha = txtSenha.Text.Trim();

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }

            using (var ctx = new SPCookbookEntities())
            {
                var usuario = ctx.Usuario.Where(u => u.email == email && u.senha == senha).FirstOrDefault();

                if(usuario == null)
                {
                    MessageBox.Show("Usuário não existe");
                    return;
                }

                if (chkDados.Checked)
                {
                    Properties.Settings.Default["email"] = email;
                    Properties.Settings.Default["senha"] = senha;
                    Properties.Settings.Default["ManterConectado"] = true;
                }
                else
                {
                    Properties.Settings.Default["email"] = string.Empty;
                    Properties.Settings.Default["senha"] = string.Empty;
                    Properties.Settings.Default["ManterConectado"] = false;
                }

                Properties.Settings.Default.Save();

                UsuarioLogado.CurrentUser = usuario;

                MessageBox.Show("Login feito com sucesso");

                this.Hide();
                Form1 form = new Form1();
                form.Show();

            }
        }

        private void CarregarDados()
        {
            if(Properties.Settings.Default.ManterConectado == true)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtSenha.Text = Properties.Settings.Default.senha;
                chkDados.Checked = true;
            }
        }

        private void picboxOlho_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void picboxOlho_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void picboxCancelar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
