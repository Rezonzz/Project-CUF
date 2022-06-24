using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_signin : Form
    {
        public frm_signin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
        OleDbCommand cmd = new OleDbCommand();

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_confirm.Clear();
            txt_username.Focus();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
                frm_login frm_login = new frm_login();
                frm_login.Show();
                this.Close();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_password.Text == "" && txt_confirm.Text == "")
            {
                MessageBox.Show("As caixas do Username e Password estão vazios", "Sign in Falhado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_password.Text == txt_confirm.Text)
            {
                con.Open();
                string register = "INSERT INTO Users VALUES ('" + txt_username.Text + "','" + txt_password.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                frm_login frm_login = new frm_login();
                frm_login.Show();
                this.Close();
                MessageBox.Show("Registro concluido com sucesso! Agora faça log in.", "Sig in");
            }
            else
            {
                lbl_invalido.Visible = true;
                txt_password.ResetText();
                txt_confirm.ResetText();
                txt_password.Focus();
            }
            
        }

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked == false)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_confirm.UseSystemPasswordChar = false;
            }
            else if (chk_mostrar.Checked == true && txt_password.Text!="Password" && txt_confirm.Text!="Confirm Password")
            {
                txt_password.UseSystemPasswordChar = true;
                txt_confirm.UseSystemPasswordChar = true;
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

        private void txt_username_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.ResetText();
                txt_username.Focus();
            }
        }

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            if (txt_confirm.Text == "Confirmar Password")
            {
                txt_confirm.UseSystemPasswordChar = false;
                txt_confirm.ResetText();
                txt_confirm.Focus();
            }
        }

        private void frm_signin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
        }
    }
}
