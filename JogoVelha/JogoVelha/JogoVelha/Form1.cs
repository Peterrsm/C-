using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        private int qj;
        private int jogada = 0;
        private Random numCasa = new Random();
        String Xou0 = "";
        int nvl = 0;

        public Form1(int nivel)
        {
            nvl = nivel;
            InitializeComponent();
            jogada = 1;
            numCasa = new Random();
            Xou0 = "";
    }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            int quemJoga = numCasa.Next(1, 10);

            qj = quemJoga;

            if (quemJoga % 2 == 0)
            {
                switch (nvl)
                {
                    case 1:
                        ComputadorJovem();
                        break;
                    case 2:
                        ComputadorMaduro();
                        break;
                    case 3:
                        ComputadorVelho();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Você joga!");
            }

        }

        private void btnCasa1_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text != String.Empty)
            {
                MessageBox.Show("Jogada inválida. Tente novamente!");

            }else
            {
                if (jogada % 2 == 1)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }

                jogada++;

                int i = Verifica();
                if (i == 1)
                {
                    MessageBox.Show("Voce venceu!");
                    jogarNovamente();
                }

                switch (nvl)
                {
                    case 1:
                        ComputadorJovem();
                        break;
                    case 2:
                        ComputadorMaduro();
                        break;
                    case 3:
                        ComputadorVelho();
                        break;
                }
            }
        }

        private void ComputadorJovem()
        {
            bool jogou;

            jogou = false;

            if (jogada % 2 == 0)
            {
                Xou0 = "0";
            }
            else
            {
                Xou0 = "X";
            }

            while (jogou == false)
            {
                int jogue = numCasa.Next(1, 10);

                switch (jogue)
                {
                    case 1:
                        if (btnCasa1.Text == String.Empty)
                        {
                            btnCasa1.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 2:
                        if(btnCasa2.Text == String.Empty)
                        {
                            btnCasa2.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }                        
                        break;

                    case 3:
                        if (btnCasa3.Text == String.Empty)
                        {
                            btnCasa3.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 4:
                        if (btnCasa4.Text == String.Empty)
                        {
                            btnCasa4.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 5:
                        if (btnCasa5.Text == String.Empty)
                        {
                            btnCasa5.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 6:
                        if (btnCasa6.Text == String.Empty)
                        {
                            btnCasa6.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 7:
                        if (btnCasa7.Text == String.Empty)
                        {
                            btnCasa7.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 8:
                        if (btnCasa8.Text == String.Empty)
                        {
                            btnCasa8.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;

                    case 9:
                        if (btnCasa9.Text == String.Empty)
                        {
                            btnCasa9.Text = Xou0;
                            jogou = true;
                            jogada++;
                        }else
                        {
                            jogou = true;
                            ComputadorJovem();
                        }
                        break;
                }

                int i = Verifica();
                if (i == 1)
                {
                    MessageBox.Show("Voce perdeu!");
                    jogarNovamente();
                }

            }
        }

        private void ComputadorMaduro()
        {
            Random numCasa = new Random();            
            bool jogou = false;

            if(jogada % 2 == 0)
            {
                Xou0 = "0";
            }
            else
            {
                Xou0 = "X";
            }
            while(jogou == false)
            {
                int jogue = decideJogada();

                switch (jogue){
                    case 1:
                        btnCasa1.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 2:
                        btnCasa2.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 3:
                        btnCasa3.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 4:
                        btnCasa4.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 5:
                        btnCasa5.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 6:
                        btnCasa6.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 7:
                        btnCasa7.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 8:
                        btnCasa8.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 9:
                        btnCasa9.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;                
                }
                
                int i = Verifica();
                if (i == 1)
                {
                    MessageBox.Show("Voce perdeu!");
                    jogarNovamente();
                }

            }
        }

        private void ComputadorVelho()
        {
            Random numCasa = new Random();
            bool jogou = false;

            if (jogada % 2 == 0)
            {
                Xou0 = "0";
            }
            else
            {
                Xou0 = "X";
            }
            while (jogou == false)
            {
                int jogue = decideJogada();

                Console.WriteLine("jogada " + jogada);
                Console.WriteLine("quemjoga " + qj);
                Console.WriteLine("casa " + jogue);
                Console.WriteLine("-------------------------");
                switch (jogue)
                {
                    case 1:
                        btnCasa1.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 2:
                        btnCasa2.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 3:
                        btnCasa3.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 4:
                        btnCasa4.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 5:
                        btnCasa5.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 6:
                        btnCasa6.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 7:
                        btnCasa7.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 8:
                        btnCasa8.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;

                    case 9:
                        btnCasa9.Text = Xou0;
                        jogou = true;
                        jogada++;
                        break;
                }

                int i = Verifica();
                if (i == 1)
                {
                    MessageBox.Show("Voce perdeu!");
                    jogarNovamente();
                }

            }
        }

        //Verifica() analisa se há um vencedor, com o cenário atual
        private int Verifica()
        {
            //Casas 1, 2 e 3
            if (btnCasa1.Text.Equals(btnCasa2.Text) && 
                btnCasa1.Text.Equals(btnCasa3.Text) && 
                btnCasa1.Text != String.Empty)
            {
                return 1;
            }

            //Casas 1, 5 e 9
            if (btnCasa1.Text.Equals(btnCasa5.Text) &&
                btnCasa1.Text.Equals(btnCasa9.Text) &&
                btnCasa1.Text != String.Empty)
            {
                return 1;
            }

            //Casas 1, 4 e 7
            if (btnCasa1.Text.Equals(btnCasa4.Text) &&
                btnCasa1.Text.Equals(btnCasa7.Text) &&
                btnCasa1.Text != String.Empty)
            {
                return 1;
            }

            //Casas 2, 5 e 8
            if (btnCasa2.Text.Equals(btnCasa5.Text) &&
                btnCasa2.Text.Equals(btnCasa8.Text) &&
                btnCasa2.Text != String.Empty)
            {
                return 1;
            }

            //Casas 3, 6 e 9
            if (btnCasa3.Text.Equals(btnCasa6.Text) &&
                btnCasa3.Text.Equals(btnCasa9.Text) &&
                btnCasa3.Text != String.Empty)
            {
                return 1;
            }

            //Casas 3, 5 e 7
            if (btnCasa3.Text.Equals(btnCasa5.Text) &&
                btnCasa3.Text.Equals(btnCasa7.Text) &&
                btnCasa3.Text != String.Empty)
            {
                return 1;
            }

            //Casas 4, 5 e 6
            if (btnCasa4.Text.Equals(btnCasa5.Text) &&
                btnCasa4.Text.Equals(btnCasa6.Text) &&
                btnCasa4.Text != String.Empty)
            {
                return 1;                
            }

            //Casas 7, 8 e 9
            if (btnCasa7.Text.Equals(btnCasa8.Text) &&
                btnCasa8.Text.Equals(btnCasa9.Text) &&
                btnCasa7.Text != String.Empty)
            {
                return 1;
            }


            /*--------------------------------------------------------------------------*/


            //Verifica fim de jogo em empate
            if (btnCasa1.Text != String.Empty &&
               btnCasa2.Text != String.Empty &&
               btnCasa3.Text != String.Empty &&
               btnCasa4.Text != String.Empty &&
               btnCasa5.Text != String.Empty &&
               btnCasa6.Text != String.Empty &&
               btnCasa7.Text != String.Empty &&
               btnCasa8.Text != String.Empty &&
               btnCasa9.Text != String.Empty)
            {
                MessageBox.Show("Deu Velha!");
                jogarNovamente();
            }

            return 0;
        }

        //decideJogada() analisa todo o tabuleiro e decide qual a próxima jogada, 
        //priorizando o ataque
        private int decideJogada()
        {
            //"jog" representa a casa em que o computador irá jogar, iniciando 
            //com um número aleatório e pode ser alterado conforme a disposição das jogadas
            //anteriores
            int jog = numCasa.Next(0, 10);

            //"sinal" trabalha como observador e alerta quando uma jogada for definida, 
            //para que as demais não sejam processadas
            bool sinal = false;
                        
            while (sinal == false)
            {
                //JOGADAS DE ATAQUE
                //Casas 1, 2 e 3
                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa2.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa3.Text) &&
                    btnCasa2.Text == String.Empty)
                {
                    jog = 2;
                    sinal = true;
                    break;
                }

                if (btnCasa2.Text.Equals(Xou0) &&
                    btnCasa2.Text.Equals(btnCasa3.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 1, 5 e 9
                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa5.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa9.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text.Equals(Xou0) &&
                    btnCasa5.Text.Equals(btnCasa9.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 1, 4 e 7
                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa4.Text) &&
                    btnCasa7.Text == String.Empty)
                {

                    jog = 7;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text.Equals(Xou0) &&
                    btnCasa1.Text.Equals(btnCasa7.Text) &&
                    btnCasa4.Text == String.Empty)
                {
                    jog = 4;
                    sinal = true;
                    break;
                }

                if (btnCasa4.Text.Equals(Xou0) &&
                    btnCasa4.Text.Equals(btnCasa7.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 2, 5 e 8
                if (btnCasa2.Text.Equals(Xou0) &&
                    btnCasa2.Text.Equals(btnCasa5.Text) &&
                    btnCasa8.Text == String.Empty)
                {
                    jog = 8;
                    sinal = true;
                    break;
                }

                if (btnCasa2.Text.Equals(Xou0) &&
                    btnCasa2.Text.Equals(btnCasa8.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text.Equals(Xou0) &&
                    btnCasa5.Text.Equals(btnCasa8.Text) &&
                    btnCasa2.Text == String.Empty)
                {
                    jog = 2;
                    sinal = true;
                    break;
                }

                //Casas 3, 6 e 9
                if (btnCasa3.Text.Equals(Xou0) &&
                    btnCasa3.Text.Equals(btnCasa6.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa3.Text.Equals(Xou0) &&
                    btnCasa3.Text.Equals(btnCasa9.Text) &&
                    btnCasa6.Text == String.Empty)
                {
                    jog = 6;
                    sinal = true;
                    break;
                }

                if (btnCasa6.Text.Equals(Xou0) &&
                    btnCasa6.Text.Equals(btnCasa9.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                //Casas 3, 5 e 7
                if (btnCasa3.Text.Equals(Xou0) &&
                    btnCasa3.Text.Equals(btnCasa5.Text) &&
                    btnCasa7.Text == String.Empty)
                {
                    jog = 7;
                    sinal = true;
                    break;
                }

                if (btnCasa3.Text.Equals(Xou0) &&
                    btnCasa3.Text.Equals(btnCasa7.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text.Equals(Xou0) &&
                    btnCasa5.Text.Equals(btnCasa7.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                //Casas 4, 5 e 6
                if (btnCasa4.Text.Equals(Xou0) &&
                    btnCasa4.Text.Equals(btnCasa5.Text) &&
                    btnCasa6.Text == String.Empty)
                {
                    jog = 6;
                    sinal = true;
                    break;
                }

                if (btnCasa4.Text.Equals(Xou0) &&
                    btnCasa4.Text.Equals(btnCasa6.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text.Equals(Xou0) &&
                    btnCasa5.Text.Equals(btnCasa6.Text) &&
                    btnCasa4.Text == String.Empty)
                {
                    jog = 4;
                    sinal = true;
                    break;
                }

                //Casas 7, 8 e 9
                if (btnCasa7.Text.Equals(Xou0) &&
                    btnCasa7.Text.Equals(btnCasa8.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa7.Text.Equals(Xou0) &&
                    btnCasa7.Text.Equals(btnCasa9.Text) &&
                    btnCasa8.Text == String.Empty)
                {
                    jog = 8;
                    sinal = true;
                    break;
                }

                if (btnCasa8.Text.Equals(Xou0) &&
                    btnCasa8.Text.Equals(btnCasa9.Text) &&
                    btnCasa7.Text == String.Empty)
                {
                    jog = 7;
                    sinal = true;
                    break;
                }


                /*--------------------------------------------------------------------------*/


                //JOGADAS DE DEFESA
                //Casas 1, 2 e 3
                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != Xou0 &&
                    btnCasa1.Text.Equals(btnCasa2.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != (Xou0) &&
                    btnCasa1.Text.Equals(btnCasa3.Text) &&
                    btnCasa2.Text == String.Empty)
                {
                    jog = 2;
                    sinal = true;
                    break;
                }

                if (btnCasa2.Text != String.Empty &&
                    btnCasa2.Text != (Xou0) &&
                    btnCasa2.Text.Equals(btnCasa3.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 1, 5 e 9
                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != (Xou0) &&
                    btnCasa1.Text.Equals(btnCasa5.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != (Xou0) &&
                    btnCasa1.Text.Equals(btnCasa9.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text != String.Empty &&
                    btnCasa5.Text != (Xou0) &&
                    btnCasa5.Text.Equals(btnCasa9.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 1, 4 e 7
                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != (Xou0) &&
                    btnCasa1.Text.Equals(btnCasa4.Text) &&
                    btnCasa7.Text == String.Empty)
                {
                    jog = 7;
                    sinal = true;
                    break;
                }

                if (btnCasa1.Text != String.Empty &&
                    btnCasa1.Text != (Xou0) &&
                    btnCasa1.Text.Equals(btnCasa7.Text) &&
                    btnCasa4.Text == String.Empty)
                {
                    jog = 4;
                    sinal = true;
                    break;
                }

                if (btnCasa4.Text != String.Empty &&
                    btnCasa4.Text != (Xou0) &&
                    btnCasa4.Text.Equals(btnCasa7.Text) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    sinal = true;
                    break;
                }

                //Casas 2, 5 e 8
                if (btnCasa2.Text != String.Empty &&
                    btnCasa2.Text != (Xou0) &&
                    btnCasa2.Text.Equals(btnCasa5.Text) &&
                    btnCasa8.Text == String.Empty)
                {
                    jog = 8;
                    sinal = true;
                    break;
                }

                if (btnCasa2.Text != String.Empty &&
                    btnCasa2.Text != (Xou0) &&
                    btnCasa2.Text.Equals(btnCasa8.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text != String.Empty &&
                    btnCasa5.Text != (Xou0) &&
                    btnCasa5.Text.Equals(btnCasa8.Text) &&
                    btnCasa2.Text == String.Empty)
                {
                    jog = 2;
                    sinal = true;
                    break;
                }

                //Casas 3, 6 e 9
                if (btnCasa3.Text != String.Empty &&
                    btnCasa3.Text != (Xou0) &&
                    btnCasa3.Text.Equals(btnCasa6.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa3.Text != String.Empty &&
                    btnCasa3.Text != Xou0 &&
                    btnCasa3.Text.Equals(btnCasa9.Text) &&
                    btnCasa6.Text == String.Empty)
                {
                    jog = 6;
                    sinal = true;
                    break;
                }

                if (btnCasa6.Text != String.Empty &&
                    btnCasa6.Text != (Xou0) &&
                    btnCasa6.Text.Equals(btnCasa9.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                //Casas 3, 5 e 7
                if (btnCasa3.Text != String.Empty &&
                    btnCasa3.Text != (Xou0) &&
                    btnCasa3.Text.Equals(btnCasa5.Text) &&
                    btnCasa7.Text == String.Empty)
                {
                    jog = 7;
                    sinal = true;
                    break;
                }

                if (btnCasa3.Text != String.Empty &&
                    btnCasa3.Text != Xou0 &&
                    btnCasa3.Text.Equals(btnCasa7.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text != String.Empty &&
                    btnCasa5.Text != (Xou0) &&
                    btnCasa5.Text.Equals(btnCasa7.Text) &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    sinal = true;
                    break;
                }

                //Casas 4, 5 e 6
                if (btnCasa4.Text != String.Empty &&
                    btnCasa4.Text != (Xou0) &&
                    btnCasa4.Text.Equals(btnCasa5.Text) &&
                    btnCasa6.Text == String.Empty)
                {
                    jog = 6;
                    sinal = true;
                    break;
                }

                if (btnCasa4.Text != String.Empty &&
                    btnCasa4.Text != (Xou0) &&
                    btnCasa4.Text.Equals(btnCasa6.Text) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    sinal = true;
                    break;
                }

                if (btnCasa5.Text != String.Empty &&
                    btnCasa5.Text != (Xou0) &&
                    btnCasa5.Text.Equals(btnCasa6.Text) &&
                    btnCasa4.Text == String.Empty)
                {
                    jog = 4;
                    sinal = true;
                    break;
                }

                //Casas 7, 8 e 9
                if (btnCasa7.Text != String.Empty &&
                    btnCasa7.Text != (Xou0) &&
                    btnCasa7.Text.Equals(btnCasa8.Text) &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    sinal = true;
                    break;
                }

                if (btnCasa7.Text != String.Empty &&
                    btnCasa7.Text != (Xou0) &&
                    btnCasa7.Text.Equals(btnCasa9.Text) &&
                    btnCasa8.Text == String.Empty)
                {
                    jog = 8;
                    sinal = true;
                    break;
                }

                if (btnCasa8.Text != String.Empty &&
                    btnCasa8.Text != (Xou0) &&
                    btnCasa8.Text.Equals(btnCasa9.Text) &&
                    btnCasa7.Text == String.Empty)
                {
                    jog = 7;
                    sinal = true;
                    break;
                }
                             
                
                //CASO NENHUMA FINALIZAÇÃO OU DEFESA SEJA VÁLIDA, SÃO AS
                //PRIMEIRAS JOGADAS
                //APLICA-SE APENAS AO NIVEL "VELHO"
                if(nvl == 3 && sinal == false && jogada <= 6)
                {
                    Console.WriteLine("Passou");
                    jog = primeirasJogadas();
                    break;
                }

                sinal = true;
            }

            Console.WriteLine("jog = " + jog);

            /*--------------------------------------------------------------------------*/
            //Retorna a casa escolhida para a próxima jogada
            switch (jog)
            {
                case 1:
                    if(btnCasa1.Text == String.Empty)
                    {
                        return 1;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 2:
                    if (btnCasa2.Text == String.Empty)
                    {
                        return 2;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 3:
                    if (btnCasa3.Text == String.Empty)
                    {
                        return 3;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 4:
                    if (btnCasa4.Text == String.Empty)
                    {
                        return 4;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 5:
                    if (btnCasa5.Text == String.Empty)
                    {
                        return 5;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 6:
                    if (btnCasa6.Text == String.Empty)
                    {
                        return 6;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 7:
                    if (btnCasa7.Text == String.Empty)
                    {
                        return 7;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 8:
                    if (btnCasa8.Text == String.Empty)
                    {
                        return 8;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;

                case 9:
                    if (btnCasa9.Text == String.Empty)
                    {
                        return 9;
                    }
                    else
                    {
                        decideJogada();
                    }

                    break;
            }

            return 0;
        }

        private void jogarNovamente()
        {
            if (MessageBox.Show("Jogar novamente?", "Deseja...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 jogo = new Form2();
                jogo.ShowDialog();
            }
            else
            {
                Application.Exit();
                //this.Close();
            }
        }


        private int primeirasJogadas()
        {
             


            //bool sinal = false;
            int jog = 0;

            //PC Começa senão Player Começa
            if(qj %2 == 0)
            {

                //PC inicia o jogo
                //Terceira jogada - quinta rodada do jogo
                if (jogada == 5 &&                    
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    return jog;
                }
                else
                {
                    if (jogada == 5 &&
                        btnCasa7.Text == String.Empty)
                    {
                        jog = 7;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 5 &&
                            btnCasa5.Text == String.Empty)
                        {
                            jog = 5;
                            return jog;
                        }
                    }
                }

                
                //PC inicia o jogo
                //Primeira jogada
                if (jogada == 1 &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    return jog;
                }



                //PC inicia o jogo
                //Segunda jogada - terceira rodada do jogo
                //PC com casa 1
                if (jogada == 3 &&
                    btnCasa1.Text.Equals(Xou0) &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    return jog;
                }
                else
                {
                    if (jogada == 3 &&
                        btnCasa1.Text.Equals(Xou0) &&
                        btnCasa9.Text == String.Empty)
                    {
                        jog = 9;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 3 &&
                            btnCasa1.Text.Equals(Xou0) &&
                            btnCasa7.Text == String.Empty)
                        {
                            jog = 7;
                            return jog;
                        }
                    }
                }



                //PC inicia o jogo
                //Segunda jogada
                //PC com casa 5
                if (jogada == 3 &&
                    btnCasa5.Text.Equals(Xou0) &&
                    btnCasa1.Text == String.Empty)
                {
                    jog = 1;
                    return jog;
                }
                else
                {
                    if (jogada == 3 &&
                        btnCasa5.Text.Equals(Xou0) &&
                        btnCasa9.Text == String.Empty)
                    {
                        jog = 9;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 3 &&
                            btnCasa5.Text.Equals(Xou0) &&
                            btnCasa7.Text == String.Empty)
                        {
                            jog = 7;
                            return jog;
                        }
                    }
                }
            }
            else {

                //Player inicia o jogo
                //Segunda jogada - quarta rodada do jogo
                if (jogada == 4 &&
                    btnCasa7.Text != String.Empty &&
                    btnCasa2.Text != String.Empty &&
                    btnCasa2.Text != Xou0 &&
                    btnCasa7.Text != Xou0)
                {
                    jog = 1;
                    return jog;
                }

                //Player inicia o jogo
                //Segunda jogada - quarta rodada do jogo
                if (jogada == 4 &&
                    btnCasa9.Text != String.Empty &&
                    btnCasa2.Text != String.Empty &&
                    btnCasa2.Text != Xou0 &&
                    btnCasa3.Text != Xou0)
                {
                    jog = 3;
                    return jog;
                }

                //Player inicia o jogo
                //Segunda jogada - quarta rodada do jogo
                if (jogada == 4 &&
                    btnCasa4.Text != String.Empty &&
                    btnCasa3.Text != String.Empty &&
                    btnCasa4.Text != Xou0 &&
                    btnCasa3.Text != Xou0)
                {
                    jog = 1;
                    return jog;
                }

                //Player inicia o jogo
                //Terceira jogada - sexta rodada do jogo
                if (jogada == 6 &&
                    btnCasa3.Text == String.Empty)
                {
                    jog = 3;
                    return jog;
                }
                else
                {
                    if (jogada == 6 &&
                        btnCasa7.Text == String.Empty)
                    {
                        jog = 7;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 6 &&
                            btnCasa5.Text == String.Empty)
                        {
                            jog = 5;
                            return jog;
                        }
                    }
                }

                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa6.Text != String.Empty &&
                    btnCasa8.Text != String.Empty &&
                    btnCasa6.Text != Xou0 &&
                    btnCasa8.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 9;
                    return 9;
                }

                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa4.Text != String.Empty &&
                    btnCasa8.Text != String.Empty &&
                    btnCasa4.Text != Xou0 &&
                    btnCasa8.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 7;
                    return 7;
                }

                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa2.Text != String.Empty &&
                    btnCasa6.Text != String.Empty &&
                    btnCasa2.Text != Xou0 &&
                    btnCasa6.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 3;
                    return 3;
                }

                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa2.Text != String.Empty &&
                    btnCasa4.Text != String.Empty &&
                    btnCasa2.Text != Xou0 &&
                    btnCasa4.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 1;
                    return 1;
                }

                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa1.Text != String.Empty &&
                    btnCasa9.Text != String.Empty &&
                    btnCasa1.Text != Xou0 &&
                    btnCasa9.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 4;
                    return jog;
                }


                //Player inicia o jogo
                //Terceira jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa3.Text != String.Empty &&
                    btnCasa7.Text != String.Empty &&
                    btnCasa3.Text != Xou0 &&
                    btnCasa7.Text != Xou0 &&
                    btnCasa5.Text.Equals(Xou0))
                {
                    jog = 4;
                    return jog;
                }


                //Player inicia o jogo
                //Segunda jogada do PC - quarta rodada do jogo
                //PC com casa 1
                if (jogada == 4 &&
                    btnCasa1.Text == Xou0 &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    return jog;
                }
                else
                {
                    if (jogada == 4 &&
                        btnCasa1.Text == Xou0 &&
                        btnCasa5.Text == String.Empty)
                    {
                        jog = 5;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 4 &&
                            btnCasa1.Text == Xou0 &&
                            btnCasa7.Text == String.Empty)
                        {
                            jog = 7;
                            return jog;
                        }
                    }
                }



                //Player inicia o jogo
                //Primeira jogada do PC - Segunda rodada do jogo
                if (jogada == 2 &&
                    btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    return jog;
                }
                else
                {
                    if (jogada == 2 &&
                        btnCasa1.Text == String.Empty)
                    {
                        jog = 1;
                        return jog;
                    }
                }
                               

                
                //Player inicia o jogo
                //Segunda jogada do PC - quarta rodada do jogo
                //PC com casa 5
                if (jogada == 4 &&
                    btnCasa5.Text == Xou0 &&
                    btnCasa9.Text == String.Empty)
                {
                    jog = 9;
                    return jog;
                }
                else
                {
                    if (jogada == 4 &&
                        btnCasa5.Text == Xou0 &&
                        btnCasa7.Text == String.Empty)
                    {
                        jog = 7;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 4 &&
                            btnCasa5.Text == Xou0 &&
                            btnCasa3.Text == String.Empty)
                        {
                            jog = 3;
                            return jog;
                        }
                    }
                }



                //Player inicia o jogo
                //Terceira jogada
                if (jogada == 6 &&
                   btnCasa5.Text == String.Empty)
                {
                    jog = 5;
                    return jog;
                }
                else
                {
                    if (jogada == 6 &&
                        btnCasa9.Text == String.Empty)
                    {
                        jog = 9;
                        return jog;
                    }
                    else
                    {
                        if (jogada == 6 &&
                           btnCasa7.Text == String.Empty)
                        {
                            jog = 7;
                            return jog;
                        }
                    }
                }
            }
            
  //---------------------------------------------------------------------------------


                if (jogada == 4 &&
                    btnCasa3.Text != String.Empty &&
                    btnCasa4.Text != String.Empty &&
                    btnCasa3.Text != Xou0 &&
                    btnCasa4.Text != Xou0 &&
                    btnCasa5.Text == Xou0)
                {
                    jog = 2;
                return jog;
                }


            if (jogada == 5 &&
                btnCasa3.Text != String.Empty &&
                btnCasa8.Text != String.Empty &&
                btnCasa3.Text != Xou0 &&
                btnCasa8.Text != Xou0 &&
                btnCasa5.Text == Xou0)
            {
                jog = 6;
                return jog;
            }

            return 0;        
        }
    }
}
