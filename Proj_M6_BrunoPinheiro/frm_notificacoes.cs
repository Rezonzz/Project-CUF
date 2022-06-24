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
    public partial class frm_notificacoes : Form
    {
        public frm_notificacoes()
        {
            InitializeComponent();
        }

        private void pic_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/cuf");
        }

        private void pic_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/cuf.pt/");
        }

        private void pic_linkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/cuf-hospitais-e-clínicas");
        }

        private void pic_yt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/SaudecufPt");
        }

        private void pnl_notificacao_Click(object sender, EventArgs e)
        {
            pnl_notificao1.Location = new Point(39, 50);
            pnl_separador2.Location = new Point(39, 229);
            pnl_notificacao.Visible = false;
            pnl_notificao1.Visible = true;
        }

        private void pnl_notificao1_Click(object sender, EventArgs e)
        {
            pnl_notificao1.Location = new Point(37, 229);
            pnl_separador2.Location = new Point(39, 83);
            pnl_notificacao.Visible = true;
            pnl_notificao1.Visible = false;
        }
    }
}
