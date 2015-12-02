using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkApp
{
    public partial class Form1 : Form
    {
        string[] coins = new string[4];
        int valuesEntered;
        int spaces = 4;

        public Form1()
        {
            InitializeComponent();
            valuesEntered = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (valuesEntered == 4)
            {
                MessageBox.Show("No spaces available");
                btnEnter.Enabled = false;
                lblStandardSpaces.ForeColor = System.Drawing.Color.Red;
                lblStandardTitle.ForeColor = System.Drawing.Color.Red;
                groupBox1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                coins[valuesEntered] = "coin" + valuesEntered.ToString();
                valuesEntered++;
                listBox1.Items.Add(coins);
                spaces--;
            }
            lblStandardSpaces.Text = spaces.ToString();
        }
        private void lblCoinDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
