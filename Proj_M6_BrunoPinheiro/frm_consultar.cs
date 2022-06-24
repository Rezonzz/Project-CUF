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

namespace Proj_M6_BrunoPinheiro
{
    public partial class frm_consultar : Form
    {
        public frm_consultar()
        {
            InitializeComponent();
        }

        private void frm_consultar_Load(object sender, EventArgs e)
        {
            StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
            while (!LerPacientes.EndOfStream)
            {
                String linha = LerPacientes.ReadLine();
                String numeroex = linha.Substring(0, 6);
                String nomepaciente = linha.Substring(6, 21);
                String data = linha.Substring(27, 16);
                String seguro = linha.Substring(43, 21);
                String nomemedico = linha.Substring(64, 21);
                String tipoex = linha.Substring(85, 23);
                String local = linha.Substring(108, 11);
                String contraste = linha.Substring(119, 11);
                String tipocontraste = linha.Substring(130, 11);
                String reacoes = linha.Substring(141, 16);
                String comparticipacao = linha.Substring(157, 6);
                String precocomp = linha.Substring(163, 5);
                dgv_pacientes.Rows.Add(numeroex, nomepaciente, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
            }
            LerPacientes.Dispose();
        }
    }
}
