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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdder = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CostForNextClickAdd = new System.Windows.Forms.Label();
            this.CurrentClickAdd = new System.Windows.Forms.Label();
            this.lblCurrValuePerClick = new System.Windows.Forms.Label();
            this.lblCostForNextValuePerClick = new System.Windows.Forms.Label();
            this.lblClickAdder = new System.Windows.Forms.Label();
            this.ClicksTillNextAdder = new System.Windows.Forms.Label();
            this.lblClicksTill = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(202, 183);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(294, 173);
            this.click.TabIndex = 0;
            this.click.Text = "CLICK ME";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.btnMultiplier.Location = new System.Drawing.Point(597, 183);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(141, 35);
            this.btnMultiplier.TabIndex = 3;
            this.btnMultiplier.Text = "INCREASE  MULT";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClicksTillNextAdder);
            this.panel1.Controls.Add(this.lblClicksTill);
            this.panel1.Controls.Add(this.CostForNextClickAdd);
            this.panel1.Controls.Add(this.CurrentClickAdd);
            this.panel1.Controls.Add(this.lblCurrValuePerClick);
            this.panel1.Controls.Add(this.lblCostForNextValuePerClick);
            this.panel1.Controls.Add(this.lblClickAdder);
            this.panel1.Controls.Add(this.btnAdder);
            this.panel1.Location = new System.Drawing.Point(588, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 128);
            this.panel1.TabIndex = 6;
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
            this.lblClicksTill.Size = new System.Drawing.Size(71, 13);
            this.lblClicksTill.TabIndex = 10;
            this.lblClicksTill.Text = "Clicks To Go:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdder;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrValuePerClick;
        private System.Windows.Forms.Label lblCostForNextValuePerClick;
        private System.Windows.Forms.Label lblClickAdder;
        private System.Windows.Forms.Label CostForNextClickAdd;
        private System.Windows.Forms.Label CurrentClickAdd;
        private System.Windows.Forms.Label ClicksTillNextAdder;
        private System.Windows.Forms.Label lblClicksTill;
    }
}

