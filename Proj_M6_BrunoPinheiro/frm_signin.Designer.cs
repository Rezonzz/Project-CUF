
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signin));
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.lbl_obrigatorio1 = new System.Windows.Forms.Label();
            this.lbl_obrigatorio2 = new System.Windows.Forms.Label();
            this.lbl_invalido = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_limpar = new System.Windows.Forms.Label();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_obrigatorio3 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_instalarmobile = new System.Windows.Forms.Label();
            this.pic_mycuf = new System.Windows.Forms.PictureBox();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.pic_confirmar = new System.Windows.Forms.PictureBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.pic_username = new System.Windows.Forms.PictureBox();
            this.pic_cuf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mycuf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrar.Location = new System.Drawing.Point(26, 364);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(121, 20);
            this.chk_mostrar.TabIndex = 42;
            this.chk_mostrar.Text = "Mostrar password";
            this.chk_mostrar.UseVisualStyleBackColor = true;
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.chk_mostrar_CheckedChanged);
            // 
            // lbl_obrigatorio1
            // 
            this.lbl_obrigatorio1.AutoSize = true;
            this.lbl_obrigatorio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obrigatorio1.ForeColor = System.Drawing.Color.Red;
            this.lbl_obrigatorio1.Location = new System.Drawing.Point(244, 164);
            this.lbl_obrigatorio1.Name = "lbl_obrigatorio1";
            this.lbl_obrigatorio1.Size = new System.Drawing.Size(14, 18);
            this.lbl_obrigatorio1.TabIndex = 41;
            this.lbl_obrigatorio1.Text = "*";
            // 
            // lbl_obrigatorio2
            // 
            this.lbl_obrigatorio2.AutoSize = true;
            this.lbl_obrigatorio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obrigatorio2.ForeColor = System.Drawing.Color.Red;
            this.lbl_obrigatorio2.Location = new System.Drawing.Point(244, 241);
            this.lbl_obrigatorio2.Name = "lbl_obrigatorio2";
            this.lbl_obrigatorio2.Size = new System.Drawing.Size(14, 18);
            this.lbl_obrigatorio2.TabIndex = 40;
            this.lbl_obrigatorio2.Text = "*";
            // 
            // lbl_invalido
            // 
            this.lbl_invalido.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalido.Location = new System.Drawing.Point(153, 366);
            this.lbl_invalido.Name = "lbl_invalido";
            this.lbl_invalido.Size = new System.Drawing.Size(118, 32);
            this.lbl_invalido.TabIndex = 39;
            this.lbl_invalido.Text = "As passwords não são iguais";
            this.lbl_invalido.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_password.Location = new System.Drawing.Point(68, 250);
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
            this.txt_username.Location = new System.Drawing.Point(68, 173);
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
            this.lbl_limpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_limpar.Location = new System.Drawing.Point(215, 403);
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
            this.lbl_sair.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_sair.Location = new System.Drawing.Point(122, 443);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(36, 20);
            this.lbl_sair.TabIndex = 35;
            this.lbl_sair.Text = "Sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signin.Location = new System.Drawing.Point(69, 403);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(140, 37);
            this.btn_signin.TabIndex = 34;
            this.btn_signin.Text = "SIGN IN";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // lbl_signin
            // 
            this.lbl_signin.AutoSize = true;
            this.lbl_signin.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signin.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_signin.Location = new System.Drawing.Point(80, 117);
            this.lbl_signin.Name = "lbl_signin";
            this.lbl_signin.Size = new System.Drawing.Size(138, 40);
            this.lbl_signin.TabIndex = 33;
            this.lbl_signin.Text = "SIGN IN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(25, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(25, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 31;
            // 
            // lbl_obrigatorio3
            // 
            this.lbl_obrigatorio3.AutoSize = true;
            this.lbl_obrigatorio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obrigatorio3.ForeColor = System.Drawing.Color.Red;
            this.lbl_obrigatorio3.Location = new System.Drawing.Point(244, 311);
            this.lbl_obrigatorio3.Name = "lbl_obrigatorio3";
            this.lbl_obrigatorio3.Size = new System.Drawing.Size(14, 18);
            this.lbl_obrigatorio3.TabIndex = 46;
            this.lbl_obrigatorio3.Text = "*";
            // 
            // txt_confirm
            // 
            this.txt_confirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_confirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_confirm.Location = new System.Drawing.Point(68, 320);
            this.txt_confirm.Multiline = true;
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(191, 27);
            this.txt_confirm.TabIndex = 45;
            this.txt_confirm.Text = "Confirmar Password";
            this.txt_confirm.UseSystemPasswordChar = true;
            this.txt_confirm.Click += new System.EventHandler(this.txt_confirm_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(25, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 44;
            // 
            // lbl_instalarmobile
            // 
            this.lbl_instalarmobile.AutoSize = true;
            this.lbl_instalarmobile.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instalarmobile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_instalarmobile.Location = new System.Drawing.Point(286, 180);
            this.lbl_instalarmobile.Name = "lbl_instalarmobile";
            this.lbl_instalarmobile.Size = new System.Drawing.Size(335, 27);
            this.lbl_instalarmobile.TabIndex = 48;
            this.lbl_instalarmobile.Text = "Instale a nossa app mobile!";
            // 
            // pic_mycuf
            // 
            this.pic_mycuf.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.unnamed;
            this.pic_mycuf.Location = new System.Drawing.Point(287, 12);
            this.pic_mycuf.Name = "pic_mycuf";
            this.pic_mycuf.Size = new System.Drawing.Size(334, 159);
            this.pic_mycuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mycuf.TabIndex = 49;
            this.pic_mycuf.TabStop = false;
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.qrcodecuf;
            this.pic_qrcode.Location = new System.Drawing.Point(383, 221);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(131, 127);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_qrcode.TabIndex = 47;
            this.pic_qrcode.TabStop = false;
            // 
            // pic_confirmar
            // 
            this.pic_confirmar.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.padlock;
            this.pic_confirmar.Location = new System.Drawing.Point(25, 311);
            this.pic_confirmar.Name = "pic_confirmar";
            this.pic_confirmar.Size = new System.Drawing.Size(37, 36);
            this.pic_confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_confirmar.TabIndex = 43;
            this.pic_confirmar.TabStop = false;
            // 
            // pic_password
            // 
            this.pic_password.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.padlock;
            this.pic_password.Location = new System.Drawing.Point(25, 241);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(37, 36);
            this.pic_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_password.TabIndex = 30;
            this.pic_password.TabStop = false;
            // 
            // pic_username
            // 
            this.pic_username.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.user;
            this.pic_username.Location = new System.Drawing.Point(25, 164);
            this.pic_username.Name = "pic_username";
            this.pic_username.Size = new System.Drawing.Size(37, 36);
            this.pic_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_username.TabIndex = 29;
            this.pic_username.TabStop = false;
            // 
            // pic_cuf
            // 
            this.pic_cuf.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.imagem_2022_05_31_144625029_removebg_preview;
            this.pic_cuf.Location = new System.Drawing.Point(69, 12);
            this.pic_cuf.Name = "pic_cuf";
            this.pic_cuf.Size = new System.Drawing.Size(159, 102);
            this.pic_cuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cuf.TabIndex = 28;
            this.pic_cuf.TabStop = false;
            // 
            // frm_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(633, 484);
            this.Controls.Add(this.pic_mycuf);
            this.Controls.Add(this.lbl_instalarmobile);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.lbl_obrigatorio3);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pic_confirmar);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.lbl_obrigatorio1);
            this.Controls.Add(this.lbl_obrigatorio2);
            this.Controls.Add(this.lbl_invalido);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_limpar);
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.lbl_signin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_password);
            this.Controls.Add(this.pic_username);
            this.Controls.Add(this.pic_cuf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in - CUF Descobertas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_signin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mycuf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cuf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_mostrar;
        private System.Windows.Forms.Label lbl_obrigatorio1;
        private System.Windows.Forms.Label lbl_obrigatorio2;
        private System.Windows.Forms.Label lbl_invalido;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_limpar;
        private System.Windows.Forms.Label lbl_sair;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.PictureBox pic_username;
        private System.Windows.Forms.PictureBox pic_cuf;
        private System.Windows.Forms.Label lbl_obrigatorio3;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic_confirmar;
        private System.Windows.Forms.PictureBox pic_mycuf;
        private System.Windows.Forms.Label lbl_instalarmobile;
        private System.Windows.Forms.PictureBox pic_qrcode;
    }
}