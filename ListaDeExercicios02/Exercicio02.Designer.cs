
namespace ListaDeExercicios02
{
    partial class Exercicio02
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
            this.label_Comprimento = new System.Windows.Forms.Label();
            this.ttb_Comprimento = new System.Windows.Forms.TextBox();
            this.label_Largura = new System.Windows.Forms.Label();
            this.ttb_Largura = new System.Windows.Forms.TextBox();
            this.label_Altura = new System.Windows.Forms.Label();
            this.ttb_Altura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos calcular o volume de uma caixa retangular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Comprimento
            // 
            this.label_Comprimento.AutoSize = true;
            this.label_Comprimento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Comprimento.Location = new System.Drawing.Point(16, 59);
            this.label_Comprimento.Name = "label_Comprimento";
            this.label_Comprimento.Size = new System.Drawing.Size(132, 25);
            this.label_Comprimento.TabIndex = 1;
            this.label_Comprimento.Text = "Comprimento:";
            this.label_Comprimento.Click += new System.EventHandler(this.label2_Click);
            // 
            // ttb_Comprimento
            // 
            this.ttb_Comprimento.Location = new System.Drawing.Point(21, 87);
            this.ttb_Comprimento.Name = "ttb_Comprimento";
            this.ttb_Comprimento.Size = new System.Drawing.Size(100, 23);
            this.ttb_Comprimento.TabIndex = 2;
            // 
            // label_Largura
            // 
            this.label_Largura.AutoSize = true;
            this.label_Largura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Largura.Location = new System.Drawing.Point(21, 130);
            this.label_Largura.Name = "label_Largura";
            this.label_Largura.Size = new System.Drawing.Size(81, 25);
            this.label_Largura.TabIndex = 1;
            this.label_Largura.Text = "Largura:";
            this.label_Largura.Click += new System.EventHandler(this.label2_Click);
            // 
            // ttb_Largura
            // 
            this.ttb_Largura.Location = new System.Drawing.Point(21, 158);
            this.ttb_Largura.Name = "ttb_Largura";
            this.ttb_Largura.Size = new System.Drawing.Size(100, 23);
            this.ttb_Largura.TabIndex = 2;
            // 
            // label_Altura
            // 
            this.label_Altura.AutoSize = true;
            this.label_Altura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Altura.Location = new System.Drawing.Point(21, 209);
            this.label_Altura.Name = "label_Altura";
            this.label_Altura.Size = new System.Drawing.Size(67, 25);
            this.label_Altura.TabIndex = 1;
            this.label_Altura.Text = "Altura:";
            this.label_Altura.Click += new System.EventHandler(this.label2_Click);
            // 
            // ttb_Altura
            // 
            this.ttb_Altura.Location = new System.Drawing.Point(21, 235);
            this.ttb_Altura.Name = "ttb_Altura";
            this.ttb_Altura.Size = new System.Drawing.Size(100, 23);
            this.ttb_Altura.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(321, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ttb_Altura);
            this.Controls.Add(this.ttb_Largura);
            this.Controls.Add(this.ttb_Comprimento);
            this.Controls.Add(this.label_Altura);
            this.Controls.Add(this.label_Largura);
            this.Controls.Add(this.label_Comprimento);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio02";
            this.Text = "Exercício 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Comprimento;
        private System.Windows.Forms.TextBox ttb_Comprimento;
        private System.Windows.Forms.Label label_Largura;
        private System.Windows.Forms.TextBox ttb_Largura;
        private System.Windows.Forms.Label label_Altura;
        private System.Windows.Forms.TextBox ttb_Altura;
        private System.Windows.Forms.Button button1;
    }
}