namespace LojaVinilJogo
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.tituloSplashFormLabel = new System.Windows.Forms.Label();
            this.textoCarregamentolabel = new System.Windows.Forms.Label();
            this.splashFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloSplashFormLabel
            // 
            this.tituloSplashFormLabel.AutoSize = true;
            this.tituloSplashFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloSplashFormLabel.Location = new System.Drawing.Point(418, 148);
            this.tituloSplashFormLabel.Name = "tituloSplashFormLabel";
            this.tituloSplashFormLabel.Size = new System.Drawing.Size(287, 33);
            this.tituloSplashFormLabel.TabIndex = 0;
            this.tituloSplashFormLabel.Text = "Loja Vinis e Games";
            // 
            // textoCarregamentolabel
            // 
            this.textoCarregamentolabel.AutoSize = true;
            this.textoCarregamentolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCarregamentolabel.Location = new System.Drawing.Point(420, 288);
            this.textoCarregamentolabel.Name = "textoCarregamentolabel";
            this.textoCarregamentolabel.Size = new System.Drawing.Size(51, 20);
            this.textoCarregamentolabel.TabIndex = 1;
            this.textoCarregamentolabel.Text = "label2";
            // 
            // splashFormProgressBar
            // 
            this.splashFormProgressBar.Location = new System.Drawing.Point(424, 311);
            this.splashFormProgressBar.Name = "splashFormProgressBar";
            this.splashFormProgressBar.Size = new System.Drawing.Size(310, 23);
            this.splashFormProgressBar.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splashFormProgressBar);
            this.Controls.Add(this.textoCarregamentolabel);
            this.Controls.Add(this.tituloSplashFormLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de carregamento";
            this.Shown += new System.EventHandler(this.SplashForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloSplashFormLabel;
        private System.Windows.Forms.Label textoCarregamentolabel;
        private System.Windows.Forms.ProgressBar splashFormProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}