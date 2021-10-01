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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            if (ttb_Altura.Text.Length > 0 && ttb_Comprimento.Text.Length > 0 && ttb_Largura.Text.Length > 0)
            {
                // Transforma todas entradas em variáveis decimais
                decimal altura = Convert.ToDecimal(ttb_Altura.Text);
                decimal comprimento = Convert.ToDecimal(ttb_Comprimento.Text);
                decimal largura = Convert.ToDecimal(ttb_Largura.Text);

                // Verifica se todos os números digitados são positivos e maiores que zero
                if (altura > 0 && comprimento > 0 && largura > 0)
                    MessageBox.Show("O volume é: " + (altura * comprimento * largura), "Resultado", MessageBoxButtons.OK);

                // Aviso caso haja números negativos ou iguais a zero
                else
                    MessageBox.Show("Digite somente valores positivos, maiores que zero!", "Aviso");
            }
            // Aviso caso haja algum campo não preenchido
            else
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Aviso");
        }
    }
}
