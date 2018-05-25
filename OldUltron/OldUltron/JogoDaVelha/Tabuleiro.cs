using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace OldUltron.JogoDaVelha
{
    public class Tabuleiro
    {
        private String[,] mapa = new String[3, 3]; // cria uma mtariz de string 3 por 3
        private Jogador jogador; // instancia jogador que esta jogando atulmente (MIN-->Player MAX-->IA)
        private int valor = 0;// valor é a variavel que define se vc ganhou(1), empatou(0) ou perdeu(-1)

        private Tabuleiro pai;
        private List<Tabuleiro> filhos = new List<Tabuleiro>();

        //essa função passa por todos os tabuleiros filhos e acha os filhos que
        //tiveram os maiores valores que no caso seria 1(filhos ganhadores)
        public Tabuleiro getMelhorFilho()
        {
            Tabuleiro aux = new Tabuleiro();
            int melhor = int.MinValue; // define o maior numero possivel no intenger para achar o menor valor
            int i = 1;
            foreach (Tabuleiro filho in filhos)
            {
                if (filho.getValor() > melhor)
                {
                    aux = filho;
                    melhor = filho.getValor();
                }
            }
            return aux;
        }

        //get valor é usado para trazer o resultado final do jogo (ganhou perdeu empatou)
        public int getValor()
        {
            return valor;
        }

        //seta se perdeu ou ganhou ou empatou
        public void setValor(int valor)
        {
            this.valor = valor;
        }

        //pega o tabuleiro atual do jogo
        public Tabuleiro getPai()
        {
            return pai;
        }

        //seta qual o tabuleiro atual do jogo
        public void setPai(Tabuleiro pai)
        {
            this.pai = pai;
        }

        //pega qual o jogador atiual MIN->player MAX->IA
        public Jogador getJogador()
        {
            return jogador;
        }

        //seta qual o jogador atiual MIN->player MAX->IA
        public void setJogador(Jogador jogador)
        {
            this.jogador = jogador;
        }

        // pega um valor do tabuleiro baseado na linha e na coluna
        public String getXY(int linha, int coluna)
        {
            return mapa[linha, coluna];
        }

        // pega tabuleiro
        public String[,] getMapa()
        {
            return mapa;
        }

        // define onde sera marcado o X no tabuleiro
        public void setX(int linha, int coluna)
        {
            mapa[linha, coluna] = "X";
        }
        // define onde sera marcado o O no tabuleiro
        public void setO(int linha, int coluna)
        {
            mapa[linha, coluna] = "O";
        }

        #region verifica possibilidade de vitoria para IA
        private Boolean verificarHorizontal(int linha)
        {
            return ("O".Equals(mapa[linha, 0]) && "O".Equals(mapa[linha, 1]) && "O".Equals(mapa[linha, 2]));
        }
        private Boolean verificarVertical(int coluna)
        {
            return ("O".Equals(mapa[0, coluna]) && "O".Equals(mapa[1, coluna]) && "O".Equals(mapa[2, coluna]));
        }
        private Boolean verificarDiagonalPrincipal()
        {
            return ("O".Equals(mapa[0, 0]) && "O".Equals(mapa[1, 1]) && "O".Equals(mapa[2, 2]));
        }
        private Boolean verificarDiagonalSecundaria()
        {
            return ("O".Equals(mapa[0, 2]) && "O".Equals(mapa[1, 1]) && "O".Equals(mapa[2, 0]));
        }
        #endregion


        #region verifica possibilidade de derrota para IA
        //verifica possibilidade de derrota para IA
        private Boolean verificarPerdeuHorizontal(int linha)
        {
            return ("X".Equals(mapa[linha, 0]) && "X".Equals(mapa[linha, 1]) && "X".Equals(mapa[linha, 2]));
        }
        //verifica possibilidade de derrota para IA
        private Boolean verificarPerdeuVertical(int coluna)
        {
            return ("X".Equals(mapa[0, coluna]) && "X".Equals(mapa[1, coluna]) && "X".Equals(mapa[2, coluna]));
        }
        //verifica possibilidade de derrota para IA
        private Boolean verificarPerdeuDiagonalPrincipal()
        {
            return ("X".Equals(mapa[0, 0]) && "X".Equals(mapa[1, 1]) && "X".Equals(mapa[2, 2]));
        }
        //verifica possibilidade de derrota para IA
        private Boolean verificarPerdeuDiagonalSecundaria()
        {
            return ("X".Equals(mapa[0, 2]) && "X".Equals(mapa[1, 1]) && "X".Equals(mapa[2, 0]));
        }
        #endregion

        #region verifica todas as possibilidades

        //verifica todas as possibilidades de vitoria
        //caso alguma volte true IA ganhou
        public Boolean ganhou()
        {
            //return false;
            return (verificarHorizontal(0)
                    || verificarHorizontal(1)
                    || verificarHorizontal(2)
                    || verificarVertical(0)
                    || verificarVertical(1)
                    || verificarVertical(2)
                    || verificarDiagonalPrincipal()
                    || verificarDiagonalSecundaria());
        }
        //verifica todas as possibilidades de derrota 
        //caso alguma volte true IA perdeu
        public Boolean perdeu()
        {
            return (verificarPerdeuHorizontal(0)
                    || verificarPerdeuHorizontal(1)
                    || verificarPerdeuHorizontal(2)
                    || verificarPerdeuVertical(0)
                    || verificarPerdeuVertical(1)
                    || verificarPerdeuVertical(2)
                    || verificarPerdeuDiagonalPrincipal()
                    || verificarPerdeuDiagonalSecundaria());
        }
        /*verifica se empatou
        *passa por todo tabuleiro e verifica se tem algum espaço null no tabuleiro
        *caso tenha empatou é false
        *caso não tenha nenhum null no tabuleiro e a IA não tenha ganhado empatou é true
        */
        public Boolean empate()
        {
            Boolean empate = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mapa[i, j] == null)
                    {
                        empate = false;
                        break;
                    }
                }
            }
            return empate && !ganhou();
        }
        #endregion

        //verifica se tabuleiro é final, se alguem ganhou, perdeu ou empatou
        //função é chamada todas as vezes depois de uma jogada
        public Boolean isFinal()
        {
            return ganhou() || empate() || perdeu();
        }

        // vai pegar o resultado da partida (ganhou, perdeu, empatou) dos tabuleiros
        public int getResultado()
        {
            if (ganhou())
            {
                this.valor = 1;
                return 1;
            }
            else {
                if (perdeu())
                {
                    this.valor = -1;
                    return -1;
                }
                else {
                    return 0;
                }
            }
        }

        // pega todos os filhos do tabuleiro pai, (todas as possibilidades de jogada)
        public List<Tabuleiro> getTodosFilhos()
        {
            return filhos;
        }

        //Nessa função ele gera filhos para o tabuleiro que foi passado
        //resumindo ele gera as proximas jogadas possiveis(gera as possibilidades)
        public List<Tabuleiro> getFilhos(Tabuleiro tab)
        {
            filhos = new List<Tabuleiro>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        Tabuleiro filho = tab.copiar();//faz clone do pai e embriona o filho
                        filho.setPai(tab);// seta o pai desse filho
                                          // verifica se a posição atual esta marcada
                        if (filho.getXY(i, j) == null)
                        {
                            //se posição marcada verifica qual jogador marcou
                            //se jogador igual a MAX vez IA
                            if (jogador.Equals(Jogador.Max))
                            {
                                filho.setO(i, j);
                            }
                            else {//se não vez do player
                                filho.setX(i, j);
                            }
                            //filho.mostra();
                            //System.out.println("-----------------");
                            filho.getResultado();
                            filhos.Add(filho);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            //retorna todos os filhos daquele pai
            return filhos;
        }

        //clona todo o tabuleiro
        protected Tabuleiro copiar()
        {
            Tabuleiro aux = new Tabuleiro();
            //anda nas linhas
            for (int i = 0; i< 3; i++) {
                //copia uma linha por vez
                for (int j = 0; j < 3; j++)
                {
                    aux.getMapa()[i,j] = mapa[i, j];
                }
                    //System.arraycopy(obj, pos_incial_obj, clone_obj, pos_inicial_clone_obj, numero_arrays_copiado);
                    //System.arraycopy(mapa[i], 0, aux.getMapa()[i], 0, 3);
            }
            return aux;
         }
    }
}
