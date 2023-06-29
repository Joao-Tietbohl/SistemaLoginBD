namespace SistemaLoginBD.Apresentação.Vendas
{
    partial class ListagemVenda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVendas
            // 
            this.gridVendas.AllowUserToAddRows = false;
            this.gridVendas.AllowUserToDeleteRows = false;
            this.gridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVendas.Location = new System.Drawing.Point(0, 0);
            this.gridVendas.Name = "gridVendas";
            this.gridVendas.ReadOnly = true;
            this.gridVendas.RowHeadersWidth = 51;
            this.gridVendas.RowTemplate.Height = 24;
            this.gridVendas.Size = new System.Drawing.Size(821, 477);
            this.gridVendas.TabIndex = 1;
            this.gridVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVendas_CellClick);
            // 
            // ListagemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridVendas);
            this.Name = "ListagemVenda";
            this.Size = new System.Drawing.Size(821, 477);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVendas;
    }
}
