using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagicSquare;

namespace GUI_4_MagicSquare_usage
{
    public partial class Form1 : Form
    {

        int[,] arr = new int[2, 2];
        Square mySquare = new Square();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        { 
            arr[0, 0] = 1;
            arr[0, 1] = 1;
            arr[1, 0] = 1;
            arr[1, 1] = 1;

            displayOutput(arr);        
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 2;
            arr[1, 1] = 1;

            displayOutput(arr );
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 2;
            arr[1, 1] = 3;

            displayOutput(arr);
        }


        private void displayOutput(int [,] arr)
        { 
            lblResult.Text = mySquare.IsMagic(arr);        
        }
        
    }  
 }

