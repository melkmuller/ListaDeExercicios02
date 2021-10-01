
namespace ListaDeExercicios02
{
    partial class ListaDeExercicios02
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu01 = new System.Windows.Forms.MenuStrip();
            this.menuExercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExercicio01 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExercicio02 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exercicio03 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exercicio04 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exercicio05 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_nome = new System.Windows.Forms.Label();
            this.menu01.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu01
            // 
            this.menu01.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExercicios,
            this.menuSair});
            this.menu01.Location = new System.Drawing.Point(0, 0);
            this.menu01.Name = "menu01";
            this.menu01.Size = new System.Drawing.Size(389, 24);
            this.menu01.TabIndex = 0;
            this.menu01.Text = "menuStrip1";
            // 
            // menuExercicios
            // 
            this.menuExercicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExercicio01,
            this.menuExercicio02,
            this.menu_Exercicio03,
            this.menu_Exercicio04,
            this.menu_Exercicio05});
            this.menuExercicios.Name = "menuExercicios";
            this.menuExercicios.Size = new System.Drawing.Size(71, 20);
            this.menuExercicios.Text = "Exercícios";
            // 
            // menuExercicio01
            // 
            this.menuExercicio01.Name = "menuExercicio01";
            this.menuExercicio01.Size = new System.Drawing.Size(180, 22);
            this.menuExercicio01.Text = "Exercício 01";
            this.menuExercicio01.Click += new System.EventHandler(this.menuExercício01_Click);
            // 
            // menuExercicio02
            // 
            this.menuExercicio02.Name = "menuExercicio02";
            this.menuExercicio02.Size = new System.Drawing.Size(180, 22);
            this.menuExercicio02.Text = "Exercício 02";
            this.menuExercicio02.Click += new System.EventHandler(this.menuExercicio02_Click);
            // 
            // menu_Exercicio03
            // 
            this.menu_Exercicio03.Name = "menu_Exercicio03";
            this.menu_Exercicio03.Size = new System.Drawing.Size(180, 22);
            this.menu_Exercicio03.Text = "Exercício 03";
            this.menu_Exercicio03.Click += new System.EventHandler(this.menu_Exercicio03_Click);
            // 
            // menu_Exercicio04
            // 
            this.menu_Exercicio04.Name = "menu_Exercicio04";
            this.menu_Exercicio04.Size = new System.Drawing.Size(180, 22);
            this.menu_Exercicio04.Text = "Exercício 04";
            this.menu_Exercicio04.Click += new System.EventHandler(this.exercício04ToolStripMenuItem_Click);
            // 
            // menu_Exercicio05
            // 
            this.menu_Exercicio05.Name = "menu_Exercicio05";
            this.menu_Exercicio05.Size = new System.Drawing.Size(180, 22);
            this.menu_Exercicio05.Text = "Exercício 05";
            this.menu_Exercicio05.Click += new System.EventHandler(this.exercício05ToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE EXERCÍCIOS 02";
            // 
            // label2_nome
            // 
            this.label2_nome.AutoSize = true;
            this.label2_nome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2_nome.Location = new System.Drawing.Point(21, 94);
            this.label2_nome.Name = "label2_nome";
            this.label2_nome.Size = new System.Drawing.Size(218, 25);
            this.label2_nome.TabIndex = 2;
            this.label2_nome.Text = "Aluno: Melkizedek Müller";
            this.label2_nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListaDeExercicios02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 163);
            this.Controls.Add(this.label2_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu01);
            this.MainMenuStrip = this.menu01;
            this.Name = "ListaDeExercicios02";
            this.Text = "Menu Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu01.ResumeLayout(false);
            this.menu01.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu01;
        private System.Windows.Forms.ToolStripMenuItem menuExercicios;
        private System.Windows.Forms.ToolStripMenuItem menuExercicio01;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_nome;
        private System.Windows.Forms.ToolStripMenuItem menuExercicio02;
        private System.Windows.Forms.ToolStripMenuItem menu_Exercicio03;
        private System.Windows.Forms.ToolStripMenuItem menu_Exercicio04;
        private System.Windows.Forms.ToolStripMenuItem menu_Exercicio05;
    }
}

