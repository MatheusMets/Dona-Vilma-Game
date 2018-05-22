using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGeneral
{
    public partial class Form1 : Form
    {
        Player IA = new Player();
        Player player = new Player();
        VictoryConditionEnum VCE;
        Random rand;
        List<Button> screenButtons;
        Button BotaoQueSeraClicado = null;
        bool isIATurn = false;

        public readonly int[] Teste1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        public Form1()
        { 

            VCE = new VictoryConditionEnum();

            InitializeComponent();

            screenButtons = new List<Button>() {
                btnA1,
                btnA2,
                btnA3,
                btnB1,
                btnB2,
                btnB3,
                btnC1,
                btnC2,
                btnC3
            };

            richLog.AppendText("START!");
            richLog.AppendText("\nO jogo já se iniciou. É a sua vez!");
            richLog.AppendText("\nEsperando o usuário jogar...");

 
            //ExecutaTicTacToe();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            richLog.Clear();
            richLog.AppendText("START!");
            richLog.AppendText("\nVocê é o X. A IA é a O!");
            richLog.AppendText("\nO jogo já se iniciou. É a sua vez!");
            richLog.AppendText("\nEsperando o usuário jogar...");

            /*      ISSO FOI SÓ PRA TESTAR SE O MÉTODO VERIFICADOR DE VITÓRIA TÁ CERTO
            IA.MyCurrentArrayNumbers = Teste1;
            bool v = IA.Won(VCE);

            if (v)
                MessageBox.Show("Venceu!");
            else
                MessageBox.Show("Not yet!"); */

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnA1.Text = "O";
                IA.AdicionaNoVetor(1);
            }
            else
            {
                btnA1.Text = "X";
                player.AdicionaNoVetor(1);
                screenButtons.Remove(btnA1);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnA2.Text = "O";
                IA.AdicionaNoVetor(2);
            }
            else
            {
                btnA2.Text = "X";
                player.AdicionaNoVetor(2);
                screenButtons.Remove(btnA2);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnA3.Text = "O";
                IA.AdicionaNoVetor(3);
            }
            else
            {
                btnA3.Text = "X";
                screenButtons.Remove(btnA3);
                player.AdicionaNoVetor(3);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnB1.Text = "O";
                IA.AdicionaNoVetor(4);
            }
            else
            {
                btnB1.Text = "X";
                player.AdicionaNoVetor(4);
                screenButtons.Remove(btnB1);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnB2.Text = "O";
                IA.AdicionaNoVetor(5);
            }
            else
            {
                btnB2.Text = "X";
                player.AdicionaNoVetor(5);
                screenButtons.Remove(btnB2);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnB3.Text = "O";
                IA.AdicionaNoVetor(6);
            }
            else
            {
                btnB3.Text = "X";
                player.AdicionaNoVetor(6);
                screenButtons.Remove(btnB3);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnC1.Text = "O";
                IA.AdicionaNoVetor(7);
            }
            else
            {
                btnC1.Text = "X";
                player.AdicionaNoVetor(7);
                screenButtons.Remove(btnC1);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnC2.Text = "O";
                IA.AdicionaNoVetor(8);
            }
            else
            {
                btnC2.Text = "X";
                player.AdicionaNoVetor(8);
                screenButtons.Remove(btnC2);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (isIATurn)
            {
                btnC3.Text = "O";
                IA.AdicionaNoVetor(9);
            }
            else
            {
                btnC3.Text = "X";
                player.AdicionaNoVetor(9);
                screenButtons.Remove(btnC3);
            }

            isIATurn = !isIATurn;

            BotaoQueSeraClicado = ExecutaTicTacToe();

            if (BotaoQueSeraClicado != null)
                BotaoQueSeraClicado.PerformClick();
        }

        private Button ExecutaTicTacToe()
        {

            if (screenButtons.Count == 0)
                DeuVelhaReiniciaTudo();

            if (IA.Won(VCE))
            {
                richLog.AppendText("\nIA venceu!");
                MessageBox.Show("\nIA venceu!");
                //Reseta os valores
                return null;
            }
            else if(player.Won(VCE))
            {
                richLog.AppendText("\nPlayer venceu!");
                MessageBox.Show("\nPlayer venceu!");
                //Reseta os valores
                return null;
            }

            if (isIATurn)
            {
                rand = new Random();
                BotaoQueSeraClicado = screenButtons[rand.Next(screenButtons.Count)];

                screenButtons.Remove(BotaoQueSeraClicado);
                return BotaoQueSeraClicado;
                //BotaoQueSeraClicado.PerformClick();
            }
            else
            {
                return null;
            }

        }

        private void DeuVelhaReiniciaTudo()
        {
            richLog.AppendText("\nDeu velha, seu verme! ");
            MessageBox.Show("\nDeu velha, seu verme! ");
            //Reset
        }
    }
}
