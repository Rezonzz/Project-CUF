
namespace Proj_M6_BrunoPinheiro
{
    partial class frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.lbl_bemvindo = new System.Windows.Forms.Label();
            this.pic_gifcuf = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gifcuf)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bemvindo
            // 
            this.lbl_bemvindo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bemvindo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_bemvindo.Location = new System.Drawing.Point(59, 96);
            this.lbl_bemvindo.Name = "lbl_bemvindo";
            this.lbl_bemvindo.Size = new System.Drawing.Size(635, 31);
            this.lbl_bemvindo.TabIndex = 3;
            this.lbl_bemvindo.Text = "Bem-vindo ao espaço de saúde e bem-estar";
            this.lbl_bemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_gifcuf
            // 
            this.pic_gifcuf.Image = global::Proj_M6_BrunoPinheiro.Properties.Resources.ezgif_com_gif_maker;
            this.pic_gifcuf.Location = new System.Drawing.Point(103, 148);
            this.pic_gifcuf.Name = "pic_gifcuf";
            this.pic_gifcuf.Size = new System.Drawing.Size(550, 309);
            this.pic_gifcuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_gifcuf.TabIndex = 2;
            this.pic_gifcuf.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 31);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(751, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bemvindo);
            this.Controls.Add(this.pic_gifcuf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pic_gifcuf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_bemvindo;
        private System.Windows.Forms.PictureBox pic_gifcuf;
        private System.Windows.Forms.Label label1;
    }
}