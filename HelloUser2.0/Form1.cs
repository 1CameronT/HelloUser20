/**
 * Name:Cameron
 * Teacher:Mr Hardman
 * Assignment:Lab 2 , Program:1 
 * Date Last Modified:November 18
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //The user age is storing in a variable
            int userAge = Convert.ToInt32(txtAge.Text);

            //Displaying text back to user and their name
            lblDisplay.Text = "Hello " + txtName.Text;

            //If the user age is older or younger than 15, they get different messages
            if (userAge < 15)
            {
                lblDisplay2.Text = "You're " + (15 - userAge) + " years younger than me.";

            } else {
                lblDisplay2.Text = "You're " + (userAge - 15) + " years older than me";
            }

            
            



        }
    }
}
