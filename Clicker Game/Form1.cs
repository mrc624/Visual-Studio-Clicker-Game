using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Security;

namespace Clicker_Game
{
    public partial class Form1 : Form
    {
        //Declarations
        delegate void VoidDelegate();

        uint clicks = 0;
        uint net_clicks = 0;
        uint net_currency = 0;
        uint adder = 1;
        uint multiplier = 1;
        uint Seconds = 0;

        private System.Timers.Timer Timer;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
           Seconds++;
           Invoke (new VoidDelegate (Second_Trigger));
        }

        private void Second_Trigger()
        {
            SecondsElapsed.Text = Seconds.ToString();
        }

        //Event trigger
        private void click_Click(object sender, EventArgs e)
        {
            Run_Click();
            Reset_Btns();
            Update_Clicks();
        }

        private void btnAdder_Click(object sender, EventArgs e)
        {
            net_clicks++;
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

        //Click updater
        private void Update_Clicks()
        {
            CurrentCurrency.Text = clicks.ToString();
            OverallClicks.Text = net_clicks.ToString();
            OverallCurrency.Text = net_currency.ToString();
            Update_Click_Add();
            Update_Click_Mult();
        }

        private void Update_Click_Add()
        {
            CurrentClickAdd.Text = adder.ToString();
            CostForNextClickAdd.Text = (100 * adder).ToString();
            if (clicks >= 100 * adder)
            {
                ClicksTillNextAdder.Text = "Available";
                ClicksTillNextAdder.BackColor = Color.Green;
            }
            else
            {
                ClicksTillNextAdder.Text = ((100 * adder) - clicks).ToString();
                ClicksTillNextAdder.BackColor = SystemColors.Control;
            }
        }

        private void Update_Click_Mult()
        {
            CurrentClickMult.Text = multiplier.ToString();
            CostForNextClickMult.Text = (1000 * multiplier).ToString();
            if (clicks >= 1000 * multiplier)
            {
                ClicksTillNextMult.Text = "Available";
                ClicksTillNextMult.BackColor = Color.Green;
            }
            else
            {
                ClicksTillNextMult.Text = ((1000 * multiplier) - clicks).ToString();
                ClicksTillNextMult.BackColor = SystemColors.Control;
            }
        }

        //Resets
        private void Reset_Btns()
        {
            Reset_btnAdder();
            Reset_btnMultiplier();
        }

        private void Run_Click ()
        {
            clicks = (adder * multiplier) + clicks;
            net_currency = net_currency + (adder * multiplier);
            net_clicks++;
        }

        private void Reset_btnAdder()
        {
            btnAdder.Text = "Button Adder";
            btnAdder.BackColor = SystemColors.Window;
        }

        private void Reset_btnMultiplier()
        {
            btnMultiplier.Text = "Button Adder";
            btnMultiplier.BackColor = SystemColors.Window;
        }
    }
}
