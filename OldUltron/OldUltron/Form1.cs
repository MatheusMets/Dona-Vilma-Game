using OldUltron.JogoDaVelha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldUltron
{
    public partial class Form1 : Form
    {
        private int ganhou = 0, perdeu = 0, empate = 0;
        private Tabuleiro tabuleiro = new Tabuleiro();
        private MiniMax minimax = new MiniMax();

        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            //instancia tabuleiro
            tabuleiro = new Tabuleiro();
            //seta os valores contidos nas linhas e colunas do tabuleiro
            //nos botoes
            setTabuleiro(tabuleiro);
            //seta quem vai começar o jogo
            //obs: no caso o jogador player sempre começa
            tabuleiro.setJogador(Jogador.Min); // Minha vez de Jogar
                                               // tabela de pontos com jogos ganhados, perdidos e empatados
            placar.Text = "Ganhou: " + ganhou + " Perdeu: " + perdeu + " Empatou: " + empate;
            MessageBox.Show("Eu sou Old Ultron, e esse jogo decidira o destino do mundo! HAHAHAHAHAHA");    
        }

        //função que passa as jogadas X e O para os botoes
        public void setTabuleiro(Tabuleiro tab)
        {
            A1.Text = tab.getXY(0, 0);
            A2.Text = tab.getXY(0, 1);
            A3.Text = tab.getXY(0, 2);

            B1.Text = tab.getXY(1, 0);
            B2.Text = tab.getXY(1, 1);
            B3.Text = tab.getXY(1, 2);

            C1.Text = tab.getXY(2, 0);
            C2.Text = tab.getXY(2, 1);
            C3.Text = tab.getXY(2, 2);
        }

        public void marcaX(Button Celula, int auxLinha, int auxColuna)
        {
            if (tabuleiro.getJogador().Equals(Jogador.Min))
            {// verifica se o tabuleiro é player

                //Eu Joguei
                //Button celula = (Button)me.getSource();
                //System.out.println(celula);
                if (string.IsNullOrEmpty(Celula.Text))
                {//verifica se ele pode fazer essa jogada
                    Celula.Text = "X";//joga X no Button escolhido
                    //repassa a jogada executada no design para o tabuleiro map
                    tabuleiro.setX(auxLinha,auxColuna);
                    //Calculo o Minimax
                    tabuleiro.setJogador(Jogador.Max);//jogada da IA
                    tabuleiro = minimax.minimaxDecision(tabuleiro);//Tomar melhor decisão
                                                           //Computador Joga
                    setTabuleiro(tabuleiro);//Passa as letras para o tabueliro
                    tabuleiro.setJogador(Jogador.Min);
                    if (tabuleiro.isFinal())
                    {
                        MessageBox.Show("Você ganhou? " + tabuleiro.perdeu() + "\nVocê perdeu? " + tabuleiro.ganhou() + "\nDeu empate? " + tabuleiro.empate());
                        if (tabuleiro.ganhou())
                            perdeu++;
                        if (tabuleiro.perdeu())
                            ganhou++;
                        if (tabuleiro.empate())
                            empate++;
                        this.init();
                    }
                }
                else {
                    if (Celula.Text.Equals("X"))
                    {
                        MessageBox.Show("Mortal, Você já jogou ai, preste atenção!");
                    }
                    else {
                        MessageBox.Show("Inseto, eu Ultron já joguei ai, preste mais atenção atenção!");
                    }
                }
            }
            else {
                MessageBox.Show("Nao é sua vez ainda espere!");
            }
        }

        private void A1_Click_1(object sender, EventArgs e)
        {
            marcaX(A1, 0, 0);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            marcaX(A2, 0, 1);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            marcaX(A3, 0, 2);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            marcaX(B1, 1, 0);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            marcaX(B2, 1, 1);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            marcaX(B3, 1, 2);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            marcaX(C1, 2, 0);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            marcaX(C2, 2, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            init();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            marcaX(C3, 2, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
