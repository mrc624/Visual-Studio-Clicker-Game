namespace Clicker_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.click = new System.Windows.Forms.Button();
            this.CurrentCurrency = new System.Windows.Forms.Label();
            this.btnAdder = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.ClickAddPanel = new System.Windows.Forms.Panel();
            this.ClicksTillNextAdder = new System.Windows.Forms.Label();
            this.lblClicksTill = new System.Windows.Forms.Label();
            this.CostForNextClickAdd = new System.Windows.Forms.Label();
            this.CurrentClickAdd = new System.Windows.Forms.Label();
            this.lblCurrValuePerClick = new System.Windows.Forms.Label();
            this.lblCostForNextValuePerClick = new System.Windows.Forms.Label();
            this.lblClickAdder = new System.Windows.Forms.Label();
            this.ClickMultPanel = new System.Windows.Forms.Panel();
            this.ClicksTillNextMult = new System.Windows.Forms.Label();
            this.lblMultClicksToGo = new System.Windows.Forms.Label();
            this.CostForNextClickMult = new System.Windows.Forms.Label();
            this.CurrentClickMult = new System.Windows.Forms.Label();
            this.lblMultCurrent = new System.Windows.Forms.Label();
            this.lblCostForNextMult = new System.Windows.Forms.Label();
            this.lblClickMultipler = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OverallCurrency = new System.Windows.Forms.Label();
            this.OverallClicks = new System.Windows.Forms.Label();
            this.lblOverallClicks = new System.Windows.Forms.Label();
            this.lblNetCurrency = new System.Windows.Forms.Label();
            this.lblOverallClickStats = new System.Windows.Forms.Label();
            this.SecondsElapsed = new System.Windows.Forms.Label();
            this.btnAutoClickSec = new System.Windows.Forms.Button();
            this.dev_give_1000 = new System.Windows.Forms.Button();
            this.ClickAddPanel.SuspendLayout();
            this.ClickMultPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(249, 122);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(294, 173);
            this.click.TabIndex = 0;
            this.click.Text = "CLICK ME";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // CurrentCurrency
            // 
            this.CurrentCurrency.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CurrentCurrency.AutoSize = true;
            this.CurrentCurrency.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCurrency.Location = new System.Drawing.Point(254, 17);
            this.CurrentCurrency.Name = "CurrentCurrency";
            this.CurrentCurrency.Size = new System.Drawing.Size(300, 73);
            this.CurrentCurrency.TabIndex = 1;
            this.CurrentCurrency.Text = "Unknown";
            this.CurrentCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdder
            // 
            this.btnAdder.Location = new System.Drawing.Point(3, 85);
            this.btnAdder.Name = "btnAdder";
            this.btnAdder.Size = new System.Drawing.Size(194, 35);
            this.btnAdder.TabIndex = 2;
            this.btnAdder.Text = "INCREASE  ADD";
            this.btnAdder.UseVisualStyleBackColor = true;
            this.btnAdder.Click += new System.EventHandler(this.btnAdder_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Location = new System.Drawing.Point(3, 85);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(194, 35);
            this.btnMultiplier.TabIndex = 3;
            this.btnMultiplier.Text = "INCREASE  MULT";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // ClickAddPanel
            // 
            this.ClickAddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickAddPanel.Controls.Add(this.ClicksTillNextAdder);
            this.ClickAddPanel.Controls.Add(this.lblClicksTill);
            this.ClickAddPanel.Controls.Add(this.CostForNextClickAdd);
            this.ClickAddPanel.Controls.Add(this.CurrentClickAdd);
            this.ClickAddPanel.Controls.Add(this.lblCurrValuePerClick);
            this.ClickAddPanel.Controls.Add(this.lblCostForNextValuePerClick);
            this.ClickAddPanel.Controls.Add(this.lblClickAdder);
            this.ClickAddPanel.Controls.Add(this.btnAdder);
            this.ClickAddPanel.Location = new System.Drawing.Point(588, 12);
            this.ClickAddPanel.Name = "ClickAddPanel";
            this.ClickAddPanel.Size = new System.Drawing.Size(200, 128);
            this.ClickAddPanel.TabIndex = 6;
            // 
            // ClicksTillNextAdder
            // 
            this.ClicksTillNextAdder.AutoSize = true;
            this.ClicksTillNextAdder.Location = new System.Drawing.Point(118, 70);
            this.ClicksTillNextAdder.Name = "ClicksTillNextAdder";
            this.ClicksTillNextAdder.Size = new System.Drawing.Size(53, 13);
            this.ClicksTillNextAdder.TabIndex = 11;
            this.ClicksTillNextAdder.Text = "Unknown";
            // 
            // lblClicksTill
            // 
            this.lblClicksTill.AutoSize = true;
            this.lblClicksTill.Location = new System.Drawing.Point(4, 70);
            this.lblClicksTill.Name = "lblClicksTill";
            this.lblClicksTill.Size = new System.Drawing.Size(79, 13);
            this.lblClicksTill.TabIndex = 10;
            this.lblClicksTill.Text = "Currency to go:";
            // 
            // CostForNextClickAdd
            // 
            this.CostForNextClickAdd.AutoSize = true;
            this.CostForNextClickAdd.Location = new System.Drawing.Point(117, 55);
            this.CostForNextClickAdd.Name = "CostForNextClickAdd";
            this.CostForNextClickAdd.Size = new System.Drawing.Size(53, 13);
            this.CostForNextClickAdd.TabIndex = 9;
            this.CostForNextClickAdd.Text = "Unknown";
            // 
            // CurrentClickAdd
            // 
            this.CurrentClickAdd.AutoSize = true;
            this.CurrentClickAdd.Location = new System.Drawing.Point(117, 40);
            this.CurrentClickAdd.Name = "CurrentClickAdd";
            this.CurrentClickAdd.Size = new System.Drawing.Size(53, 13);
            this.CurrentClickAdd.TabIndex = 8;
            this.CurrentClickAdd.Text = "Unknown";
            // 
            // lblCurrValuePerClick
            // 
            this.lblCurrValuePerClick.AutoSize = true;
            this.lblCurrValuePerClick.Location = new System.Drawing.Point(3, 40);
            this.lblCurrValuePerClick.Name = "lblCurrValuePerClick";
            this.lblCurrValuePerClick.Size = new System.Drawing.Size(44, 13);
            this.lblCurrValuePerClick.TabIndex = 7;
            this.lblCurrValuePerClick.Text = "Current:";
            // 
            // lblCostForNextValuePerClick
            // 
            this.lblCostForNextValuePerClick.AutoSize = true;
            this.lblCostForNextValuePerClick.Location = new System.Drawing.Point(3, 55);
            this.lblCostForNextValuePerClick.Name = "lblCostForNextValuePerClick";
            this.lblCostForNextValuePerClick.Size = new System.Drawing.Size(71, 13);
            this.lblCostForNextValuePerClick.TabIndex = 4;
            this.lblCostForNextValuePerClick.Text = "Cost for Next:";
            // 
            // lblClickAdder
            // 
            this.lblClickAdder.AutoSize = true;
            this.lblClickAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickAdder.Location = new System.Drawing.Point(4, 4);
            this.lblClickAdder.Name = "lblClickAdder";
            this.lblClickAdder.Size = new System.Drawing.Size(87, 16);
            this.lblClickAdder.TabIndex = 3;
            this.lblClickAdder.Text = "Click Adder";
            // 
            // ClickMultPanel
            // 
            this.ClickMultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickMultPanel.Controls.Add(this.ClicksTillNextMult);
            this.ClickMultPanel.Controls.Add(this.lblMultClicksToGo);
            this.ClickMultPanel.Controls.Add(this.btnMultiplier);
            this.ClickMultPanel.Controls.Add(this.CostForNextClickMult);
            this.ClickMultPanel.Controls.Add(this.CurrentClickMult);
            this.ClickMultPanel.Controls.Add(this.lblMultCurrent);
            this.ClickMultPanel.Controls.Add(this.lblCostForNextMult);
            this.ClickMultPanel.Controls.Add(this.lblClickMultipler);
            this.ClickMultPanel.Location = new System.Drawing.Point(588, 146);
            this.ClickMultPanel.Name = "ClickMultPanel";
            this.ClickMultPanel.Size = new System.Drawing.Size(200, 128);
            this.ClickMultPanel.TabIndex = 7;
            // 
            // ClicksTillNextMult
            // 
            this.ClicksTillNextMult.AutoSize = true;
            this.ClicksTillNextMult.Location = new System.Drawing.Point(118, 70);
            this.ClicksTillNextMult.Name = "ClicksTillNextMult";
            this.ClicksTillNextMult.Size = new System.Drawing.Size(53, 13);
            this.ClicksTillNextMult.TabIndex = 11;
            this.ClicksTillNextMult.Text = "Unknown";
            // 
            // lblMultClicksToGo
            // 
            this.lblMultClicksToGo.AutoSize = true;
            this.lblMultClicksToGo.Location = new System.Drawing.Point(4, 70);
            this.lblMultClicksToGo.Name = "lblMultClicksToGo";
            this.lblMultClicksToGo.Size = new System.Drawing.Size(79, 13);
            this.lblMultClicksToGo.TabIndex = 10;
            this.lblMultClicksToGo.Text = "Currency to go:";
            // 
            // CostForNextClickMult
            // 
            this.CostForNextClickMult.AutoSize = true;
            this.CostForNextClickMult.Location = new System.Drawing.Point(117, 55);
            this.CostForNextClickMult.Name = "CostForNextClickMult";
            this.CostForNextClickMult.Size = new System.Drawing.Size(53, 13);
            this.CostForNextClickMult.TabIndex = 9;
            this.CostForNextClickMult.Text = "Unknown";
            // 
            // CurrentClickMult
            // 
            this.CurrentClickMult.AutoSize = true;
            this.CurrentClickMult.Location = new System.Drawing.Point(117, 40);
            this.CurrentClickMult.Name = "CurrentClickMult";
            this.CurrentClickMult.Size = new System.Drawing.Size(53, 13);
            this.CurrentClickMult.TabIndex = 8;
            this.CurrentClickMult.Text = "Unknown";
            // 
            // lblMultCurrent
            // 
            this.lblMultCurrent.AutoSize = true;
            this.lblMultCurrent.Location = new System.Drawing.Point(3, 40);
            this.lblMultCurrent.Name = "lblMultCurrent";
            this.lblMultCurrent.Size = new System.Drawing.Size(44, 13);
            this.lblMultCurrent.TabIndex = 7;
            this.lblMultCurrent.Text = "Current:";
            // 
            // lblCostForNextMult
            // 
            this.lblCostForNextMult.AutoSize = true;
            this.lblCostForNextMult.Location = new System.Drawing.Point(3, 55);
            this.lblCostForNextMult.Name = "lblCostForNextMult";
            this.lblCostForNextMult.Size = new System.Drawing.Size(71, 13);
            this.lblCostForNextMult.TabIndex = 4;
            this.lblCostForNextMult.Text = "Cost for Next:";
            // 
            // lblClickMultipler
            // 
            this.lblClickMultipler.AutoSize = true;
            this.lblClickMultipler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickMultipler.Location = new System.Drawing.Point(4, 4);
            this.lblClickMultipler.Name = "lblClickMultipler";
            this.lblClickMultipler.Size = new System.Drawing.Size(108, 16);
            this.lblClickMultipler.TabIndex = 3;
            this.lblClickMultipler.Text = "Click Multiplier";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.OverallCurrency);
            this.panel1.Controls.Add(this.OverallClicks);
            this.panel1.Controls.Add(this.lblOverallClicks);
            this.panel1.Controls.Add(this.lblNetCurrency);
            this.panel1.Controls.Add(this.lblOverallClickStats);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 84);
            this.panel1.TabIndex = 8;
            // 
            // OverallCurrency
            // 
            this.OverallCurrency.AutoSize = true;
            this.OverallCurrency.Location = new System.Drawing.Point(117, 55);
            this.OverallCurrency.Name = "OverallCurrency";
            this.OverallCurrency.Size = new System.Drawing.Size(53, 13);
            this.OverallCurrency.TabIndex = 9;
            this.OverallCurrency.Text = "Unknown";
            // 
            // OverallClicks
            // 
            this.OverallClicks.AutoSize = true;
            this.OverallClicks.Location = new System.Drawing.Point(117, 40);
            this.OverallClicks.Name = "OverallClicks";
            this.OverallClicks.Size = new System.Drawing.Size(53, 13);
            this.OverallClicks.TabIndex = 8;
            this.OverallClicks.Text = "Unknown";
            // 
            // lblOverallClicks
            // 
            this.lblOverallClicks.AutoSize = true;
            this.lblOverallClicks.Location = new System.Drawing.Point(3, 40);
            this.lblOverallClicks.Name = "lblOverallClicks";
            this.lblOverallClicks.Size = new System.Drawing.Size(71, 13);
            this.lblOverallClicks.TabIndex = 7;
            this.lblOverallClicks.Text = "Overall Clicks";
            // 
            // lblNetCurrency
            // 
            this.lblNetCurrency.AutoSize = true;
            this.lblNetCurrency.Location = new System.Drawing.Point(3, 55);
            this.lblNetCurrency.Name = "lblNetCurrency";
            this.lblNetCurrency.Size = new System.Drawing.Size(106, 13);
            this.lblNetCurrency.TabIndex = 4;
            this.lblNetCurrency.Text = "Net Currency Earned";
            // 
            // lblOverallClickStats
            // 
            this.lblOverallClickStats.AutoSize = true;
            this.lblOverallClickStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallClickStats.Location = new System.Drawing.Point(4, 4);
            this.lblOverallClickStats.Name = "lblOverallClickStats";
            this.lblOverallClickStats.Size = new System.Drawing.Size(134, 16);
            this.lblOverallClickStats.TabIndex = 3;
            this.lblOverallClickStats.Text = "Overall Click Stats";
            // 
            // SecondsElapsed
            // 
            this.SecondsElapsed.AutoSize = true;
            this.SecondsElapsed.Location = new System.Drawing.Point(480, 342);
            this.SecondsElapsed.Name = "SecondsElapsed";
            this.SecondsElapsed.Size = new System.Drawing.Size(53, 13);
            this.SecondsElapsed.TabIndex = 9;
            this.SecondsElapsed.Text = "Unknown";
            // 
            // btnAutoClickSec
            // 
            this.btnAutoClickSec.Location = new System.Drawing.Point(47, 313);
            this.btnAutoClickSec.Name = "btnAutoClickSec";
            this.btnAutoClickSec.Size = new System.Drawing.Size(271, 54);
            this.btnAutoClickSec.TabIndex = 10;
            this.btnAutoClickSec.Text = "INCREASE AUTO CLICK PER SECOND";
            this.btnAutoClickSec.UseVisualStyleBackColor = true;
            this.btnAutoClickSec.Click += new System.EventHandler(this.btnAutoClickSec_Click);
            // 
            // dev_give_1000
            // 
            this.dev_give_1000.Location = new System.Drawing.Point(596, 343);
            this.dev_give_1000.Name = "dev_give_1000";
            this.dev_give_1000.Size = new System.Drawing.Size(75, 23);
            this.dev_give_1000.TabIndex = 11;
            this.dev_give_1000.Text = "Dev Give 1000";
            this.dev_give_1000.UseVisualStyleBackColor = true;
            this.dev_give_1000.Click += new System.EventHandler(this.dev_give_1000_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dev_give_1000);
            this.Controls.Add(this.btnAutoClickSec);
            this.Controls.Add(this.SecondsElapsed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClickMultPanel);
            this.Controls.Add(this.ClickAddPanel);
            this.Controls.Add(this.CurrentCurrency);
            this.Controls.Add(this.click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ClickAddPanel.ResumeLayout(false);
            this.ClickAddPanel.PerformLayout();
            this.ClickMultPanel.ResumeLayout(false);
            this.ClickMultPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label CurrentCurrency;
        private System.Windows.Forms.Button btnAdder;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Panel ClickAddPanel;
        private System.Windows.Forms.Label lblCurrValuePerClick;
        private System.Windows.Forms.Label lblCostForNextValuePerClick;
        private System.Windows.Forms.Label lblClickAdder;
        private System.Windows.Forms.Label CostForNextClickAdd;
        private System.Windows.Forms.Label CurrentClickAdd;
        private System.Windows.Forms.Label ClicksTillNextAdder;
        private System.Windows.Forms.Label lblClicksTill;
        private System.Windows.Forms.Panel ClickMultPanel;
        private System.Windows.Forms.Label ClicksTillNextMult;
        private System.Windows.Forms.Label lblMultClicksToGo;
        private System.Windows.Forms.Label CostForNextClickMult;
        private System.Windows.Forms.Label CurrentClickMult;
        private System.Windows.Forms.Label lblMultCurrent;
        private System.Windows.Forms.Label lblCostForNextMult;
        private System.Windows.Forms.Label lblClickMultipler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OverallCurrency;
        private System.Windows.Forms.Label OverallClicks;
        private System.Windows.Forms.Label lblOverallClicks;
        private System.Windows.Forms.Label lblNetCurrency;
        private System.Windows.Forms.Label lblOverallClickStats;
        private System.Windows.Forms.Label SecondsElapsed;
        private System.Windows.Forms.Button btnAutoClickSec;
        private System.Windows.Forms.Button dev_give_1000;
    }
}

