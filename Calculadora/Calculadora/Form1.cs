using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBox
            int numero1 = int.Parse(textBoxNumero1.Text);
            int numero2 = int.Parse(textBoxNumero2.Text);

            // Realizar a operação escolhida
            int resultado = numero1 + numero2;

            // Exibir o resultado em outra textbox 
            textBoxResultado.Text = resultado.ToString();
        }
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBox
            int numero1 = int.Parse(textBoxNumero1.Text);
            int numero2 = int.Parse(textBoxNumero2.Text);

            // Realizar a operação escolhida
            int resultado = numero1 - numero2;

            // Exibir o resultado em outra textbox 
            textBoxResultado.Text = resultado.ToString();
        }
        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBox
            int numero1 = int.Parse(textBoxNumero1.Text);
            int numero2 = int.Parse(textBoxNumero2.Text);

            // Realizar a operação escolhida
            int resultado = numero1 * numero2;

            // Exibir o resultado em outra textbox 
            textBoxResultado.Text = resultado.ToString();
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBox
            int numero1 = int.Parse(textBoxNumero1.Text);
            int numero2 = int.Parse(textBoxNumero2.Text);

            // Realizar a operação escolhida
            int resultado = numero1 / numero2;

            // Exibir o resultado em outra textbox 
            textBoxResultado.Text = resultado.ToString();
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // Limpar os TextBox
            textBoxNumero1.Text = "";
            textBoxNumero2.Text = "";
            textBoxResultado.Text = "";
        }

    }
}
