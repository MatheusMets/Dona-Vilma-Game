using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGeneral
{
    public class Player
    {

        private int[] myCurrentNumber;

        public bool Won(int[] VetorAtualDoPlayer, VictoryConditionEnum VCE)
        {
            bool ConfirmaVitoria = true;

            if (VetorAtualDoPlayer.Count() == 0)
            {
                return false;
            }
            else
            {
                foreach (int[] VetorCondicaoDeVitoriaAtual in VCE.ConditionList)                   //Em cada vetor condição de vitória
                {

                    foreach (int NumeroDoVetorDeVitoria in VetorCondicaoDeVitoriaAtual)            //Em cada numero do vetor de condicao de vitoria       
                    {
                        foreach (int NumeroDoVetorDoPlayer in VetorAtualDoPlayer)                  //Em cada número no meu vetor atual
                        {
                            if (NumeroDoVetorDoPlayer == )
                            {

                            } else

                            if (NumeroDoVetorDoPlayer != VetorCondicaoDeVitoriaAtual[0] || 
                                NumeroDoVetorDoPlayer != VetorCondicaoDeVitoriaAtual[1] || 
                                NumeroDoVetorDoPlayer != VetorCondicaoDeVitoriaAtual[2])     //Se não tiver nenhum número que casa...
                                break;                                                       //Para de verificar nesse vetor
                            else
                            {

                            }
                        }
                        return true;
                    }
                        
                }
            }

            return false;
        }

    }
}
