namespace LojaVinilJogo
{
    partial class UsuarioForm
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
            this.tituloUsuarioLabel = new System.Windows.Forms.Label();
            this.descricaoAcaoUsuarioLabel = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonsBottomUsuarioPanel = new System.Windows.Forms.Panel();
            this.salvarUsuarioButton = new System.Windows.Forms.Button();
            this.fecharUsuarioButton = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.dataCadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.middleCadastrarUsuarioPanel = new System.Windows.Forms.Panel();
            this.nomeCompletoLabel = new System.Windows.Forms.Label();
            this.dataDeCadastroLabel = new System.Windows.Forms.Label();
            this.tipoUsuarioLabel = new System.Windows.Forms.Label();
            this.nomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.topoCadastarUsuarioPanel = new System.Windows.Forms.Panel();
            this.buttonsBottomUsuarioPanel.SuspendLayout();
            this.middleCadastrarUsuarioPanel.SuspendLayout();
            this.topoCadastarUsuarioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloUsuarioLabel
            // 
            this.tituloUsuarioLabel.AutoSize = true;
            this.tituloUsuarioLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloUsuarioLabel.Location = new System.Drawing.Point(260, 9);
            this.tituloUsuarioLabel.Name = "tituloUsuarioLabel";
            this.tituloUsuarioLabel.Size = new System.Drawing.Size(145, 34);
            this.tituloUsuarioLabel.TabIndex = 0;
            this.tituloUsuarioLabel.Text = "Usuários";
            // 
            // descricaoAcaoUsuarioLabel
            // 
            this.descricaoAcaoUsuarioLabel.AutoSize = true;
            this.descricaoAcaoUsuarioLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoAcaoUsuarioLabel.Location = new System.Drawing.Point(270, 43);
            this.descricaoAcaoUsuarioLabel.Name = "descricaoAcaoUsuarioLabel";
            this.descricaoAcaoUsuarioLabel.Size = new System.Drawing.Size(124, 17);
            this.descricaoAcaoUsuarioLabel.TabIndex = 23;
            this.descricaoAcaoUsuarioLabel.Text = "Cadastrar usuários";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(559, 140);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 19;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonsBottomUsuarioPanel
            // 
            this.buttonsBottomUsuarioPanel.Controls.Add(this.salvarUsuarioButton);
            this.buttonsBottomUsuarioPanel.Controls.Add(this.fecharUsuarioButton);
            this.buttonsBottomUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsBottomUsuarioPanel.Location = new System.Drawing.Point(0, 165);
            this.buttonsBottomUsuarioPanel.Name = "buttonsBottomUsuarioPanel";
            this.buttonsBottomUsuarioPanel.Size = new System.Drawing.Size(621, 31);
            this.buttonsBottomUsuarioPanel.TabIndex = 18;
            // 
            // salvarUsuarioButton
            // 
            this.salvarUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarUsuarioButton.Location = new System.Drawing.Point(200, 5);
            this.salvarUsuarioButton.Name = "salvarUsuarioButton";
            this.salvarUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.salvarUsuarioButton.TabIndex = 11;
            this.salvarUsuarioButton.Text = "Salvar";
            this.salvarUsuarioButton.UseVisualStyleBackColor = true;
            this.salvarUsuarioButton.Click += new System.EventHandler(this.salvarUsuarioButton_Click);
            // 
            // fecharUsuarioButton
            // 
            this.fecharUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharUsuarioButton.Location = new System.Drawing.Point(362, 5);
            this.fecharUsuarioButton.Name = "fecharUsuarioButton";
            this.fecharUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.fecharUsuarioButton.TabIndex = 9;
            this.fecharUsuarioButton.Text = "Fechar";
            this.fecharUsuarioButton.UseVisualStyleBackColor = true;
            this.fecharUsuarioButton.Click += new System.EventHandler(this.fecharUsuarioButton_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(355, 57);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(256, 20);
            this.senhaTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(51, 57);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // tipoUsuarioComboBox
            // 
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Items.AddRange(new object[] {
            "1 - Administrador",
            "2 -Operador"});
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(100, 98);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(161, 21);
            this.tipoUsuarioComboBox.TabIndex = 15;
            // 
            // dataCadastroDateTimePicker
            // 
            this.dataCadastroDateTimePicker.Location = new System.Drawing.Point(360, 98);
            this.dataCadastroDateTimePicker.Name = "dataCadastroDateTimePicker";
            this.dataCadastroDateTimePicker.Size = new System.Drawing.Size(251, 20);
            this.dataCadastroDateTimePicker.TabIndex = 14;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(311, 61);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(38, 13);
            this.senhaLabel.TabIndex = 13;
            this.senhaLabel.Text = "Senha";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 61);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "E-mail";
            // 
            // middleCadastrarUsuarioPanel
            // 
            this.middleCadastrarUsuarioPanel.Controls.Add(this.ativoCheckBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.buttonsBottomUsuarioPanel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.senhaTextBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.emailTextBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.tipoUsuarioComboBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.dataCadastroDateTimePicker);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.senhaLabel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.emailLabel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.nomeCompletoLabel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.dataDeCadastroLabel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.tipoUsuarioLabel);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.nomeCompletoTextBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.idTextBox);
            this.middleCadastrarUsuarioPanel.Controls.Add(this.idLabel);
            this.middleCadastrarUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleCadastrarUsuarioPanel.Location = new System.Drawing.Point(0, 73);
            this.middleCadastrarUsuarioPanel.Name = "middleCadastrarUsuarioPanel";
            this.middleCadastrarUsuarioPanel.Size = new System.Drawing.Size(621, 196);
            this.middleCadastrarUsuarioPanel.TabIndex = 9;
            // 
            // nomeCompletoLabel
            // 
            this.nomeCompletoLabel.AutoSize = true;
            this.nomeCompletoLabel.Location = new System.Drawing.Point(126, 25);
            this.nomeCompletoLabel.Name = "nomeCompletoLabel";
            this.nomeCompletoLabel.Size = new System.Drawing.Size(82, 13);
            this.nomeCompletoLabel.TabIndex = 10;
            this.nomeCompletoLabel.Text = "Nome Completo";
            // 
            // dataDeCadastroLabel
            // 
            this.dataDeCadastroLabel.AutoSize = true;
            this.dataDeCadastroLabel.Location = new System.Drawing.Point(267, 102);
            this.dataDeCadastroLabel.Name = "dataDeCadastroLabel";
            this.dataDeCadastroLabel.Size = new System.Drawing.Size(89, 13);
            this.dataDeCadastroLabel.TabIndex = 8;
            this.dataDeCadastroLabel.Text = "Data do cadastro";
            // 
            // tipoUsuarioLabel
            // 
            this.tipoUsuarioLabel.AutoSize = true;
            this.tipoUsuarioLabel.Location = new System.Drawing.Point(12, 102);
            this.tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            this.tipoUsuarioLabel.Size = new System.Drawing.Size(82, 13);
            this.tipoUsuarioLabel.TabIndex = 4;
            this.tipoUsuarioLabel.Text = "Tipo de Usuário";
            // 
            // nomeCompletoTextBox
            // 
            this.nomeCompletoTextBox.Location = new System.Drawing.Point(214, 21);
            this.nomeCompletoTextBox.Name = "nomeCompletoTextBox";
            this.nomeCompletoTextBox.Size = new System.Drawing.Size(397, 20);
            this.nomeCompletoTextBox.TabIndex = 3;
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
            this.idLabel.Location = new System.Drawing.Point(12, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // topoCadastarUsuarioPanel
            // 
            this.topoCadastarUsuarioPanel.Controls.Add(this.tituloUsuarioLabel);
            this.topoCadastarUsuarioPanel.Controls.Add(this.descricaoAcaoUsuarioLabel);
            this.topoCadastarUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoCadastarUsuarioPanel.Location = new System.Drawing.Point(0, 0);
            this.topoCadastarUsuarioPanel.Name = "topoCadastarUsuarioPanel";
            this.topoCadastarUsuarioPanel.Size = new System.Drawing.Size(621, 73);
            this.topoCadastarUsuarioPanel.TabIndex = 8;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 269);
            this.Controls.Add(this.middleCadastrarUsuarioPanel);
            this.Controls.Add(this.topoCadastarUsuarioPanel);
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioForm";
            this.buttonsBottomUsuarioPanel.ResumeLayout(false);
            this.middleCadastrarUsuarioPanel.ResumeLayout(false);
            this.middleCadastrarUsuarioPanel.PerformLayout();
            this.topoCadastarUsuarioPanel.ResumeLayout(false);
            this.topoCadastarUsuarioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tituloUsuarioLabel;
        private System.Windows.Forms.Label descricaoAcaoUsuarioLabel;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Panel buttonsBottomUsuarioPanel;
        private System.Windows.Forms.Button salvarUsuarioButton;
        private System.Windows.Forms.Button fecharUsuarioButton;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
        private System.Windows.Forms.DateTimePicker dataCadastroDateTimePicker;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel middleCadastrarUsuarioPanel;
        private System.Windows.Forms.Label nomeCompletoLabel;
        private System.Windows.Forms.Label dataDeCadastroLabel;
        private System.Windows.Forms.Label tipoUsuarioLabel;
        private System.Windows.Forms.TextBox nomeCompletoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel topoCadastarUsuarioPanel;
    }
}