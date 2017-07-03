using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NivsTestGames
{
    public partial class Form1 : Form
    {
        RPSForm newRPSForm = new RPSForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRPS_Click(object sender, EventArgs e)
        {
            newRPSForm.Show();
        }
    }
}
