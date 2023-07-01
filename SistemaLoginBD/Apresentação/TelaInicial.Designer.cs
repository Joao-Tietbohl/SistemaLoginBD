namespace SistemaLoginBD.Apresentação
{
    partial class TelaInicial
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
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnControleFuncionarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnControleVendas = new System.Windows.Forms.Button();
            this.btnControleProdutos = new System.Windows.Forms.Button();
            this.pListagem = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBemVindo.Location = new System.Drawing.Point(4, 496);
            this.lbBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(81, 14);
            this.lbBemVindo.TabIndex = 0;
            this.lbBemVindo.Text = "NomeUsuario";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(3, 414);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 28);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnControleFuncionarios);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.lbBemVindo);
            this.flowLayoutPanel1.Controls.Add(this.btnSair);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 569);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 88);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 88);
            this.panel1.TabIndex = 4;
            // 
            // btnControleFuncionarios
            // 
            this.btnControleFuncionarios.BackColor = System.Drawing.SystemColors.Control;
            this.btnControleFuncionarios.Location = new System.Drawing.Point(3, 97);
            this.btnControleFuncionarios.Name = "btnControleFuncionarios";
            this.btnControleFuncionarios.Size = new System.Drawing.Size(200, 42);
            this.btnControleFuncionarios.TabIndex = 4;
            this.btnControleFuncionarios.Text = "Controle Funcionarios";
            this.btnControleFuncionarios.UseVisualStyleBackColor = false;
            this.btnControleFuncionarios.Click += new System.EventHandler(this.btnControleFuncionarios_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnControleVendas);
            this.panel3.Controls.Add(this.btnControleProdutos);
            this.panel3.Location = new System.Drawing.Point(3, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 348);
            this.panel3.TabIndex = 5;
            // 
            // btnControleVendas
            // 
            this.btnControleVendas.BackColor = System.Drawing.SystemColors.Control;
            this.btnControleVendas.Location = new System.Drawing.Point(0, 77);
            this.btnControleVendas.Name = "btnControleVendas";
            this.btnControleVendas.Size = new System.Drawing.Size(200, 42);
            this.btnControleVendas.TabIndex = 7;
            this.btnControleVendas.Text = "Controle Vendas";
            this.btnControleVendas.UseVisualStyleBackColor = false;
            this.btnControleVendas.Click += new System.EventHandler(this.btnControleVendas_Click);
            // 
            // btnControleProdutos
            // 
            this.btnControleProdutos.BackColor = System.Drawing.SystemColors.Control;
            this.btnControleProdutos.Location = new System.Drawing.Point(-3, 19);
            this.btnControleProdutos.Name = "btnControleProdutos";
            this.btnControleProdutos.Size = new System.Drawing.Size(200, 42);
            this.btnControleProdutos.TabIndex = 6;
            this.btnControleProdutos.Text = "Controle Produtos";
            this.btnControleProdutos.UseVisualStyleBackColor = false;
            this.btnControleProdutos.Click += new System.EventHandler(this.btnControleProdutos_Click);
            // 
            // pListagem
            // 
            this.pListagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pListagem.Location = new System.Drawing.Point(209, 79);
            this.pListagem.Name = "pListagem";
            this.pListagem.Size = new System.Drawing.Size(821, 478);
            this.pListagem.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.btnInserir);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(203, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 73);
            this.panel4.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(264, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(143, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 32);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(23, 21);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(102, 32);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 569);
            this.Controls.Add(this.pListagem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBemVindo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnControleFuncionarios;
        private System.Windows.Forms.Panel pListagem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnControleProdutos;
        private System.Windows.Forms.Button btnControleVendas;
    }
}