
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_loginadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loginadmin));
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.lbl_invalido = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_limpar = new System.Windows.Forms.Label();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.pic_username = new System.Windows.Forms.PictureBox();
            this.pic_cuf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrar.Location = new System.Drawing.Point(31, 307);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(121, 20);
            this.chk_mostrar.TabIndex = 40;
            this.chk_mostrar.Text = "Mostrar password";
            this.chk_mostrar.UseVisualStyleBackColor = true;
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.chk_mostrar_CheckedChanged);
            // 
            // lbl_invalido
            // 
            this.lbl_invalido.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalido.Location = new System.Drawing.Point(158, 309);
            this.lbl_invalido.Name = "lbl_invalido";
            this.lbl_invalido.Size = new System.Drawing.Size(138, 32);
            this.lbl_invalido.TabIndex = 39;
            this.lbl_invalido.Text = "Username ou Password Inválidos";
            this.lbl_invalido.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_password.Location = new System.Drawing.Point(74, 267);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(191, 27);
            this.txt_password.TabIndex = 38;
            this.txt_password.Text = "Password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_username.Location = new System.Drawing.Point(74, 190);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 27);
            this.txt_username.TabIndex = 37;
            this.txt_username.Text = "Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            // 
            // lbl_limpar
            // 
            this.lbl_limpar.AutoSize = true;
            this.lbl_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_limpar.Location = new System.Drawing.Point(217, 349);
            this.lbl_limpar.Name = "lbl_limpar";
            this.lbl_limpar.Size = new System.Drawing.Size(56, 19);
            this.lbl_limpar.TabIndex = 36;
            this.lbl_limpar.Text = "Limpar";
            this.lbl_limpar.Click += new System.EventHandler(this.lbl_limpar_Click);
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sair.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_sair.Location = new System.Drawing.Point(123, 389);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(35, 19);
            this.lbl_sair.TabIndex = 35;
            this.lbl_sair.Text = "Sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(71, 349);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 37);
            this.btn_login.TabIndex = 34;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_login.Location = new System.Drawing.Point(19, 134);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(271, 40);
            this.lbl_login.TabIndex = 33;
            this.lbl_login.Text = "LOG IN - ADMIN";
            // 
            // pnl_2
            // 
            this.pnl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_2.Location = new System.Drawing.Point(31, 300);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(236, 1);
            this.pnl_2.TabIndex = 32;
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_1.Location = new System.Drawing.Point(31, 223);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(236, 1);
            this.pnl_1.TabIndex = 31;
            // 
            // pic_password
            // 
            this.pic_password.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.padlock;
            this.pic_password.Location = new System.Drawing.Point(31, 258);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(37, 36);
            this.pic_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_password.TabIndex = 30;
            this.pic_password.TabStop = false;
            // 
            // pic_username
            // 
            this.pic_username.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.user;
            this.pic_username.Location = new System.Drawing.Point(31, 181);
            this.pic_username.Name = "pic_username";
            this.pic_username.Size = new System.Drawing.Size(37, 36);
            this.pic_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_username.TabIndex = 29;
            this.pic_username.TabStop = false;
            // 
            // pic_cuf
            // 
            this.pic_cuf.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.imagem_2022_05_31_144625029_removebg_preview;
            this.pic_cuf.Location = new System.Drawing.Point(74, 29);
            this.pic_cuf.Name = "pic_cuf";
            this.pic_cuf.Size = new System.Drawing.Size(159, 102);
            this.pic_cuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cuf.TabIndex = 28;
            this.pic_cuf.TabStop = false;
            // 
            // frm_loginadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(304, 420);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.lbl_invalido);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_limpar);
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.pic_password);
            this.Controls.Add(this.pic_username);
            this.Controls.Add(this.pic_cuf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_loginadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in - Admin - CUF Descobertas";
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_mostrar;
        private System.Windows.Forms.Label lbl_invalido;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_limpar;
        private System.Windows.Forms.Label lbl_sair;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.PictureBox pic_username;
        private System.Windows.Forms.PictureBox pic_cuf;
    }
}