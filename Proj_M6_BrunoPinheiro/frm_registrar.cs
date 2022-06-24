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
    public partial class frm_registrar : Form
    {
        string contraste, tipocontraste, reacoes, precototal, data;
        int numex;
        float comp, precocomp, preco;
        bool validarnumex;
        public frm_registrar()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txt_numex.ResetText();
            txt_nome.ResetText();
            cbo_seguro.SelectedIndex = 0;
            txt_nomemedico.ResetText();
            cbo_tipoex.SelectedIndex = 0;
            cbo_local.SelectedIndex = 0;
            rad_sim.Checked = false;
            rad_nao.Checked = false;
            rad_ionico.Checked = false;
            rad_naoionico.Checked = false;
            txt_reacoes.ResetText();
            cbo_valorcomp.SelectedIndex = 0;
            txt_preco.ResetText();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_numex.Text != "")
            {
                validarnumex = int.TryParse(txt_numex.Text, out numex);
                if (validarnumex)
                {
                    if (numex <= 9999)
                    {
                        if (txt_nome.Text != "")
                        {
                            if (cbo_seguro.SelectedIndex != 0)
                            {
                                if (txt_nomemedico.Text != "")
                                {
                                    if (cbo_tipoex.SelectedIndex != 0)
                                    {
                                        if (cbo_local.SelectedIndex != 0)
                                        {
                                            if (rad_sim.Checked == true || rad_nao.Checked == true)
                                            {
                                                if (cbo_valorcomp.SelectedIndex != 0)
                                                {
                                                    if (txt_preco.Text != "")
                                                    {
                                                        if (cbo_valorcomp.SelectedIndex == 1)
                                                        {
                                                            comp = 1;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 2)
                                                        {
                                                            comp = 0.95F;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 3)
                                                        {
                                                            comp = 0.90F;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 4)
                                                        {
                                                            comp = 0.85F;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 5)
                                                        {
                                                            comp = 0.80F;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 6)
                                                        {
                                                            comp = 0.50F;
                                                        }
                                                        else if (cbo_valorcomp.SelectedIndex == 7)
                                                        {
                                                            comp = 0;
                                                        }
                                                        if (rad_sim.Checked == true)
                                                        {
                                                            contraste = "Sim";
                                                        }
                                                        else if (rad_nao.Checked == true)
                                                        {
                                                            contraste = "Não";
                                                        }
                                                        if (rad_ionico.Checked == true)
                                                        {
                                                            tipocontraste = "Iônico";
                                                        }
                                                        else if (rad_naoionico.Checked == true)
                                                        {
                                                            tipocontraste = "Não Iônico";
                                                        }
                                                        if (rad_ionico.Checked == false && rad_naoionico.Checked == false)
                                                        {
                                                            tipocontraste = "Nenhum";
                                                        }
                                                        if (txt_reacoes.Text == "")
                                                        {
                                                            reacoes = "Nenhumas";
                                                        }
                                                        else
                                                        {
                                                            reacoes = txt_reacoes.Text;
                                                        }
                                                        preco = float.Parse(txt_preco.Text);
                                                        if (comp != 0)
                                                        {
                                                            precocomp = preco-(preco * comp);
                                                        }
                                                        else
                                                        {
                                                            precocomp = preco;
                                                        }
                                                        precototal = precocomp.ToString();
                                                        data = dtp_realizacao.Value.ToString("dd/MM/yyyy");
                                                        StreamWriter InfoPacientes = new StreamWriter("InfoPacientes.txt", true);
                                                        InfoPacientes.WriteLine("{0, -5} {1, -20} {2, -15} {3, -20} {4, -20} {5, -22} {6, -10} {7, -10} {8, -10} {9, -15} {10, -5} {11, -15}",
                                                            numex, txt_nome.Text, data, cbo_seguro.Text, txt_nomemedico.Text, cbo_tipoex.Text, cbo_local.Text, contraste, tipocontraste, reacoes, cbo_valorcomp.Text, precototal
                                                            );
                                                        InfoPacientes.Dispose();
                                                        Limpar();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Não selecionou o valor de comparticipação", "Valor de comparticipação",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    cbo_valorcomp.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Não selecionou se existe contraste", "Contraste",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Não selecionou o local", "Local",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            cbo_local.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Não selecionou o tipo de exame", "Tipo de exame",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbo_tipoex.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Não digitou o nome do médico", "Nome do Médico",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_nomemedico.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não selecionou o seguro de saúde", "Seguro de saúde",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbo_seguro.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não digitou o Nome do paciente", "Nome do paciente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_nome.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não digite um número com mais de 5 algarismos", "Número de exame",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_numex.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Não digitou um número de exame", "Número de exame",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_numex.Focus();
                }
            }
            else
            {
                MessageBox.Show("Não digitou o número do exame", "Número de exame",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numex.Focus();
            }
        }

        private void txt_numex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_numex.Text == "")
                {
                    MessageBox.Show("Não digitou o número do exame", "Número de exame",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_numex.Focus();
                }
                else
                {
                    txt_nome.Focus();
                }
            }
        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nome.Text == "")
                {
                    MessageBox.Show("Não digitou o Nome do paciente", "Nome do paciente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nome.Focus();
                }
                else
                {
                    dtp_realizacao.Focus();
                }
            }
        }

        private void dtp_realizacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 cbo_seguro.Focus();
            }
        }

        private void cbo_seguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbo_seguro.SelectedIndex == 0)
                {
                    MessageBox.Show("Não selecionou o seguro de saúde", "Seguro de saúde",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_seguro.Focus();
                }
                else
                {
                    txt_nomemedico.Focus();
                }
            }
        }

        private void frm_registrar_Load(object sender, EventArgs e)
        {
            cbo_seguro.SelectedIndex = 0;
            cbo_seguro.SelectedIndex = 0;
            cbo_tipoex.SelectedIndex = 0;
            cbo_local.SelectedIndex = 0;
            cbo_valorcomp.SelectedIndex = 0;
        }

        private void txt_nomemedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nomemedico.Text == "")
                {
                    MessageBox.Show("Não digitou o nome do médico", "Nome do Médico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nomemedico.Focus();
                }
                else
                {
                    cbo_tipoex.Focus();
                }
            }
        }

        private void cbo_tipoex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbo_tipoex.SelectedIndex==0)
                {
                    MessageBox.Show("Não selecionou o tipo de exame", "Tipo de exame",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_tipoex.Focus();
                }
                else
                {
                    cbo_local.Focus();
                }
            }
        }

        private void cbo_local_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbo_local.SelectedIndex==0)
                {
                    MessageBox.Show("Não selecionou o local", "Local",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_local.Focus();
                }
                else
                {
                    txt_reacoes.Focus();
                }
            }
        }

        private void rad_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_sim.Checked == true)
            {
                grp_tipocontraste.Visible = true;
            }
        }

        private void rad_sim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rad_naoionico.Focus();
            }
        }

        private void txt_preco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_preco.Text == "")
                {
                    MessageBox.Show("Não digitou o preço", "Preço",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_preco.Focus();
                }
                else
                {
                    btn_registrar.PerformClick();
                }
            }
        }

        private void rad_nao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_reacoes.Focus();
            }
        }

        private void txt_reacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbo_valorcomp.Focus();
            }
        }

        private void cbo_valorcomp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbo_valorcomp.SelectedIndex==0)
                {
                    MessageBox.Show("Não selecionou o valor de comparticipação", "Valor de comparticipação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_valorcomp.Focus();
                }
                else
                {
                    txt_preco.Focus();
                }
            }
        }

        private void rad_nao_CheckedChanged(object sender, EventArgs e)
        {
            grp_tipocontraste.Visible = false;
            rad_ionico.Checked = false;
            rad_naoionico.Checked = false;
        }
    }
}
