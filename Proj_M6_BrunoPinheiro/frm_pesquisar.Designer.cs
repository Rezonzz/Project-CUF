
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisar));
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
            this.pnl_pesquisar = new System.Windows.Forms.Panel();
            this.txt_numex = new System.Windows.Forms.TextBox();
            this.lbl_numex = new System.Windows.Forms.Label();
            this.cbo_local = new System.Windows.Forms.ComboBox();
            this.lbl_pesqlocal = new System.Windows.Forms.Label();
            this.txt_pesqnomemedico = new System.Windows.Forms.TextBox();
            this.lbl_pesqnomemedico = new System.Windows.Forms.Label();
            this.txt_pesqnomepaciente = new System.Windows.Forms.TextBox();
            this.lbl_pesqnomepaciente = new System.Windows.Forms.Label();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_estatistica = new System.Windows.Forms.Label();
            this.pnl_estatistica = new System.Windows.Forms.Panel();
            this.txt_precoexbarato = new System.Windows.Forms.TextBox();
            this.lbl_precoexbarato = new System.Windows.Forms.Label();
            this.txt_localbarato = new System.Windows.Forms.TextBox();
            this.lbl_localbarato = new System.Windows.Forms.Label();
            this.txt_tipoexbarato = new System.Windows.Forms.TextBox();
            this.lbl_tipoexbarato = new System.Windows.Forms.Label();
            this.txt_nomebarato = new System.Windows.Forms.TextBox();
            this.lbl_nomebarato = new System.Windows.Forms.Label();
            this.txt_precoexcaro = new System.Windows.Forms.TextBox();
            this.lbl_precoexcaro = new System.Windows.Forms.Label();
            this.txt_localcaro = new System.Windows.Forms.TextBox();
            this.lbl_localcaro = new System.Windows.Forms.Label();
            this.txt_tipoexcaro = new System.Windows.Forms.TextBox();
            this.lbl_tipoexcaro = new System.Windows.Forms.Label();
            this.txt_nomecaro = new System.Windows.Forms.TextBox();
            this.lbl_nomecaro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_estatistica1 = new System.Windows.Forms.Label();
            this.pnl_estistica1 = new System.Windows.Forms.Panel();
            this.txt_contarinferior = new System.Windows.Forms.TextBox();
            this.lbl_contarinferior = new System.Windows.Forms.Label();
            this.txt_precomedio = new System.Windows.Forms.TextBox();
            this.lbl_precomedia = new System.Windows.Forms.Label();
            this.txt_somaprecos = new System.Windows.Forms.TextBox();
            this.lbl_somaprecos = new System.Windows.Forms.Label();
            this.lbl_aviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.pnl_pesquisar.SuspendLayout();
            this.pnl_estatistica.SuspendLayout();
            this.pnl_estistica1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
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
            this.dgv_pacientes.Size = new System.Drawing.Size(727, 161);
            this.dgv_pacientes.TabIndex = 1;
            // 
            // numeroex
            // 
            this.numeroex.HeaderText = "Número do Exam.";
            this.numeroex.Name = "numeroex";
            // 
            // nomepaciente
            // 
            this.nomepaciente.HeaderText = "Nome do Paciente";
            this.nomepaciente.Name = "nomepaciente";
            this.nomepaciente.Width = 150;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 140;
            // 
            // Seguro
            // 
            this.Seguro.HeaderText = "Seguro de Saúde";
            this.Seguro.Name = "Seguro";
            this.Seguro.Width = 150;
            // 
            // Nomemedico
            // 
            this.Nomemedico.HeaderText = "Nome do Médico";
            this.Nomemedico.Name = "Nomemedico";
            this.Nomemedico.Width = 150;
            // 
            // Tipoexame
            // 
            this.Tipoexame.HeaderText = "Tipo de Exame";
            this.Tipoexame.Name = "Tipoexame";
            this.Tipoexame.Width = 125;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.Width = 125;
            // 
            // Contraste
            // 
            this.Contraste.HeaderText = "Contraste";
            this.Contraste.Name = "Contraste";
            // 
            // TipodoContraste
            // 
            this.TipodoContraste.HeaderText = "Tipo do Contraste";
            this.TipodoContraste.Name = "TipodoContraste";
            // 
            // Reacoesalergicas
            // 
            this.Reacoesalergicas.HeaderText = "Reações Alérgicas";
            this.Reacoesalergicas.Name = "Reacoesalergicas";
            this.Reacoesalergicas.Width = 250;
            // 
            // Valorcomp
            // 
            this.Valorcomp.HeaderText = "Valor de comparticipação";
            this.Valorcomp.Name = "Valorcomp";
            // 
            // Precocomcomp
            // 
            this.Precocomcomp.HeaderText = "Preço com comparticipação";
            this.Precocomcomp.Name = "Precocomcomp";
            // 
            // pnl_pesquisar
            // 
            this.pnl_pesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_pesquisar.Controls.Add(this.txt_numex);
            this.pnl_pesquisar.Controls.Add(this.lbl_numex);
            this.pnl_pesquisar.Controls.Add(this.cbo_local);
            this.pnl_pesquisar.Controls.Add(this.lbl_pesqlocal);
            this.pnl_pesquisar.Controls.Add(this.txt_pesqnomemedico);
            this.pnl_pesquisar.Controls.Add(this.lbl_pesqnomemedico);
            this.pnl_pesquisar.Controls.Add(this.txt_pesqnomepaciente);
            this.pnl_pesquisar.Controls.Add(this.lbl_pesqnomepaciente);
            this.pnl_pesquisar.Location = new System.Drawing.Point(12, 198);
            this.pnl_pesquisar.Name = "pnl_pesquisar";
            this.pnl_pesquisar.Size = new System.Drawing.Size(350, 170);
            this.pnl_pesquisar.TabIndex = 2;
            // 
            // txt_numex
            // 
            this.txt_numex.Location = new System.Drawing.Point(173, 42);
            this.txt_numex.Name = "txt_numex";
            this.txt_numex.Size = new System.Drawing.Size(168, 20);
            this.txt_numex.TabIndex = 13;
            this.txt_numex.TextChanged += new System.EventHandler(this.txt_numex_TextChanged);
            // 
            // lbl_numex
            // 
            this.lbl_numex.AutoSize = true;
            this.lbl_numex.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numex.Location = new System.Drawing.Point(40, 41);
            this.lbl_numex.Name = "lbl_numex";
            this.lbl_numex.Size = new System.Drawing.Size(127, 19);
            this.lbl_numex.TabIndex = 12;
            this.lbl_numex.Text = "Número do exame:";
            // 
            // cbo_local
            // 
            this.cbo_local.FormattingEnabled = true;
            this.cbo_local.Items.AddRange(new object[] {
            "Selecione o local:",
            "Bexiga",
            "Braço",
            "Cabeça",
            "Cérebro",
            "Costas",
            "Crânio",
            "Esôfago",
            "Estômago",
            "Joelho",
            "Mão",
            "Nariz",
            "Olhos",
            "Ombro",
            "Ouvido",
            "Pé",
            "Peito",
            "Perna",
            "Pescoço",
            "Pulmões"});
            this.cbo_local.Location = new System.Drawing.Point(173, 136);
            this.cbo_local.Name = "cbo_local";
            this.cbo_local.Size = new System.Drawing.Size(168, 21);
            this.cbo_local.TabIndex = 11;
            this.cbo_local.SelectedIndexChanged += new System.EventHandler(this.cbo_local_SelectedIndexChanged);
            // 
            // lbl_pesqlocal
            // 
            this.lbl_pesqlocal.AutoSize = true;
            this.lbl_pesqlocal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesqlocal.Location = new System.Drawing.Point(65, 135);
            this.lbl_pesqlocal.Name = "lbl_pesqlocal";
            this.lbl_pesqlocal.Size = new System.Drawing.Size(106, 19);
            this.lbl_pesqlocal.TabIndex = 4;
            this.lbl_pesqlocal.Text = "Pesquisar Local:";
            // 
            // txt_pesqnomemedico
            // 
            this.txt_pesqnomemedico.Location = new System.Drawing.Point(173, 103);
            this.txt_pesqnomemedico.Name = "txt_pesqnomemedico";
            this.txt_pesqnomemedico.Size = new System.Drawing.Size(168, 20);
            this.txt_pesqnomemedico.TabIndex = 3;
            this.txt_pesqnomemedico.TextChanged += new System.EventHandler(this.txt_pesqnomemedico_TextChanged);
            // 
            // lbl_pesqnomemedico
            // 
            this.lbl_pesqnomemedico.AutoSize = true;
            this.lbl_pesqnomemedico.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesqnomemedico.Location = new System.Drawing.Point(13, 103);
            this.lbl_pesqnomemedico.Name = "lbl_pesqnomemedico";
            this.lbl_pesqnomemedico.Size = new System.Drawing.Size(158, 19);
            this.lbl_pesqnomemedico.TabIndex = 2;
            this.lbl_pesqnomemedico.Text = "Pesquisar nome médico:";
            // 
            // txt_pesqnomepaciente
            // 
            this.txt_pesqnomepaciente.Location = new System.Drawing.Point(173, 72);
            this.txt_pesqnomepaciente.Name = "txt_pesqnomepaciente";
            this.txt_pesqnomepaciente.Size = new System.Drawing.Size(168, 20);
            this.txt_pesqnomepaciente.TabIndex = 1;
            this.txt_pesqnomepaciente.TextChanged += new System.EventHandler(this.txt_pesqnomepaciente_TextChanged);
            // 
            // lbl_pesqnomepaciente
            // 
            this.lbl_pesqnomepaciente.AutoSize = true;
            this.lbl_pesqnomepaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesqnomepaciente.Location = new System.Drawing.Point(7, 72);
            this.lbl_pesqnomepaciente.Name = "lbl_pesqnomepaciente";
            this.lbl_pesqnomepaciente.Size = new System.Drawing.Size(165, 19);
            this.lbl_pesqnomepaciente.TabIndex = 0;
            this.lbl_pesqnomepaciente.Text = "Pesquisar nome paciente:";
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_pesquisar.Location = new System.Drawing.Point(12, 184);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(99, 23);
            this.lbl_pesquisar.TabIndex = 0;
            this.lbl_pesquisar.Text = "Pesquisar";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Location = new System.Drawing.Point(231, 399);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(131, 45);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_estatistica
            // 
            this.lbl_estatistica.AutoSize = true;
            this.lbl_estatistica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_estatistica.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatistica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_estatistica.Location = new System.Drawing.Point(398, 184);
            this.lbl_estatistica.Name = "lbl_estatistica";
            this.lbl_estatistica.Size = new System.Drawing.Size(105, 23);
            this.lbl_estatistica.TabIndex = 4;
            this.lbl_estatistica.Text = "Estatistica";
            // 
            // pnl_estatistica
            // 
            this.pnl_estatistica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_estatistica.Controls.Add(this.txt_precoexbarato);
            this.pnl_estatistica.Controls.Add(this.lbl_precoexbarato);
            this.pnl_estatistica.Controls.Add(this.txt_localbarato);
            this.pnl_estatistica.Controls.Add(this.lbl_localbarato);
            this.pnl_estatistica.Controls.Add(this.txt_tipoexbarato);
            this.pnl_estatistica.Controls.Add(this.lbl_tipoexbarato);
            this.pnl_estatistica.Controls.Add(this.txt_nomebarato);
            this.pnl_estatistica.Controls.Add(this.lbl_nomebarato);
            this.pnl_estatistica.Controls.Add(this.txt_precoexcaro);
            this.pnl_estatistica.Controls.Add(this.lbl_precoexcaro);
            this.pnl_estatistica.Controls.Add(this.txt_localcaro);
            this.pnl_estatistica.Controls.Add(this.lbl_localcaro);
            this.pnl_estatistica.Controls.Add(this.txt_tipoexcaro);
            this.pnl_estatistica.Controls.Add(this.lbl_tipoexcaro);
            this.pnl_estatistica.Controls.Add(this.txt_nomecaro);
            this.pnl_estatistica.Controls.Add(this.lbl_nomecaro);
            this.pnl_estatistica.Controls.Add(this.label2);
            this.pnl_estatistica.Controls.Add(this.label5);
            this.pnl_estatistica.Location = new System.Drawing.Point(398, 198);
            this.pnl_estatistica.Name = "pnl_estatistica";
            this.pnl_estatistica.Size = new System.Drawing.Size(307, 225);
            this.pnl_estatistica.TabIndex = 5;
            // 
            // txt_precoexbarato
            // 
            this.txt_precoexbarato.Location = new System.Drawing.Point(182, 189);
            this.txt_precoexbarato.Name = "txt_precoexbarato";
            this.txt_precoexbarato.ReadOnly = true;
            this.txt_precoexbarato.Size = new System.Drawing.Size(102, 20);
            this.txt_precoexbarato.TabIndex = 28;
            this.txt_precoexbarato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_precoexbarato
            // 
            this.lbl_precoexbarato.AutoSize = true;
            this.lbl_precoexbarato.Location = new System.Drawing.Point(189, 173);
            this.lbl_precoexbarato.Name = "lbl_precoexbarato";
            this.lbl_precoexbarato.Size = new System.Drawing.Size(87, 13);
            this.lbl_precoexbarato.TabIndex = 27;
            this.lbl_precoexbarato.Text = "Preço do exame:";
            // 
            // txt_localbarato
            // 
            this.txt_localbarato.Location = new System.Drawing.Point(182, 146);
            this.txt_localbarato.Name = "txt_localbarato";
            this.txt_localbarato.ReadOnly = true;
            this.txt_localbarato.Size = new System.Drawing.Size(102, 20);
            this.txt_localbarato.TabIndex = 26;
            this.txt_localbarato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_localbarato
            // 
            this.lbl_localbarato.AutoSize = true;
            this.lbl_localbarato.Location = new System.Drawing.Point(214, 130);
            this.lbl_localbarato.Name = "lbl_localbarato";
            this.lbl_localbarato.Size = new System.Drawing.Size(36, 13);
            this.lbl_localbarato.TabIndex = 25;
            this.lbl_localbarato.Text = "Local:";
            // 
            // txt_tipoexbarato
            // 
            this.txt_tipoexbarato.Location = new System.Drawing.Point(182, 105);
            this.txt_tipoexbarato.Name = "txt_tipoexbarato";
            this.txt_tipoexbarato.ReadOnly = true;
            this.txt_tipoexbarato.Size = new System.Drawing.Size(102, 20);
            this.txt_tipoexbarato.TabIndex = 24;
            this.txt_tipoexbarato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_tipoexbarato
            // 
            this.lbl_tipoexbarato.AutoSize = true;
            this.lbl_tipoexbarato.Location = new System.Drawing.Point(193, 89);
            this.lbl_tipoexbarato.Name = "lbl_tipoexbarato";
            this.lbl_tipoexbarato.Size = new System.Drawing.Size(80, 13);
            this.lbl_tipoexbarato.TabIndex = 23;
            this.lbl_tipoexbarato.Text = "Tipo de exame:";
            // 
            // txt_nomebarato
            // 
            this.txt_nomebarato.Location = new System.Drawing.Point(182, 61);
            this.txt_nomebarato.Name = "txt_nomebarato";
            this.txt_nomebarato.ReadOnly = true;
            this.txt_nomebarato.Size = new System.Drawing.Size(102, 20);
            this.txt_nomebarato.TabIndex = 22;
            this.txt_nomebarato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nomebarato
            // 
            this.lbl_nomebarato.AutoSize = true;
            this.lbl_nomebarato.Location = new System.Drawing.Point(184, 45);
            this.lbl_nomebarato.Name = "lbl_nomebarato";
            this.lbl_nomebarato.Size = new System.Drawing.Size(97, 13);
            this.lbl_nomebarato.TabIndex = 21;
            this.lbl_nomebarato.Text = "Nome do paciente:";
            // 
            // txt_precoexcaro
            // 
            this.txt_precoexcaro.Location = new System.Drawing.Point(20, 189);
            this.txt_precoexcaro.Name = "txt_precoexcaro";
            this.txt_precoexcaro.ReadOnly = true;
            this.txt_precoexcaro.Size = new System.Drawing.Size(102, 20);
            this.txt_precoexcaro.TabIndex = 20;
            this.txt_precoexcaro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_precoexcaro
            // 
            this.lbl_precoexcaro.AutoSize = true;
            this.lbl_precoexcaro.Location = new System.Drawing.Point(27, 173);
            this.lbl_precoexcaro.Name = "lbl_precoexcaro";
            this.lbl_precoexcaro.Size = new System.Drawing.Size(87, 13);
            this.lbl_precoexcaro.TabIndex = 19;
            this.lbl_precoexcaro.Text = "Preço do exame:";
            // 
            // txt_localcaro
            // 
            this.txt_localcaro.Location = new System.Drawing.Point(20, 146);
            this.txt_localcaro.Name = "txt_localcaro";
            this.txt_localcaro.ReadOnly = true;
            this.txt_localcaro.Size = new System.Drawing.Size(102, 20);
            this.txt_localcaro.TabIndex = 18;
            this.txt_localcaro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_localcaro
            // 
            this.lbl_localcaro.AutoSize = true;
            this.lbl_localcaro.Location = new System.Drawing.Point(52, 130);
            this.lbl_localcaro.Name = "lbl_localcaro";
            this.lbl_localcaro.Size = new System.Drawing.Size(36, 13);
            this.lbl_localcaro.TabIndex = 17;
            this.lbl_localcaro.Text = "Local:";
            // 
            // txt_tipoexcaro
            // 
            this.txt_tipoexcaro.Location = new System.Drawing.Point(20, 105);
            this.txt_tipoexcaro.Name = "txt_tipoexcaro";
            this.txt_tipoexcaro.ReadOnly = true;
            this.txt_tipoexcaro.Size = new System.Drawing.Size(102, 20);
            this.txt_tipoexcaro.TabIndex = 16;
            this.txt_tipoexcaro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_tipoexcaro
            // 
            this.lbl_tipoexcaro.AutoSize = true;
            this.lbl_tipoexcaro.Location = new System.Drawing.Point(31, 89);
            this.lbl_tipoexcaro.Name = "lbl_tipoexcaro";
            this.lbl_tipoexcaro.Size = new System.Drawing.Size(80, 13);
            this.lbl_tipoexcaro.TabIndex = 15;
            this.lbl_tipoexcaro.Text = "Tipo de exame:";
            // 
            // txt_nomecaro
            // 
            this.txt_nomecaro.Location = new System.Drawing.Point(20, 61);
            this.txt_nomecaro.Name = "txt_nomecaro";
            this.txt_nomecaro.ReadOnly = true;
            this.txt_nomecaro.Size = new System.Drawing.Size(102, 20);
            this.txt_nomecaro.TabIndex = 14;
            this.txt_nomecaro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nomecaro
            // 
            this.lbl_nomecaro.AutoSize = true;
            this.lbl_nomecaro.Location = new System.Drawing.Point(22, 45);
            this.lbl_nomecaro.Name = "lbl_nomecaro";
            this.lbl_nomecaro.Size = new System.Drawing.Size(97, 13);
            this.lbl_nomecaro.TabIndex = 13;
            this.lbl_nomecaro.Text = "Nome do paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exame mais caro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Exame mais barato:";
            // 
            // lbl_estatistica1
            // 
            this.lbl_estatistica1.AutoSize = true;
            this.lbl_estatistica1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_estatistica1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatistica1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_estatistica1.Location = new System.Drawing.Point(12, 385);
            this.lbl_estatistica1.Name = "lbl_estatistica1";
            this.lbl_estatistica1.Size = new System.Drawing.Size(105, 23);
            this.lbl_estatistica1.TabIndex = 6;
            this.lbl_estatistica1.Text = "Estatistica";
            // 
            // pnl_estistica1
            // 
            this.pnl_estistica1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_estistica1.Controls.Add(this.txt_contarinferior);
            this.pnl_estistica1.Controls.Add(this.lbl_contarinferior);
            this.pnl_estistica1.Controls.Add(this.txt_precomedio);
            this.pnl_estistica1.Controls.Add(this.lbl_precomedia);
            this.pnl_estistica1.Controls.Add(this.txt_somaprecos);
            this.pnl_estistica1.Controls.Add(this.lbl_somaprecos);
            this.pnl_estistica1.Location = new System.Drawing.Point(12, 399);
            this.pnl_estistica1.Name = "pnl_estistica1";
            this.pnl_estistica1.Size = new System.Drawing.Size(191, 162);
            this.pnl_estistica1.TabIndex = 7;
            // 
            // txt_contarinferior
            // 
            this.txt_contarinferior.Location = new System.Drawing.Point(44, 127);
            this.txt_contarinferior.Name = "txt_contarinferior";
            this.txt_contarinferior.ReadOnly = true;
            this.txt_contarinferior.Size = new System.Drawing.Size(102, 20);
            this.txt_contarinferior.TabIndex = 20;
            // 
            // lbl_contarinferior
            // 
            this.lbl_contarinferior.AutoSize = true;
            this.lbl_contarinferior.Location = new System.Drawing.Point(15, 110);
            this.lbl_contarinferior.Name = "lbl_contarinferior";
            this.lbl_contarinferior.Size = new System.Drawing.Size(167, 13);
            this.lbl_contarinferior.TabIndex = 19;
            this.lbl_contarinferior.Text = "Quantos preços inferioes a média:";
            // 
            // txt_precomedio
            // 
            this.txt_precomedio.Location = new System.Drawing.Point(44, 82);
            this.txt_precomedio.Name = "txt_precomedio";
            this.txt_precomedio.ReadOnly = true;
            this.txt_precomedio.Size = new System.Drawing.Size(102, 20);
            this.txt_precomedio.TabIndex = 18;
            // 
            // lbl_precomedia
            // 
            this.lbl_precomedia.AutoSize = true;
            this.lbl_precomedia.Location = new System.Drawing.Point(60, 66);
            this.lbl_precomedia.Name = "lbl_precomedia";
            this.lbl_precomedia.Size = new System.Drawing.Size(70, 13);
            this.lbl_precomedia.TabIndex = 17;
            this.lbl_precomedia.Text = "Preço Médio:";
            // 
            // txt_somaprecos
            // 
            this.txt_somaprecos.Location = new System.Drawing.Point(44, 37);
            this.txt_somaprecos.Name = "txt_somaprecos";
            this.txt_somaprecos.ReadOnly = true;
            this.txt_somaprecos.Size = new System.Drawing.Size(102, 20);
            this.txt_somaprecos.TabIndex = 16;
            // 
            // lbl_somaprecos
            // 
            this.lbl_somaprecos.AutoSize = true;
            this.lbl_somaprecos.Location = new System.Drawing.Point(32, 21);
            this.lbl_somaprecos.Name = "lbl_somaprecos";
            this.lbl_somaprecos.Size = new System.Drawing.Size(130, 13);
            this.lbl_somaprecos.TabIndex = 15;
            this.lbl_somaprecos.Text = "Soma de todos os preços:";
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.Color.Azure;
            this.lbl_aviso.Location = new System.Drawing.Point(368, 426);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(375, 61);
            this.lbl_aviso.TabIndex = 8;
            this.lbl_aviso.Text = "Para Atualizar os dados caso elimine uma linha clique no botao \"Pesquisar/Editar\"" +
    " no menu lateral";
            // 
            // frm_pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 573);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.lbl_estatistica1);
            this.Controls.Add(this.lbl_estatistica);
            this.Controls.Add(this.pnl_estatistica);
            this.Controls.Add(this.pnl_estistica1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.pnl_pesquisar);
            this.Controls.Add(this.dgv_pacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_pesquisar";
            this.Text = "frm_pesquisar";
            this.Load += new System.EventHandler(this.frm_pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.pnl_pesquisar.ResumeLayout(false);
            this.pnl_pesquisar.PerformLayout();
            this.pnl_estatistica.ResumeLayout(false);
            this.pnl_estatistica.PerformLayout();
            this.pnl_estistica1.ResumeLayout(false);
            this.pnl_estistica1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Panel pnl_pesquisar;
        private System.Windows.Forms.Label lbl_pesqlocal;
        private System.Windows.Forms.TextBox txt_pesqnomemedico;
        private System.Windows.Forms.Label lbl_pesqnomemedico;
        private System.Windows.Forms.TextBox txt_pesqnomepaciente;
        private System.Windows.Forms.Label lbl_pesqnomepaciente;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.ComboBox cbo_local;
        private System.Windows.Forms.TextBox txt_numex;
        private System.Windows.Forms.Label lbl_numex;
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
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_estatistica;
        private System.Windows.Forms.Panel pnl_estatistica;
        private System.Windows.Forms.TextBox txt_precoexbarato;
        private System.Windows.Forms.Label lbl_precoexbarato;
        private System.Windows.Forms.TextBox txt_localbarato;
        private System.Windows.Forms.Label lbl_localbarato;
        private System.Windows.Forms.TextBox txt_tipoexbarato;
        private System.Windows.Forms.Label lbl_tipoexbarato;
        private System.Windows.Forms.TextBox txt_nomebarato;
        private System.Windows.Forms.Label lbl_nomebarato;
        private System.Windows.Forms.TextBox txt_precoexcaro;
        private System.Windows.Forms.Label lbl_precoexcaro;
        private System.Windows.Forms.TextBox txt_localcaro;
        private System.Windows.Forms.Label lbl_localcaro;
        private System.Windows.Forms.TextBox txt_tipoexcaro;
        private System.Windows.Forms.Label lbl_tipoexcaro;
        private System.Windows.Forms.TextBox txt_nomecaro;
        private System.Windows.Forms.Label lbl_nomecaro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_estatistica1;
        private System.Windows.Forms.Panel pnl_estistica1;
        private System.Windows.Forms.TextBox txt_contarinferior;
        private System.Windows.Forms.Label lbl_contarinferior;
        private System.Windows.Forms.TextBox txt_precomedio;
        private System.Windows.Forms.Label lbl_precomedia;
        private System.Windows.Forms.TextBox txt_somaprecos;
        private System.Windows.Forms.Label lbl_somaprecos;
        private System.Windows.Forms.Label lbl_aviso;
    }
}