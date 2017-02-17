using System;
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
    public partial class GameoverScreen : UserControl
    {
        public GameoverScreen()
        {
            InitializeComponent();
            //Displays what pattern the player failed on
            patternnumberLabel.Text = "" + Form1.pattern.Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //This allows the player to return to the MainScreen
            Form f = FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
