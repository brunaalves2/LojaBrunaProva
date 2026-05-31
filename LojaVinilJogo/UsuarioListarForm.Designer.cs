namespace LojaVinilJogo
{
    partial class UsuarioListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioListarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.middleUsuarioPanel = new System.Windows.Forms.Panel();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonsBottomUsuarioPanel = new System.Windows.Forms.Panel();
            this.excluirUsuarioButton = new System.Windows.Forms.Button();
            this.inserirUsuarioButton = new System.Windows.Forms.Button();
            this.alterarUsuarioButton = new System.Windows.Forms.Button();
            this.fecharUsuarioButton = new System.Windows.Forms.Button();
            this.bottomUsuarioPanel = new System.Windows.Forms.Panel();
            this.qtdUsuariosLabel = new System.Windows.Forms.Label();
            this.tituloTopUsuarioLabel = new System.Windows.Forms.Label();
            this.listarUsuárioButton = new System.Windows.Forms.Button();
            this.filtroInativoUsuarioRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroAtivoUsuarioRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroTodosUsuárioRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroStatusUsuárioLabel = new System.Windows.Forms.Label();
            this.pesquisarUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.topoUsuárioPanel = new System.Windows.Forms.Panel();
            this.iconUsuariosPanel = new System.Windows.Forms.Panel();
            this.usuariosPictureBox = new System.Windows.Forms.PictureBox();
            this.descricaoPesquisarUsuárioLabel = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.middleUsuarioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.buttonsBottomUsuarioPanel.SuspendLayout();
            this.bottomUsuarioPanel.SuspendLayout();
            this.topoUsuárioPanel.SuspendLayout();
            this.iconUsuariosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // middleUsuarioPanel
            // 
            this.middleUsuarioPanel.Controls.Add(this.usuarioDataGridView);
            this.middleUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleUsuarioPanel.Location = new System.Drawing.Point(0, 113);
            this.middleUsuarioPanel.Name = "middleUsuarioPanel";
            this.middleUsuarioPanel.Size = new System.Drawing.Size(839, 288);
            this.middleUsuarioPanel.TabIndex = 7;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.tipoUsuarioDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(839, 288);
            this.usuarioDataGridView.TabIndex = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(SGC_Negocio.Mapeamento.Usuario);
            // 
            // buttonsBottomUsuarioPanel
            // 
            this.buttonsBottomUsuarioPanel.Controls.Add(this.excluirUsuarioButton);
            this.buttonsBottomUsuarioPanel.Controls.Add(this.inserirUsuarioButton);
            this.buttonsBottomUsuarioPanel.Controls.Add(this.alterarUsuarioButton);
            this.buttonsBottomUsuarioPanel.Controls.Add(this.fecharUsuarioButton);
            this.buttonsBottomUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsBottomUsuarioPanel.Location = new System.Drawing.Point(499, 0);
            this.buttonsBottomUsuarioPanel.Name = "buttonsBottomUsuarioPanel";
            this.buttonsBottomUsuarioPanel.Size = new System.Drawing.Size(340, 49);
            this.buttonsBottomUsuarioPanel.TabIndex = 1;
            // 
            // excluirUsuarioButton
            // 
            this.excluirUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirUsuarioButton.Location = new System.Drawing.Point(10, 14);
            this.excluirUsuarioButton.Name = "excluirUsuarioButton";
            this.excluirUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.excluirUsuarioButton.TabIndex = 12;
            this.excluirUsuarioButton.Text = "Excluir";
            this.excluirUsuarioButton.UseVisualStyleBackColor = true;
            this.excluirUsuarioButton.Click += new System.EventHandler(this.excluirUsuarioButton_Click);
            // 
            // inserirUsuarioButton
            // 
            this.inserirUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirUsuarioButton.Location = new System.Drawing.Point(91, 14);
            this.inserirUsuarioButton.Name = "inserirUsuarioButton";
            this.inserirUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.inserirUsuarioButton.TabIndex = 11;
            this.inserirUsuarioButton.Text = "Inserir";
            this.inserirUsuarioButton.UseVisualStyleBackColor = true;
            this.inserirUsuarioButton.Click += new System.EventHandler(this.inserirUsuarioButton_Click);
            // 
            // alterarUsuarioButton
            // 
            this.alterarUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarUsuarioButton.Location = new System.Drawing.Point(172, 14);
            this.alterarUsuarioButton.Name = "alterarUsuarioButton";
            this.alterarUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.alterarUsuarioButton.TabIndex = 10;
            this.alterarUsuarioButton.Text = "Alterar";
            this.alterarUsuarioButton.UseVisualStyleBackColor = true;
            this.alterarUsuarioButton.Click += new System.EventHandler(this.alterarUsuarioButton_Click);
            // 
            // fecharUsuarioButton
            // 
            this.fecharUsuarioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharUsuarioButton.Location = new System.Drawing.Point(253, 14);
            this.fecharUsuarioButton.Name = "fecharUsuarioButton";
            this.fecharUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.fecharUsuarioButton.TabIndex = 9;
            this.fecharUsuarioButton.Text = "Fechar";
            this.fecharUsuarioButton.UseVisualStyleBackColor = true;
            this.fecharUsuarioButton.Click += new System.EventHandler(this.fecharUsuarioButton_Click);
            // 
            // bottomUsuarioPanel
            // 
            this.bottomUsuarioPanel.Controls.Add(this.qtdUsuariosLabel);
            this.bottomUsuarioPanel.Controls.Add(this.buttonsBottomUsuarioPanel);
            this.bottomUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomUsuarioPanel.Location = new System.Drawing.Point(0, 401);
            this.bottomUsuarioPanel.Name = "bottomUsuarioPanel";
            this.bottomUsuarioPanel.Size = new System.Drawing.Size(839, 49);
            this.bottomUsuarioPanel.TabIndex = 8;
            // 
            // qtdUsuariosLabel
            // 
            this.qtdUsuariosLabel.AutoSize = true;
            this.qtdUsuariosLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.qtdUsuariosLabel.Location = new System.Drawing.Point(12, 18);
            this.qtdUsuariosLabel.Name = "qtdUsuariosLabel";
            this.qtdUsuariosLabel.Size = new System.Drawing.Size(17, 17);
            this.qtdUsuariosLabel.TabIndex = 2;
            this.qtdUsuariosLabel.Text = "...";
            // 
            // tituloTopUsuarioLabel
            // 
            this.tituloTopUsuarioLabel.AutoSize = true;
            this.tituloTopUsuarioLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloTopUsuarioLabel.Location = new System.Drawing.Point(145, 9);
            this.tituloTopUsuarioLabel.Name = "tituloTopUsuarioLabel";
            this.tituloTopUsuarioLabel.Size = new System.Drawing.Size(145, 34);
            this.tituloTopUsuarioLabel.TabIndex = 0;
            this.tituloTopUsuarioLabel.Text = "Usuários";
            // 
            // listarUsuárioButton
            // 
            this.listarUsuárioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarUsuárioButton.Location = new System.Drawing.Point(751, 68);
            this.listarUsuárioButton.Name = "listarUsuárioButton";
            this.listarUsuárioButton.Size = new System.Drawing.Size(75, 23);
            this.listarUsuárioButton.TabIndex = 22;
            this.listarUsuárioButton.Text = "Listar";
            this.listarUsuárioButton.UseVisualStyleBackColor = true;
            this.listarUsuárioButton.Click += new System.EventHandler(this.listarUsuárioButton_Click);
            // 
            // filtroInativoUsuarioRadioButton
            // 
            this.filtroInativoUsuarioRadioButton.AutoSize = true;
            this.filtroInativoUsuarioRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroInativoUsuarioRadioButton.Location = new System.Drawing.Point(666, 69);
            this.filtroInativoUsuarioRadioButton.Name = "filtroInativoUsuarioRadioButton";
            this.filtroInativoUsuarioRadioButton.Size = new System.Drawing.Size(63, 20);
            this.filtroInativoUsuarioRadioButton.TabIndex = 21;
            this.filtroInativoUsuarioRadioButton.Text = "Inativo";
            this.filtroInativoUsuarioRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroAtivoUsuarioRadioButton
            // 
            this.filtroAtivoUsuarioRadioButton.AutoSize = true;
            this.filtroAtivoUsuarioRadioButton.Checked = true;
            this.filtroAtivoUsuarioRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAtivoUsuarioRadioButton.Location = new System.Drawing.Point(611, 69);
            this.filtroAtivoUsuarioRadioButton.Name = "filtroAtivoUsuarioRadioButton";
            this.filtroAtivoUsuarioRadioButton.Size = new System.Drawing.Size(53, 20);
            this.filtroAtivoUsuarioRadioButton.TabIndex = 20;
            this.filtroAtivoUsuarioRadioButton.TabStop = true;
            this.filtroAtivoUsuarioRadioButton.Text = "Ativo";
            this.filtroAtivoUsuarioRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroTodosUsuárioRadioButton
            // 
            this.filtroTodosUsuárioRadioButton.AutoSize = true;
            this.filtroTodosUsuárioRadioButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosUsuárioRadioButton.Location = new System.Drawing.Point(549, 69);
            this.filtroTodosUsuárioRadioButton.Name = "filtroTodosUsuárioRadioButton";
            this.filtroTodosUsuárioRadioButton.Size = new System.Drawing.Size(59, 20);
            this.filtroTodosUsuárioRadioButton.TabIndex = 19;
            this.filtroTodosUsuárioRadioButton.Text = "Todos";
            this.filtroTodosUsuárioRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroStatusUsuárioLabel
            // 
            this.filtroStatusUsuárioLabel.AutoSize = true;
            this.filtroStatusUsuárioLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroStatusUsuárioLabel.Location = new System.Drawing.Point(546, 50);
            this.filtroStatusUsuárioLabel.Name = "filtroStatusUsuárioLabel";
            this.filtroStatusUsuárioLabel.Size = new System.Drawing.Size(43, 16);
            this.filtroStatusUsuárioLabel.TabIndex = 18;
            this.filtroStatusUsuárioLabel.Text = "Status";
            // 
            // pesquisarUsuarioTextBox
            // 
            this.pesquisarUsuarioTextBox.Location = new System.Drawing.Point(145, 69);
            this.pesquisarUsuarioTextBox.Name = "pesquisarUsuarioTextBox";
            this.pesquisarUsuarioTextBox.Size = new System.Drawing.Size(381, 20);
            this.pesquisarUsuarioTextBox.TabIndex = 1;
            // 
            // topoUsuárioPanel
            // 
            this.topoUsuárioPanel.Controls.Add(this.tituloTopUsuarioLabel);
            this.topoUsuárioPanel.Controls.Add(this.iconUsuariosPanel);
            this.topoUsuárioPanel.Controls.Add(this.descricaoPesquisarUsuárioLabel);
            this.topoUsuárioPanel.Controls.Add(this.listarUsuárioButton);
            this.topoUsuárioPanel.Controls.Add(this.filtroInativoUsuarioRadioButton);
            this.topoUsuárioPanel.Controls.Add(this.filtroAtivoUsuarioRadioButton);
            this.topoUsuárioPanel.Controls.Add(this.filtroTodosUsuárioRadioButton);
            this.topoUsuárioPanel.Controls.Add(this.filtroStatusUsuárioLabel);
            this.topoUsuárioPanel.Controls.Add(this.pesquisarUsuarioTextBox);
            this.topoUsuárioPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoUsuárioPanel.Location = new System.Drawing.Point(0, 0);
            this.topoUsuárioPanel.Name = "topoUsuárioPanel";
            this.topoUsuárioPanel.Size = new System.Drawing.Size(839, 113);
            this.topoUsuárioPanel.TabIndex = 6;
            // 
            // iconUsuariosPanel
            // 
            this.iconUsuariosPanel.Controls.Add(this.usuariosPictureBox);
            this.iconUsuariosPanel.Location = new System.Drawing.Point(0, 0);
            this.iconUsuariosPanel.Name = "iconUsuariosPanel";
            this.iconUsuariosPanel.Size = new System.Drawing.Size(139, 113);
            this.iconUsuariosPanel.TabIndex = 24;
            // 
            // usuariosPictureBox
            // 
            this.usuariosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usuariosPictureBox.Image")));
            this.usuariosPictureBox.Location = new System.Drawing.Point(4, 4);
            this.usuariosPictureBox.Name = "usuariosPictureBox";
            this.usuariosPictureBox.Size = new System.Drawing.Size(127, 106);
            this.usuariosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usuariosPictureBox.TabIndex = 0;
            this.usuariosPictureBox.TabStop = false;
            // 
            // descricaoPesquisarUsuárioLabel
            // 
            this.descricaoPesquisarUsuárioLabel.AutoSize = true;
            this.descricaoPesquisarUsuárioLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoPesquisarUsuárioLabel.Location = new System.Drawing.Point(145, 50);
            this.descricaoPesquisarUsuárioLabel.Name = "descricaoPesquisarUsuárioLabel";
            this.descricaoPesquisarUsuárioLabel.Size = new System.Drawing.Size(159, 17);
            this.descricaoPesquisarUsuárioLabel.TabIndex = 23;
            this.descricaoPesquisarUsuárioLabel.Text = "Digite o nome do usuário";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoUsuarioDataGridViewTextBoxColumn
            // 
            this.tipoUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "TipoUsuario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Tipo de Usuário";
            this.tipoUsuarioDataGridViewTextBoxColumn.Name = "tipoUsuarioDataGridViewTextBoxColumn";
            this.tipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoUsuarioDataGridViewTextBoxColumn.Width = 98;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataCadastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data do Cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Width = 106;
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
            // UsuarioListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.middleUsuarioPanel);
            this.Controls.Add(this.bottomUsuarioPanel);
            this.Controls.Add(this.topoUsuárioPanel);
            this.Name = "UsuarioListarForm";
            this.Text = "UsuarioListarForm";
            this.Shown += new System.EventHandler(this.UsuarioListarForm_Shown);
            this.middleUsuarioPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.buttonsBottomUsuarioPanel.ResumeLayout(false);
            this.bottomUsuarioPanel.ResumeLayout(false);
            this.bottomUsuarioPanel.PerformLayout();
            this.topoUsuárioPanel.ResumeLayout(false);
            this.topoUsuárioPanel.PerformLayout();
            this.iconUsuariosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel middleUsuarioPanel;
        private System.Windows.Forms.Panel buttonsBottomUsuarioPanel;
        private System.Windows.Forms.Button excluirUsuarioButton;
        private System.Windows.Forms.Button inserirUsuarioButton;
        private System.Windows.Forms.Button alterarUsuarioButton;
        private System.Windows.Forms.Button fecharUsuarioButton;
        private System.Windows.Forms.Panel bottomUsuarioPanel;
        private System.Windows.Forms.Label tituloTopUsuarioLabel;
        private System.Windows.Forms.Button listarUsuárioButton;
        private System.Windows.Forms.RadioButton filtroInativoUsuarioRadioButton;
        private System.Windows.Forms.RadioButton filtroAtivoUsuarioRadioButton;
        private System.Windows.Forms.RadioButton filtroTodosUsuárioRadioButton;
        private System.Windows.Forms.Label filtroStatusUsuárioLabel;
        private System.Windows.Forms.TextBox pesquisarUsuarioTextBox;
        private System.Windows.Forms.Panel topoUsuárioPanel;
        private System.Windows.Forms.Panel iconUsuariosPanel;
        private System.Windows.Forms.Label descricaoPesquisarUsuárioLabel;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.PictureBox usuariosPictureBox;
        private System.Windows.Forms.Label qtdUsuariosLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}