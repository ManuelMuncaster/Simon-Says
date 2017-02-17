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
    {   //Setting up guess variable
        int guess;

        public GameScreen()
        {
            InitializeComponent();
        }
        private void greenButton_Click(object sender, EventArgs e)
        {  //Plays the appropriate sound for the button that has been clicked
            Form1.sound.Add(3);
            Sound();
            if (Form1.pattern[guess] == 2)
            {   //Makes the button flash
                Refresh();
                greenButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(250);
                greenButton.BackColor = Color.Green;
                Refresh();
                //Adds one to guess
                guess++;
                if (Form1.pattern.Count() == guess)
                {   //If the player clicks the right button, play the computerTurn function again
                    Thread.Sleep(1500);
                    computerTurn();
                }
            }
            else
            {   //If the player clicks the wrong button, play the GameOver function and sound
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
        {   //Once the game loads up, clears the pattern list and start the computerTurn
            Form1.pattern.Clear();
            computerTurn();
        }
        public void computerTurn()
        {   //Randomize the guess variable
            Random randGen = new Random();
            guess = randGen.Next(1, 5);
            //Add the guess into the pattern list
            Form1.pattern.Add(guess);

            for (int i = 0; i < Form1.pattern.Count; i++)
            {   //For loop to go through and read the list
                if (Form1.pattern[i] == 1)
                {   //If the index is 1, then flash the red button
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;
                    //Play the sound for the red button
                    Form1.sound.Add(2);
                    Sound();
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

                    Form1.sound.Add(3);
                    Sound();
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

                    Form1.sound.Add(1);
                    Sound();
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

                    Form1.sound.Add(4);
                    Sound();
                }
                //Set guess back to 0
                guess = 0;
            }
        }
        public void GameOver()
        {   //Switch the GameScreen to the GameoverScreen
            Form f = FindForm();
            f.Controls.Remove(this);

            GameoverScreen gs = new GameoverScreen();
            f.Controls.Add(gs);
        }
        public void Sound()
        {   //Setting up soundPlayers
            SoundPlayer bluePlayer = new SoundPlayer(Properties.Resources.blue);
            SoundPlayer redPlayer = new SoundPlayer(Properties.Resources.red);
            SoundPlayer greenPlayer = new SoundPlayer(Properties.Resources.green);
            SoundPlayer yellowPlayer = new SoundPlayer(Properties.Resources.yellow);
            SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.mistake);

            for (int s = 0; s < Form1.sound.Count; s++)
            {   //For loop to read through the list, if s is == to a certain numbers then player a specified sound
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
                //Clear the sound list
                Form1.sound.Clear();
            }
        }
    }
}
