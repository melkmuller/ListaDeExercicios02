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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            /* Fazer todas as verificações individualmente nos texboxes;
               Caso o texto seja diferente de VAZIO ele segue verificando;
               Verifica de o número está entre 0 e 10, se afirmativo ele atribui
               na variável "nota" o valor digitado pelo usuário e avisa ao sistema
               que a nota existe através do TRUE na variável booleana;
               Caso o usuário digite um número negativo ou maior que 10 o sistema informa. */

            bool nota1existe = false;
            bool nota2existe = false;
            bool nota3existe = false;
            bool nota4existe = false;

            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal nota4 = 0;

            if (ttb_nota1.Text != "")
            {
                if (ttb_nota1.TextLength != 0 && Convert.ToDecimal(ttb_nota1.Text) >= 0 && Convert.ToDecimal(ttb_nota1.Text) <= 10)
                {
                    
                    nota1 = Convert.ToDecimal(ttb_nota1.Text);
                    nota1existe = true;
                }
                else if (Convert.ToDecimal(ttb_nota1.Text) < 0 || Convert.ToDecimal(ttb_nota1.Text) > 10)
                    MessageBox.Show("A nota não pode ser negativa ou maior que 10", "Aviso");                                   
                else
                {

                }
            }
            else
            {

            }

            if (ttb_nota2.Text != "")
            {
                if (ttb_nota2.TextLength != 0 && Convert.ToDecimal(ttb_nota2.Text) >= 0 && Convert.ToDecimal(ttb_nota2.Text) <= 10)
                {
                    
                    nota2 = Convert.ToDecimal(ttb_nota2.Text);
                    nota2existe = true;
                }
                else if (Convert.ToDecimal(ttb_nota2.Text) < 0 || Convert.ToDecimal(ttb_nota2.Text) > 10)
                    MessageBox.Show("A nota não pode ser negativa ou maior que 10", "Aviso");
                else
                {

                }
            }
            else
            {

            }


            if (ttb_nota3.Text != "")
            {
                if (ttb_nota3.TextLength != 0 && Convert.ToDecimal(ttb_nota3.Text) >= 0 && Convert.ToDecimal(ttb_nota3.Text) <= 10)
                {
                    
                    nota3 = Convert.ToDecimal(ttb_nota3.Text);
                    nota3existe = true;
                }
                else if (Convert.ToDecimal(ttb_nota3.Text) < 0 || Convert.ToDecimal(ttb_nota3.Text) > 10)
                    MessageBox.Show("A nota não pode ser negativa ou maior que 10", "Aviso");
                else
                {

                }
            }
            else
            {

            }

            if (ttb_nota4.Text != "")
            {
                if (ttb_nota4.TextLength != 0 && Convert.ToDecimal(ttb_nota4.Text) >= 0 && Convert.ToDecimal(ttb_nota4.Text) <= 10)
                {
                    
                    nota4 = Convert.ToDecimal(ttb_nota4.Text);
                    nota4existe = true;
                }
                else if (Convert.ToDecimal(ttb_nota4.Text) < 0 || Convert.ToDecimal(ttb_nota4.Text) > 10)
                    MessageBox.Show("A nota não pode ser negativa ou maior que 10", "Aviso");
                else
                {

                }
            }
            else
            {

            }

            //Fazer o cálculo com cada combinação possível de notas e mostra o resultado

            if (nota1existe == true && nota2existe == true && nota3existe == true && nota4existe == true)
                MessageBox.Show("A média das quatro notas válidas é: " + Math.Round(((nota1 + nota2 + nota3 + nota4) / 4),2),"Resultado");
            else if
                (nota1existe == true && nota2existe == true && nota3existe == true && nota4existe == false)
                MessageBox.Show("A média das três notas válidas é: " + Math.Round(((nota1 + nota2 + nota3) / 3),2),"Resultado");
            else if
                (nota1existe == true && nota2existe == true && nota3existe == false && nota4existe == false)
                MessageBox.Show("A média das duas válidas notas é: " + Math.Round(((nota1 + nota2) / 2),2),"Resultado");
            else if
                (nota1existe == true && nota2existe == true && nota3existe == false && nota4existe == true)
                MessageBox.Show("A média das três notas válidas é: " + Math.Round(((nota1 + nota2 + nota4) / 3),2),"Resultado");
            else if
                (nota1existe == true && nota2existe == false && nota3existe == true && nota4existe == true)
                MessageBox.Show("A média das três notas válidas é: " + Math.Round(((nota1 + nota3 + nota4) / 3),2),"Resultado");
            else if
                (nota1existe == false && nota2existe == true && nota3existe == true && nota4existe == true)
                MessageBox.Show("A média das três notas válidas é: " + Math.Round(((nota2 + nota3 + nota4) / 3),2),"Resultado");
            else if
                (nota1existe == true && nota2existe == false && nota3existe == false && nota4existe == true)
                MessageBox.Show("A média das duas notas válidas é: " + Math.Round(((nota1 + nota4) / 2),2),"Resultado");
            else if
                (nota1existe == false && nota2existe == false && nota3existe == true && nota4existe == true)
                MessageBox.Show("A média das duas notas válidas é: " + Math.Round(((nota3 + nota4) / 2),2),"Resultado");
            else
                MessageBox.Show("Digite ao menos duas notas");



        }
    }
}
