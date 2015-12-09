using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace CarParkApp
{
    public partial class Form1 : Form
    {
        string[] coins = new string[4];
        int spacesEntered;
        int spaces = 4;
        int disabledSpaces;
        int disabled = 4;

        public Form1()
        {
            InitializeComponent();
            spacesEntered = 0;
            disabledSpaces = 0;
            btnTakeCoin.Enabled = false;
            timeBarrier.Enabled = false;
            btnStandard.Visible = false;
            btnDisabled.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnStandard.Visible = true;
            btnDisabled.Visible = true;
            btnEnter.Enabled = false;

            systemMessages.Text = "Please select whether you wish to aquire a standard space or a disabled space";
        }
        private void lblCoinDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void standardSpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var spacesInput = new spacesInput();
            spacesInput.Show();
        }

        private void btnTakeCoin_Click(object sender, EventArgs e)
        {
            btnTakeCoin.BackColor = Color.Gray;
            btnTakeCoin.Enabled = false;
            btnEnter.Enabled = false;
            systemMessages.Text = "Please proceed to a parking space";
            txtBarrierStatus.Text = "Raised";
            txtBarrierStatus.ForeColor = Color.Green;
            timeBarrier.Enabled = true;
        }

        private void btnFlash_Tick(object sender, EventArgs e)
        {

        }

        private void timeBarrier_Tick(object sender, EventArgs e)
        {
            systemMessages.Text = "Welcome please select enter car park";
            txtBarrierStatus.Text = "Lowered";
            btnEnter.Enabled = true;
            txtBarrierStatus.ForeColor = Color.Red;
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            if (spacesEntered == 4)
            {
                btnStandard.Enabled = false;
                lblStandardSpaces.ForeColor = System.Drawing.Color.Red;
                lblStandardTitle.ForeColor = System.Drawing.Color.Red;
                groupBox1.ForeColor = System.Drawing.Color.Red;
                btnStandard.BackColor = System.Drawing.Color.Red;
                systemMessages.ForeColor = Color.Red;
                systemMessages.Text = 
                    "-----PLEASE NOTE-----" + "\n" +
                    "Sorry, we have no standard spaces available in our car park";
                btnEnter.Enabled = true;
            }
            else
            {
                systemMessages.Text = "";
                listBox1.Items.Add("Standard Coin " + spacesEntered);
                //coins[valuesEntered] = "coin";
                spacesEntered++;
                //listBox1.Items.Add(coins);
                spaces--;
                systemMessages.Text = "Please take your coin";
                btnTakeCoin.Enabled = true;
                btnStandard.Visible = true;
                btnDisabled.Visible = true;
                btnEnter.Enabled = false;
            }
            btnStandard.Visible = false;
            btnDisabled.Visible = false;
            lblStandardSpaces.Text = spaces.ToString();
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            if (disabledSpaces == 4)
            {
                btnDisabled.Enabled = false;
                lblStandardSpaces.ForeColor = System.Drawing.Color.Red;
                lblStandardTitle.ForeColor = System.Drawing.Color.Red;
                groupBox1.ForeColor = System.Drawing.Color.Red;
                btnEnter.BackColor = System.Drawing.Color.Red;
                systemMessages.ForeColor = Color.Red;
                systemMessages.Text =
                    "-----PLEASE NOTE-----" + System.Environment.NewLine +
                    "Sorry, we have no standard spaces available in our car park";
                btnEnter.Enabled = true;
            }
            else
            {
                systemMessages.Text = "";
                listBox1.Items.Add("Disabled Coin " + disabledSpaces);
                //coins[valuesEntered] = "coin";
                disabledSpaces++;
                //listBox1.Items.Add(coins);
                disabled--;
                systemMessages.Text = "Please take your coin";
                btnTakeCoin.Enabled = true;
                btnStandard.Visible = true;
                btnDisabled.Visible = true;
                btnEnter.Enabled = false;
            }
            btnStandard.Visible = false;
            btnDisabled.Visible = false;
            lblDisabledSpaces.Text = disabled.ToString();
        }

        private void btnReturnCoin_Click(object sender, EventArgs e)
        {
            Form ReturnACoin = new ReturnACoin();
             ReturnACoin.Show();
        }
    }
}
