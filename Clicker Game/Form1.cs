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
        }
    }
}
