namespace Clicker
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash
        {
            set
            {
                cash = value;
                Moni.Text = "Cash: $" + value.ToString();
            }
            get
            {
                return cash;
            }
        }
        int buttonLevel;
        int AutoAmmount1;
        int AutoInterval1;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            AutoAmmount1 = 10;
            AutoInterval1 = 0;
            AutoIntTxtBox1.Text = AutoInterval1.ToString();
            MoneyPTTxtBox1.Text = AutoAmmount1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoAmmount1 * 10;
            AutoMoneyUpCost1.Text = upgradeCost.ToString();
            if (cash > upgradeCost)
            {
                AutoAmmount1 += 10;
                MoneyPTTxtBox1.Text = AutoAmmount1.ToString();
                Cash -= upgradeCost;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel - 1);
        }

        private void Interval_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoInterval1 * 100;
            IntUpCostTxtBox.Text = upgradeCost.ToString();
            if (Cash >= upgradeCost)
            {
                AutoInterval1++;
                AutoIntTxtBox1.Text = AutoInterval1.ToString();
                AutoIntTimer1.Interval = (int)Math.Ceiling((double)((60 / AutoInterval1) * 100 + float.Epsilon));
                if (!AutoIntTimer1.Enabled)
                    AutoIntTimer1.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void ClickUp_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                ButtonLvlTxtBox.Text = buttonLevel.ToString();
                Cash -= upgradeCost;

                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                Click.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutoIntTimer_Tick(object sender, EventArgs e)
        {
            Cash += AutoInterval1;
        }

        private void MoneyPT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttnUpgCostTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}