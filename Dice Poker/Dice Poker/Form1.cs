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

        private void timer1_Tick(object sender, EventArgs e)
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
            //array para manter a contagem do número em cada mão
            int[] dadosArray = new int[6];

            //variável para controlar a execução do loop
            int i = 1;

            //iterar seis vezes para manter a contagem do total
            //de 1s, 2s, 3s, 4s, 5s e 6s que foram rolados
            for (int i = 1; i < 7; i++)
            {
                if (dado1 == i) dadosArray[i] += 1;
                if (dado2 == i) dadosArray[i] += 1;
                if (dado3 == i) dadosArray[i] += 1;
                if (dado4 == i) dadosArray[i] += 1;
                if (dado5 == i) dadosArray[i] += 1;
            }

            //iterar seis vezes para contar as mãos vencedoras
            for (int i = 1; i < 7; i++)
            {
                //ver se o jogador tem 5 do mesmo tipo
                if (dadosArray[i] == 5)
                {
                    creditos += 4;
                    txtOutput.Text = "GANHOU! 5 of a kind.\nGanhou 4 créditos.";
                }

                //ver se o jogador tem 4 do mesmo tipo
                if (dadosArray[i] == 4)
                {
                    creditos += 3;
                    txtOutput.Text = "GANHOU! 4 of a kind.\nGanhou 3 créditos.";
                }

                //ver se o jogador tem 3 do mesmo tipo ou Full House (3 + 2)
                if (dadosArray[i] == 3)
                {
                    //tem 3 do mesmo tipo
                    bool fullHouse = false;

                    //verificar se tem 2 do mesmo tipo
                    for (int j = 1; j < 7; j++)
                    {
                        if (dadosArray[j] == 2)
                        {
                            fullHouse = true;
                            creditos += 2;
                            txtOutput.Text = "GANHOU! Full House.\nGanhou 2 créditos.";
                            return;
                        }
                    }

                    if (fullHouse == false)
                    {
                        creditos += 1;
                        txtOutput.Text = "GANHOU! 3 of a kind.\nGanhou 1 crédito.";
                        return;
                    }
                }

                //iterar os dados 2 a 6 à procura de um High Straight
                //cada uma das posições só pode conter o valor 1
                for (int i = 2; i < 7; j++)
                {
                    if (dadosArray[i] != 1) return;
                    else
                    {
                        //quando terminar 
                        if (i == 6)
                        {
                            creditos += 3;
                            txtOutput.Text = "GANHOU! High Straight.\nGanhou 3 créditos.";
                            return;
                        }
                    }
                }

                for (int i = 1; i < 5; i++)
                {
                    if (dadosArray[i] != 1) return;
                    else
                    {
                        if (i == 5)
                        {
                            creditos += 3;
                            txtOutput.Text = "GANHOU! Low Straight.\nGanhou 3 créditos.";
                            return;
                        }
                    }
                }

                //atualizar o preço da jogada
                creditos -= 2;
                txtOutput.Text = "SORRY! Perdeu esta mão e 2 créditos.";
            }
        }

        private void AtualizarConta()
        {
            txtOutput.Text = "Tem" + creditos.ToString() + "créditos.";
        }

        private void FimDoJogo()
        {
            //variável para resposta ao jogador
            DialogResult resposta = new DialogResult();

            //linmpar as mensagens de estado do jogo
            txtOutput.Text = "";

            //prompt alerta para avisar ao jogador
            string mensagem = "Não tem crédito.\nGostaria de jogar outra vez?";

            resposta = MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se o jogador clica em Sim deve-se criar um novo jogo
            if (resposta == DialogResult.Yes)
            {
                //redefinir a conta do jogador
                creditos = 20;

                //mostra a imagem em branco nas picture box
                pbDado1.Image = imgDados.Images[0];
                pbDado2.Image = imgDados.Images[0];
                pbDado3.Image = imgDados.Images[0];
                pbDado4.Image = imgDados.Images[0];
                pbDado5.Image = imgDados.Images[0];

            }
            else
            {
                //o jogador não quer jogar mais
                Application.Exit();
            }

        }

        private void chkDados_CheckedChanged(object sender, EventArgs e) 
        {
            //se o jogador seleciona "manter tudo"
            if (chkDados.Checked == true)
            {
                chkDado1.Checked = true;
                chkDado2.Checked = true;
                chkDado3.Checked = true;
                chkDado4.Checked = true;
                chkDado5.Checked = true;
                btnRolar.Text = "Manter tudo";
            }
            else
            {
                chkDado1.Checked = false;
                chkDado2.Checked = false;
                chkDado3.Checked = false;
                chkDado4.Checked = false;
                chkDado5.Checked = false;
                btnRolar.Text = "Rolar os Dados";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLegenda_Click(object sender, EventArgs e)
        {

        }