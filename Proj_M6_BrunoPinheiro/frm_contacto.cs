using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_contacto : Form
    {
        public frm_contacto()
        {
            InitializeComponent();
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {
            pic_perfil1.Location = new Point(3, 286);
            pnl_mensagem1.Location = new Point(38, 151);
            pic_escrever.Visible = false;
            pic_escrever2.Visible = true;
            pnl_mensagem1.Visible = true;
            btn_comecar.Enabled = false;
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            btn_nao.Enabled = false;
            pic_perfil1.Location = new Point(3, 341);
            pnl_sim.Visible = true;
            pic_escrever2.Visible = false;
            pnl_mensagem1.Location = new Point(38, -67);
            pnl_mesangem3.Location = new Point(38, 174);
            pnl_mesangem3.Visible = true;
            pic_perfil3.Visible = true;
            btn_sim.BackColor = Color.Silver;
        }

        private void llbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cuf.pt/perguntas-frequentes");
        }

        private void llbl_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=DmwnWrRmTWksmMPDRdvnrWnJKChJhwBlvrPlVgDDpTpBQVJHHbqKrxKQcrJZTMpVSDKKRzBcBXkV");
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            btn_sim.Enabled = false;
            pnl_mensagem1.Location = new Point(38, 115);
            pic_perfil1.Location = new Point(3, 341);
            btn_nao.BackColor = Color.Silver;
            pnl_nao.Visible = true;
            pnl_mensagem2.Visible = true;
            pic_perfil2.Visible = true;
            pic_escrever2.Visible = false;
            pic_perfil1.Visible = true;
        }
    }
}
