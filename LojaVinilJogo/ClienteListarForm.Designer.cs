namespace LojaVinilJogo
{
    partial class ClienteListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteListarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.descricaoPesquisarClienteLabel = new System.Windows.Forms.Label();
            this.topoClientePanel = new System.Windows.Forms.Panel();
            this.tituloTopClienteLabel = new System.Windows.Forms.Label();
            this.listarClienteButton = new System.Windows.Forms.Button();
            this.filtroInativoClienteRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroAtivoClienteRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroTodosClienteRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroStatusClienteLabel = new System.Windows.Forms.Label();
            this.pesquisarClienteTextBox = new System.Windows.Forms.TextBox();
            this.inserirClienteButton = new System.Windows.Forms.Button();
            this.alterarClienteButton = new System.Windows.Forms.Button();
            this.fecharClienteButton = new System.Windows.Forms.Button();
            this.excluirClienteButton = new System.Windows.Forms.Button();
            this.bottomClientePanel = new System.Windows.Forms.Panel();
            this.qtdClientesLabel = new System.Windows.Forms.Label();
            this.buttonsBottomClientePanel = new System.Windows.Forms.Panel();
            this.middleClientePanel = new System.Windows.Forms.Panel();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.topoClientePanel.SuspendLayout();
            this.bottomClientePanel.SuspendLayout();
            this.buttonsBottomClientePanel.SuspendLayout();
            this.middleClientePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // descricaoPesquisarClienteLabel
            // 
            this.descricaoPesquisarClienteLabel.AutoSize = true;
            this.descricaoPesquisarClienteLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoPesquisarClienteLabel.Location = new System.Drawing.Point(145, 50);
            this.descricaoPesquisarClienteLabel.Name = "descricaoPesquisarClienteLabel";
            this.descricaoPesquisarClienteLabel.Size = new System.Drawing.Size(154, 17);
            this.descricaoPesquisarClienteLabel.TabIndex = 23;
            this.descricaoPesquisarClienteLabel.Text = "Digite o nome do cliente";
            // 
            // topoClientePanel
            // 
            this.topoClientePanel.Controls.Add(this.tituloTopClienteLabel);
            this.topoClientePanel.Controls.Add(this.iconPanel);
            this.topoClientePanel.Controls.Add(this.descricaoPesquisarClienteLabel);
            this.topoClientePanel.Controls.Add(this.listarClienteButton);
            this.topoClientePanel.Controls.Add(this.filtroInativoClienteRadioButton);
            this.topoClientePanel.Controls.Add(this.filtroAtivoClienteRadioButton);
            this.topoClientePanel.Controls.Add(this.filtroTodosClienteRadioButton);
            this.topoClientePanel.Controls.Add(this.filtroStatusClienteLabel);
            this.topoClientePanel.Controls.Add(this.pesquisarClienteTextBox);
            this.topoClientePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoClientePanel.Location = new System.Drawing.Point(0, 0);
            this.topoClientePanel.Name = "topoClientePanel";
            this.topoClientePanel.Size = new System.Drawing.Size(839, 113);
            this.topoClientePanel.TabIndex = 3;
            // 
            // tituloTopClienteLabel
            // 
            this.tituloTopClienteLabel.AutoSize = true;
            this.tituloTopClienteLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloTopClienteLabel.Location = new System.Drawing.Point(145, 9);
            this.tituloTopClienteLabel.Name = "tituloTopClienteLabel";
            this.tituloTopClienteLabel.Size = new System.Drawing.Size(135, 34);
            this.tituloTopClienteLabel.TabIndex = 0;
            this.tituloTopClienteLabel.Text = "Clientes";
            // 
            // listarClienteButton
            // 
            this.listarClienteButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarClienteButton.Location = new System.Drawing.Point(751, 68);
            this.listarClienteButton.Name = "listarClienteButton";
            this.listarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.listarClienteButton.TabIndex = 22;
            this.listarClienteButton.Text = "Listar";
            this.listarClienteButton.UseVisualStyleBackColor = true;
            this.listarClienteButton.Click += new System.EventHandler(this.listarClienteButton_Click);
            // 
            // filtroInativoClienteRadioButton
            // 
            this.filtroInativoClienteRadioButton.AutoSize = true;
            this.filtroInativoClienteRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroInativoClienteRadioButton.Location = new System.Drawing.Point(666, 69);
            this.filtroInativoClienteRadioButton.Name = "filtroInativoClienteRadioButton";
            this.filtroInativoClienteRadioButton.Size = new System.Drawing.Size(63, 20);
            this.filtroInativoClienteRadioButton.TabIndex = 21;
            this.filtroInativoClienteRadioButton.Text = "Inativo";
            this.filtroInativoClienteRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroAtivoClienteRadioButton
            // 
            this.filtroAtivoClienteRadioButton.AutoSize = true;
            this.filtroAtivoClienteRadioButton.Checked = true;
            this.filtroAtivoClienteRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAtivoClienteRadioButton.Location = new System.Drawing.Point(611, 69);
            this.filtroAtivoClienteRadioButton.Name = "filtroAtivoClienteRadioButton";
            this.filtroAtivoClienteRadioButton.Size = new System.Drawing.Size(53, 20);
            this.filtroAtivoClienteRadioButton.TabIndex = 20;
            this.filtroAtivoClienteRadioButton.TabStop = true;
            this.filtroAtivoClienteRadioButton.Text = "Ativo";
            this.filtroAtivoClienteRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroTodosClienteRadioButton
            // 
            this.filtroTodosClienteRadioButton.AutoSize = true;
            this.filtroTodosClienteRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosClienteRadioButton.Location = new System.Drawing.Point(549, 69);
            this.filtroTodosClienteRadioButton.Name = "filtroTodosClienteRadioButton";
            this.filtroTodosClienteRadioButton.Size = new System.Drawing.Size(59, 20);
            this.filtroTodosClienteRadioButton.TabIndex = 19;
            this.filtroTodosClienteRadioButton.Text = "Todos";
            this.filtroTodosClienteRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroStatusClienteLabel
            // 
            this.filtroStatusClienteLabel.AutoSize = true;
            this.filtroStatusClienteLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroStatusClienteLabel.Location = new System.Drawing.Point(546, 50);
            this.filtroStatusClienteLabel.Name = "filtroStatusClienteLabel";
            this.filtroStatusClienteLabel.Size = new System.Drawing.Size(43, 16);
            this.filtroStatusClienteLabel.TabIndex = 18;
            this.filtroStatusClienteLabel.Text = "Status";
            // 
            // pesquisarClienteTextBox
            // 
            this.pesquisarClienteTextBox.Location = new System.Drawing.Point(145, 69);
            this.pesquisarClienteTextBox.Name = "pesquisarClienteTextBox";
            this.pesquisarClienteTextBox.Size = new System.Drawing.Size(381, 20);
            this.pesquisarClienteTextBox.TabIndex = 1;
            // 
            // inserirClienteButton
            // 
            this.inserirClienteButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirClienteButton.Location = new System.Drawing.Point(91, 14);
            this.inserirClienteButton.Name = "inserirClienteButton";
            this.inserirClienteButton.Size = new System.Drawing.Size(75, 23);
            this.inserirClienteButton.TabIndex = 11;
            this.inserirClienteButton.Text = "Inserir";
            this.inserirClienteButton.UseVisualStyleBackColor = true;
            this.inserirClienteButton.Click += new System.EventHandler(this.inserirClienteButton_Click);
            // 
            // alterarClienteButton
            // 
            this.alterarClienteButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarClienteButton.Location = new System.Drawing.Point(172, 14);
            this.alterarClienteButton.Name = "alterarClienteButton";
            this.alterarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.alterarClienteButton.TabIndex = 10;
            this.alterarClienteButton.Text = "Alterar";
            this.alterarClienteButton.UseVisualStyleBackColor = true;
            this.alterarClienteButton.Click += new System.EventHandler(this.alterarClienteButton_Click);
            // 
            // fecharClienteButton
            // 
            this.fecharClienteButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharClienteButton.Location = new System.Drawing.Point(253, 14);
            this.fecharClienteButton.Name = "fecharClienteButton";
            this.fecharClienteButton.Size = new System.Drawing.Size(75, 23);
            this.fecharClienteButton.TabIndex = 9;
            this.fecharClienteButton.Text = "Fechar";
            this.fecharClienteButton.UseVisualStyleBackColor = true;
            this.fecharClienteButton.Click += new System.EventHandler(this.fecharClienteButton_Click);
            // 
            // excluirClienteButton
            // 
            this.excluirClienteButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirClienteButton.Location = new System.Drawing.Point(10, 14);
            this.excluirClienteButton.Name = "excluirClienteButton";
            this.excluirClienteButton.Size = new System.Drawing.Size(75, 23);
            this.excluirClienteButton.TabIndex = 12;
            this.excluirClienteButton.Text = "Excluir";
            this.excluirClienteButton.UseVisualStyleBackColor = true;
            this.excluirClienteButton.Click += new System.EventHandler(this.excluirClienteButton_Click);
            // 
            // bottomClientePanel
            // 
            this.bottomClientePanel.Controls.Add(this.qtdClientesLabel);
            this.bottomClientePanel.Controls.Add(this.buttonsBottomClientePanel);
            this.bottomClientePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomClientePanel.Location = new System.Drawing.Point(0, 401);
            this.bottomClientePanel.Name = "bottomClientePanel";
            this.bottomClientePanel.Size = new System.Drawing.Size(839, 49);
            this.bottomClientePanel.TabIndex = 5;
            // 
            // qtdClientesLabel
            // 
            this.qtdClientesLabel.AutoSize = true;
            this.qtdClientesLabel.Location = new System.Drawing.Point(12, 18);
            this.qtdClientesLabel.Name = "qtdClientesLabel";
            this.qtdClientesLabel.Size = new System.Drawing.Size(16, 13);
            this.qtdClientesLabel.TabIndex = 2;
            this.qtdClientesLabel.Text = "...";
            // 
            // buttonsBottomClientePanel
            // 
            this.buttonsBottomClientePanel.Controls.Add(this.excluirClienteButton);
            this.buttonsBottomClientePanel.Controls.Add(this.inserirClienteButton);
            this.buttonsBottomClientePanel.Controls.Add(this.alterarClienteButton);
            this.buttonsBottomClientePanel.Controls.Add(this.fecharClienteButton);
            this.buttonsBottomClientePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsBottomClientePanel.Location = new System.Drawing.Point(499, 0);
            this.buttonsBottomClientePanel.Name = "buttonsBottomClientePanel";
            this.buttonsBottomClientePanel.Size = new System.Drawing.Size(340, 49);
            this.buttonsBottomClientePanel.TabIndex = 1;
            // 
            // middleClientePanel
            // 
            this.middleClientePanel.Controls.Add(this.clienteDataGridView);
            this.middleClientePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleClientePanel.Location = new System.Drawing.Point(0, 113);
            this.middleClientePanel.Name = "middleClientePanel";
            this.middleClientePanel.Size = new System.Drawing.Size(839, 337);
            this.middleClientePanel.TabIndex = 4;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.Size = new System.Drawing.Size(839, 337);
            this.clienteDataGridView.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(SGC_Negocio.Mapeamento.Cliente);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 52;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nomeCompletoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome Completo";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataNascimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 118;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sexoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 56;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.enderecoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 74;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ClienteListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.bottomClientePanel);
            this.Controls.Add(this.middleClientePanel);
            this.Controls.Add(this.topoClientePanel);
            this.Name = "ClienteListarForm";
            this.Text = "Listar Clientes";
            this.Shown += new System.EventHandler(this.ClienteListarForm_Shown);
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.topoClientePanel.ResumeLayout(false);
            this.topoClientePanel.PerformLayout();
            this.bottomClientePanel.ResumeLayout(false);
            this.bottomClientePanel.PerformLayout();
            this.buttonsBottomClientePanel.ResumeLayout(false);
            this.middleClientePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Label descricaoPesquisarClienteLabel;
        private System.Windows.Forms.Panel topoClientePanel;
        private System.Windows.Forms.Button listarClienteButton;
        private System.Windows.Forms.RadioButton filtroInativoClienteRadioButton;
        private System.Windows.Forms.RadioButton filtroAtivoClienteRadioButton;
        private System.Windows.Forms.RadioButton filtroTodosClienteRadioButton;
        private System.Windows.Forms.Label filtroStatusClienteLabel;
        private System.Windows.Forms.TextBox pesquisarClienteTextBox;
        private System.Windows.Forms.Label tituloTopClienteLabel;
        private System.Windows.Forms.Button inserirClienteButton;
        private System.Windows.Forms.Button alterarClienteButton;
        private System.Windows.Forms.Button fecharClienteButton;
        private System.Windows.Forms.Button excluirClienteButton;
        private System.Windows.Forms.Panel bottomClientePanel;
        private System.Windows.Forms.Panel buttonsBottomClientePanel;
        private System.Windows.Forms.Panel middleClientePanel;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label qtdClientesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}