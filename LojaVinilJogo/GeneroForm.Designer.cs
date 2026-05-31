namespace LojaVinilJogo
{
    partial class GeneroForm
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
            this.topoCadastarGeneroPanel = new System.Windows.Forms.Panel();
            this.tituloTopGeneroLabel = new System.Windows.Forms.Label();
            this.descricaoAcaoGeneroLabel = new System.Windows.Forms.Label();
            this.buttonsBottomClientePanel = new System.Windows.Forms.Panel();
            this.salvarGeneroVinilButton = new System.Windows.Forms.Button();
            this.fecharVinilButton = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.middleCadastrarGeneroPanel = new System.Windows.Forms.Panel();
            this.nomeGeneroLabel = new System.Windows.Forms.Label();
            this.nomeGeneroVinilTextBox = new System.Windows.Forms.TextBox();
            this.idVinilTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.topoCadastarGeneroPanel.SuspendLayout();
            this.buttonsBottomClientePanel.SuspendLayout();
            this.middleCadastrarGeneroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topoCadastarGeneroPanel
            // 
            this.topoCadastarGeneroPanel.Controls.Add(this.tituloTopGeneroLabel);
            this.topoCadastarGeneroPanel.Controls.Add(this.descricaoAcaoGeneroLabel);
            this.topoCadastarGeneroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoCadastarGeneroPanel.Location = new System.Drawing.Point(0, 0);
            this.topoCadastarGeneroPanel.Name = "topoCadastarGeneroPanel";
            this.topoCadastarGeneroPanel.Size = new System.Drawing.Size(592, 67);
            this.topoCadastarGeneroPanel.TabIndex = 10;
            // 
            // tituloTopGeneroLabel
            // 
            this.tituloTopGeneroLabel.AutoSize = true;
            this.tituloTopGeneroLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTopGeneroLabel.Location = new System.Drawing.Point(202, 10);
            this.tituloTopGeneroLabel.Name = "tituloTopGeneroLabel";
            this.tituloTopGeneroLabel.Size = new System.Drawing.Size(216, 34);
            this.tituloTopGeneroLabel.TabIndex = 0;
            this.tituloTopGeneroLabel.Text = "Gênero - Vinil";
            // 
            // descricaoAcaoGeneroLabel
            // 
            this.descricaoAcaoGeneroLabel.AutoSize = true;
            this.descricaoAcaoGeneroLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoAcaoGeneroLabel.Location = new System.Drawing.Point(225, 44);
            this.descricaoAcaoGeneroLabel.Name = "descricaoAcaoGeneroLabel";
            this.descricaoAcaoGeneroLabel.Size = new System.Drawing.Size(171, 17);
            this.descricaoAcaoGeneroLabel.TabIndex = 23;
            this.descricaoAcaoGeneroLabel.Text = "Cadastrar gênero para vinil";
            // 
            // buttonsBottomClientePanel
            // 
            this.buttonsBottomClientePanel.Controls.Add(this.salvarGeneroVinilButton);
            this.buttonsBottomClientePanel.Controls.Add(this.fecharVinilButton);
            this.buttonsBottomClientePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsBottomClientePanel.Location = new System.Drawing.Point(0, 140);
            this.buttonsBottomClientePanel.Name = "buttonsBottomClientePanel";
            this.buttonsBottomClientePanel.Size = new System.Drawing.Size(592, 31);
            this.buttonsBottomClientePanel.TabIndex = 18;
            // 
            // salvarGeneroVinilButton
            // 
            this.salvarGeneroVinilButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarGeneroVinilButton.Location = new System.Drawing.Point(193, 5);
            this.salvarGeneroVinilButton.Name = "salvarGeneroVinilButton";
            this.salvarGeneroVinilButton.Size = new System.Drawing.Size(75, 23);
            this.salvarGeneroVinilButton.TabIndex = 11;
            this.salvarGeneroVinilButton.Text = "Salvar";
            this.salvarGeneroVinilButton.UseVisualStyleBackColor = true;
            this.salvarGeneroVinilButton.Click += new System.EventHandler(this.salvarGeneroButton_Click);
            // 
            // fecharVinilButton
            // 
            this.fecharVinilButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharVinilButton.Location = new System.Drawing.Point(355, 5);
            this.fecharVinilButton.Name = "fecharVinilButton";
            this.fecharVinilButton.Size = new System.Drawing.Size(75, 23);
            this.fecharVinilButton.TabIndex = 9;
            this.fecharVinilButton.Text = "Fechar";
            this.fecharVinilButton.UseVisualStyleBackColor = true;
            this.fecharVinilButton.Click += new System.EventHandler(this.fecharVinilButton_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(533, 117);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 19;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // middleCadastrarGeneroPanel
            // 
            this.middleCadastrarGeneroPanel.Controls.Add(this.nomeGeneroLabel);
            this.middleCadastrarGeneroPanel.Controls.Add(this.nomeGeneroVinilTextBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.idVinilTextBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.idLabel);
            this.middleCadastrarGeneroPanel.Controls.Add(this.ativoCheckBox);
            this.middleCadastrarGeneroPanel.Controls.Add(this.buttonsBottomClientePanel);
            this.middleCadastrarGeneroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleCadastrarGeneroPanel.Location = new System.Drawing.Point(0, 0);
            this.middleCadastrarGeneroPanel.Name = "middleCadastrarGeneroPanel";
            this.middleCadastrarGeneroPanel.Size = new System.Drawing.Size(592, 171);
            this.middleCadastrarGeneroPanel.TabIndex = 11;
            // 
            // nomeGeneroLabel
            // 
            this.nomeGeneroLabel.AutoSize = true;
            this.nomeGeneroLabel.Location = new System.Drawing.Point(116, 91);
            this.nomeGeneroLabel.Name = "nomeGeneroLabel";
            this.nomeGeneroLabel.Size = new System.Drawing.Size(86, 13);
            this.nomeGeneroLabel.TabIndex = 23;
            this.nomeGeneroLabel.Text = "Nome do gênero";
            // 
            // nomeGeneroVinilTextBox
            // 
            this.nomeGeneroVinilTextBox.Location = new System.Drawing.Point(208, 87);
            this.nomeGeneroVinilTextBox.Name = "nomeGeneroVinilTextBox";
            this.nomeGeneroVinilTextBox.Size = new System.Drawing.Size(375, 20);
            this.nomeGeneroVinilTextBox.TabIndex = 22;
            // 
            // idVinilTextBox
            // 
            this.idVinilTextBox.Location = new System.Drawing.Point(36, 87);
            this.idVinilTextBox.Name = "idVinilTextBox";
            this.idVinilTextBox.ReadOnly = true;
            this.idVinilTextBox.Size = new System.Drawing.Size(74, 20);
            this.idVinilTextBox.TabIndex = 21;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 91);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "ID";
            // 
            // GeneroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 171);
            this.Controls.Add(this.topoCadastarGeneroPanel);
            this.Controls.Add(this.middleCadastrarGeneroPanel);
            this.Name = "GeneroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro de Gênero - Vinil";
            this.topoCadastarGeneroPanel.ResumeLayout(false);
            this.topoCadastarGeneroPanel.PerformLayout();
            this.buttonsBottomClientePanel.ResumeLayout(false);
            this.middleCadastrarGeneroPanel.ResumeLayout(false);
            this.middleCadastrarGeneroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topoCadastarGeneroPanel;
        private System.Windows.Forms.Label tituloTopGeneroLabel;
        private System.Windows.Forms.Label descricaoAcaoGeneroLabel;
        private System.Windows.Forms.Panel buttonsBottomClientePanel;
        private System.Windows.Forms.Button salvarGeneroVinilButton;
        private System.Windows.Forms.Button fecharVinilButton;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Panel middleCadastrarGeneroPanel;
        private System.Windows.Forms.Label nomeGeneroLabel;
        private System.Windows.Forms.TextBox nomeGeneroVinilTextBox;
        private System.Windows.Forms.TextBox idVinilTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}