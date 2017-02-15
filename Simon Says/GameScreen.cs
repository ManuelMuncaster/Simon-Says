using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon_Says
{
    public partial class GameScreen : UserControl
    {
        int guess;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                Refresh();
                Thread.Sleep(250);
                greenButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                greenButton.BackColor = Color.Green;
                Refresh();

                guess++;
                Thread.Sleep(1500);
                if (Form1.pattern.Count() == guess)
                {
                    computerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                Refresh();
                Thread.Sleep(250);
                redButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                redButton.BackColor = Color.Red;
                Refresh();

                guess++;
                Thread.Sleep(1500);
                if (Form1.pattern.Count() == guess)
                {
                    computerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                Refresh();
                Thread.Sleep(250);
                blueButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                blueButton.BackColor = Color.Blue;
                Refresh();

                guess++;
                Thread.Sleep(1500);
                if (Form1.pattern.Count() == guess)
                {
                    computerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 4)
            {
                Refresh();
                Thread.Sleep(250);
                yellowButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                yellowButton.BackColor = Color.Yellow;
                Refresh();
        
                Thread.Sleep(1500);
                if (Form1.pattern.Count() == guess)
                {
                    computerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            computerTurn();

        }
        public void computerTurn()
        {
            Random randGen = new Random();
            guess = randGen.Next(1, 5);

            Form1.pattern.Add(guess);

            for (int i = 0; i < Form1.pattern.Count; i++)
            { 
                if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;

                }
                else if (Form1.pattern[i] == 2)
                {
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.Green;
                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.Blue;
                }
                else if (Form1.pattern[i] == 4)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Yellow;

                }
                guess = 0;
            }

        }
        public void GameOver()
        {
            Form f = FindForm();
            f.Controls.Remove(this);

            GameoverScreen gs = new GameoverScreen();
            f.Controls.Add(gs);

        }
    }
}
