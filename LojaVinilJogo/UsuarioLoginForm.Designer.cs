namespace LojaVinilJogo
{
    partial class UsuarioLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioLoginForm));
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconLoginPictureBox = new System.Windows.Forms.PictureBox();
            this.topoLoginPanel = new System.Windows.Forms.Panel();
            this.tituloTopLoginLabel = new System.Windows.Forms.Label();
            this.middleLoginPanel = new System.Windows.Forms.Panel();
            this.senhaLoginTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fecharButton = new System.Windows.Forms.Button();
            this.entrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLoginPictureBox)).BeginInit();
            this.topoLoginPanel.SuspendLayout();
            this.middleLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.iconLoginPictureBox);
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(108, 93);
            this.iconPanel.TabIndex = 24;
            // 
            // iconLoginPictureBox
            // 
            this.iconLoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconLoginPictureBox.Image")));
            this.iconLoginPictureBox.Location = new System.Drawing.Point(4, 4);
            this.iconLoginPictureBox.Name = "iconLoginPictureBox";
            this.iconLoginPictureBox.Size = new System.Drawing.Size(97, 84);
            this.iconLoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconLoginPictureBox.TabIndex = 0;
            this.iconLoginPictureBox.TabStop = false;
            // 
            // topoLoginPanel
            // 
            this.topoLoginPanel.Controls.Add(this.label2);
            this.topoLoginPanel.Controls.Add(this.label1);
            this.topoLoginPanel.Controls.Add(this.tituloTopLoginLabel);
            this.topoLoginPanel.Controls.Add(this.iconPanel);
            this.topoLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topoLoginPanel.Name = "topoLoginPanel";
            this.topoLoginPanel.Size = new System.Drawing.Size(444, 97);
            this.topoLoginPanel.TabIndex = 17;
            // 
            // tituloTopLoginLabel
            // 
            this.tituloTopLoginLabel.AutoSize = true;
            this.tituloTopLoginLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloTopLoginLabel.Location = new System.Drawing.Point(214, 9);
            this.tituloTopLoginLabel.Name = "tituloTopLoginLabel";
            this.tituloTopLoginLabel.Size = new System.Drawing.Size(97, 34);
            this.tituloTopLoginLabel.TabIndex = 0;
            this.tituloTopLoginLabel.Text = "Login";
            // 
            // middleLoginPanel
            // 
            this.middleLoginPanel.Controls.Add(this.senhaLoginTextBox);
            this.middleLoginPanel.Controls.Add(this.senhaLabel);
            this.middleLoginPanel.Controls.Add(this.emailLoginTextBox);
            this.middleLoginPanel.Controls.Add(this.emailLabel);
            this.middleLoginPanel.Controls.Add(this.fecharButton);
            this.middleLoginPanel.Controls.Add(this.entrarButton);
            this.middleLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.middleLoginPanel.Name = "middleLoginPanel";
            this.middleLoginPanel.Size = new System.Drawing.Size(444, 230);
            this.middleLoginPanel.TabIndex = 18;
            // 
            // senhaLoginTextBox
            // 
            this.senhaLoginTextBox.Location = new System.Drawing.Point(121, 156);
            this.senhaLoginTextBox.Name = "senhaLoginTextBox";
            this.senhaLoginTextBox.PasswordChar = '*';
            this.senhaLoginTextBox.Size = new System.Drawing.Size(264, 20);
            this.senhaLoginTextBox.TabIndex = 15;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(77, 163);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(38, 13);
            this.senhaLabel.TabIndex = 14;
            this.senhaLabel.Text = "Senha";
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Location = new System.Drawing.Point(121, 116);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(264, 20);
            this.emailLoginTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(77, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "E-mail";
            // 
            // fecharButton
            // 
            this.fecharButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.Location = new System.Drawing.Point(293, 193);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 9;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // entrarButton
            // 
            this.entrarButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarButton.Location = new System.Drawing.Point(127, 193);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(75, 23);
            this.entrarButton.TabIndex = 11;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = true;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Entre com suas credenciais para ter acesso as funcionalidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = " do sistema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsuarioLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 230);
            this.Controls.Add(this.topoLoginPanel);
            this.Controls.Add(this.middleLoginPanel);
            this.Name = "UsuarioLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLoginPictureBox)).EndInit();
            this.topoLoginPanel.ResumeLayout(false);
            this.topoLoginPanel.PerformLayout();
            this.middleLoginPanel.ResumeLayout(false);
            this.middleLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Panel topoLoginPanel;
        private System.Windows.Forms.Label tituloTopLoginLabel;
        private System.Windows.Forms.Panel middleLoginPanel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.TextBox senhaLoginTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox iconLoginPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}