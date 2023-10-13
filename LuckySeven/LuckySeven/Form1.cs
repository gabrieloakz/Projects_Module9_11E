using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LuckySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public int Jogada()
        {
            //Verificar se saiu algum 7
            if (Convert.ToInt32(label1.Text) == 7 || Convert.ToInt32(label2.Text) == 7 || Convert.ToInt32(label3.Text) == 7)
            {
                return 1;
            }
            else if (Convert.ToInt32(label1.Text) == 7 && Convert.ToInt32(label2.Text) == 7 || Convert.ToInt32(label1.Text) == 7 && Convert.ToInt32(label3.Text) == 7 || Convert.ToInt32(label2.Text) == 7 && Convert.ToInt32(label3.Text) == 7)
            {
                return 2;
            }
            else if (Convert.ToInt32(label1.Text) == 7 && Convert.ToInt32(label2.Text) == 7 && Convert.ToInt32(label3.Text) == 7)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Tem a certeza?", "Confirmar", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //Ocultar a imagem de ganhou
            pictureBox1.Visible = false;

            //O jogador inicia com 10 créditos na máquina
            int creditos = 10;

            //Várivel que verifica se ganhou ou não
            int resultado;

            //Criar um gerador de número aleatórios
            Random rnd = new Random();

            if (creditos > 0)
            {
                //Obter um número aleatório entre 1 e 10 para aparecer em cada label
                label1.Text = (rnd.Next(1, 10)).ToString();
                label2.Text = (rnd.Next(1, 10)).ToString();
                label3.Text = (rnd.Next(1, 10)).ToString();

                //Cada aposta(spin) custa 1 crédito;
                creditos--;

                //Chamada função da jogada
                resultado = Jogada();

                if (resultado == 1)
                {
                    //Mostrar mensagem de vencedor
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos++;
                }
                else if (resultado == 2)
                {
                    //Mostrar mensagem de vencedor
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos += 2;
                }
                else if (resultado == 3)
                {
                    //Mostrar mensagem de vencedor
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos += 5;
                }
                else if (resultado == 4)
                {
                    //Mostrar que não ganhou nada
                    MessageBox.Show("Você não ganhou nada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = false;
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {

                MessageBox.Show("Você não tem créditos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Perguntar ao jogador se ele quer iniciar um novo jogo
                DialogResult resposta = MessageBox.Show("Deseja iniciar um novo jogo?", "Novo Jogo", MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    // Reiniciar o jogo aqui (redefinindo os créditos, ocultando a imagem, etc.)
                    pictureBox1.Visible = false;
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    // ... outras inicializações

                    // Reiniciar o número de créditos
                    creditos = 10;
                }
                else
                {
                    // Se o jogador escolher não iniciar um novo jogo, então sair do aplicativo
                    Application.Exit();
                }
            }

        }

    }
}
