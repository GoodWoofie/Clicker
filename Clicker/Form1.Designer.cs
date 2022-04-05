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
            this.IntUpCostTxtBox1 = new System.Windows.Forms.TextBox();
            this.Buttonlvl = new System.Windows.Forms.Label();
            this.ButtonLvlTxtBox = new System.Windows.Forms.TextBox();
            this.AutoIntTimer1 = new System.Windows.Forms.Timer(this.components);
            this.IntUpCostTxtBox2 = new System.Windows.Forms.TextBox();
            this.AutoIntTxtBox2 = new System.Windows.Forms.TextBox();
            this.AutoMoneyUpCost2 = new System.Windows.Forms.TextBox();
            this.MoneyPTTxtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Interval2 = new System.Windows.Forms.Button();
            this.Auto2 = new System.Windows.Forms.Button();
            this.AutoIntTimer2 = new System.Windows.Forms.Timer(this.components);
            this.IntUpCostTxtBox3 = new System.Windows.Forms.TextBox();
            this.AutoIntTxtBox3 = new System.Windows.Forms.TextBox();
            this.AutoMoneyUpCost3 = new System.Windows.Forms.TextBox();
            this.MoneyPTTxtBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Interval3 = new System.Windows.Forms.Button();
            this.Auto3 = new System.Windows.Forms.Button();
            this.AutoIntTimer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(810, 224);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(269, 253);
            this.Click.TabIndex = 0;
            this.Click.Text = "Click! ($)";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Moni
            // 
            this.Moni.AutoSize = true;
            this.Moni.Location = new System.Drawing.Point(913, 206);
            this.Moni.Name = "Moni";
            this.Moni.Size = new System.Drawing.Size(56, 15);
            this.Moni.TabIndex = 1;
            this.Moni.Text = "Money: $";
            this.Moni.TextChanged += new System.EventHandler(this.Moni_TextChanged);
            this.Moni.Click += new System.EventHandler(this.Moni_Click);
            // 
            // ClickUp
            // 
            this.ClickUp.Location = new System.Drawing.Point(717, 194);
            this.ClickUp.Name = "ClickUp";
            this.ClickUp.Size = new System.Drawing.Size(77, 78);
            this.ClickUp.TabIndex = 2;
            this.ClickUp.Text = "Upgrade Click";
            this.ClickUp.UseVisualStyleBackColor = true;
            this.ClickUp.Click += new System.EventHandler(this.ClickUp_Click);
            // 
            // Auto1
            // 
            this.Auto1.Location = new System.Drawing.Point(44, 176);
            this.Auto1.Name = "Auto1";
            this.Auto1.Size = new System.Drawing.Size(81, 78);
            this.Auto1.TabIndex = 3;
            this.Auto1.Text = "AutoMoneyMachine mk1";
            this.Auto1.UseVisualStyleBackColor = true;
            this.Auto1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Interval1
            // 
            this.Interval1.Location = new System.Drawing.Point(405, 178);
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
            this.IntUpgCost.Location = new System.Drawing.Point(492, 244);
            this.IntUpgCost.Name = "IntUpgCost";
            this.IntUpgCost.Size = new System.Drawing.Size(80, 15);
            this.IntUpgCost.TabIndex = 6;
            this.IntUpgCost.Text = "Upgrade cost:";
            // 
            // Intinfo1
            // 
            this.Intinfo1.AutoSize = true;
            this.Intinfo1.Location = new System.Drawing.Point(492, 178);
            this.Intinfo1.Name = "Intinfo1";
            this.Intinfo1.Size = new System.Drawing.Size(92, 15);
            this.Intinfo1.TabIndex = 5;
            this.Intinfo1.Text = "Current interval:";
            // 
            // MoneyPTUpgrade
            // 
            this.MoneyPTUpgrade.AutoSize = true;
            this.MoneyPTUpgrade.Location = new System.Drawing.Point(131, 240);
            this.MoneyPTUpgrade.Name = "MoneyPTUpgrade";
            this.MoneyPTUpgrade.Size = new System.Drawing.Size(80, 15);
            this.MoneyPTUpgrade.TabIndex = 8;
            this.MoneyPTUpgrade.Text = "Upgrade cost:";
            // 
            // MoneyPT1
            // 
            this.MoneyPT1.AutoSize = true;
            this.MoneyPT1.Location = new System.Drawing.Point(131, 176);
            this.MoneyPT1.Name = "MoneyPT1";
            this.MoneyPT1.Size = new System.Drawing.Size(89, 15);
            this.MoneyPT1.TabIndex = 7;
            this.MoneyPT1.Text = "Money per tick:";
            // 
            // MoneyPTTxtBox1
            // 
            this.MoneyPTTxtBox1.Location = new System.Drawing.Point(226, 174);
            this.MoneyPTTxtBox1.Name = "MoneyPTTxtBox1";
            this.MoneyPTTxtBox1.Size = new System.Drawing.Size(100, 23);
            this.MoneyPTTxtBox1.TabIndex = 11;
            this.MoneyPTTxtBox1.TextChanged += new System.EventHandler(this.MoneyPT1_TextChanged);
            // 
            // AutoMoneyUpCost1
            // 
            this.AutoMoneyUpCost1.Location = new System.Drawing.Point(226, 236);
            this.AutoMoneyUpCost1.Name = "AutoMoneyUpCost1";
            this.AutoMoneyUpCost1.Size = new System.Drawing.Size(100, 23);
            this.AutoMoneyUpCost1.TabIndex = 12;
            // 
            // AutoIntTxtBox1
            // 
            this.AutoIntTxtBox1.Location = new System.Drawing.Point(590, 174);
            this.AutoIntTxtBox1.Name = "AutoIntTxtBox1";
            this.AutoIntTxtBox1.Size = new System.Drawing.Size(100, 23);
            this.AutoIntTxtBox1.TabIndex = 13;
            // 
            // IntUpCostTxtBox1
            // 
            this.IntUpCostTxtBox1.Location = new System.Drawing.Point(590, 242);
            this.IntUpCostTxtBox1.Name = "IntUpCostTxtBox1";
            this.IntUpCostTxtBox1.Size = new System.Drawing.Size(100, 23);
            this.IntUpCostTxtBox1.TabIndex = 14;
            // 
            // Buttonlvl
            // 
            this.Buttonlvl.AutoSize = true;
            this.Buttonlvl.Location = new System.Drawing.Point(726, 174);
            this.Buttonlvl.Name = "Buttonlvl";
            this.Buttonlvl.Size = new System.Drawing.Size(61, 15);
            this.Buttonlvl.TabIndex = 15;
            this.Buttonlvl.Text = "Button lvl:";
            this.Buttonlvl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonLvlTxtBox
            // 
            this.ButtonLvlTxtBox.Location = new System.Drawing.Point(793, 171);
            this.ButtonLvlTxtBox.Name = "ButtonLvlTxtBox";
            this.ButtonLvlTxtBox.Size = new System.Drawing.Size(100, 23);
            this.ButtonLvlTxtBox.TabIndex = 16;
            // 
            // AutoIntTimer1
            // 
            this.AutoIntTimer1.Tick += new System.EventHandler(this.AutoIntTimer_Tick);
            // 
            // IntUpCostTxtBox2
            // 
            this.IntUpCostTxtBox2.Location = new System.Drawing.Point(590, 352);
            this.IntUpCostTxtBox2.Name = "IntUpCostTxtBox2";
            this.IntUpCostTxtBox2.Size = new System.Drawing.Size(100, 23);
            this.IntUpCostTxtBox2.TabIndex = 26;
            // 
            // AutoIntTxtBox2
            // 
            this.AutoIntTxtBox2.Location = new System.Drawing.Point(590, 284);
            this.AutoIntTxtBox2.Name = "AutoIntTxtBox2";
            this.AutoIntTxtBox2.Size = new System.Drawing.Size(100, 23);
            this.AutoIntTxtBox2.TabIndex = 25;
            // 
            // AutoMoneyUpCost2
            // 
            this.AutoMoneyUpCost2.Location = new System.Drawing.Point(226, 346);
            this.AutoMoneyUpCost2.Name = "AutoMoneyUpCost2";
            this.AutoMoneyUpCost2.Size = new System.Drawing.Size(100, 23);
            this.AutoMoneyUpCost2.TabIndex = 24;
            // 
            // MoneyPTTxtBox2
            // 
            this.MoneyPTTxtBox2.Location = new System.Drawing.Point(226, 284);
            this.MoneyPTTxtBox2.Name = "MoneyPTTxtBox2";
            this.MoneyPTTxtBox2.Size = new System.Drawing.Size(100, 23);
            this.MoneyPTTxtBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Upgrade cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Money per tick:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Upgrade cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Current interval:";
            // 
            // Interval2
            // 
            this.Interval2.Location = new System.Drawing.Point(405, 288);
            this.Interval2.Name = "Interval2";
            this.Interval2.Size = new System.Drawing.Size(81, 82);
            this.Interval2.TabIndex = 18;
            this.Interval2.Text = "Tick interval For AMM 2";
            this.Interval2.UseVisualStyleBackColor = true;
            this.Interval2.Click += new System.EventHandler(this.Interval2_Click);
            // 
            // Auto2
            // 
            this.Auto2.Location = new System.Drawing.Point(44, 286);
            this.Auto2.Name = "Auto2";
            this.Auto2.Size = new System.Drawing.Size(81, 78);
            this.Auto2.TabIndex = 17;
            this.Auto2.Text = "AutoMoneyMachine mk2";
            this.Auto2.UseVisualStyleBackColor = true;
            this.Auto2.Click += new System.EventHandler(this.Auto2_Click);
            // 
            // AutoIntTimer2
            // 
            this.AutoIntTimer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntUpCostTxtBox3
            // 
            this.IntUpCostTxtBox3.Location = new System.Drawing.Point(590, 460);
            this.IntUpCostTxtBox3.Name = "IntUpCostTxtBox3";
            this.IntUpCostTxtBox3.Size = new System.Drawing.Size(100, 23);
            this.IntUpCostTxtBox3.TabIndex = 37;
            // 
            // AutoIntTxtBox3
            // 
            this.AutoIntTxtBox3.Location = new System.Drawing.Point(590, 392);
            this.AutoIntTxtBox3.Name = "AutoIntTxtBox3";
            this.AutoIntTxtBox3.Size = new System.Drawing.Size(100, 23);
            this.AutoIntTxtBox3.TabIndex = 36;
            // 
            // AutoMoneyUpCost3
            // 
            this.AutoMoneyUpCost3.Location = new System.Drawing.Point(226, 454);
            this.AutoMoneyUpCost3.Name = "AutoMoneyUpCost3";
            this.AutoMoneyUpCost3.Size = new System.Drawing.Size(100, 23);
            this.AutoMoneyUpCost3.TabIndex = 35;
            // 
            // MoneyPTTxtBox3
            // 
            this.MoneyPTTxtBox3.Location = new System.Drawing.Point(226, 392);
            this.MoneyPTTxtBox3.Name = "MoneyPTTxtBox3";
            this.MoneyPTTxtBox3.Size = new System.Drawing.Size(100, 23);
            this.MoneyPTTxtBox3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Upgrade cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Money per tick:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Upgrade cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Current interval:";
            // 
            // Interval3
            // 
            this.Interval3.Location = new System.Drawing.Point(405, 396);
            this.Interval3.Name = "Interval3";
            this.Interval3.Size = new System.Drawing.Size(81, 82);
            this.Interval3.TabIndex = 29;
            this.Interval3.Text = "Tick interval For AMM 3";
            this.Interval3.UseVisualStyleBackColor = true;
            this.Interval3.Click += new System.EventHandler(this.Interval3_Click);
            // 
            // Auto3
            // 
            this.Auto3.Location = new System.Drawing.Point(44, 394);
            this.Auto3.Name = "Auto3";
            this.Auto3.Size = new System.Drawing.Size(81, 78);
            this.Auto3.TabIndex = 28;
            this.Auto3.Text = "AutoMoneyMachine mk3";
            this.Auto3.UseVisualStyleBackColor = true;
            this.Auto3.Click += new System.EventHandler(this.Auto3_Click);
            // 
            // AutoIntTimer3
            // 
            this.AutoIntTimer3.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Clicker.Properties.Resources.capitalist;
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clicker.Properties.Resources.istockphoto_503589364_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IntUpCostTxtBox3);
            this.Controls.Add(this.AutoIntTxtBox3);
            this.Controls.Add(this.AutoMoneyUpCost3);
            this.Controls.Add(this.MoneyPTTxtBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Interval3);
            this.Controls.Add(this.Auto3);
            this.Controls.Add(this.IntUpCostTxtBox2);
            this.Controls.Add(this.AutoIntTxtBox2);
            this.Controls.Add(this.AutoMoneyUpCost2);
            this.Controls.Add(this.MoneyPTTxtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Interval2);
            this.Controls.Add(this.Auto2);
            this.Controls.Add(this.ButtonLvlTxtBox);
            this.Controls.Add(this.Buttonlvl);
            this.Controls.Add(this.IntUpCostTxtBox1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private TextBox IntUpCostTxtBox1;
        private Label Buttonlvl;
        private TextBox ButtonLvlTxtBox;
        private System.Windows.Forms.Timer AutoIntTimer1;
        private TextBox IntUpCostTxtBox2;
        private TextBox AutoIntTxtBox2;
        private TextBox AutoMoneyUpCost2;
        private TextBox MoneyPTTxtBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Interval2;
        private Button Auto2;
        private System.Windows.Forms.Timer AutoIntTimer2;
        private TextBox IntUpCostTxtBox3;
        private TextBox AutoIntTxtBox3;
        private TextBox AutoMoneyUpCost3;
        private TextBox MoneyPTTxtBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button Interval3;
        private Button Auto3;
        private System.Windows.Forms.Timer AutoIntTimer3;
        private PictureBox pictureBox1;
    }
}