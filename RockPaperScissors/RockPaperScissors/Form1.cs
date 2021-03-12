using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int PlayerScore = 0;
        public int CPUscore = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            playerPictureBox.Image = Image.FromFile("PlayerShake.gif");
            CPUPictureBox.Image = Image.FromFile("CPUShake.gif");
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            playerPictureBox.Image = Image.FromFile("PlayerRock.gif");

            Random r = new Random();
            int computerChoice = r.Next(3);


            //Rock
            if (computerChoice == 0)
            {
                CPUPictureBox.Image = Image.FromFile("CPURock.gif");
                MessageBox.Show("Tie");
            }

            //Paper
            else if (computerChoice == 1)
            {
                CPUPictureBox.Image = Image.FromFile("CPUPaper.gif");
                MessageBox.Show("CPU Wins");
                CPUscore = CPUscore + 1;
            }

            //Scissors
            else if (computerChoice == 2)
            {
                CPUPictureBox.Image = Image.FromFile("CPUScissors.gif");
                MessageBox.Show("Player Wins");
                PlayerScore = PlayerScore + 1;
            }
            playerPictureBox.Image = Image.FromFile("PlayerShake.gif");
            CPUPictureBox.Image = Image.FromFile("CPUShake.gif");
            playerScore.Text = PlayerScore.ToString();
            CPUScore.Text = CPUscore.ToString();

            if (PlayerScore == 5)
            {
                MessageBox.Show("Player Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }

            else if (CPUscore == 5)
            {
                MessageBox.Show("CPU Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerPictureBox.Image = Image.FromFile("PlayerPaper.gif");

            Random r = new Random();
            int computerChoice = r.Next(3);

            //Rock
            if (computerChoice == 0)
            {
                CPUPictureBox.Image = Image.FromFile("CPURock.gif");
                MessageBox.Show("Player Wins");
                PlayerScore = PlayerScore + 1;
            }

            //Paper
            else if (computerChoice == 1)
            {
                CPUPictureBox.Image = Image.FromFile("CPUPaper.gif");
                MessageBox.Show("Tie");
            }

            //Scissors
            else if (computerChoice == 2)
            {
                CPUPictureBox.Image = Image.FromFile("CPUScissors.gif");
                MessageBox.Show("CPU Wins");
                CPUscore = CPUscore + 1;
            }
            playerPictureBox.Image = Image.FromFile("PlayerShake.gif");
            CPUPictureBox.Image = Image.FromFile("CPUShake.gif");
            playerScore.Text = PlayerScore.ToString();
            CPUScore.Text = CPUscore.ToString();

            if (PlayerScore == 5)
            {
                MessageBox.Show("Player Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }

            else if (CPUscore == 5)
            {
                MessageBox.Show("CPU Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            playerPictureBox.Image = Image.FromFile("PlayerScissors.gif");

            Random r = new Random();
            int computerChoice = r.Next(3);

            //Rock
            if (computerChoice == 0)
            {
                CPUPictureBox.Image = Image.FromFile("CPURock.gif");
                MessageBox.Show("CPU Wins");
                CPUscore = CPUscore + 1;
            }

            //Paper
            else if (computerChoice == 1)
            {
                CPUPictureBox.Image = Image.FromFile("CPUPaper.gif");
                MessageBox.Show("Player Wins");
                PlayerScore = PlayerScore + 1;
            }

            //Scissors
            else if (computerChoice == 2)
            {
                CPUPictureBox.Image = Image.FromFile("CPUScissors.gif");
                MessageBox.Show("Tie");
            }
            playerPictureBox.Image = Image.FromFile("PlayerShake.gif");
            CPUPictureBox.Image = Image.FromFile("CPUShake.gif");
            playerScore.Text = PlayerScore.ToString();
            CPUScore.Text = CPUscore.ToString();

            if (PlayerScore == 5)
            {
                MessageBox.Show("Player Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }

            else if (CPUscore == 5)
            {
                MessageBox.Show("CPU Wins the Game!");
                PlayerScore = 0;
                CPUscore = 0;
                playerScore.Text = PlayerScore.ToString();
                CPUScore.Text = CPUscore.ToString();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Reset");
            PlayerScore = 0;
            CPUscore = 0;
            playerScore.Text = PlayerScore.ToString();
            CPUScore.Text = CPUscore.ToString();
        }
    }
}
