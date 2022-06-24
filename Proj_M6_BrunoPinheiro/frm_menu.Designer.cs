
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_cuf = new System.Windows.Forms.Label();
            this.llbl_privacidade = new System.Windows.Forms.LinkLabel();
            this.llbl_termos = new System.Windows.Forms.LinkLabel();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.pic_cuf = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(12, 324);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(491, 26);
            this.lbl_user.TabIndex = 18;
            this.lbl_user.Text = "Bem vindo(a), a aplicação de gestão da CUF Descobertas";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cuf
            // 
            this.lbl_cuf.AutoSize = true;
            this.lbl_cuf.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuf.Location = new System.Drawing.Point(136, 24);
            this.lbl_cuf.Name = "lbl_cuf";
            this.lbl_cuf.Size = new System.Drawing.Size(252, 30);
            this.lbl_cuf.TabIndex = 14;
            this.lbl_cuf.Text = "Hospital CUF Descobertas";
            this.lbl_cuf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbl_privacidade
            // 
            this.llbl_privacidade.AutoSize = true;
            this.llbl_privacidade.Location = new System.Drawing.Point(6, 358);
            this.llbl_privacidade.Name = "llbl_privacidade";
            this.llbl_privacidade.Size = new System.Drawing.Size(164, 13);
            this.llbl_privacidade.TabIndex = 25;
            this.llbl_privacidade.TabStop = true;
            this.llbl_privacidade.Text = "Politica de Privacidade e cookies";
            this.llbl_privacidade.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_privacidade_LinkClicked);
            // 
            // llbl_termos
            // 
            this.llbl_termos.AutoSize = true;
            this.llbl_termos.Location = new System.Drawing.Point(176, 358);
            this.llbl_termos.Name = "llbl_termos";
            this.llbl_termos.Size = new System.Drawing.Size(103, 13);
            this.llbl_termos.TabIndex = 24;
            this.llbl_termos.TabStop = true;
            this.llbl_termos.Text = "Termos e condições";
            this.llbl_termos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_termos_LinkClicked);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.management__1_;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_admin.Location = new System.Drawing.Point(379, 207);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_admin.Size = new System.Drawing.Size(117, 84);
            this.btn_admin.TabIndex = 26;
            this.btn_admin.Text = "Área de Admin";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_encerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encerrar.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.imagem_2022_05_31_144529030__2_;
            this.btn_encerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_encerrar.Location = new System.Drawing.Point(16, 207);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_encerrar.Size = new System.Drawing.Size(117, 84);
            this.btn_encerrar.TabIndex = 21;
            this.btn_encerrar.Text = "Encerrar sessão";
            this.btn_encerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_encerrar.UseVisualStyleBackColor = false;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_encerrar_Click);
            // 
            // pic_cuf
            // 
            this.pic_cuf.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.kisspng_cuf_descobertas_hospital_cuf_infante_santo_hospit_portugal_logo_5b28de70f3fbc7_9308381815294050409994;
            this.pic_cuf.Location = new System.Drawing.Point(154, 186);
            this.pic_cuf.Name = "pic_cuf";
            this.pic_cuf.Size = new System.Drawing.Size(200, 128);
            this.pic_cuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cuf.TabIndex = 15;
            this.pic_cuf.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.sair__1___3_;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair.Location = new System.Drawing.Point(388, 72);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btn_sair.Size = new System.Drawing.Size(108, 99);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_autor
            // 
            this.btn_autor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_autor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autor.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.Captura_de_ecrã_2022_05_31_001442_removebg_preview__2_;
            this.btn_autor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_autor.Location = new System.Drawing.Point(265, 72);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btn_autor.Size = new System.Drawing.Size(108, 99);
            this.btn_autor.TabIndex = 12;
            this.btn_autor.Text = "Autor";
            this.btn_autor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_autor.UseVisualStyleBackColor = false;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.Captura_de_ecrã_2022_05_31_001431_removebg_preview__2_;
            this.btn_sobre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sobre.Location = new System.Drawing.Point(141, 72);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btn_sobre.Size = new System.Drawing.Size(108, 99);
            this.btn_sobre.TabIndex = 11;
            this.btn_sobre.Text = "Sobre Nós";
            this.btn_sobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sobre.UseVisualStyleBackColor = false;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.Captura_de_ecrã_2022_05_31_001507_removebg_preview__2_;
            this.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_registrar.Location = new System.Drawing.Point(18, 72);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btn_registrar.Size = new System.Drawing.Size(108, 99);
            this.btn_registrar.TabIndex = 10;
            this.btn_registrar.Text = "Exames";
            this.btn_registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.llbl_privacidade);
            this.Controls.Add(this.llbl_termos);
            this.Controls.Add(this.btn_encerrar);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pic_cuf);
            this.Controls.Add(this.lbl_cuf);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.btn_sobre);
            this.Controls.Add(this.btn_registrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Exames Médicos - CUF Descobertas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pic_cuf;
        private System.Windows.Forms.Label lbl_cuf;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_autor;
        private System.Windows.Forms.Button btn_sobre;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.LinkLabel llbl_privacidade;
        private System.Windows.Forms.LinkLabel llbl_termos;
        private System.Windows.Forms.Button btn_admin;
    }
}