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
        private VictoryConditionEnum VCE;

        List<Button> screenButtons;


        public readonly int[] Teste1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public readonly int[] VetorNaoVitorioso = { 1, 4, 8, 5, 3 };


        public Form1()
        { 

            VCE = new VictoryConditionEnum();

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

            InitializeComponent();

            richLog.AppendText("START!");
            richLog.AppendText("\nO jogo já se iniciou. É a sua vez!");
            richLog.AppendText("\nEsperando o usuário jogar...");

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            richLog.Clear();
            richLog.AppendText("START!");
            richLog.AppendText("\nO jogo já se iniciou. É a sua vez!");
            richLog.AppendText("\nEsperando o usuário jogar...");

            btnA1.Text = "O";
            btnA2.Text = "X";
            btnA3.Text = "O";

            btnB1.Text = "X";
            btnB2.Text = "X";
            btnB3.Text = "O";

            btnC1.Text = "X";
            btnC2.Text = "O";
            btnC3.Text = "X";


            IA.MyCurrentArrayNumbers = Teste1;
            bool v = IA.Won(VCE);

            if (v)
                MessageBox.Show("Venceu!");
            else
                MessageBox.Show("Not yet!");

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnA1);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnA2);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnA3);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnB1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnB2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnB3);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            screenButtons.Remove(btnC3);
        }
    }
}
