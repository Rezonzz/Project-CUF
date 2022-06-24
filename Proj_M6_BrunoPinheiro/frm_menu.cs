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
    public partial class frm_menu : Form
    {
        string passar_nome;
        string login;
        public frm_menu()
        {
            InitializeComponent();
        }
        public void passar_login(String login)
        {
            passar_nome = login.ToString();
        }
        private void btn_autor_Click(object sender, EventArgs e)
        {
            frm_autor frm_autor = new frm_autor();
            frm_autor.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "Sair da Gestão de Exames Médicos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                frm_exames frm_exames = new frm_exames();
                frm_exames.Close();
            }
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja encerrar a sessão?", "Sair da Gestão de Exames Médicos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login frm_login = new frm_login();
                frm_login.Show();
                this.Close();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            login = passar_nome;
            frm_exames frm_exames = new frm_exames(); 
            frm_exames.passar_login(login.ToString());
            frm_exames.Show();
            this.Hide();

        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frm_sobrenos frm_sobrenos = new frm_sobrenos();
            frm_sobrenos.Show();
        }

        private void llbl_privacidade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cuf.pt/politica-de-privacidade-e-cookies");
        }

        private void llbl_termos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cuf.pt/sobre-nos/termos-e-condicoes");
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            frm_loginadmin frm_loginadmin = new frm_loginadmin();
            frm_loginadmin.Show();
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
        }
    }
}
