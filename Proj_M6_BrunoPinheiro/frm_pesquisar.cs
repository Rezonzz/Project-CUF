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
    public partial class frm_pesquisar : Form
    {
        public frm_pesquisar()
        {
            InitializeComponent();
        }

        float maior = 0, menor = 999, precosoma=0, media, contar=0, contarinfmedia=0, preco;

        private void frm_pesquisar_Load(object sender, EventArgs e)
        {
            Ler();
        }

            private void txt_pesqnomepaciente_TextChanged(object sender, EventArgs e)
            {
            dgv_pacientes.Rows.Clear();
            if (txt_pesqnomepaciente.Text != "")
            {
                StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes.EndOfStream)
                {
                    String linha = LerPacientes.ReadLine();
                    String numeroex = linha.Substring(0, 6);
                    String nomeex = linha.Substring(6, 21);
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
                    string pesquisar = nomeex.Trim();
                    if (pesquisar == txt_pesqnomepaciente.Text)
                    {
                        dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                    }
                }
                LerPacientes.Dispose();
            }
            else
            {
                StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes.EndOfStream)
                {
                    String linha = LerPacientes.ReadLine();
                    String numeroex = linha.Substring(0, 6);
                    String nomeex = linha.Substring(6, 21);
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
                    dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                }
                LerPacientes.Dispose();
                txt_pesqnomepaciente.ResetText();
                cbo_local.SelectedIndex = 0;
            }
        }

        private void txt_pesqnomemedico_TextChanged(object sender, EventArgs e)
        {
            dgv_pacientes.Rows.Clear();
            if (txt_pesqnomemedico.Text != "")
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
                    string pesquisar = nomemedico.Trim();
                    if (pesquisar == txt_pesqnomemedico.Text)
                    {
                        dgv_pacientes.Rows.Add(numeroex, nomepaciente, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                    }
                }
                LerPacientes.Dispose();
            }
            else
            {
                StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes.EndOfStream)
                {
                    String linha = LerPacientes.ReadLine();
                    String numeroex = linha.Substring(0, 6);
                    String nomeex = linha.Substring(6, 21);
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
                    dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                }
                LerPacientes.Dispose();
                txt_pesqnomemedico.ResetText();
                cbo_local.SelectedIndex = 0;
            }
        }

        private void cbo_local_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_pacientes.Rows.Clear();
            if (cbo_local.Text != "")
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
                    string pesquisar = local.Trim();
                    if (pesquisar == cbo_local.Text)
                    {
                        dgv_pacientes.Rows.Add(numeroex, nomepaciente, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                    }
                }
                LerPacientes.Dispose();
            }
            else
            {
                StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes.EndOfStream)
                {
                    String linha = LerPacientes.ReadLine();
                    String numeroex = linha.Substring(0, 6);
                    String nomeex = linha.Substring(6, 21);
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
                    dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                }
                LerPacientes.Dispose();
                
                cbo_local.SelectedIndex = 0;
            }
        }

        private void txt_numex_TextChanged(object sender, EventArgs e)
        {
            dgv_pacientes.Rows.Clear();
            if (txt_numex.Text != "")
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
                    string pesquisar = numeroex.Trim();
                    if (pesquisar == txt_numex.Text)
                    {
                        dgv_pacientes.Rows.Add(numeroex, nomepaciente, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                    }
                }
                LerPacientes.Dispose();
            }
            else
            {
                StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes.EndOfStream)
                {
                    String linha = LerPacientes.ReadLine();
                    String numeroex = linha.Substring(0, 6);
                    String nomeex = linha.Substring(6, 21);
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
                    dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
                }
                LerPacientes.Dispose();
                txt_numex.ResetText();
                cbo_local.SelectedIndex = 0;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem a certeza que quer apagar esta linha?", "Apagar Linha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dgv_pacientes.CurrentCell.RowIndex;
                dgv_pacientes.Rows.RemoveAt(index);
                List<string> quotelist = File.ReadAllLines("InfoPacientes.txt").ToList();
                quotelist.RemoveAt(index);
                File.WriteAllLines("InfoPacientes.txt", quotelist.ToArray());

                dgv_pacientes.Rows.Clear();
                Ler();
            }
        }
        public void Ler()
        {
            StreamReader LerPacientes = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
            while (!LerPacientes.EndOfStream)
            {
                contar++;
                String linha = LerPacientes.ReadLine();
                String numeroex = linha.Substring(0, 6);
                String nomeex = linha.Substring(6, 21);
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

                preco = float.Parse(precocomp);
                if (preco > maior)
                {
                    maior = preco;
                    txt_nomecaro.Text = nomeex;
                    txt_tipoexcaro.Text = tipoex;
                    txt_localcaro.Text = local;
                    txt_precoexcaro.Text = precocomp;
                }
                if (preco < menor)
                {
                    menor = preco;
                    txt_nomebarato.Text = nomeex;
                    txt_tipoexbarato.Text = tipoex;
                    txt_localbarato.Text = local;
                    txt_precoexbarato.Text = precocomp;
                }
                precosoma = precosoma + preco;
                dgv_pacientes.Rows.Add(numeroex, nomeex, data, seguro, nomemedico, tipoex, local, contraste, tipocontraste, reacoes, comparticipacao, precocomp);
            }
            LerPacientes.Dispose();
            
            
                StreamReader LerPacientes2 = new StreamReader("InfoPacientes.txt", Encoding.UTF8);
                while (!LerPacientes2.EndOfStream)
                {
                String linha = LerPacientes2.ReadLine();
                String precocomp = linha.Substring(163, 5);
                preco = float.Parse(precocomp);
                    media = precosoma / contar;
                    if (preco < media)
                    {
                        contarinfmedia++;
                    }
                }
                LerPacientes2.Dispose();
                txt_somaprecos.Text = precosoma.ToString();
                txt_precomedio.Text = media.ToString();
                txt_contarinferior.Text = contarinfmedia.ToString();
        }
    }
}
