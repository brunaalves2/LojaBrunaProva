namespace LojaVinilJogo
{
    partial class VitrineProdutoPesquisaForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.jogoRadioButton = new System.Windows.Forms.RadioButton();
            this.vinilRadioButton = new System.Windows.Forms.RadioButton();
            this.todosRadioButton = new System.Windows.Forms.RadioButton();
            this.pesquisarProdutoTextBox = new System.Windows.Forms.TextBox();
            this.pesquisarProdutoLabel = new System.Windows.Forms.Label();
            this.tituloItensLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.qtdLabel = new System.Windows.Forms.Label();
            this.buttonsBottomPanel = new System.Windows.Forms.Panel();
            this.numeroPaginaLabel = new System.Windows.Forms.Label();
            this.proximoButton = new System.Windows.Forms.Button();
            this.anteriorButton = new System.Windows.Forms.Button();
            this.produtosFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.buttonsBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.tituloLabel);
            this.topPanel.Controls.Add(this.jogoRadioButton);
            this.topPanel.Controls.Add(this.vinilRadioButton);
            this.topPanel.Controls.Add(this.todosRadioButton);
            this.topPanel.Controls.Add(this.pesquisarProdutoTextBox);
            this.topPanel.Controls.Add(this.pesquisarProdutoLabel);
            this.topPanel.Controls.Add(this.tituloItensLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1068, 127);
            this.topPanel.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(558, 11);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(114, 34);
            this.tituloLabel.TabIndex = 7;
            this.tituloLabel.Text = "Vitrine";
            // 
            // jogoRadioButton
            // 
            this.jogoRadioButton.AutoSize = true;
            this.jogoRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogoRadioButton.Location = new System.Drawing.Point(864, 91);
            this.jogoRadioButton.Name = "jogoRadioButton";
            this.jogoRadioButton.Size = new System.Drawing.Size(103, 19);
            this.jogoRadioButton.TabIndex = 6;
            this.jogoRadioButton.TabStop = true;
            this.jogoRadioButton.Text = "Somente jogos";
            this.jogoRadioButton.UseVisualStyleBackColor = true;
            this.jogoRadioButton.CheckedChanged += new System.EventHandler(this.todosRadioButton_CheckedChanged);
            // 
            // vinilRadioButton
            // 
            this.vinilRadioButton.AutoSize = true;
            this.vinilRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinilRadioButton.Location = new System.Drawing.Point(758, 91);
            this.vinilRadioButton.Name = "vinilRadioButton";
            this.vinilRadioButton.Size = new System.Drawing.Size(98, 19);
            this.vinilRadioButton.TabIndex = 5;
            this.vinilRadioButton.TabStop = true;
            this.vinilRadioButton.Text = "Somente vinis";
            this.vinilRadioButton.UseVisualStyleBackColor = true;
            this.vinilRadioButton.CheckedChanged += new System.EventHandler(this.todosRadioButton_CheckedChanged);
            // 
            // todosRadioButton
            // 
            this.todosRadioButton.AutoSize = true;
            this.todosRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todosRadioButton.Location = new System.Drawing.Point(682, 91);
            this.todosRadioButton.Name = "todosRadioButton";
            this.todosRadioButton.Size = new System.Drawing.Size(56, 19);
            this.todosRadioButton.TabIndex = 4;
            this.todosRadioButton.TabStop = true;
            this.todosRadioButton.Text = "Todos";
            this.todosRadioButton.UseVisualStyleBackColor = true;
            this.todosRadioButton.CheckedChanged += new System.EventHandler(this.todosRadioButton_CheckedChanged);
            // 
            // pesquisarProdutoTextBox
            // 
            this.pesquisarProdutoTextBox.Location = new System.Drawing.Point(330, 89);
            this.pesquisarProdutoTextBox.Name = "pesquisarProdutoTextBox";
            this.pesquisarProdutoTextBox.Size = new System.Drawing.Size(315, 20);
            this.pesquisarProdutoTextBox.TabIndex = 3;
            this.pesquisarProdutoTextBox.TextChanged += new System.EventHandler(this.pesquisarProdutoTextBox_TextChanged);
            // 
            // pesquisarProdutoLabel
            // 
            this.pesquisarProdutoLabel.AutoSize = true;
            this.pesquisarProdutoLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarProdutoLabel.Location = new System.Drawing.Point(326, 65);
            this.pesquisarProdutoLabel.Name = "pesquisarProdutoLabel";
            this.pesquisarProdutoLabel.Size = new System.Drawing.Size(186, 21);
            this.pesquisarProdutoLabel.TabIndex = 2;
            this.pesquisarProdutoLabel.Text = "Digite o nome do produto";
            // 
            // tituloItensLabel
            // 
            this.tituloItensLabel.AutoSize = true;
            this.tituloItensLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloItensLabel.Location = new System.Drawing.Point(743, 63);
            this.tituloItensLabel.Name = "tituloItensLabel";
            this.tituloItensLabel.Size = new System.Drawing.Size(148, 15);
            this.tituloItensLabel.TabIndex = 1;
            this.tituloItensLabel.Text = "Quais produtos deseja ver?";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.qtdLabel);
            this.bottomPanel.Controls.Add(this.buttonsBottomPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 538);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1068, 61);
            this.bottomPanel.TabIndex = 2;
            // 
            // qtdLabel
            // 
            this.qtdLabel.AutoSize = true;
            this.qtdLabel.Location = new System.Drawing.Point(12, 36);
            this.qtdLabel.Name = "qtdLabel";
            this.qtdLabel.Size = new System.Drawing.Size(16, 13);
            this.qtdLabel.TabIndex = 4;
            this.qtdLabel.Text = "...";
            // 
            // buttonsBottomPanel
            // 
            this.buttonsBottomPanel.Controls.Add(this.numeroPaginaLabel);
            this.buttonsBottomPanel.Controls.Add(this.proximoButton);
            this.buttonsBottomPanel.Controls.Add(this.anteriorButton);
            this.buttonsBottomPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsBottomPanel.Location = new System.Drawing.Point(810, 0);
            this.buttonsBottomPanel.Name = "buttonsBottomPanel";
            this.buttonsBottomPanel.Size = new System.Drawing.Size(258, 61);
            this.buttonsBottomPanel.TabIndex = 3;
            // 
            // numeroPaginaLabel
            // 
            this.numeroPaginaLabel.AutoSize = true;
            this.numeroPaginaLabel.Location = new System.Drawing.Point(121, 39);
            this.numeroPaginaLabel.Name = "numeroPaginaLabel";
            this.numeroPaginaLabel.Size = new System.Drawing.Size(16, 13);
            this.numeroPaginaLabel.TabIndex = 2;
            this.numeroPaginaLabel.Text = "...";
            this.numeroPaginaLabel.Click += new System.EventHandler(this.numeroPaginaLabel_Click);
            // 
            // proximoButton
            // 
            this.proximoButton.Location = new System.Drawing.Point(156, 15);
            this.proximoButton.Name = "proximoButton";
            this.proximoButton.Size = new System.Drawing.Size(75, 23);
            this.proximoButton.TabIndex = 1;
            this.proximoButton.Text = "Próximo ▶";
            this.proximoButton.UseVisualStyleBackColor = true;
            this.proximoButton.Click += new System.EventHandler(this.proximoButton_Click);
            // 
            // anteriorButton
            // 
            this.anteriorButton.Location = new System.Drawing.Point(30, 15);
            this.anteriorButton.Name = "anteriorButton";
            this.anteriorButton.Size = new System.Drawing.Size(75, 23);
            this.anteriorButton.TabIndex = 0;
            this.anteriorButton.Text = "◀ Anterior";
            this.anteriorButton.UseVisualStyleBackColor = true;
            this.anteriorButton.Click += new System.EventHandler(this.anteriorButton_Click);
            // 
            // produtosFlowLayoutPanel
            // 
            this.produtosFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosFlowLayoutPanel.Location = new System.Drawing.Point(0, 127);
            this.produtosFlowLayoutPanel.Name = "produtosFlowLayoutPanel";
            this.produtosFlowLayoutPanel.Size = new System.Drawing.Size(1068, 411);
            this.produtosFlowLayoutPanel.TabIndex = 3;
            // 
            // VitrineProdutoPesquisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.produtosFlowLayoutPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "VitrineProdutoPesquisaForm";
            this.Text = "Vitrine de Produtos";
            this.Shown += new System.EventHandler(this.VitrineProdutoPesquisaForm_Shown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.buttonsBottomPanel.ResumeLayout(false);
            this.buttonsBottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label qtdLabel;
        private System.Windows.Forms.Panel buttonsBottomPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.RadioButton jogoRadioButton;
        private System.Windows.Forms.RadioButton vinilRadioButton;
        private System.Windows.Forms.RadioButton todosRadioButton;
        private System.Windows.Forms.TextBox pesquisarProdutoTextBox;
        private System.Windows.Forms.Label pesquisarProdutoLabel;
        private System.Windows.Forms.Label tituloItensLabel;
        private System.Windows.Forms.FlowLayoutPanel produtosFlowLayoutPanel;
        private System.Windows.Forms.Button proximoButton;
        private System.Windows.Forms.Button anteriorButton;
        private System.Windows.Forms.Label numeroPaginaLabel;
    }
}