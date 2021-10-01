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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void Exercicio03_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            if (ttb_combustivel.TextLength > 0 && ttb_kmfinal.TextLength > 0 && ttb_kminicial.TextLength > 0)
            {
                decimal km_final = Convert.ToDecimal(ttb_kmfinal.Text);
                decimal km_inicial = Convert.ToDecimal(ttb_kminicial.Text);
                decimal combustivel = Convert.ToDecimal(ttb_combustivel.Text);

                if (km_final > 0 && km_inicial > 0 && combustivel > 0)
                    if (km_final > km_inicial)
                    {
                        MessageBox.Show(" Você teve um consumo de " + Convert.ToDecimal(Math.Round(((km_final - km_inicial) / combustivel),3))
                            + " litros de combustível", "Resultado");
                    }
                    else
                        MessageBox.Show("Kilometragem final deve ser maior\nque kilometragem inicial","Aviso", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Nenhum valor pode ser negativo!", "Aviso", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Favor preencher todos os campos!", "Aviso");
        }
    }
}
