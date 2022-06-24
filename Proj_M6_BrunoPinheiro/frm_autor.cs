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
    public partial class frm_autor : Form
    {
        public frm_autor()
        {
            InitializeComponent();
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ynw.brunoo/");
        }
    }
}
