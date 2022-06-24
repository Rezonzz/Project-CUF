
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar));
            this.pnl_dadospaciente = new System.Windows.Forms.Panel();
            this.dtp_realizacao = new System.Windows.Forms.DateTimePicker();
            this.txt_nomemedico = new System.Windows.Forms.TextBox();
            this.lbl_nomemedico = new System.Windows.Forms.Label();
            this.cbo_seguro = new System.Windows.Forms.ComboBox();
            this.lbl_seguro = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_datarealizacao = new System.Windows.Forms.Label();
            this.txt_numex = new System.Windows.Forms.TextBox();
            this.lbl_numex = new System.Windows.Forms.Label();
            this.lbl_dadospaciente = new System.Windows.Forms.Label();
            this.pnl_dadosex = new System.Windows.Forms.Panel();
            this.lbl_reacoes = new System.Windows.Forms.Label();
            this.txt_reacoes = new System.Windows.Forms.TextBox();
            this.grp_tipocontraste = new System.Windows.Forms.GroupBox();
            this.rad_naoionico = new System.Windows.Forms.RadioButton();
            this.rad_ionico = new System.Windows.Forms.RadioButton();
            this.grp_contraste = new System.Windows.Forms.GroupBox();
            this.rad_nao = new System.Windows.Forms.RadioButton();
            this.rad_sim = new System.Windows.Forms.RadioButton();
            this.cbo_local = new System.Windows.Forms.ComboBox();
            this.cbo_tipoex = new System.Windows.Forms.ComboBox();
            this.lbl_local = new System.Windows.Forms.Label();
            this.lbl_tipoex = new System.Windows.Forms.Label();
            this.lbl_dadosex = new System.Windows.Forms.Label();
            this.pnl_dadospagamento = new System.Windows.Forms.Panel();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_valorcomp = new System.Windows.Forms.Label();
            this.cbo_valorcomp = new System.Windows.Forms.ComboBox();
            this.lbl_dadospagamento = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.pnl_dadospaciente.SuspendLayout();
            this.pnl_dadosex.SuspendLayout();
            this.grp_tipocontraste.SuspendLayout();
            this.grp_contraste.SuspendLayout();
            this.pnl_dadospagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_dadospaciente
            // 
            this.pnl_dadospaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_dadospaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_dadospaciente.Controls.Add(this.dtp_realizacao);
            this.pnl_dadospaciente.Controls.Add(this.txt_nomemedico);
            this.pnl_dadospaciente.Controls.Add(this.lbl_nomemedico);
            this.pnl_dadospaciente.Controls.Add(this.cbo_seguro);
            this.pnl_dadospaciente.Controls.Add(this.lbl_seguro);
            this.pnl_dadospaciente.Controls.Add(this.txt_nome);
            this.pnl_dadospaciente.Controls.Add(this.lbl_nome);
            this.pnl_dadospaciente.Controls.Add(this.lbl_datarealizacao);
            this.pnl_dadospaciente.Controls.Add(this.txt_numex);
            this.pnl_dadospaciente.Controls.Add(this.lbl_numex);
            this.pnl_dadospaciente.Controls.Add(this.lbl_dadospaciente);
            this.pnl_dadospaciente.Location = new System.Drawing.Point(79, 29);
            this.pnl_dadospaciente.Name = "pnl_dadospaciente";
            this.pnl_dadospaciente.Size = new System.Drawing.Size(297, 204);
            this.pnl_dadospaciente.TabIndex = 0;
            // 
            // dtp_realizacao
            // 
            this.dtp_realizacao.CustomFormat = "dd/MM/yyyy";
            this.dtp_realizacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_realizacao.Location = new System.Drawing.Point(8, 111);
            this.dtp_realizacao.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_realizacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_realizacao.Name = "dtp_realizacao";
            this.dtp_realizacao.Size = new System.Drawing.Size(120, 20);
            this.dtp_realizacao.TabIndex = 11;
            // 
            // txt_nomemedico
            // 
            this.txt_nomemedico.Location = new System.Drawing.Point(85, 167);
            this.txt_nomemedico.Name = "txt_nomemedico";
            this.txt_nomemedico.Size = new System.Drawing.Size(123, 20);
            this.txt_nomemedico.TabIndex = 10;
            this.txt_nomemedico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nomemedico_KeyDown);
            // 
            // lbl_nomemedico
            // 
            this.lbl_nomemedico.AutoSize = true;
            this.lbl_nomemedico.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomemedico.Location = new System.Drawing.Point(88, 145);
            this.lbl_nomemedico.Name = "lbl_nomemedico";
            this.lbl_nomemedico.Size = new System.Drawing.Size(120, 19);
            this.lbl_nomemedico.TabIndex = 9;
            this.lbl_nomemedico.Text = "Nome do Médico:";
            // 
            // cbo_seguro
            // 
            this.cbo_seguro.FormattingEnabled = true;
            this.cbo_seguro.Items.AddRange(new object[] {
            "Selecione o seguro de saúde:",
            "ADSE",
            "AGEAS Seguros",
            "Allianz",
            "BIC Seguros",
            "Global Seguros",
            "Médis",
            "Multicare",
            "SNS",
            "Vitoria Seguros"});
            this.cbo_seguro.Location = new System.Drawing.Point(160, 111);
            this.cbo_seguro.Name = "cbo_seguro";
            this.cbo_seguro.Size = new System.Drawing.Size(121, 21);
            this.cbo_seguro.TabIndex = 8;
            this.cbo_seguro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_seguro_KeyDown);
            // 
            // lbl_seguro
            // 
            this.lbl_seguro.AutoSize = true;
            this.lbl_seguro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seguro.Location = new System.Drawing.Point(156, 88);
            this.lbl_seguro.Name = "lbl_seguro";
            this.lbl_seguro.Size = new System.Drawing.Size(115, 19);
            this.lbl_seguro.TabIndex = 7;
            this.lbl_seguro.Text = "Seguro de saúde:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(160, 53);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(123, 20);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_KeyDown);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(156, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(126, 19);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome do paciente:";
            // 
            // lbl_datarealizacao
            // 
            this.lbl_datarealizacao.AutoSize = true;
            this.lbl_datarealizacao.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datarealizacao.Location = new System.Drawing.Point(4, 89);
            this.lbl_datarealizacao.Name = "lbl_datarealizacao";
            this.lbl_datarealizacao.Size = new System.Drawing.Size(124, 19);
            this.lbl_datarealizacao.TabIndex = 3;
            this.lbl_datarealizacao.Text = "Data de realização:";
            // 
            // txt_numex
            // 
            this.txt_numex.Location = new System.Drawing.Point(8, 53);
            this.txt_numex.Name = "txt_numex";
            this.txt_numex.Size = new System.Drawing.Size(123, 20);
            this.txt_numex.TabIndex = 2;
            this.txt_numex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_numex_KeyDown);
            // 
            // lbl_numex
            // 
            this.lbl_numex.AutoSize = true;
            this.lbl_numex.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numex.Location = new System.Drawing.Point(4, 30);
            this.lbl_numex.Name = "lbl_numex";
            this.lbl_numex.Size = new System.Drawing.Size(127, 19);
            this.lbl_numex.TabIndex = 1;
            this.lbl_numex.Text = "Número do exame:";
            // 
            // lbl_dadospaciente
            // 
            this.lbl_dadospaciente.AutoSize = true;
            this.lbl_dadospaciente.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadospaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_dadospaciente.Location = new System.Drawing.Point(3, 0);
            this.lbl_dadospaciente.Name = "lbl_dadospaciente";
            this.lbl_dadospaciente.Size = new System.Drawing.Size(156, 21);
            this.lbl_dadospaciente.TabIndex = 0;
            this.lbl_dadospaciente.Text = "Dados do Paciente:";
            // 
            // pnl_dadosex
            // 
            this.pnl_dadosex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_dadosex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_dadosex.Controls.Add(this.lbl_reacoes);
            this.pnl_dadosex.Controls.Add(this.txt_reacoes);
            this.pnl_dadosex.Controls.Add(this.grp_tipocontraste);
            this.pnl_dadosex.Controls.Add(this.grp_contraste);
            this.pnl_dadosex.Controls.Add(this.cbo_local);
            this.pnl_dadosex.Controls.Add(this.cbo_tipoex);
            this.pnl_dadosex.Controls.Add(this.lbl_local);
            this.pnl_dadosex.Controls.Add(this.lbl_tipoex);
            this.pnl_dadosex.Controls.Add(this.lbl_dadosex);
            this.pnl_dadosex.Location = new System.Drawing.Point(79, 253);
            this.pnl_dadosex.Name = "pnl_dadosex";
            this.pnl_dadosex.Size = new System.Drawing.Size(297, 286);
            this.pnl_dadosex.TabIndex = 1;
            // 
            // lbl_reacoes
            // 
            this.lbl_reacoes.AutoSize = true;
            this.lbl_reacoes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reacoes.Location = new System.Drawing.Point(83, 220);
            this.lbl_reacoes.Name = "lbl_reacoes";
            this.lbl_reacoes.Size = new System.Drawing.Size(119, 19);
            this.lbl_reacoes.TabIndex = 14;
            this.lbl_reacoes.Text = "Reações alérgicas:";
            // 
            // txt_reacoes
            // 
            this.txt_reacoes.Location = new System.Drawing.Point(64, 242);
            this.txt_reacoes.Name = "txt_reacoes";
            this.txt_reacoes.Size = new System.Drawing.Size(162, 20);
            this.txt_reacoes.TabIndex = 13;
            this.txt_reacoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_reacoes_KeyDown);
            // 
            // grp_tipocontraste
            // 
            this.grp_tipocontraste.Controls.Add(this.rad_naoionico);
            this.grp_tipocontraste.Controls.Add(this.rad_ionico);
            this.grp_tipocontraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_tipocontraste.Location = new System.Drawing.Point(148, 104);
            this.grp_tipocontraste.Name = "grp_tipocontraste";
            this.grp_tipocontraste.Size = new System.Drawing.Size(137, 99);
            this.grp_tipocontraste.TabIndex = 12;
            this.grp_tipocontraste.TabStop = false;
            this.grp_tipocontraste.Text = "Tipo de Contraste?";
            this.grp_tipocontraste.Visible = false;
            // 
            // rad_naoionico
            // 
            this.rad_naoionico.AutoSize = true;
            this.rad_naoionico.Location = new System.Drawing.Point(26, 59);
            this.rad_naoionico.Name = "rad_naoionico";
            this.rad_naoionico.Size = new System.Drawing.Size(91, 20);
            this.rad_naoionico.TabIndex = 1;
            this.rad_naoionico.TabStop = true;
            this.rad_naoionico.Text = "Não iônico";
            this.rad_naoionico.UseVisualStyleBackColor = true;
            // 
            // rad_ionico
            // 
            this.rad_ionico.AutoSize = true;
            this.rad_ionico.Location = new System.Drawing.Point(26, 32);
            this.rad_ionico.Name = "rad_ionico";
            this.rad_ionico.Size = new System.Drawing.Size(62, 20);
            this.rad_ionico.TabIndex = 0;
            this.rad_ionico.TabStop = true;
            this.rad_ionico.Text = "Iônico";
            this.rad_ionico.UseVisualStyleBackColor = true;
            // 
            // grp_contraste
            // 
            this.grp_contraste.Controls.Add(this.rad_nao);
            this.grp_contraste.Controls.Add(this.rad_sim);
            this.grp_contraste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_contraste.Location = new System.Drawing.Point(10, 104);
            this.grp_contraste.Name = "grp_contraste";
            this.grp_contraste.Size = new System.Drawing.Size(123, 99);
            this.grp_contraste.TabIndex = 11;
            this.grp_contraste.TabStop = false;
            this.grp_contraste.Text = "Contraste?";
            // 
            // rad_nao
            // 
            this.rad_nao.AutoSize = true;
            this.rad_nao.Location = new System.Drawing.Point(37, 59);
            this.rad_nao.Name = "rad_nao";
            this.rad_nao.Size = new System.Drawing.Size(52, 20);
            this.rad_nao.TabIndex = 1;
            this.rad_nao.TabStop = true;
            this.rad_nao.Text = "Não";
            this.rad_nao.UseVisualStyleBackColor = true;
            this.rad_nao.CheckedChanged += new System.EventHandler(this.rad_nao_CheckedChanged);
            this.rad_nao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rad_nao_KeyDown);
            // 
            // rad_sim
            // 
            this.rad_sim.AutoSize = true;
            this.rad_sim.Location = new System.Drawing.Point(37, 32);
            this.rad_sim.Name = "rad_sim";
            this.rad_sim.Size = new System.Drawing.Size(49, 20);
            this.rad_sim.TabIndex = 0;
            this.rad_sim.TabStop = true;
            this.rad_sim.Text = "Sim";
            this.rad_sim.UseVisualStyleBackColor = true;
            this.rad_sim.CheckedChanged += new System.EventHandler(this.rad_sim_CheckedChanged);
            this.rad_sim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rad_sim_KeyDown);
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
            this.cbo_local.Location = new System.Drawing.Point(150, 56);
            this.cbo_local.Name = "cbo_local";
            this.cbo_local.Size = new System.Drawing.Size(121, 21);
            this.cbo_local.TabIndex = 10;
            this.cbo_local.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_local_KeyDown);
            // 
            // cbo_tipoex
            // 
            this.cbo_tipoex.FormattingEnabled = true;
            this.cbo_tipoex.Items.AddRange(new object[] {
            "Selecione o tipo de exame:",
            "Cistoscopia",
            "Densitometria Óssea",
            "Ecografia",
            "Endoscopia digestiva",
            "Exames laboratoriais",
            "Mamografia",
            "Nasofibroscopia",
            "Neurologia",
            "Oftalmoscopia",
            "Radiografia",
            "Ressonância Magnética",
            "Tomografia",
            "Tonometria",
            "Ultrassonografia"});
            this.cbo_tipoex.Location = new System.Drawing.Point(10, 56);
            this.cbo_tipoex.Name = "cbo_tipoex";
            this.cbo_tipoex.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipoex.TabIndex = 9;
            this.cbo_tipoex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_tipoex_KeyDown);
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_local.Location = new System.Drawing.Point(146, 33);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(44, 19);
            this.lbl_local.TabIndex = 5;
            this.lbl_local.Text = "Local:";
            // 
            // lbl_tipoex
            // 
            this.lbl_tipoex.AutoSize = true;
            this.lbl_tipoex.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoex.Location = new System.Drawing.Point(6, 33);
            this.lbl_tipoex.Name = "lbl_tipoex";
            this.lbl_tipoex.Size = new System.Drawing.Size(101, 19);
            this.lbl_tipoex.TabIndex = 1;
            this.lbl_tipoex.Text = "Tipo de exame:";
            // 
            // lbl_dadosex
            // 
            this.lbl_dadosex.AutoSize = true;
            this.lbl_dadosex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadosex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_dadosex.Location = new System.Drawing.Point(3, 0);
            this.lbl_dadosex.Name = "lbl_dadosex";
            this.lbl_dadosex.Size = new System.Drawing.Size(141, 21);
            this.lbl_dadosex.TabIndex = 0;
            this.lbl_dadosex.Text = "Dados do Exame:";
            // 
            // pnl_dadospagamento
            // 
            this.pnl_dadospagamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_dadospagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_dadospagamento.Controls.Add(this.txt_preco);
            this.pnl_dadospagamento.Controls.Add(this.lbl_preco);
            this.pnl_dadospagamento.Controls.Add(this.lbl_valorcomp);
            this.pnl_dadospagamento.Controls.Add(this.cbo_valorcomp);
            this.pnl_dadospagamento.Controls.Add(this.lbl_dadospagamento);
            this.pnl_dadospagamento.Location = new System.Drawing.Point(450, 131);
            this.pnl_dadospagamento.Name = "pnl_dadospagamento";
            this.pnl_dadospagamento.Size = new System.Drawing.Size(242, 157);
            this.pnl_dadospagamento.TabIndex = 2;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(61, 120);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(123, 20);
            this.txt_preco.TabIndex = 8;
            this.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_preco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_preco_KeyDown);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(99, 98);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(47, 19);
            this.lbl_preco.TabIndex = 7;
            this.lbl_preco.Text = "Preço:";
            // 
            // lbl_valorcomp
            // 
            this.lbl_valorcomp.AutoSize = true;
            this.lbl_valorcomp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorcomp.Location = new System.Drawing.Point(37, 43);
            this.lbl_valorcomp.Name = "lbl_valorcomp";
            this.lbl_valorcomp.Size = new System.Drawing.Size(169, 19);
            this.lbl_valorcomp.TabIndex = 4;
            this.lbl_valorcomp.Text = "Valor de comparticipação:";
            // 
            // cbo_valorcomp
            // 
            this.cbo_valorcomp.FormattingEnabled = true;
            this.cbo_valorcomp.Items.AddRange(new object[] {
            "Selecione o valor de comparticipação:",
            "100%",
            "95%",
            "90%",
            "85%",
            "80%",
            "50%",
            "0%"});
            this.cbo_valorcomp.Location = new System.Drawing.Point(63, 65);
            this.cbo_valorcomp.Name = "cbo_valorcomp";
            this.cbo_valorcomp.Size = new System.Drawing.Size(121, 21);
            this.cbo_valorcomp.TabIndex = 1;
            this.cbo_valorcomp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_valorcomp_KeyDown);
            // 
            // lbl_dadospagamento
            // 
            this.lbl_dadospagamento.AutoSize = true;
            this.lbl_dadospagamento.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadospagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.lbl_dadospagamento.Location = new System.Drawing.Point(3, 0);
            this.lbl_dadospagamento.Name = "lbl_dadospagamento";
            this.lbl_dadospagamento.Size = new System.Drawing.Size(177, 21);
            this.lbl_dadospagamento.TabIndex = 0;
            this.lbl_dadospagamento.Text = "Dados de Pagamento:";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.exam__1___2_;
            this.btn_registrar.Location = new System.Drawing.Point(460, 294);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_registrar.Size = new System.Drawing.Size(223, 76);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 573);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.pnl_dadospagamento);
            this.Controls.Add(this.pnl_dadosex);
            this.Controls.Add(this.pnl_dadospaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registrar";
            this.Load += new System.EventHandler(this.frm_registrar_Load);
            this.pnl_dadospaciente.ResumeLayout(false);
            this.pnl_dadospaciente.PerformLayout();
            this.pnl_dadosex.ResumeLayout(false);
            this.pnl_dadosex.PerformLayout();
            this.grp_tipocontraste.ResumeLayout(false);
            this.grp_tipocontraste.PerformLayout();
            this.grp_contraste.ResumeLayout(false);
            this.grp_contraste.PerformLayout();
            this.pnl_dadospagamento.ResumeLayout(false);
            this.pnl_dadospagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_dadospaciente;
        private System.Windows.Forms.Label lbl_dadospaciente;
        private System.Windows.Forms.TextBox txt_numex;
        private System.Windows.Forms.Label lbl_numex;
        private System.Windows.Forms.Label lbl_datarealizacao;
        private System.Windows.Forms.ComboBox cbo_seguro;
        private System.Windows.Forms.Label lbl_seguro;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel pnl_dadosex;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.Label lbl_tipoex;
        private System.Windows.Forms.Label lbl_dadosex;
        private System.Windows.Forms.ComboBox cbo_local;
        private System.Windows.Forms.ComboBox cbo_tipoex;
        private System.Windows.Forms.TextBox txt_nomemedico;
        private System.Windows.Forms.Label lbl_nomemedico;
        private System.Windows.Forms.Label lbl_reacoes;
        private System.Windows.Forms.TextBox txt_reacoes;
        private System.Windows.Forms.GroupBox grp_tipocontraste;
        private System.Windows.Forms.RadioButton rad_naoionico;
        private System.Windows.Forms.RadioButton rad_ionico;
        private System.Windows.Forms.GroupBox grp_contraste;
        private System.Windows.Forms.RadioButton rad_nao;
        private System.Windows.Forms.RadioButton rad_sim;
        private System.Windows.Forms.Panel pnl_dadospagamento;
        private System.Windows.Forms.Label lbl_valorcomp;
        private System.Windows.Forms.ComboBox cbo_valorcomp;
        private System.Windows.Forms.Label lbl_dadospagamento;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.DateTimePicker dtp_realizacao;
    }
}