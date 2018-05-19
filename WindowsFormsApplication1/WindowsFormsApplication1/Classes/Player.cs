using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGeneral
{
    public class Player
    {

        private int[] myCurrentArrayNumbers;


        public bool Won(int[] VetorAtualDoPlayer, VictoryConditionEnum VCE)
        {
            int ConfirmaVitoria = 0;

            if (VetorAtualDoPlayer.Count() < 3)     //Não é possível vencer sem fazer ao mínimo 3 marcações
            {
                return false;
            }
            else
            {
                foreach (int[] VetorCondicaoDeVitoriaAtual in VCE.ConditionList)                   //Em cada vetor condição de vitória
                {

                    foreach (int NumeroDoVetorDeVitoria in VetorCondicaoDeVitoriaAtual)            //Em cada numero do vetor de condicao de vitoria       
                    {

                        ConfirmaVitoria = 0;

                        foreach (int NumeroDoVetorDoPlayer in VetorAtualDoPlayer)                  //Em cada número no meu vetor atual
                        {
                            if (NumeroDoVetorDoPlayer == NumeroDoVetorDeVitoria)
                            {
                                ConfirmaVitoria++;
                            } 
                        }

                        if(ConfirmaVitoria == 3)
                            return true;
                    }
                }
            }

            return false;
        }

    }
}
