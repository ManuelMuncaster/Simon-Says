//Created by: Manuel Muncaster
//Date: February 14, 2017
//Purpose: This is a replica of the electronic game "Simon Says"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Says
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
        //Setting up lists

           public static List<int> pattern = new List<int>();
           public static List<int> sound = new List<int>();

        
        
                
        }
    }
