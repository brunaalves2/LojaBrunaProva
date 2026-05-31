namespace LojaVinilJogo
{
    partial class JogoListarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoListarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.middleJogoPanel = new System.Windows.Forms.Panel();
            this.jogoGridView = new System.Windows.Forms.DataGridView();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.descricaoPesquisarJogoLabel = new System.Windows.Forms.Label();
            this.topoJogoPanel = new System.Windows.Forms.Panel();
            this.tituloTopJogoLabel = new System.Windows.Forms.Label();
            this.listarJogoButton = new System.Windows.Forms.Button();
            this.filtroInativoJogoRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroAtivoJogoRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroTodosJogoRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroStatusJogoLabel = new System.Windows.Forms.Label();
            this.pesquisarJogoTextBox = new System.Windows.Forms.TextBox();
            this.bottomJogoanel = new System.Windows.Forms.Panel();
            this.qtdJogosLabel = new System.Windows.Forms.Label();
            this.buttonsBottomJogoPanel = new System.Windows.Forms.Panel();
            this.excluirJogoButton = new System.Windows.Forms.Button();
            this.inserirJogoButton = new System.Windows.Forms.Button();
            this.alterarJogoButton = new System.Windows.Forms.Button();
            this.fecharJogoButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.middleJogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.topoJogoPanel.SuspendLayout();
            this.bottomJogoanel.SuspendLayout();
            this.buttonsBottomJogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middleJogoPanel
            // 
            this.middleJogoPanel.Controls.Add(this.jogoGridView);
            this.middleJogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleJogoPanel.Location = new System.Drawing.Point(0, 113);
            this.middleJogoPanel.Name = "middleJogoPanel";
            this.middleJogoPanel.Size = new System.Drawing.Size(839, 288);
            this.middleJogoPanel.TabIndex = 13;
            // 
            // jogoGridView
            // 
            this.jogoGridView.AllowUserToAddRows = false;
            this.jogoGridView.AllowUserToDeleteRows = false;
            this.jogoGridView.AutoGenerateColumns = false;
            this.jogoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jogoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iDProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.estudioDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.plataformaDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.jogoGridView.DataSource = this.jogoBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jogoGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.jogoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jogoGridView.Location = new System.Drawing.Point(0, 0);
            this.jogoGridView.Name = "jogoGridView";
            this.jogoGridView.ReadOnly = true;
            this.jogoGridView.Size = new System.Drawing.Size(839, 288);
            this.jogoGridView.TabIndex = 0;
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(SGC_Negocio.Mapeamento.Jogo);
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
            this.iconPictureBox.Location = new System.Drawing.Point(0, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(127, 106);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // descricaoPesquisarJogoLabel
            // 
            this.descricaoPesquisarJogoLabel.AutoSize = true;
            this.descricaoPesquisarJogoLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoPesquisarJogoLabel.Location = new System.Drawing.Point(145, 50);
            this.descricaoPesquisarJogoLabel.Name = "descricaoPesquisarJogoLabel";
            this.descricaoPesquisarJogoLabel.Size = new System.Drawing.Size(139, 17);
            this.descricaoPesquisarJogoLabel.TabIndex = 23;
            this.descricaoPesquisarJogoLabel.Text = "Digite o nome do jogo";
            // 
            // topoJogoPanel
            // 
            this.topoJogoPanel.Controls.Add(this.tituloTopJogoLabel);
            this.topoJogoPanel.Controls.Add(this.iconPanel);
            this.topoJogoPanel.Controls.Add(this.descricaoPesquisarJogoLabel);
            this.topoJogoPanel.Controls.Add(this.listarJogoButton);
            this.topoJogoPanel.Controls.Add(this.filtroInativoJogoRadioButton);
            this.topoJogoPanel.Controls.Add(this.filtroAtivoJogoRadioButton);
            this.topoJogoPanel.Controls.Add(this.filtroTodosJogoRadioButton);
            this.topoJogoPanel.Controls.Add(this.filtroStatusJogoLabel);
            this.topoJogoPanel.Controls.Add(this.pesquisarJogoTextBox);
            this.topoJogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoJogoPanel.Location = new System.Drawing.Point(0, 0);
            this.topoJogoPanel.Name = "topoJogoPanel";
            this.topoJogoPanel.Size = new System.Drawing.Size(839, 113);
            this.topoJogoPanel.TabIndex = 12;
            // 
            // tituloTopJogoLabel
            // 
            this.tituloTopJogoLabel.AutoSize = true;
            this.tituloTopJogoLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTopJogoLabel.Location = new System.Drawing.Point(145, 9);
            this.tituloTopJogoLabel.Name = "tituloTopJogoLabel";
            this.tituloTopJogoLabel.Size = new System.Drawing.Size(96, 34);
            this.tituloTopJogoLabel.TabIndex = 0;
            this.tituloTopJogoLabel.Text = "Jogos";
            // 
            // listarJogoButton
            // 
            this.listarJogoButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarJogoButton.Location = new System.Drawing.Point(751, 68);
            this.listarJogoButton.Name = "listarJogoButton";
            this.listarJogoButton.Size = new System.Drawing.Size(75, 23);
            this.listarJogoButton.TabIndex = 22;
            this.listarJogoButton.Text = "Listar";
            this.listarJogoButton.UseVisualStyleBackColor = true;
            this.listarJogoButton.Click += new System.EventHandler(this.listarJogoButton_Click);
            // 
            // filtroInativoJogoRadioButton
            // 
            this.filtroInativoJogoRadioButton.AutoSize = true;
            this.filtroInativoJogoRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroInativoJogoRadioButton.Location = new System.Drawing.Point(666, 69);
            this.filtroInativoJogoRadioButton.Name = "filtroInativoJogoRadioButton";
            this.filtroInativoJogoRadioButton.Size = new System.Drawing.Size(63, 20);
            this.filtroInativoJogoRadioButton.TabIndex = 21;
            this.filtroInativoJogoRadioButton.Text = "Inativo";
            this.filtroInativoJogoRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroAtivoJogoRadioButton
            // 
            this.filtroAtivoJogoRadioButton.AutoSize = true;
            this.filtroAtivoJogoRadioButton.Checked = true;
            this.filtroAtivoJogoRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAtivoJogoRadioButton.Location = new System.Drawing.Point(611, 69);
            this.filtroAtivoJogoRadioButton.Name = "filtroAtivoJogoRadioButton";
            this.filtroAtivoJogoRadioButton.Size = new System.Drawing.Size(53, 20);
            this.filtroAtivoJogoRadioButton.TabIndex = 20;
            this.filtroAtivoJogoRadioButton.TabStop = true;
            this.filtroAtivoJogoRadioButton.Text = "Ativo";
            this.filtroAtivoJogoRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroTodosJogoRadioButton
            // 
            this.filtroTodosJogoRadioButton.AutoSize = true;
            this.filtroTodosJogoRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosJogoRadioButton.Location = new System.Drawing.Point(549, 69);
            this.filtroTodosJogoRadioButton.Name = "filtroTodosJogoRadioButton";
            this.filtroTodosJogoRadioButton.Size = new System.Drawing.Size(59, 20);
            this.filtroTodosJogoRadioButton.TabIndex = 19;
            this.filtroTodosJogoRadioButton.Text = "Todos";
            this.filtroTodosJogoRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroStatusJogoLabel
            // 
            this.filtroStatusJogoLabel.AutoSize = true;
            this.filtroStatusJogoLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroStatusJogoLabel.Location = new System.Drawing.Point(546, 50);
            this.filtroStatusJogoLabel.Name = "filtroStatusJogoLabel";
            this.filtroStatusJogoLabel.Size = new System.Drawing.Size(43, 16);
            this.filtroStatusJogoLabel.TabIndex = 18;
            this.filtroStatusJogoLabel.Text = "Status";
            // 
            // pesquisarJogoTextBox
            // 
            this.pesquisarJogoTextBox.Location = new System.Drawing.Point(145, 69);
            this.pesquisarJogoTextBox.Name = "pesquisarJogoTextBox";
            this.pesquisarJogoTextBox.Size = new System.Drawing.Size(381, 20);
            this.pesquisarJogoTextBox.TabIndex = 1;
            // 
            // bottomJogoanel
            // 
            this.bottomJogoanel.Controls.Add(this.qtdJogosLabel);
            this.bottomJogoanel.Controls.Add(this.buttonsBottomJogoPanel);
            this.bottomJogoanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomJogoanel.Location = new System.Drawing.Point(0, 401);
            this.bottomJogoanel.Name = "bottomJogoanel";
            this.bottomJogoanel.Size = new System.Drawing.Size(839, 49);
            this.bottomJogoanel.TabIndex = 14;
            // 
            // qtdJogosLabel
            // 
            this.qtdJogosLabel.AutoSize = true;
            this.qtdJogosLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.qtdJogosLabel.Location = new System.Drawing.Point(12, 18);
            this.qtdJogosLabel.Name = "qtdJogosLabel";
            this.qtdJogosLabel.Size = new System.Drawing.Size(17, 17);
            this.qtdJogosLabel.TabIndex = 3;
            this.qtdJogosLabel.Text = "...";
            // 
            // buttonsBottomJogoPanel
            // 
            this.buttonsBottomJogoPanel.Controls.Add(this.excluirJogoButton);
            this.buttonsBottomJogoPanel.Controls.Add(this.inserirJogoButton);
            this.buttonsBottomJogoPanel.Controls.Add(this.alterarJogoButton);
            this.buttonsBottomJogoPanel.Controls.Add(this.fecharJogoButton);
            this.buttonsBottomJogoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsBottomJogoPanel.Location = new System.Drawing.Point(499, 0);
            this.buttonsBottomJogoPanel.Name = "buttonsBottomJogoPanel";
            this.buttonsBottomJogoPanel.Size = new System.Drawing.Size(340, 49);
            this.buttonsBottomJogoPanel.TabIndex = 1;
            // 
            // excluirJogoButton
            // 
            this.excluirJogoButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirJogoButton.Location = new System.Drawing.Point(10, 14);
            this.excluirJogoButton.Name = "excluirJogoButton";
            this.excluirJogoButton.Size = new System.Drawing.Size(75, 23);
            this.excluirJogoButton.TabIndex = 12;
            this.excluirJogoButton.Text = "Excluir";
            this.excluirJogoButton.UseVisualStyleBackColor = true;
            this.excluirJogoButton.Click += new System.EventHandler(this.excluirJogoButton_Click);
            // 
            // inserirJogoButton
            // 
            this.inserirJogoButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirJogoButton.Location = new System.Drawing.Point(91, 14);
            this.inserirJogoButton.Name = "inserirJogoButton";
            this.inserirJogoButton.Size = new System.Drawing.Size(75, 23);
            this.inserirJogoButton.TabIndex = 11;
            this.inserirJogoButton.Text = "Inserir";
            this.inserirJogoButton.UseVisualStyleBackColor = true;
            this.inserirJogoButton.Click += new System.EventHandler(this.inserirJogoButton_Click);
            // 
            // alterarJogoButton
            // 
            this.alterarJogoButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarJogoButton.Location = new System.Drawing.Point(172, 14);
            this.alterarJogoButton.Name = "alterarJogoButton";
            this.alterarJogoButton.Size = new System.Drawing.Size(75, 23);
            this.alterarJogoButton.TabIndex = 10;
            this.alterarJogoButton.Text = "Alterar";
            this.alterarJogoButton.UseVisualStyleBackColor = true;
            this.alterarJogoButton.Click += new System.EventHandler(this.alterarJogoButton_Click);
            // 
            // fecharJogoButton
            // 
            this.fecharJogoButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharJogoButton.Location = new System.Drawing.Point(253, 14);
            this.fecharJogoButton.Name = "fecharJogoButton";
            this.fecharJogoButton.Size = new System.Drawing.Size(75, 23);
            this.fecharJogoButton.TabIndex = 9;
            this.fecharJogoButton.Text = "Fechar";
            this.fecharJogoButton.UseVisualStyleBackColor = true;
            this.fecharJogoButton.Click += new System.EventHandler(this.fecharJogoButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "IDProduto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID do Produto";
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            this.iDProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdutoDataGridViewTextBoxColumn.Width = 98;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estudioDataGridViewTextBoxColumn
            // 
            this.estudioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estudioDataGridViewTextBoxColumn.DataPropertyName = "Estudio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estudioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.estudioDataGridViewTextBoxColumn.HeaderText = "Estúdio";
            this.estudioDataGridViewTextBoxColumn.Name = "estudioDataGridViewTextBoxColumn";
            this.estudioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.anoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn.Width = 51;
            // 
            // plataformaDataGridViewTextBoxColumn
            // 
            this.plataformaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plataformaDataGridViewTextBoxColumn.DataPropertyName = "Plataforma";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.plataformaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.plataformaDataGridViewTextBoxColumn.HeaderText = "Plataforma(s)";
            this.plataformaDataGridViewTextBoxColumn.Name = "plataformaDataGridViewTextBoxColumn";
            this.plataformaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.generoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.generoDataGridViewTextBoxColumn.HeaderText = "Gênero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 87;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.valorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "Valor Unitário";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 95;
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
            // JogoListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.middleJogoPanel);
            this.Controls.Add(this.bottomJogoanel);
            this.Controls.Add(this.topoJogoPanel);
            this.Name = "JogoListarForm";
            this.Text = "Listagem de Jogos";
            this.Shown += new System.EventHandler(this.JogoListarForm_Shown);
            this.middleJogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jogoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.topoJogoPanel.ResumeLayout(false);
            this.topoJogoPanel.PerformLayout();
            this.bottomJogoanel.ResumeLayout(false);
            this.bottomJogoanel.PerformLayout();
            this.buttonsBottomJogoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel middleJogoPanel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Label descricaoPesquisarJogoLabel;
        private System.Windows.Forms.Panel topoJogoPanel;
        private System.Windows.Forms.Label tituloTopJogoLabel;
        private System.Windows.Forms.Button listarJogoButton;
        private System.Windows.Forms.RadioButton filtroInativoJogoRadioButton;
        private System.Windows.Forms.RadioButton filtroAtivoJogoRadioButton;
        private System.Windows.Forms.RadioButton filtroTodosJogoRadioButton;
        private System.Windows.Forms.Label filtroStatusJogoLabel;
        private System.Windows.Forms.TextBox pesquisarJogoTextBox;
        private System.Windows.Forms.Panel bottomJogoanel;
        private System.Windows.Forms.Panel buttonsBottomJogoPanel;
        private System.Windows.Forms.Button excluirJogoButton;
        private System.Windows.Forms.Button inserirJogoButton;
        private System.Windows.Forms.Button alterarJogoButton;
        private System.Windows.Forms.Button fecharJogoButton;
        private System.Windows.Forms.DataGridView jogoGridView;
        private System.Windows.Forms.BindingSource jogoBindingSource;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label qtdJogosLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}