using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeExercicios02
{
    public partial class ListaDeExercicios02 : Form
    {
        public ListaDeExercicios02()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuExercício01_Click(object sender, EventArgs e)
        {
            Exercicio01 tela = new Exercicio01();
            tela.Show();
        }

        private void menuExercicio02_Click(object sender, EventArgs e)
        {
            Exercicio02 tela = new Exercicio02();
            tela.Show();

        }

        private void menu_Exercicio03_Click(object sender, EventArgs e)
        {
            Exercicio03 tela = new Exercicio03();
            tela.Show();

        }
       
        private void exercício04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio04 tela = new Exercicio04();
            tela.Show();
        }

        private void exercício05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio05 tela = new Exercicio05();
            tela.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","Confirmação",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
