
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultar));
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.numeroex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomemedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoexame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodoContraste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reacoesalergicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precocomcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AllowUserToAddRows = false;
            this.dgv_pacientes.AllowUserToDeleteRows = false;
            this.dgv_pacientes.AllowUserToResizeColumns = false;
            this.dgv_pacientes.AllowUserToResizeRows = false;
            this.dgv_pacientes.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroex,
            this.nomepaciente,
            this.Data,
            this.Seguro,
            this.Nomemedico,
            this.Tipoexame,
            this.Local,
            this.Contraste,
            this.TipodoContraste,
            this.Reacoesalergicas,
            this.Valorcomp,
            this.Precocomcomp});
            this.dgv_pacientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_pacientes.Location = new System.Drawing.Point(12, 12);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            this.dgv_pacientes.Size = new System.Drawing.Size(727, 399);
            this.dgv_pacientes.TabIndex = 0;
            // 
            // numeroex
            // 
            this.numeroex.HeaderText = "Número do Exam.";
            this.numeroex.Name = "numeroex";
            this.numeroex.ReadOnly = true;
            // 
            // nomepaciente
            // 
            this.nomepaciente.HeaderText = "Nome do Paciente";
            this.nomepaciente.Name = "nomepaciente";
            this.nomepaciente.ReadOnly = true;
            this.nomepaciente.Width = 150;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 140;
            // 
            // Seguro
            // 
            this.Seguro.HeaderText = "Seguro de Saúde";
            this.Seguro.Name = "Seguro";
            this.Seguro.ReadOnly = true;
            this.Seguro.Width = 150;
            // 
            // Nomemedico
            // 
            this.Nomemedico.HeaderText = "Nome do Médico";
            this.Nomemedico.Name = "Nomemedico";
            this.Nomemedico.ReadOnly = true;
            this.Nomemedico.Width = 150;
            // 
            // Tipoexame
            // 
            this.Tipoexame.HeaderText = "Tipo de Exame";
            this.Tipoexame.Name = "Tipoexame";
            this.Tipoexame.ReadOnly = true;
            this.Tipoexame.Width = 125;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Width = 150;
            // 
            // Contraste
            // 
            this.Contraste.HeaderText = "Contraste";
            this.Contraste.Name = "Contraste";
            this.Contraste.ReadOnly = true;
            // 
            // TipodoContraste
            // 
            this.TipodoContraste.HeaderText = "Tipo do Contraste";
            this.TipodoContraste.Name = "TipodoContraste";
            this.TipodoContraste.ReadOnly = true;
            // 
            // Reacoesalergicas
            // 
            this.Reacoesalergicas.HeaderText = "Reações Alérgicas";
            this.Reacoesalergicas.Name = "Reacoesalergicas";
            this.Reacoesalergicas.ReadOnly = true;
            this.Reacoesalergicas.Width = 250;
            // 
            // Valorcomp
            // 
            this.Valorcomp.HeaderText = "Valor de comparticipação";
            this.Valorcomp.Name = "Valorcomp";
            this.Valorcomp.ReadOnly = true;
            // 
            // Precocomcomp
            // 
            this.Precocomcomp.HeaderText = "Preço com comparticipação";
            this.Precocomcomp.Name = "Precocomcomp";
            this.Precocomcomp.ReadOnly = true;
            // 
            // frm_consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 573);
            this.Controls.Add(this.dgv_pacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consultar";
            this.Load += new System.EventHandler(this.frm_consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomemedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipoexame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraste;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodoContraste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reacoesalergicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precocomcomp;
    }
}