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
        private int IndiceDaMinhaJunisse;

        public int[] MyCurrentArrayNumbers {
            get { return  myCurrentArrayNumbers; }
        }

        public void AdicionaNoVetor(int i)
        {
            myCurrentArrayNumbers[IndiceDaMinhaJunisse] = i;
            IndiceDaMinhaJunisse++;
        }


        public Player()
        {
            myCurrentArrayNumbers = new int[8];
            IndiceDaMinhaJunisse = 0;
        }

        public bool Won(VictoryConditionEnum VCE)
        {
            int ConfirmaVitoria = 0;

            if (MyCurrentArrayNumbers.Count() < 3)     //Não é possível vencer sem fazer ao mínimo 3 marcações
            {
                return false;
            }
            else
            {
                foreach (int[] VetorCondicaoDeVitoriaAtual in VCE.ConditionList)                   //Em cada vetor condição de vitória
                {

                    ConfirmaVitoria = 0;

                    foreach (int NumeroDoVetorDeVitoria in VetorCondicaoDeVitoriaAtual)            //Em cada numero do vetor de condicao de vitoria       
                    {

                        foreach (int NumeroDoVetorDoPlayer in MyCurrentArrayNumbers)                  //Em cada número no meu vetor atual
                        {
                            if (NumeroDoVetorDoPlayer == NumeroDoVetorDeVitoria)
                            {
                                ConfirmaVitoria++;
                            }
                        }

                        if (ConfirmaVitoria == 3)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
