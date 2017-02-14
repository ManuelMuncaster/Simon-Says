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

        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            computerTurn();

        }
        public void computerTurn()
        {
            int button;
            Random randGen = new Random();
            button = randGen.Next(0, 5);

            Form1.pattern.Add(button);

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

                button = 0;
            }

        }
    }
}
