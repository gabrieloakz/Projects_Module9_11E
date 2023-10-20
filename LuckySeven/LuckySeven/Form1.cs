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
        private int vitorias = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public int Jogada()
        {
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

        private void lblWins_Click(object sender, EventArgs e)
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
            pictureBox1.Visible = false;
            int creditos = 10;
            int resultado;
            Random rnd = new Random();

            if (creditos > 0)
            {
                label1.Text = (rnd.Next(1, 10)).ToString();
                label2.Text = (rnd.Next(1, 10)).ToString();
                label3.Text = (rnd.Next(1, 10)).ToString();
                creditos--;
                resultado = Jogada();

                if (resultado == 1)
                {
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos++;
                    vitorias++;
                    lblWins.Text = "Vitórias: " + vitorias;
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos += 2;
                    vitorias++;
                    lblWins.Text = "Vitórias: " + vitorias;
                }
                else if (resultado == 3)
                {
                    MessageBox.Show("Você é um vencedor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    SystemSounds.Beep.Play();
                    creditos += 5;
                    vitorias++;
                    lblWins.Text = "Vitórias: " + vitorias;
                }
                else if (resultado == 4)
                {
                    MessageBox.Show("Você não ganhou nada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = false;
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                MessageBox.Show("Você não tem créditos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult resposta = MessageBox.Show("Deseja iniciar um novo jogo?", "Novo Jogo", MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    pictureBox1.Visible = false;
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    creditos = 10;
                    vitorias = 0;
                    lblWins.Text = "Vitórias: " + vitorias;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
