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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void btt_tamanho_Click(object sender, EventArgs e)
        {
            if (ttb_texto.Text != "")
            {
                label_resultado.Text = ttb_texto.Text.Length.ToString() + " caractere(s), contando os espaços";
            }
            else
                label_resultado.Text = "Digite algo";
        }

        private void btt_palavras_Click(object sender, EventArgs e)
        {
            if (ttb_texto.TextLength > 0)
            {
                int palavras = 1;
                int pos = 0;

                while (pos < ttb_texto.TextLength)
                {
                    if (ttb_texto.Text[pos].ToString() == " ")
                        palavras++;
                    pos++;

                }

                label_resultado.Text = palavras + " palavra(s)";
            }
            else
                label_resultado.Text = "Nenhuma palavra digitada";

        }

        private void ttb_inverter_Click(object sender, EventArgs e)
        {
            if (ttb_texto.Text != "")
            {
                string invertida = "";
                int pos = ttb_texto.TextLength;

                for (int tamanho = ttb_texto.TextLength; tamanho > 0; tamanho--)
                {
                    invertida = invertida + ttb_texto.Text[pos - 1].ToString();
                    pos--;
                }
                label_resultado.Text = invertida;
            }
            else
                label_resultado.Text = "Nenhum texto digitado";
        }
    }
}
