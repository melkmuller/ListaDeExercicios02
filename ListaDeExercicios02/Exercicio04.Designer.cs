
namespace ListaDeExercicios02
{
    partial class Exercicio04
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
            this.label_texto = new System.Windows.Forms.Label();
            this.ttb_texto = new System.Windows.Forms.TextBox();
            this.btt_tamanho = new System.Windows.Forms.Button();
            this.btt_palavras = new System.Windows.Forms.Button();
            this.ttb_inverter = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_texto
            // 
            this.label_texto.AutoSize = true;
            this.label_texto.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_texto.Location = new System.Drawing.Point(186, 9);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(437, 30);
            this.label_texto.TabIndex = 0;
            this.label_texto.Text = "Digite qualquer texto abaixo:";
            // 
            // ttb_texto
            // 
            this.ttb_texto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ttb_texto.Location = new System.Drawing.Point(27, 58);
            this.ttb_texto.Name = "ttb_texto";
            this.ttb_texto.Size = new System.Drawing.Size(744, 33);
            this.ttb_texto.TabIndex = 1;
            // 
            // btt_tamanho
            // 
            this.btt_tamanho.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btt_tamanho.Location = new System.Drawing.Point(27, 114);
            this.btt_tamanho.Name = "btt_tamanho";
            this.btt_tamanho.Size = new System.Drawing.Size(189, 98);
            this.btt_tamanho.TabIndex = 2;
            this.btt_tamanho.Text = "TAMANHO";
            this.btt_tamanho.UseVisualStyleBackColor = true;
            this.btt_tamanho.Click += new System.EventHandler(this.btt_tamanho_Click);
            // 
            // btt_palavras
            // 
            this.btt_palavras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btt_palavras.Location = new System.Drawing.Point(305, 114);
            this.btt_palavras.Name = "btt_palavras";
            this.btt_palavras.Size = new System.Drawing.Size(189, 98);
            this.btt_palavras.TabIndex = 2;
            this.btt_palavras.Text = "PALAVRAS";
            this.btt_palavras.UseVisualStyleBackColor = true;
            this.btt_palavras.Click += new System.EventHandler(this.btt_palavras_Click);
            // 
            // ttb_inverter
            // 
            this.ttb_inverter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttb_inverter.Location = new System.Drawing.Point(582, 114);
            this.ttb_inverter.Name = "ttb_inverter";
            this.ttb_inverter.Size = new System.Drawing.Size(189, 98);
            this.ttb_inverter.TabIndex = 2;
            this.ttb_inverter.Text = "INVERTER";
            this.ttb_inverter.UseVisualStyleBackColor = true;
            this.ttb_inverter.Click += new System.EventHandler(this.ttb_inverter_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_resultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_resultado.Location = new System.Drawing.Point(27, 301);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(744, 30);
            this.label_resultado.TabIndex = 3;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.ttb_inverter);
            this.Controls.Add(this.btt_palavras);
            this.Controls.Add(this.btt_tamanho);
            this.Controls.Add(this.ttb_texto);
            this.Controls.Add(this.label_texto);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Exercicio04";
            this.Text = "Exercício 04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_texto;
        private System.Windows.Forms.TextBox ttb_texto;
        private System.Windows.Forms.Button btt_tamanho;
        private System.Windows.Forms.Button btt_palavras;
        private System.Windows.Forms.Button ttb_inverter;
        private System.Windows.Forms.Label label_resultado;
    }
}