using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Form1 : Form
    {

        uint clicks = 0;
        uint adder = 1;
        uint multiplier = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            Run_Click();
            Reset_Btns();
            Update_Clicks();
        }

        private void Reset_Btns()
        {
            Reset_btnAdder();
            Reset_btnMultiplier();
        }

        private void Run_Click ()
        {
            clicks = (adder * multiplier) + clicks;
        }

        private void btnAdder_Click(object sender, EventArgs e)
        {
            if (clicks >= 100 * adder)
            {
                clicks = clicks - (100 * adder);
                adder++;
                btnAdder.Text = "Sufficient Amount";
                btnAdder.BackColor = Color.Green;
            }
            else
            {
                btnAdder.Text = "Insufficient Amount";
                btnAdder.BackColor = Color.Red;
            }
            Update_Clicks();
        }

        private void Reset_btnAdder()
        {
            btnAdder.Text = "Button Adder";
            btnAdder.BackColor = SystemColors.Window;
        }

        private void Update_Clicks()
        {
            label1.Text = clicks.ToString();
            Update_Click_Add();
        }

        private void Update_Click_Add()
        {
            CurrentClickAdd.Text = adder.ToString();
            CostForNextClickAdd.Text = (100 * adder).ToString();
            if ( clicks >= 100 * adder)
            {
                ClicksTillNextAdder.Text = "Available";
                ClicksTillNextAdder.BackColor = Color.Green;
            }
            else
            {
                ClicksTillNextAdder.Text = ((100 * adder) - clicks).ToString();
                ClicksTillNextAdder.BackColor = SystemColors.Window;
            }
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            if (clicks >= 1000 * multiplier)
            {
                clicks = clicks - (1000 * multiplier);
                multiplier++;
                btnMultiplier.Text = "Sufficient Amount";
                btnMultiplier.BackColor = Color.Green;
            }
            else
            {
                btnMultiplier.Text = "Insufficient Amount";
                btnMultiplier.BackColor = Color.Red;
            }
            Update_Clicks();
        }
        private void Reset_btnMultiplier()
        {
            btnMultiplier.Text = "Button Adder";
            btnMultiplier.BackColor = SystemColors.Window;
        }
    }
}
