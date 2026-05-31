namespace LojaVinilJogo
{
    partial class GeneroJogoListarForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneroJogoListarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topoGeneroPanel = new System.Windows.Forms.Panel();
            this.tituloTopGeneroLabel = new System.Windows.Forms.Label();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.descricaoPesquisarGeneroLabel = new System.Windows.Forms.Label();
            this.listarGeneroButton = new System.Windows.Forms.Button();
            this.filtroInativoGeneroRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroAtivoGeneroRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroTodosGeneroRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroStatusLabel = new System.Windows.Forms.Label();
            this.pesquisarGeneroTextBox = new System.Windows.Forms.TextBox();
            this.generoDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excluirGeneroButton = new System.Windows.Forms.Button();
            this.inserirGeneroButton = new System.Windows.Forms.Button();
            this.middleGeneroPanel = new System.Windows.Forms.Panel();
            this.alterarGeneroButton = new System.Windows.Forms.Button();
            this.buttonsBottomGeneroPanel = new System.Windows.Forms.Panel();
            this.fecharGeneroButton = new System.Windows.Forms.Button();
            this.bottomGeneroPanel = new System.Windows.Forms.Panel();
            this.qtdGenerosLabel = new System.Windows.Forms.Label();
            this.topoGeneroPanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.middleGeneroPanel.SuspendLayout();
            this.buttonsBottomGeneroPanel.SuspendLayout();
            this.bottomGeneroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topoGeneroPanel
            // 
            this.topoGeneroPanel.Controls.Add(this.tituloTopGeneroLabel);
            this.topoGeneroPanel.Controls.Add(this.iconPanel);
            this.topoGeneroPanel.Controls.Add(this.descricaoPesquisarGeneroLabel);
            this.topoGeneroPanel.Controls.Add(this.listarGeneroButton);
            this.topoGeneroPanel.Controls.Add(this.filtroInativoGeneroRadioButton);
            this.topoGeneroPanel.Controls.Add(this.filtroAtivoGeneroRadioButton);
            this.topoGeneroPanel.Controls.Add(this.filtroTodosGeneroRadioButton);
            this.topoGeneroPanel.Controls.Add(this.filtroStatusLabel);
            this.topoGeneroPanel.Controls.Add(this.pesquisarGeneroTextBox);
            this.topoGeneroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoGeneroPanel.Location = new System.Drawing.Point(0, 0);
            this.topoGeneroPanel.Name = "topoGeneroPanel";
            this.topoGeneroPanel.Size = new System.Drawing.Size(839, 113);
            this.topoGeneroPanel.TabIndex = 12;
            // 
            // tituloTopGeneroLabel
            // 
            this.tituloTopGeneroLabel.AutoSize = true;
            this.tituloTopGeneroLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloTopGeneroLabel.Location = new System.Drawing.Point(145, 9);
            this.tituloTopGeneroLabel.Name = "tituloTopGeneroLabel";
            this.tituloTopGeneroLabel.Size = new System.Drawing.Size(232, 34);
            this.tituloTopGeneroLabel.TabIndex = 0;
            this.tituloTopGeneroLabel.Text = "Gêneros - Jogo";
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.iconPictureBox);
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(130, 113);
            this.iconPanel.TabIndex = 24;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(0, 4);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(127, 106);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // descricaoPesquisarGeneroLabel
            // 
            this.descricaoPesquisarGeneroLabel.AutoSize = true;
            this.descricaoPesquisarGeneroLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoPesquisarGeneroLabel.Location = new System.Drawing.Point(145, 50);
            this.descricaoPesquisarGeneroLabel.Name = "descricaoPesquisarGeneroLabel";
            this.descricaoPesquisarGeneroLabel.Size = new System.Drawing.Size(210, 17);
            this.descricaoPesquisarGeneroLabel.TabIndex = 23;
            this.descricaoPesquisarGeneroLabel.Text = "Digite o nome do gênero do game";
            // 
            // listarGeneroButton
            // 
            this.listarGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarGeneroButton.Location = new System.Drawing.Point(751, 68);
            this.listarGeneroButton.Name = "listarGeneroButton";
            this.listarGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.listarGeneroButton.TabIndex = 22;
            this.listarGeneroButton.Text = "Listar";
            this.listarGeneroButton.UseVisualStyleBackColor = true;
            this.listarGeneroButton.Click += new System.EventHandler(this.listarGeneroButton_Click);
            // 
            // filtroInativoGeneroRadioButton
            // 
            this.filtroInativoGeneroRadioButton.AutoSize = true;
            this.filtroInativoGeneroRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroInativoGeneroRadioButton.Location = new System.Drawing.Point(666, 69);
            this.filtroInativoGeneroRadioButton.Name = "filtroInativoGeneroRadioButton";
            this.filtroInativoGeneroRadioButton.Size = new System.Drawing.Size(63, 20);
            this.filtroInativoGeneroRadioButton.TabIndex = 21;
            this.filtroInativoGeneroRadioButton.Text = "Inativo";
            this.filtroInativoGeneroRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroAtivoGeneroRadioButton
            // 
            this.filtroAtivoGeneroRadioButton.AutoSize = true;
            this.filtroAtivoGeneroRadioButton.Checked = true;
            this.filtroAtivoGeneroRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAtivoGeneroRadioButton.Location = new System.Drawing.Point(611, 69);
            this.filtroAtivoGeneroRadioButton.Name = "filtroAtivoGeneroRadioButton";
            this.filtroAtivoGeneroRadioButton.Size = new System.Drawing.Size(53, 20);
            this.filtroAtivoGeneroRadioButton.TabIndex = 20;
            this.filtroAtivoGeneroRadioButton.TabStop = true;
            this.filtroAtivoGeneroRadioButton.Text = "Ativo";
            this.filtroAtivoGeneroRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroTodosGeneroRadioButton
            // 
            this.filtroTodosGeneroRadioButton.AutoSize = true;
            this.filtroTodosGeneroRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosGeneroRadioButton.Location = new System.Drawing.Point(549, 69);
            this.filtroTodosGeneroRadioButton.Name = "filtroTodosGeneroRadioButton";
            this.filtroTodosGeneroRadioButton.Size = new System.Drawing.Size(59, 20);
            this.filtroTodosGeneroRadioButton.TabIndex = 19;
            this.filtroTodosGeneroRadioButton.Text = "Todos";
            this.filtroTodosGeneroRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroStatusLabel
            // 
            this.filtroStatusLabel.AutoSize = true;
            this.filtroStatusLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroStatusLabel.Location = new System.Drawing.Point(546, 50);
            this.filtroStatusLabel.Name = "filtroStatusLabel";
            this.filtroStatusLabel.Size = new System.Drawing.Size(43, 16);
            this.filtroStatusLabel.TabIndex = 18;
            this.filtroStatusLabel.Text = "Status";
            // 
            // pesquisarGeneroTextBox
            // 
            this.pesquisarGeneroTextBox.Location = new System.Drawing.Point(145, 69);
            this.pesquisarGeneroTextBox.Name = "pesquisarGeneroTextBox";
            this.pesquisarGeneroTextBox.Size = new System.Drawing.Size(381, 20);
            this.pesquisarGeneroTextBox.TabIndex = 1;
            // 
            // generoDataGridView
            // 
            this.generoDataGridView.AllowUserToAddRows = false;
            this.generoDataGridView.AllowUserToDeleteRows = false;
            this.generoDataGridView.AutoGenerateColumns = false;
            this.generoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.generoDataGridView.DataSource = this.generoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.generoDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.generoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.generoDataGridView.Name = "generoDataGridView";
            this.generoDataGridView.ReadOnly = true;
            this.generoDataGridView.Size = new System.Drawing.Size(839, 288);
            this.generoDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do gênero";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 37;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataSource = typeof(SGC_Negocio.Mapeamento.Genero);
            // 
            // excluirGeneroButton
            // 
            this.excluirGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirGeneroButton.Location = new System.Drawing.Point(10, 14);
            this.excluirGeneroButton.Name = "excluirGeneroButton";
            this.excluirGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.excluirGeneroButton.TabIndex = 12;
            this.excluirGeneroButton.Text = "Excluir";
            this.excluirGeneroButton.UseVisualStyleBackColor = true;
            this.excluirGeneroButton.Click += new System.EventHandler(this.excluirGeneroButton_Click);
            // 
            // inserirGeneroButton
            // 
            this.inserirGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirGeneroButton.Location = new System.Drawing.Point(91, 14);
            this.inserirGeneroButton.Name = "inserirGeneroButton";
            this.inserirGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.inserirGeneroButton.TabIndex = 11;
            this.inserirGeneroButton.Text = "Inserir";
            this.inserirGeneroButton.UseVisualStyleBackColor = true;
            this.inserirGeneroButton.Click += new System.EventHandler(this.inserirGeneroButton_Click);
            // 
            // middleGeneroPanel
            // 
            this.middleGeneroPanel.Controls.Add(this.generoDataGridView);
            this.middleGeneroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleGeneroPanel.Location = new System.Drawing.Point(0, 113);
            this.middleGeneroPanel.Name = "middleGeneroPanel";
            this.middleGeneroPanel.Size = new System.Drawing.Size(839, 288);
            this.middleGeneroPanel.TabIndex = 13;
            // 
            // alterarGeneroButton
            // 
            this.alterarGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarGeneroButton.Location = new System.Drawing.Point(172, 14);
            this.alterarGeneroButton.Name = "alterarGeneroButton";
            this.alterarGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.alterarGeneroButton.TabIndex = 10;
            this.alterarGeneroButton.Text = "Alterar";
            this.alterarGeneroButton.UseVisualStyleBackColor = true;
            this.alterarGeneroButton.Click += new System.EventHandler(this.alterarGeneroButton_Click);
            // 
            // buttonsBottomGeneroPanel
            // 
            this.buttonsBottomGeneroPanel.Controls.Add(this.excluirGeneroButton);
            this.buttonsBottomGeneroPanel.Controls.Add(this.inserirGeneroButton);
            this.buttonsBottomGeneroPanel.Controls.Add(this.alterarGeneroButton);
            this.buttonsBottomGeneroPanel.Controls.Add(this.fecharGeneroButton);
            this.buttonsBottomGeneroPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsBottomGeneroPanel.Location = new System.Drawing.Point(499, 0);
            this.buttonsBottomGeneroPanel.Name = "buttonsBottomGeneroPanel";
            this.buttonsBottomGeneroPanel.Size = new System.Drawing.Size(340, 49);
            this.buttonsBottomGeneroPanel.TabIndex = 1;
            // 
            // fecharGeneroButton
            // 
            this.fecharGeneroButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharGeneroButton.Location = new System.Drawing.Point(253, 14);
            this.fecharGeneroButton.Name = "fecharGeneroButton";
            this.fecharGeneroButton.Size = new System.Drawing.Size(75, 23);
            this.fecharGeneroButton.TabIndex = 9;
            this.fecharGeneroButton.Text = "Fechar";
            this.fecharGeneroButton.UseVisualStyleBackColor = true;
            this.fecharGeneroButton.Click += new System.EventHandler(this.fecharGeneroButton_Click);
            // 
            // bottomGeneroPanel
            // 
            this.bottomGeneroPanel.Controls.Add(this.qtdGenerosLabel);
            this.bottomGeneroPanel.Controls.Add(this.buttonsBottomGeneroPanel);
            this.bottomGeneroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomGeneroPanel.Location = new System.Drawing.Point(0, 401);
            this.bottomGeneroPanel.Name = "bottomGeneroPanel";
            this.bottomGeneroPanel.Size = new System.Drawing.Size(839, 49);
            this.bottomGeneroPanel.TabIndex = 14;
            // 
            // qtdGenerosLabel
            // 
            this.qtdGenerosLabel.AutoSize = true;
            this.qtdGenerosLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.qtdGenerosLabel.Location = new System.Drawing.Point(12, 18);
            this.qtdGenerosLabel.Name = "qtdGenerosLabel";
            this.qtdGenerosLabel.Size = new System.Drawing.Size(17, 17);
            this.qtdGenerosLabel.TabIndex = 2;
            this.qtdGenerosLabel.Text = "...";
            // 
            // GeneroJogoListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.middleGeneroPanel);
            this.Controls.Add(this.bottomGeneroPanel);
            this.Controls.Add(this.topoGeneroPanel);
            this.Name = "GeneroJogoListarForm";
            this.Text = "Listagem de Gênero - Jogos";
            this.Shown += new System.EventHandler(this.GeneroJogoListarForm_Shown);
            this.topoGeneroPanel.ResumeLayout(false);
            this.topoGeneroPanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            this.middleGeneroPanel.ResumeLayout(false);
            this.buttonsBottomGeneroPanel.ResumeLayout(false);
            this.bottomGeneroPanel.ResumeLayout(false);
            this.bottomGeneroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topoGeneroPanel;
        private System.Windows.Forms.Label tituloTopGeneroLabel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Label descricaoPesquisarGeneroLabel;
        private System.Windows.Forms.Button listarGeneroButton;
        private System.Windows.Forms.RadioButton filtroInativoGeneroRadioButton;
        private System.Windows.Forms.RadioButton filtroAtivoGeneroRadioButton;
        private System.Windows.Forms.RadioButton filtroTodosGeneroRadioButton;
        private System.Windows.Forms.Label filtroStatusLabel;
        private System.Windows.Forms.TextBox pesquisarGeneroTextBox;
        private System.Windows.Forms.DataGridView generoDataGridView;
        private System.Windows.Forms.Button excluirGeneroButton;
        private System.Windows.Forms.Button inserirGeneroButton;
        private System.Windows.Forms.Panel middleGeneroPanel;
        private System.Windows.Forms.Button alterarGeneroButton;
        private System.Windows.Forms.Panel buttonsBottomGeneroPanel;
        private System.Windows.Forms.Button fecharGeneroButton;
        private System.Windows.Forms.Panel bottomGeneroPanel;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label qtdGenerosLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}