namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Click = new System.Windows.Forms.Button();
            this.Moni = new System.Windows.Forms.Label();
            this.ClickUp = new System.Windows.Forms.Button();
            this.Auto1 = new System.Windows.Forms.Button();
            this.Interval1 = new System.Windows.Forms.Button();
            this.IntUpgCost = new System.Windows.Forms.Label();
            this.Intinfo1 = new System.Windows.Forms.Label();
            this.MoneyPTUpgrade = new System.Windows.Forms.Label();
            this.MoneyPT1 = new System.Windows.Forms.Label();
            this.MoneyPTTxtBox1 = new System.Windows.Forms.TextBox();
            this.AutoMoneyUpCost1 = new System.Windows.Forms.TextBox();
            this.AutoIntTxtBox1 = new System.Windows.Forms.TextBox();
            this.IntUpCostTxtBox = new System.Windows.Forms.TextBox();
            this.Buttonlvl = new System.Windows.Forms.Label();
            this.ButtonLvlTxtBox = new System.Windows.Forms.TextBox();
            this.AutoIntTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(703, 700);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(269, 56);
            this.Click.TabIndex = 0;
            this.Click.Text = "Click! ($)";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Moni
            // 
            this.Moni.AutoSize = true;
            this.Moni.Location = new System.Drawing.Point(556, 259);
            this.Moni.Name = "Moni";
            this.Moni.Size = new System.Drawing.Size(56, 15);
            this.Moni.TabIndex = 1;
            this.Moni.Text = "Money: $";
            // 
            // ClickUp
            // 
            this.ClickUp.Location = new System.Drawing.Point(620, 689);
            this.ClickUp.Name = "ClickUp";
            this.ClickUp.Size = new System.Drawing.Size(77, 78);
            this.ClickUp.TabIndex = 2;
            this.ClickUp.Text = "Upgrade Click";
            this.ClickUp.UseVisualStyleBackColor = true;
            this.ClickUp.Click += new System.EventHandler(this.ClickUp_Click);
            // 
            // Auto1
            // 
            this.Auto1.Location = new System.Drawing.Point(26, 320);
            this.Auto1.Name = "Auto1";
            this.Auto1.Size = new System.Drawing.Size(81, 78);
            this.Auto1.TabIndex = 3;
            this.Auto1.Text = "AutoMoneyMachine1";
            this.Auto1.UseVisualStyleBackColor = true;
            this.Auto1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Interval1
            // 
            this.Interval1.Location = new System.Drawing.Point(387, 321);
            this.Interval1.Name = "Interval1";
            this.Interval1.Size = new System.Drawing.Size(81, 82);
            this.Interval1.TabIndex = 4;
            this.Interval1.Text = "Tick interval For AMM 1";
            this.Interval1.UseVisualStyleBackColor = true;
            this.Interval1.Click += new System.EventHandler(this.Interval_Click);
            // 
            // IntUpgCost
            // 
            this.IntUpgCost.AutoSize = true;
            this.IntUpgCost.Location = new System.Drawing.Point(474, 388);
            this.IntUpgCost.Name = "IntUpgCost";
            this.IntUpgCost.Size = new System.Drawing.Size(80, 15);
            this.IntUpgCost.TabIndex = 6;
            this.IntUpgCost.Text = "Upgrade cost:";
            // 
            // Intinfo1
            // 
            this.Intinfo1.AutoSize = true;
            this.Intinfo1.Location = new System.Drawing.Point(474, 321);
            this.Intinfo1.Name = "Intinfo1";
            this.Intinfo1.Size = new System.Drawing.Size(92, 15);
            this.Intinfo1.TabIndex = 5;
            this.Intinfo1.Text = "Current interval:";
            // 
            // MoneyPTUpgrade
            // 
            this.MoneyPTUpgrade.AutoSize = true;
            this.MoneyPTUpgrade.Location = new System.Drawing.Point(113, 383);
            this.MoneyPTUpgrade.Name = "MoneyPTUpgrade";
            this.MoneyPTUpgrade.Size = new System.Drawing.Size(80, 15);
            this.MoneyPTUpgrade.TabIndex = 8;
            this.MoneyPTUpgrade.Text = "Upgrade cost:";
            // 
            // MoneyPT1
            // 
            this.MoneyPT1.AutoSize = true;
            this.MoneyPT1.Location = new System.Drawing.Point(113, 320);
            this.MoneyPT1.Name = "MoneyPT1";
            this.MoneyPT1.Size = new System.Drawing.Size(89, 15);
            this.MoneyPT1.TabIndex = 7;
            this.MoneyPT1.Text = "Money per tick:";
            // 
            // MoneyPTTxtBox1
            // 
            this.MoneyPTTxtBox1.Location = new System.Drawing.Point(208, 317);
            this.MoneyPTTxtBox1.Name = "MoneyPTTxtBox1";
            this.MoneyPTTxtBox1.Size = new System.Drawing.Size(100, 23);
            this.MoneyPTTxtBox1.TabIndex = 11;
            this.MoneyPTTxtBox1.TextChanged += new System.EventHandler(this.MoneyPT1_TextChanged);
            // 
            // AutoMoneyUpCost1
            // 
            this.AutoMoneyUpCost1.Location = new System.Drawing.Point(208, 380);
            this.AutoMoneyUpCost1.Name = "AutoMoneyUpCost1";
            this.AutoMoneyUpCost1.Size = new System.Drawing.Size(100, 23);
            this.AutoMoneyUpCost1.TabIndex = 12;
            // 
            // AutoIntTxtBox1
            // 
            this.AutoIntTxtBox1.Location = new System.Drawing.Point(572, 318);
            this.AutoIntTxtBox1.Name = "AutoIntTxtBox1";
            this.AutoIntTxtBox1.Size = new System.Drawing.Size(100, 23);
            this.AutoIntTxtBox1.TabIndex = 13;
            // 
            // IntUpCostTxtBox
            // 
            this.IntUpCostTxtBox.Location = new System.Drawing.Point(572, 385);
            this.IntUpCostTxtBox.Name = "IntUpCostTxtBox";
            this.IntUpCostTxtBox.Size = new System.Drawing.Size(100, 23);
            this.IntUpCostTxtBox.TabIndex = 14;
            // 
            // Buttonlvl
            // 
            this.Buttonlvl.AutoSize = true;
            this.Buttonlvl.Location = new System.Drawing.Point(997, 715);
            this.Buttonlvl.Name = "Buttonlvl";
            this.Buttonlvl.Size = new System.Drawing.Size(61, 15);
            this.Buttonlvl.TabIndex = 15;
            this.Buttonlvl.Text = "Button lvl:";
            this.Buttonlvl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonLvlTxtBox
            // 
            this.ButtonLvlTxtBox.Location = new System.Drawing.Point(1066, 712);
            this.ButtonLvlTxtBox.Name = "ButtonLvlTxtBox";
            this.ButtonLvlTxtBox.Size = new System.Drawing.Size(100, 23);
            this.ButtonLvlTxtBox.TabIndex = 16;
            // 
            // AutoIntTimer1
            // 
            this.AutoIntTimer1.Tick += new System.EventHandler(this.AutoIntTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 847);
            this.Controls.Add(this.ButtonLvlTxtBox);
            this.Controls.Add(this.Buttonlvl);
            this.Controls.Add(this.IntUpCostTxtBox);
            this.Controls.Add(this.AutoIntTxtBox1);
            this.Controls.Add(this.AutoMoneyUpCost1);
            this.Controls.Add(this.MoneyPTTxtBox1);
            this.Controls.Add(this.MoneyPTUpgrade);
            this.Controls.Add(this.MoneyPT1);
            this.Controls.Add(this.IntUpgCost);
            this.Controls.Add(this.Intinfo1);
            this.Controls.Add(this.Interval1);
            this.Controls.Add(this.Auto1);
            this.Controls.Add(this.ClickUp);
            this.Controls.Add(this.Moni);
            this.Controls.Add(this.Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Click;
        private Label Moni;
        private Button ClickUp;
        private Button Auto1;
        private Button Interval1;
        private Label IntUpgCost;
        private Label Intinfo1;
        private Label MoneyPTUpgrade;
        private Label MoneyPT1;
        private TextBox MoneyPTTxtBox1;
        private TextBox AutoMoneyUpCost1;
        private TextBox AutoIntTxtBox1;
        private TextBox IntUpCostTxtBox;
        private Label Buttonlvl;
        private TextBox ButtonLvlTxtBox;
        private System.Windows.Forms.Timer AutoIntTimer1;
    }
}