
namespace ListaDeExercicios02
{
    partial class Exercicio03
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
            this.label_Enunciado = new System.Windows.Forms.Label();
            this.label_KMinicial = new System.Windows.Forms.Label();
            this.ttb_kminicial = new System.Windows.Forms.TextBox();
            this.label_kmfinal = new System.Windows.Forms.Label();
            this.ttb_kmfinal = new System.Windows.Forms.TextBox();
            this.label_combustivel = new System.Windows.Forms.Label();
            this.ttb_combustivel = new System.Windows.Forms.TextBox();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Enunciado
            // 
            this.label_Enunciado.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Enunciado.Location = new System.Drawing.Point(12, 9);
            this.label_Enunciado.Name = "label_Enunciado";
            this.label_Enunciado.Size = new System.Drawing.Size(569, 88);
            this.label_Enunciado.TabIndex = 0;
            this.label_Enunciado.Text = "Vamos calular a média de consumo do carro em uma viagem";
            this.label_Enunciado.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_KMinicial
            // 
            this.label_KMinicial.AutoSize = true;
            this.label_KMinicial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_KMinicial.Location = new System.Drawing.Point(22, 102);
            this.label_KMinicial.Name = "label_KMinicial";
            this.label_KMinicial.Size = new System.Drawing.Size(207, 30);
            this.label_KMinicial.TabIndex = 1;
            this.label_KMinicial.Text = "Kilometragem Inicial:";
            this.label_KMinicial.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ttb_kminicial
            // 
            this.ttb_kminicial.Location = new System.Drawing.Point(22, 135);
            this.ttb_kminicial.Name = "ttb_kminicial";
            this.ttb_kminicial.Size = new System.Drawing.Size(134, 23);
            this.ttb_kminicial.TabIndex = 2;
            // 
            // label_kmfinal
            // 
            this.label_kmfinal.AutoSize = true;
            this.label_kmfinal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_kmfinal.Location = new System.Drawing.Point(22, 169);
            this.label_kmfinal.Name = "label_kmfinal";
            this.label_kmfinal.Size = new System.Drawing.Size(196, 30);
            this.label_kmfinal.TabIndex = 1;
            this.label_kmfinal.Text = "Kilometragem Final:";
            this.label_kmfinal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ttb_kmfinal
            // 
            this.ttb_kmfinal.Location = new System.Drawing.Point(22, 200);
            this.ttb_kmfinal.Name = "ttb_kmfinal";
            this.ttb_kmfinal.Size = new System.Drawing.Size(134, 23);
            this.ttb_kmfinal.TabIndex = 2;
            // 
            // label_combustivel
            // 
            this.label_combustivel.AutoSize = true;
            this.label_combustivel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_combustivel.Location = new System.Drawing.Point(22, 227);
            this.label_combustivel.Name = "label_combustivel";
            this.label_combustivel.Size = new System.Drawing.Size(155, 30);
            this.label_combustivel.TabIndex = 1;
            this.label_combustivel.Text = "Consumo Km/l:";
            this.label_combustivel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ttb_combustivel
            // 
            this.ttb_combustivel.Location = new System.Drawing.Point(22, 258);
            this.ttb_combustivel.Name = "ttb_combustivel";
            this.ttb_combustivel.Size = new System.Drawing.Size(134, 23);
            this.ttb_combustivel.TabIndex = 2;
            // 
            // btt_calcular
            // 
            this.btt_calcular.BackColor = System.Drawing.Color.IndianRed;
            this.btt_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btt_calcular.Font = new System.Drawing.Font("Sigmar One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btt_calcular.Location = new System.Drawing.Point(367, 147);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(161, 82);
            this.btt_calcular.TabIndex = 3;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = false;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 309);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.ttb_combustivel);
            this.Controls.Add(this.ttb_kmfinal);
            this.Controls.Add(this.ttb_kminicial);
            this.Controls.Add(this.label_combustivel);
            this.Controls.Add(this.label_kmfinal);
            this.Controls.Add(this.label_KMinicial);
            this.Controls.Add(this.label_Enunciado);
            this.Name = "Exercicio03";
            this.Text = "Exercicio 03";
            this.Load += new System.EventHandler(this.Exercicio03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Enunciado;
        private System.Windows.Forms.Label label_KMinicial;
        private System.Windows.Forms.TextBox ttb_kminicial;
        private System.Windows.Forms.Label label_kmfinal;
        private System.Windows.Forms.TextBox ttb_kmfinal;
        private System.Windows.Forms.Label label_combustivel;
        private System.Windows.Forms.TextBox ttb_combustivel;
        private System.Windows.Forms.Button btt_calcular;
    }
}