using System.Media;
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
        int AutoAmmount2;
        int AutoAmmount3;
        int AutoInterval1;
        int AutoInterval2;
        int AutoInterval3;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            AutoAmmount1 = 10;
            AutoAmmount2 = 100;
            AutoAmmount3 = 1000;
            AutoInterval1 = 1;
            AutoInterval2 = 1;
            AutoInterval3 = 1;
            AutoIntTxtBox1.Text = AutoInterval1.ToString();
            AutoIntTxtBox2.Text = AutoInterval2.ToString();
            AutoIntTxtBox3.Text = AutoInterval3.ToString();
            MoneyPTTxtBox1.Text = AutoAmmount1.ToString();
            MoneyPTTxtBox2.Text = AutoAmmount2.ToString();
            MoneyPTTxtBox3.Text = AutoAmmount3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoAmmount1 * 10;
            AutoMoneyUpCost1.Text = upgradeCost.ToString();
            if (cash >= upgradeCost)
            {
                Auto1.Enabled = true;
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
            IntUpCostTxtBox1.Text = upgradeCost.ToString();
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
            Cash += AutoAmmount1;
        }

        private void MoneyPT1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Auto2_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoAmmount2 * 100;
            AutoMoneyUpCost2.Text = upgradeCost.ToString();
            if (cash >= upgradeCost)
            {
                AutoAmmount2 += 100;
                MoneyPTTxtBox2.Text = AutoAmmount2.ToString();
                Cash -= upgradeCost;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cash += AutoAmmount2;
        }

        private void Interval2_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoInterval2 * 1000;
            IntUpCostTxtBox2.Text = upgradeCost.ToString();
            if (Cash >= upgradeCost)
            {
                AutoInterval2++;
                AutoIntTxtBox2.Text = AutoInterval2.ToString();
                AutoIntTimer2.Interval = (int)Math.Ceiling((double)((60 / AutoInterval2) * 100 + float.Epsilon));
                if (!AutoIntTimer2.Enabled)
                    AutoIntTimer2.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void Auto3_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoAmmount3 * 1000;
            AutoMoneyUpCost3.Text = upgradeCost.ToString();
            if (cash >= upgradeCost)
            {
                AutoAmmount3 += 1000;
                MoneyPTTxtBox3.Text = AutoAmmount3.ToString();
                Cash -= upgradeCost;
            }
        }

        private void Interval3_Click(object sender, EventArgs e)
        {
            int upgradeCost = AutoInterval3 * 10000;
            IntUpCostTxtBox3.Text = upgradeCost.ToString();
            if (Cash >= upgradeCost)
            {
                AutoInterval3++;
                AutoIntTxtBox3.Text = AutoInterval3.ToString();
                AutoIntTimer3.Interval = (int)Math.Ceiling((double)((60 / AutoInterval3) * 100 + float.Epsilon));
                if (!AutoIntTimer3.Enabled)
                    AutoIntTimer3.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Cash += AutoAmmount3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer Music = new SoundPlayer(Properties.Resources.song);
            Music.PlayLooping();
        }
    }
}