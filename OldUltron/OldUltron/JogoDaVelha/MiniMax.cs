using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldUltron.JogoDaVelha
{
    public class MiniMax
    {
        #region implementação minimax

        // essa função vai descobrir as jogadas possiveis
        // usando maximização vc vai ter as possibilidades de derrota da IA
        private int MinValue(Tabuleiro tabuleiro)
        {
            if (tabuleiro.isFinal())
            {
                tabuleiro.setValor(tabuleiro.getResultado());
                return tabuleiro.getValor();
            }
            else {
                tabuleiro.setValor(int.MaxValue);
                tabuleiro.setJogador(Jogador.Min);//filho vai começar jogada com player
                List<Tabuleiro> filhos = tabuleiro.getFilhos(tabuleiro);
                foreach (Tabuleiro filho in filhos)
                {
                    //Math.min-->compara quais dos dois valores é menor e retorna o menor deles
                    //seta o menor valor entre o o valor do tabuleiro filho atual e o valor de maximização do tabuleiro filho atual
                    tabuleiro.setValor(Math.Min(tabuleiro.getValor(), MaxValue(filho)));
                }
                return tabuleiro.getValor();
            }
        }

        // essa função vai descobrir as jogadas possiveis
        // usando maximização vc vai ter as possibilidades de vitoria da IA
        // obs: se tab é terminal, jogo já acabou
        private int MaxValue(Tabuleiro tabuleiro)
        {
            if (tabuleiro.isFinal())
            {//se já tem um resultado, solta valor
                tabuleiro.setValor(tabuleiro.getResultado());
                return tabuleiro.getValor();
            }
            else {
                tabuleiro.setValor(int.MinValue);
                tabuleiro.setJogador(Jogador.Max);//filho vai começar jogada com IA
                List<Tabuleiro> filhos = tabuleiro.getFilhos(tabuleiro);
                foreach (Tabuleiro filho in filhos)
                {
                    //Math.max-->compara quais dos dois valores é maior e retorna o maior deles
                    //seta o maior valor entre o o valor do tabuleiro filho atual e o valor de minimização do tabuleiro filho atual
                    tabuleiro.setValor(Math.Max(tabuleiro.getValor(), MinValue(filho)));
                }
                return tabuleiro.getValor();
            }
        }

        //Escolhe a melhor opção de jogada após calcular todas as jogadas possiveis.
        public Tabuleiro minimaxDecision(Tabuleiro tabuleiro)
        {
            //pega a maximização do tabuleiro (melhor cenario).
            int melhor = MaxValue(tabuleiro);
            List<Tabuleiro> filhos = tabuleiro.getTodosFilhos();
            foreach (Tabuleiro filho in filhos)
            {
                //Proucura o filho que gerou a maximização do tabuleiro
                if (filho.getValor() == melhor)
                {
                    return filho;
                }
            }
            return null;
        }
        #endregion  
    }
}
