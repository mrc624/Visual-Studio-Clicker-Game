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
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(183, 168);
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
            this.label1.Location = new System.Drawing.Point(584, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnAdder
            // 
            this.btnAdder.Location = new System.Drawing.Point(587, 118);
            this.btnAdder.Name = "btnAdder";
            this.btnAdder.Size = new System.Drawing.Size(141, 35);
            this.btnAdder.TabIndex = 2;
            this.btnAdder.Text = "INCREASE  ADD";
            this.btnAdder.UseVisualStyleBackColor = true;
            this.btnAdder.Click += new System.EventHandler(this.btnAdder_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Location = new System.Drawing.Point(587, 168);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(141, 35);
            this.btnMultiplier.TabIndex = 3;
            this.btnMultiplier.Text = "INCREASE  MULT";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.btnAdder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdder;
        private System.Windows.Forms.Button btnMultiplier;
    }
}

