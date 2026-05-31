namespace LojaVinilJogo
{
    partial class GeneroJogoForm
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
            this.descricaoAcaoGeneroLabel = new System.Windows.Forms.Label();
            this.buttonsBottomGeneroPanel = new System.Windows.Forms.Panel();
            this.salvarGeneroButton = new System.Windows.Forms.Button();
            this.fecharGeneroButton = new System.Windows.Forms.Button();
            this.tituloTopGeneroLabel = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.nomeGeneroLabel = new System.Windows.Forms.Label();
            this.nomeGeneroTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.middleCadastrarGeneroPanel = new System.Windows.Forms.Panel();
            this.topoCadastarGeneroPanel = new System.Windows.Forms.Panel();
            this.buttonsBottomGeneroPanel.SuspendLayout();
            this.middleCadastrarGeneroPanel.SuspendLayout();
            this.topoCadastarGeneroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoAcaoGeneroLabel
            // 
            this.descricaoAcaoGeneroLabel.AutoSize = true;
            this.descricaoAcaoGeneroLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoAcaoGeneroLabel.Location = new System.Drawing.Point(203, 47);
            this.descricaoAcaoGeneroLabel.Name = "descricaoAcaoGeneroLabel";
            this.descricaoAcaoGeneroLabel.Size = new System.Drawing.Size(173, 17);
            this.descricaoAcaoGeneroLabel.TabIndex = 23;
            this.descricaoAcaoGeneroLabel.Text = "Cadastrar gênero para jogo";
            // 
            // buttonsBottomGeneroPanel
            // 
            this.buttonsBottomGeneroPanel.Controls.Add(this.salvarGeneroButton);
            this.buttonsBottomGeneroPanel.Controls.Add(this.fecharGeneroButton);
            this.buttonsBottomGeneroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsBottomGeneroPanel.Location = new System.Drawing.Point(0, 73);
            this.buttonsBottomGeneroPanel.Name = "buttonsBottomGeneroPanel";
            this.buttonsBottomGeneroPanel.Size = new System.Drawing.Size(592, 31);
            this.buttonsBottomGeneroPanel.TabIndex = 18;
            // 
            // salvarGeneroButton
            // 
            this.salvarGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarGeneroButton.Location = new System.Drawing.Point(206, 5);
            this.salvarGeneroButton.Name = "salvarGeneroButton";
            this.salvarGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.salvarGeneroButton.TabIndex = 11;
            this.salvarGeneroButton.Text = "Salvar";
            this.salvarGeneroButton.UseVisualStyleBackColor = true;
            this.salvarGeneroButton.Click += new System.EventHandler(this.salvarGeneroButton_Click);
            // 
            // fecharGeneroButton
            // 
            this.fecharGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharGeneroButton.Location = new System.Drawing.Point(368, 5);
            this.fecharGeneroButton.Name = "fecharGeneroButton";
            this.fecharGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.fecharGeneroButton.TabIndex = 9;
            this.fecharGeneroButton.Text = "Fechar";
            this.fecharGeneroButton.UseVisualStyleBackColor = true;
            this.fecharGeneroButton.Click += new System.EventHandler(this.fecharGeneroButton_Click);
            // 
            // tituloTopGeneroLabel
            // 
            this.tituloTopGeneroLabel.AutoSize = true;
            this.tituloTopGeneroLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTopGeneroLabel.Location = new System.Drawing.Point(172, 13);
            this.tituloTopGeneroLabel.Name = "tituloTopGeneroLabel";
            this.tituloTopGeneroLabel.Size = new System.Drawing.Size(216, 34);
            this.tituloTopGeneroLabel.TabIndex = 0;
            this.tituloTopGeneroLabel.Text = "Gênero - Jogo";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(530, 51);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 19;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nomeGeneroLabel
            // 
            this.nomeGeneroLabel.AutoSize = true;
            this.nomeGeneroLabel.Location = new System.Drawing.Point(116, 24);
            this.nomeGeneroLabel.Name = "nomeGeneroLabel";
            this.nomeGeneroLabel.Size = new System.Drawing.Size(86, 13);
            this.nomeGeneroLabel.TabIndex = 10;
            this.nomeGeneroLabel.Text = "Nome do gênero";
            // 
            // nomeGeneroTextBox
            // 
            this.nomeGeneroTextBox.Location = new System.Drawing.Point(206, 20);
            this.nomeGeneroTextBox.Name = "nomeGeneroTextBox";
            this.nomeGeneroTextBox.Size = new System.Drawing.Size(377, 20);
            this.nomeGeneroTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(36, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(74, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // middleCadastrarGeneroPanel
            // 
            this.middleCadastrarGeneroPanel.Controls.Add(this.ativoCheckBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.buttonsBottomGeneroPanel);
            this.middleCadastrarGeneroPanel.Controls.Add(this.nomeGeneroLabel);
            this.middleCadastrarGeneroPanel.Controls.Add(this.nomeGeneroTextBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.idTextBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.idLabel);
            this.middleCadastrarGeneroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleCadastrarGeneroPanel.Location = new System.Drawing.Point(0, 67);
            this.middleCadastrarGeneroPanel.Name = "middleCadastrarGeneroPanel";
            this.middleCadastrarGeneroPanel.Size = new System.Drawing.Size(592, 104);
            this.middleCadastrarGeneroPanel.TabIndex = 9;
            // 
            // topoCadastarGeneroPanel
            // 
            this.topoCadastarGeneroPanel.Controls.Add(this.tituloTopGeneroLabel);
            this.topoCadastarGeneroPanel.Controls.Add(this.descricaoAcaoGeneroLabel);
            this.topoCadastarGeneroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoCadastarGeneroPanel.Location = new System.Drawing.Point(0, 0);
            this.topoCadastarGeneroPanel.Name = "topoCadastarGeneroPanel";
            this.topoCadastarGeneroPanel.Size = new System.Drawing.Size(592, 67);
            this.topoCadastarGeneroPanel.TabIndex = 8;
            // 
            // GeneroJogoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 171);
            this.Controls.Add(this.middleCadastrarGeneroPanel);
            this.Controls.Add(this.topoCadastarGeneroPanel);
            this.Name = "GeneroJogoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro de Gênero - Jogo";
            this.buttonsBottomGeneroPanel.ResumeLayout(false);
            this.middleCadastrarGeneroPanel.ResumeLayout(false);
            this.middleCadastrarGeneroPanel.PerformLayout();
            this.topoCadastarGeneroPanel.ResumeLayout(false);
            this.topoCadastarGeneroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label descricaoAcaoGeneroLabel;
        private System.Windows.Forms.Panel buttonsBottomGeneroPanel;
        private System.Windows.Forms.Button salvarGeneroButton;
        private System.Windows.Forms.Button fecharGeneroButton;
        private System.Windows.Forms.Label tituloTopGeneroLabel;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Label nomeGeneroLabel;
        private System.Windows.Forms.TextBox nomeGeneroTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel middleCadastrarGeneroPanel;
        private System.Windows.Forms.Panel topoCadastarGeneroPanel;
    }
}