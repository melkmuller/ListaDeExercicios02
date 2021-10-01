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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void label_enunciado_Click(object sender, EventArgs e)
        {

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            // Verifica se o Text Box foi preenchido
            if (ttb_fahrenheit.Text.Length > 0)
            {
                // Converte a entrada do texto para decimal, faz o cálculo e mostra o resultado com duas casas decimais
                decimal fahrenheit = Convert.ToDecimal(ttb_fahrenheit.Text);
                decimal celsius = (fahrenheit - 32) * 5 / 9;
                MessageBox.Show("O valor digitado equivale a " + Math.Round(celsius,2) + " graus Celsius", "Resultado", MessageBoxButtons.OK);
            }

            // Mensagem caso não haja nada digitado
            else
                MessageBox.Show("Digite algum valor!");
        }
    }
}
