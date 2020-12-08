using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples2
{
    public partial class FormCalc : Form
    {
        int numero1;
        int numero2;

        public FormCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Subtrair(numero1, numero2).ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Somar(numero1, numero2).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Divisão(numero1, numero2).ToString();
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            txbResultado.Text = Multiplicação(numero1, numero2).ToString();
        }

        int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        int Multiplicação(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        int Divisão(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
