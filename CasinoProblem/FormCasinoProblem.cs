using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoProblem
{
    public partial class FormCasinoProblem : Form
    {
        public FormCasinoProblem()
        {
            InitializeComponent();
        }


        /*
         CASINO PROBLEM
        At a casino, the following game is played between a player and the banker. The player pays the banker 
        $7.50. The banker has a roulette wheel with 36 numbers (1-36), which he spins. Assume the resulting number is 
        17. The banker then pays the player $1, and spins the wheel again. Suppose the number this time is 24. The 
        banker pays another $1, and the process continues until a number is produced which has already occured. 
        Suppose the sequence of numbers is 17,24,18,31. The banker has paid the player $4.00 . At the next turn of the 
        wheel the number is 18 ( a number already produced). At this point the game ends, and the player has lost 
        $3.50. Simulate 200 such games, and display the numbers produced by the roulette wheel, the amount the 
        player wins or loses each game, and the players total loss or gain.
         */
        private void BtnStart_Click(object sender, EventArgs e)
        {
            LstResult.Items.Clear();
            Random r = new Random();
            int number = 0;
            int[] numbersFlag = new int[37];
            double playerProfitPerGame;
            double totalProfit = 0;

            for (int simulation = 1; simulation <= 200; simulation++)
            {
                ClearArray(numbersFlag);

                playerProfitPerGame = -7.50;
                string displayNumbers = "";
                while (true)
                {
                    number = r.Next(1, 37);
                    displayNumbers += " " + number.ToString();

                    //if this number was already spun, the game is over
                    if (numbersFlag[number] == 1)
                        break;

                    numbersFlag[number] += 1;
                    playerProfitPerGame += 1;
                }

                totalProfit += playerProfitPerGame;
                LstResult.Items.Add("Simulation " + simulation + Environment.NewLine);
                LstResult.Items.Add("Numbers: " + displayNumbers + Environment.NewLine);
                LstResult.Items.Add("Profit: " + playerProfitPerGame.ToString("C") + Environment.NewLine);
            }

            LstResult.Items.Add("Total profit after 200 simulations: " + totalProfit);
        }

        private void ClearArray(int[] ar)
        {
            for (int i = 0; i <= ar.Length - 1; i++)
            {
                ar[i] = 0;
            }
        }
    }
}
