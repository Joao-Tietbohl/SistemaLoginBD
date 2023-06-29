namespace SistemaLoginBD.Apresentação.Vendas
{
    partial class CadastroVenda
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
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridProdutosDisponiveis = new System.Windows.Forms.DataGridView();
            this.gridProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DisplayMember = "Nome";
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(45, 59);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(189, 24);
            this.cbFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produtos Disponíveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produtos Selecionados";
            // 
            // gridProdutosDisponiveis
            // 
            this.gridProdutosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Valor,
            this.Quantidade});
            this.gridProdutosDisponiveis.Location = new System.Drawing.Point(33, 148);
            this.gridProdutosDisponiveis.Name = "gridProdutosDisponiveis";
            this.gridProdutosDisponiveis.ReadOnly = true;
            this.gridProdutosDisponiveis.RowHeadersWidth = 51;
            this.gridProdutosDisponiveis.RowTemplate.Height = 24;
            this.gridProdutosDisponiveis.Size = new System.Drawing.Size(673, 175);
            this.gridProdutosDisponiveis.TabIndex = 4;
            this.gridProdutosDisponiveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutosDisponiveis_CellClick);
            // 
            // gridProdutosSelecionados
            // 
            this.gridProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto1,
            this.Valor1,
            this.Quantidade1});
            this.gridProdutosSelecionados.Location = new System.Drawing.Point(33, 443);
            this.gridProdutosSelecionados.Name = "gridProdutosSelecionados";
            this.gridProdutosSelecionados.ReadOnly = true;
            this.gridProdutosSelecionados.RowHeadersWidth = 51;
            this.gridProdutosSelecionados.RowTemplate.Height = 24;
            this.gridProdutosSelecionados.Size = new System.Drawing.Size(673, 175);
            this.gridProdutosSelecionados.TabIndex = 6;
            this.gridProdutosSelecionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutosSelecionados_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Total:";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Location = new System.Drawing.Point(132, 645);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(117, 22);
            this.tbValorTotal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade:";
            // 
            // nQuantidade
            // 
            this.nQuantidade.Location = new System.Drawing.Point(371, 356);
            this.nQuantidade.Name = "nQuantidade";
            this.nQuantidade.Size = new System.Drawing.Size(71, 22);
            this.nQuantidade.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(169, 355);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(468, 355);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(99, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCadastrar.Location = new System.Drawing.Point(390, 708);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(99, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(266, 708);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 250;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 70;
            // 
            // Produto1
            // 
            this.Produto1.HeaderText = "Produto";
            this.Produto1.MinimumWidth = 6;
            this.Produto1.Name = "Produto1";
            this.Produto1.ReadOnly = true;
            this.Produto1.Width = 250;
            // 
            // Valor1
            // 
            this.Valor1.HeaderText = "Valor";
            this.Valor1.MinimumWidth = 6;
            this.Valor1.Name = "Valor1";
            this.Valor1.ReadOnly = true;
            this.Valor1.Width = 80;
            // 
            // Quantidade1
            // 
            this.Quantidade1.HeaderText = "Qtd";
            this.Quantidade1.MinimumWidth = 6;
            this.Quantidade1.Name = "Quantidade1";
            this.Quantidade1.ReadOnly = true;
            this.Quantidade1.Width = 70;
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 768);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.nQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridProdutosSelecionados);
            this.Controls.Add(this.gridProdutosDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncionario);
            this.Name = "CadastroVenda";
            this.Text = "CadastroVenda";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridProdutosDisponiveis;
        private System.Windows.Forms.DataGridView gridProdutosSelecionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade1;
    }
}