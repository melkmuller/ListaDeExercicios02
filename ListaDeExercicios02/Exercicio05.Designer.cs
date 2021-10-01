
namespace ListaDeExercicios02
{
    partial class Exercicio05
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttb_nota1 = new System.Windows.Forms.TextBox();
            this.ttb_nota2 = new System.Windows.Forms.TextBox();
            this.ttb_nota3 = new System.Windows.Forms.TextBox();
            this.ttb_nota4 = new System.Windows.Forms.TextBox();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos calcular a média de notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota 4:";
            // 
            // ttb_nota1
            // 
            this.ttb_nota1.Location = new System.Drawing.Point(117, 82);
            this.ttb_nota1.Name = "ttb_nota1";
            this.ttb_nota1.Size = new System.Drawing.Size(100, 23);
            this.ttb_nota1.TabIndex = 1;
            // 
            // ttb_nota2
            // 
            this.ttb_nota2.Location = new System.Drawing.Point(117, 153);
            this.ttb_nota2.Name = "ttb_nota2";
            this.ttb_nota2.Size = new System.Drawing.Size(100, 23);
            this.ttb_nota2.TabIndex = 1;
            // 
            // ttb_nota3
            // 
            this.ttb_nota3.Location = new System.Drawing.Point(116, 220);
            this.ttb_nota3.Name = "ttb_nota3";
            this.ttb_nota3.Size = new System.Drawing.Size(100, 23);
            this.ttb_nota3.TabIndex = 1;
            this.ttb_nota3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ttb_nota4
            // 
            this.ttb_nota4.Location = new System.Drawing.Point(116, 291);
            this.ttb_nota4.Name = "ttb_nota4";
            this.ttb_nota4.Size = new System.Drawing.Size(100, 23);
            this.ttb_nota4.TabIndex = 1;
            // 
            // btt_calcular
            // 
            this.btt_calcular.BackColor = System.Drawing.Color.Coral;
            this.btt_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btt_calcular.Font = new System.Drawing.Font("Teko SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btt_calcular.Location = new System.Drawing.Point(272, 154);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(113, 88);
            this.btt_calcular.TabIndex = 2;
            this.btt_calcular.Text = "MÉDIA";
            this.btt_calcular.UseVisualStyleBackColor = false;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 345);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.ttb_nota4);
            this.Controls.Add(this.ttb_nota3);
            this.Controls.Add(this.ttb_nota2);
            this.Controls.Add(this.ttb_nota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio05";
            this.Text = "Exercício 05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttb_nota1;
        private System.Windows.Forms.TextBox ttb_nota2;
        private System.Windows.Forms.TextBox ttb_nota3;
        private System.Windows.Forms.TextBox ttb_nota4;
        private System.Windows.Forms.Button btt_calcular;
    }
}