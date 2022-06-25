using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_login : Form
    {
        string login;
        OleDbConnection connection = new OleDbConnection();
        public frm_login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login = txt_username.Text;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where Username='" + txt_username.Text + "'and Password='" + txt_password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                frm_menu frm_menu = new frm_menu();
                frm_menu.passar_login(login.ToString());
                frm_menu.Show();
                this.Hide();
                MessageBox.Show("Log in concluido com sucesso.", "Log in - CUF Descobertas");
            }
            else
            {
                lbl_invalido.Visible = true;
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
            connection.Close();
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "Sair da Página de Log in",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked == false)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else if(chk_mostrar.Checked==true && txt_password.Text!="Password")
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            frm_signin frm_signin = new frm_signin();
            frm_signin.Show();
            this.Hide();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.ResetText();
                txt_username.Focus();
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.ResetText();
                txt_password.Focus();
            }
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
