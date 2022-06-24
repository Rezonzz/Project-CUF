using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_loginadmin : Form
    {
        public frm_loginadmin()
        {
            InitializeComponent();
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

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked == false)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else if (chk_mostrar.Checked == true && txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "Sair da Página de Log in - Admin",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text=="admin" && txt_password.Text=="admin") {
                MessageBox.Show("Log in concluido com sucesso.", "Log in - Admin - CUF Descobertas");
                frm_areaadmin frm_areaadmin = new frm_areaadmin();
                frm_areaadmin.Show();
            }
            else
            {
                lbl_invalido.Visible = true;
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
}
    }
}
