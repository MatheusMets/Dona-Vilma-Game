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
            set { myCurrentArrayNumbers = value; }
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

        public int RetornaNumeroParaImpedirVitoriaDoAdversario(Player PlayerAdversario, VictoryConditionEnum VCE)    //Retorna o int que ele deve marcar para evitar a vitoria do adversário (PEGA SEMPRE O PRIMEIRO CASO)
        {
            int ConfirmaChanceVitoria = 0;
            int[] VetorAuxiliar = new int[6];

            if (PlayerAdversario.MyCurrentArrayNumbers.Count() < 2)
            {
                return 0;
            }
            else
            {
                foreach (int[] VetorCondicaoDeVitoriaAtual in VCE.ConditionList)                   //Em cada vetor condição de vitória
                {
                    VetorAuxiliar = VetorCondicaoDeVitoriaAtual;
                    ConfirmaChanceVitoria = 0;

                    foreach (int NumeroDoVetorDeVitoria in VetorCondicaoDeVitoriaAtual)
                    {

                        foreach (int NumeroDoVetorDoPlayerAdversario in PlayerAdversario.MyCurrentArrayNumbers)
                        {
                            if (NumeroDoVetorDoPlayerAdversario == NumeroDoVetorDeVitoria)
                            {
                                VetorAuxiliar = VetorAuxiliar.Where(val => val != NumeroDoVetorDeVitoria).ToArray();
                                ConfirmaChanceVitoria++;
                            }
                        }

                        if (ConfirmaChanceVitoria == 2)
                            return VetorAuxiliar[0];

                    }
                }
            }

            return 0;
        }

        public int RetornaNumeroParaVencer(VictoryConditionEnum VCE)
        {
            int ConfirmaVitoria;
            int[] VetorAuxiliar = new int[6];

            if (MyCurrentArrayNumbers.Count() < 2)
            {
                return 0;
            }
            else
            {
                foreach (int[] VetorCondicaoDeVitoriaAtual in VCE.ConditionList)                   //Em cada vetor condição de vitória
                {
                    VetorAuxiliar = VetorCondicaoDeVitoriaAtual;
                    ConfirmaVitoria = 0;

                    foreach (int NumeroDoVetorDeVitoria in VetorCondicaoDeVitoriaAtual)
                    {

                        foreach (int NumeroAtualDoVetorDoPlayer in MyCurrentArrayNumbers)
                        {
                            if (NumeroAtualDoVetorDoPlayer == NumeroDoVetorDeVitoria)
                            {
                                VetorAuxiliar = VetorAuxiliar.Where(val => val != NumeroDoVetorDeVitoria).ToArray();
                                ConfirmaVitoria++;
                            }
                        }

                        if (ConfirmaVitoria == 2)
                            return VetorAuxiliar[0];

                    }
                }
            }

            return 0;
        }

    }
}
