
namespace ListaDeExercicios02
{
    partial class Exercicio01
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
            this.label_enunciado = new System.Windows.Forms.Label();
            this.label_indicativa = new System.Windows.Forms.Label();
            this.ttb_fahrenheit = new System.Windows.Forms.TextBox();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_enunciado
            // 
            this.label_enunciado.AutoSize = true;
            this.label_enunciado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_enunciado.ForeColor = System.Drawing.Color.Coral;
            this.label_enunciado.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label_enunciado.Location = new System.Drawing.Point(12, 26);
            this.label_enunciado.Name = "label_enunciado";
            this.label_enunciado.Size = new System.Drawing.Size(727, 28);
            this.label_enunciado.TabIndex = 0;
            this.label_enunciado.Text = "Vamos converter uma temperatura em graus Fahrenheit para Graus Celsius";
            this.label_enunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_enunciado.UseCompatibleTextRendering = true;
            this.label_enunciado.Click += new System.EventHandler(this.label_enunciado_Click);
            // 
            // label_indicativa
            // 
            this.label_indicativa.AutoSize = true;
            this.label_indicativa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_indicativa.Location = new System.Drawing.Point(29, 67);
            this.label_indicativa.Name = "label_indicativa";
            this.label_indicativa.Size = new System.Drawing.Size(288, 30);
            this.label_indicativa.TabIndex = 1;
            this.label_indicativa.Text = "Temperatura em Fahrenheit:";
            // 
            // ttb_fahrenheit
            // 
            this.ttb_fahrenheit.Location = new System.Drawing.Point(29, 100);
            this.ttb_fahrenheit.Name = "ttb_fahrenheit";
            this.ttb_fahrenheit.Size = new System.Drawing.Size(107, 23);
            this.ttb_fahrenheit.TabIndex = 2;
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(29, 139);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(75, 23);
            this.btt_calcular.TabIndex = 3;
            this.btt_calcular.Text = "CALCULAR";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.ttb_fahrenheit);
            this.Controls.Add(this.label_indicativa);
            this.Controls.Add(this.label_enunciado);
            this.Name = "Exercicio01";
            this.Text = "Exercício 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_enunciado;
        private System.Windows.Forms.Label label_indicativa;
        private System.Windows.Forms.TextBox ttb_fahrenheit;
        private System.Windows.Forms.Button btt_calcular;
    }
}