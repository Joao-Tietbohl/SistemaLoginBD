namespace SistemaLoginBD
{
    partial class FormLogin
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
            this.lbCastrese = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ainda não tem cadastro?";
            // 
            // lbCastrese
            // 
            this.lbCastrese.AutoSize = true;
            this.lbCastrese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCastrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCastrese.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCastrese.Location = new System.Drawing.Point(31, 221);
            this.lbCastrese.Name = "lbCastrese";
            this.lbCastrese.Size = new System.Drawing.Size(74, 13);
            this.lbCastrese.TabIndex = 3;
            this.lbCastrese.Text = "Cadastre-se";
            this.lbCastrese.Click += new System.EventHandler(this.lbCastrese_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(34, 70);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(169, 20);
            this.tbLogin.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(34, 127);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(169, 20);
            this.tbSenha.TabIndex = 5;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(81, 162);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(123, 104);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(92, 17);
            this.cbMostrarSenha.TabIndex = 7;
            this.cbMostrarSenha.Text = "Mostar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 274);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbCastrese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "TelaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCastrese;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
    }
}

