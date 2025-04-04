namespace SPCookBook
{
    partial class IngredienteDetalhesUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ingrediente = new System.Windows.Forms.Label();
            this.lbl_gramas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ingrediente
            // 
            this.lbl_ingrediente.AutoSize = true;
            this.lbl_ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrediente.Location = new System.Drawing.Point(23, 45);
            this.lbl_ingrediente.Name = "lbl_ingrediente";
            this.lbl_ingrediente.Size = new System.Drawing.Size(79, 18);
            this.lbl_ingrediente.TabIndex = 0;
            this.lbl_ingrediente.Text = "Ingrediente";
            // 
            // lbl_gramas
            // 
            this.lbl_gramas.AutoSize = true;
            this.lbl_gramas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gramas.Location = new System.Drawing.Point(235, 45);
            this.lbl_gramas.Name = "lbl_gramas";
            this.lbl_gramas.Size = new System.Drawing.Size(62, 18);
            this.lbl_gramas.TabIndex = 1;
            this.lbl_gramas.Text = "Gramas";
            // 
            // IngredienteDetalhesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_gramas);
            this.Controls.Add(this.lbl_ingrediente);
            this.Name = "IngredienteDetalhesUC";
            this.Size = new System.Drawing.Size(333, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ingrediente;
        private System.Windows.Forms.Label lbl_gramas;
    }
}
