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
        private VictoryConditionEnum VCE = new VictoryConditionEnum();

        public readonly int[] Teste1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public readonly int[] VetorNaoVitorioso = { 1, 4, 8, 5, 3 };


        public Form1()
        {
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
            {
                MessageBox.Show("Venceu!");
            }
            else
            {
                MessageBox.Show("Not yet!");
            }

        }
    }
}
