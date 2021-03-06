﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Says
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {   //Loads the Gamescreen when the start button is pressed
            Form f = FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void exitGame_Click(object sender, EventArgs e)
        {   //Closes the game when exit button is pressed
            Application.Exit();
        }
    }
}
