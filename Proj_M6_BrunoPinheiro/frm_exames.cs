using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_exames : Form
    {
        string passar_nome, login;

        private Form currentChildForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public frm_exames()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        public void passar_login(String login)
        {
            passar_nome = login.ToString();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            login = passar_nome;
            frm_menu frm_menu = new frm_menu();
            frm_menu.passar_login(login.ToString());
            frm_menu.Show();
            this.Hide();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_fundo.Controls.Add(childForm);
            pnl_fundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_inicio());
            pic_gifcuf.Visible = false;
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
            pnl_contacto.Visible = false;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_registrar());
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = true;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
            pnl_contacto.Visible = false;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_consultar());
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = true;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
            pnl_contacto.Visible = false;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_pesquisar());
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = true;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
            pnl_contacto.Visible = false;
        }

        private void btn_definicoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_definicoes());
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = true;
            pnl_contacto.Visible = false;
        }

        private void tmr_relogio_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToShortDateString();
            lbl_horas.Text = DateTime.Now.ToShortTimeString();
        }

        private void btn_contacto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_contacto());
            pnl_contacto.Visible = true;
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            login = passar_nome;
            frm_menu frm_menu = new frm_menu();
            frm_menu.passar_login(login.ToString());
            frm_menu.Show();
            this.Hide();
        }

        private void pnl_notificacoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_notificacoes());
            lbl_1.Visible = false;
            lbl_notificacao.Text = "Notificações";
            pnl_contacto.Visible = false;
            pic_gifcuf.Visible = false;
            pnl_registrar.Visible = false;
            pnl_consultar.Visible = false;
            pnl_pesquisar.Visible = false;
            pnl_voltar.Visible = false;
            pnl_definicoes.Visible = false;
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frm_exames_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
        }

        private void frm_exames_Load(object sender, EventArgs e)
        {
            lbl_bemvindo.Text = "Bem vindo(a), Doutor(a) " + passar_nome;
            lbl_ola.Text = "Olá, " + passar_nome;
        }
    }
}
