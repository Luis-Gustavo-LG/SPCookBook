namespace SPCookBook
{
    partial class DetalhesReceita
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
            this.picbox_receita = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_salvos = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flp_ingredientes = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_procedimentos = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_receita)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_receita
            // 
            this.picbox_receita.Location = new System.Drawing.Point(34, 30);
            this.picbox_receita.Name = "picbox_receita";
            this.picbox_receita.Size = new System.Drawing.Size(255, 129);
            this.picbox_receita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_receita.TabIndex = 0;
            this.picbox_receita.TabStop = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(308, 109);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(90, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome da Receita";
            // 
            // lbl_salvos
            // 
            this.lbl_salvos.AutoSize = true;
            this.lbl_salvos.Location = new System.Drawing.Point(58, 180);
            this.lbl_salvos.Name = "lbl_salvos";
            this.lbl_salvos.Size = new System.Drawing.Size(90, 13);
            this.lbl_salvos.TabIndex = 2;
            this.lbl_salvos.Text = "Número de saves";
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(154, 180);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(36, 13);
            this.lbl_tempo.TabIndex = 3;
            this.lbl_tempo.Text = "tempo";
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(816, 12);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingredientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Procedimentos";
            // 
            // flp_ingredientes
            // 
            this.flp_ingredientes.AutoScroll = true;
            this.flp_ingredientes.Location = new System.Drawing.Point(34, 315);
            this.flp_ingredientes.Name = "flp_ingredientes";
            this.flp_ingredientes.Size = new System.Drawing.Size(364, 238);
            this.flp_ingredientes.TabIndex = 8;
            // 
            // flp_procedimentos
            // 
            this.flp_procedimentos.AutoScroll = true;
            this.flp_procedimentos.Location = new System.Drawing.Point(527, 315);
            this.flp_procedimentos.Name = "flp_procedimentos";
            this.flp_procedimentos.Size = new System.Drawing.Size(364, 238);
            this.flp_procedimentos.TabIndex = 9;
            // 
            // DetalhesReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 601);
            this.ControlBox = false;
            this.Controls.Add(this.flp_procedimentos);
            this.Controls.Add(this.flp_ingredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.lbl_salvos);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.picbox_receita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DetalhesReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalhesReceita";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_receita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_receita;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_salvos;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flp_ingredientes;
        private System.Windows.Forms.FlowLayoutPanel flp_procedimentos;
    }
}