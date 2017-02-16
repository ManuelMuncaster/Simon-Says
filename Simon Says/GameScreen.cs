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
using System.Media;

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
            Form1.sound.Add(3);
            Sound();
            if (Form1.pattern[guess] == 2)
            {
                Refresh();
                greenButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                greenButton.BackColor = Color.Green;
                Refresh();

                guess++;
                if (Form1.pattern.Count() == guess)
                {
                    Thread.Sleep(1500);
                    computerTurn();
                }
            }
            else
            {
                Form1.sound.Add(5);
                Sound();
                GameOver();
            }
        }
        private void redButton_Click(object sender, EventArgs e)
        {
            Form1.sound.Add(2);
            Sound();
            if (Form1.pattern[guess] == 1)
            {
                Refresh();
                redButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                redButton.BackColor = Color.Red;
                Refresh();

                guess++;
                if (Form1.pattern.Count() == guess)
                {
                    Thread.Sleep(1500);
                    computerTurn();
                }
            }
            else
            {
                Form1.sound.Add(5);
                Sound();
                GameOver();
            }
        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            Form1.sound.Add(1);
            Sound();
            if (Form1.pattern[guess] == 3)
            {
                Refresh();
                blueButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                blueButton.BackColor = Color.Blue;
                Refresh();

                guess++;
                if (Form1.pattern.Count() == guess)
                {
                    Thread.Sleep(1500);
                    computerTurn();
                }
            }
            else
            {
                Form1.sound.Add(5);
                Sound();
                GameOver();
            }
        }
        private void yellowButton_Click(object sender, EventArgs e)
        {
            Form1.sound.Add(4);
            Sound();
            if (Form1.pattern[guess] == 4)
            {
                Refresh();
                yellowButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                yellowButton.BackColor = Color.Yellow;
                Refresh();

                guess++;
                if (Form1.pattern.Count() == guess)
                {
                    Thread.Sleep(1500);
                    computerTurn();
                }
            }
            else
            {
                Form1.sound.Add(5);
                Sound();
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
        public void Sound()
        {

            SoundPlayer bluePlayer = new SoundPlayer(Properties.Resources.blue);
            SoundPlayer redPlayer = new SoundPlayer(Properties.Resources.red);
            SoundPlayer greenPlayer = new SoundPlayer(Properties.Resources.green);
            SoundPlayer yellowPlayer = new SoundPlayer(Properties.Resources.yellow);
            SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.mistake);

            for (int s = 0; s < Form1.sound.Count; s++)
            {
                if (Form1.sound[s] == 1)
                {
                    bluePlayer.Play();
                }
                else if (Form1.sound[s] == 2)
                {
                    redPlayer.Play();
                }
                else if (Form1.sound[s] == 3)
                {
                    greenPlayer.Play();
                }
                else if (Form1.sound[s] == 4)
                {
                    yellowPlayer.Play();
                }
                else if (Form1.sound[s] == 5)
                {
                    errorPlayer.Play();
                }
            }
        }
    }
}
