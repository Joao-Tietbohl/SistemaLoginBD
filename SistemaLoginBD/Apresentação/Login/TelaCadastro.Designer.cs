namespace SistemaLoginBD
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(59, 55);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(207, 22);
            this.tbLogin.TabIndex = 3;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(59, 118);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(207, 22);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(59, 262);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(207, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(59, 313);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 28);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.Location = new System.Drawing.Point(59, 174);
            this.tbConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.Size = new System.Drawing.Size(207, 22);
            this.tbConfirmarSenha.TabIndex = 8;
            this.tbConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Senha";
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(59, 206);
            this.cbMostrarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(116, 20);
            this.cbMostrarSenha.TabIndex = 9;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.tbConfirmarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox tbConfirmarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
    }
}