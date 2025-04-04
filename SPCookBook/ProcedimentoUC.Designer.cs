namespace SPCookBook
{
    partial class ProcedimentoUC
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
            this.lbl_stepNumero = new System.Windows.Forms.Label();
            this.lbl_stepTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_stepNumero
            // 
            this.lbl_stepNumero.AutoSize = true;
            this.lbl_stepNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stepNumero.Location = new System.Drawing.Point(18, 15);
            this.lbl_stepNumero.Name = "lbl_stepNumero";
            this.lbl_stepNumero.Size = new System.Drawing.Size(51, 20);
            this.lbl_stepNumero.TabIndex = 0;
            this.lbl_stepNumero.Text = "label1";
            // 
            // lbl_stepTexto
            // 
            this.lbl_stepTexto.Location = new System.Drawing.Point(22, 50);
            this.lbl_stepTexto.Name = "lbl_stepTexto";
            this.lbl_stepTexto.Size = new System.Drawing.Size(283, 47);
            this.lbl_stepTexto.TabIndex = 1;
            this.lbl_stepTexto.Text = "label1";
            // 
            // ProcedimentoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_stepTexto);
            this.Controls.Add(this.lbl_stepNumero);
            this.Name = "ProcedimentoUC";
            this.Size = new System.Drawing.Size(331, 111);
            this.Load += new System.EventHandler(this.ProcedimentoUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stepNumero;
        private System.Windows.Forms.Label lbl_stepTexto;
    }
}
