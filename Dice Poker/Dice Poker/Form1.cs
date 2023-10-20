using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Code made by Gabriel 11ETGPSI */

namespace Dice_Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* definição das variáveis a usar na aplicação */

        // controla o tempo de duração da rolagem de dados
        private const int cRolarTempo = 5;

        // armazena a mensagem da barra de título
        private const string cTituloBarra = "Dice Poker";

        // controlar a exibição de controlos checkbox
        private bool cListaDados = false;

        // total de créditos na conta do jogador 
        private int creditos = 20;

        // armazena o número de jogadas de dados
        private int nrJogadas;

        private int contador; //variável contador
        private int dado1; //dado com a face 1
        private int dado2; //dado com a face 2
        private int dado3; //dado com a face 3
        private int dado4; //dado com a face 4
        private int dado5; //dado com a face 5
        private int dado6; //dado com a face 6

        private void Form1_Load(object sender, EventArgs e)
        {
            //mostrar a imagem branca nas picturebox dos dados
            pbDado1.Image = imgDados.Images[0];
            pbDado2.Image = imgDados.Images[0];
            pbDado3.Image = imgDados.Images[0];
            pbDado4.Image = imgDados.Images[0];
            pbDado5.Image = imgDados.Images[0];

            //mostrar uma saudação e o total de créditos ao jogador
            txtOutput.Text = "Bem vindo!\nEstá pronto para jogar?" + "\nTem " + creditos.ToString() + " créditos.";
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            //verificar se os dados foram lançados duas vezes
            if (nrJogadas == 2)
            {
                //Altera o texto a mostra no botão
                btnRolar.Text = "Rolar os dados";

                //colocar 0 para preparar novo jogo
                nrJogadas = 0;
            }

            //Se o primeiro lançamento foi feito deve-se alternar a 
            //exibição das checkbox e acompanhar o número de rolagens
            if (btnRolar.Text == "Rolar os dados")
            {
                cListaDados = false;
                nrJogadas++;
            }
            else
            {
                cListaDados = false;
                nrJogadas++;
            }

            //inciar o controlo do timer
            timer1.Enabled = true;
        }

        private void RolarOsDados(int x)
        {
            //aramzena os número gerados aleatoriamente
            //que representa o valor da face de um dado
            int rolar;

            //variáveis para controlar os dados que o jogador
            //escolheu para manter na sua primeira rolagem
            bool saltaCase1 = false;
            bool saltaCase2 = false;
            bool saltaCase3 = false;
            bool saltaCase4 = false;
            bool saltaCase5 = false;

            if (cListaDados)
            {
                //assinalar o dado a manter pelo jogador
                if (chkDado1.Checked == true) saltaCase1 = true;
                if (chkDado2.Checked == true) saltaCase1 = true;
                if (chkDado3.Checked == true) saltaCase1 = true;
                if (chkDado4.Checked == true) saltaCase1 = true;
                if (chkDado5.Checked == true) saltaCase1 = true;
            }

            //certificar que vai ser gerado um número aleatório
            Random r = new Random();
            rolar = r.Next(1, 6);

            //testar valor gerado para determinar face do dado
            switch (rolar)
            {
                case 1:
                    if (saltaCase1 == false)
                    {
                        //jogador optou por não guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];

                    }
                    break;

                case 2:
                    if (saltaCase2 == false)
                    {
                        //jogador optou por não guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

                case 3:
                    if (saltaCase3 == false)
                    {
                        //jogador optou por não guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

                case 4:
                    if (saltaCase4 == false)
                    {
                        //jogador optou por não guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

                case 5:
                    if (saltaCase5 == false)
                    {
                        //jogador optou por não guardar
                        if (x == 1) pbDado1.Image = imgDados.Images[1];
                        if (x == 2) pbDado1.Image = imgDados.Images[2];
                        if (x == 3) pbDado1.Image = imgDados.Images[3];
                        if (x == 4) pbDado1.Image = imgDados.Images[4];
                        if (x == 5) pbDado1.Image = imgDados.Images[5];
                        if (x == 6) pbDado1.Image = imgDados.Images[6];
                    }
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs)
        {
            //variável para controlar o loop
            int i;

            //chamar o procedimento RolarOsDados em cada interação
            for (i = 1; i < 6; i++)
            {
                RolarOsDados(i);
            }

            //incrementa o contador de jogadas
            contador += 1;

            //desativar o temporizador e exibir os chechboxno final da rolagem
            if (contador > cRolarTempo)
            {
                contador = 0;
                timer1.Enabled = false;
            }

            if (nrJogadas == 1)
            {
                //alterar o texto do botão
                btnRolar.Text = "Rolar outra vez od Dados";

                //exibir o checkbox de cada dado
                chkDado1.Visible = true;
                chkDado2.Visible = true;
                chkDado3.Visible = true;
                chkDado4.Visible = true;
                chkDado5.Visible = true;
                chkDados.Visible = true;

            }

            if (nrJogadas == 2)
            {
                //preparar para uma nova jogada
                btnRolar.Text = "Rolar os Dados";
                LimparCheckbox();

                //verificaro resultado da jogada
                VerificarResultadoJogada();
            }
        }

        private void LimparCheckbox()
        {
            //ocultar e desativar as checkboxes
            chkDado1.Visible = false;
            chkDado1.Checked = false;
            chkDado2.Visible = false;
            chkDado2.Checked = false;
            chkDado3.Visible = false;
            chkDado3.Checked = false;
            chkDado4.Visible = false;
            chkDado4.Checked = false;
            chkDado5.Visible = false;
            chkDado5.Checked = false;
            
            chkDados.Visible = false;
            chkDados.Visible = false;

        }

        private void VerificarResultadoJogada()
        {
            //array para manter a contagem do número em cada mao
        }


        private void lblLegenda_Click(object sender, EventArgs e)
        {

        }
    }
}
