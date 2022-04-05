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
        int upgradecost1;
        int upgradecost2;
        int upgradecost3;
        int upgradecost4;
        int upgradecost5;
        int upgradecost6;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            AutoAmmount1 = 1;
            AutoAmmount2 = 10;
            AutoAmmount3 = 100;
            AutoInterval1 = 1;
            AutoInterval2 = 1;
            AutoInterval3 = 1;
            AutoIntTxtBox1.Text = AutoInterval1.ToString();
            AutoIntTxtBox2.Text = AutoInterval2.ToString();
            AutoIntTxtBox3.Text = AutoInterval3.ToString();
            MoneyPTTxtBox1.Text = AutoAmmount1.ToString();
            MoneyPTTxtBox2.Text = AutoAmmount2.ToString();
            MoneyPTTxtBox3.Text = AutoAmmount3.ToString();
            Auto1.Enabled = false;
            Auto2.Enabled = false;
            Auto3.Enabled = false;
            Interval1.Enabled = false;
            Interval2.Enabled = false;
            Interval3.Enabled = false;
            upgradecost1 = 1;
            upgradecost2 = 1;
            upgradecost3 = 100;
            upgradecost4 = 100;
            upgradecost5 = 10000;
            upgradecost6 = 10000;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            upgradecost1 = AutoAmmount1 * 10;
            AutoMoneyUpCost1.Text = upgradecost1.ToString();
            if (cash >= upgradecost1)
            {
                Auto1.Enabled = true;
                AutoAmmount1 += 10;
                MoneyPTTxtBox1.Text = AutoAmmount1.ToString();
                Cash -= upgradecost1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel - 1);
        }

        private void Interval_Click(object sender, EventArgs e)
        {
            upgradecost2 = AutoInterval1 * 100;
            IntUpCostTxtBox1.Text = upgradecost2.ToString();
            if (Cash >= upgradecost2)
            {
                AutoInterval1++;
                AutoIntTxtBox1.Text = AutoInterval1.ToString();
                AutoIntTimer1.Interval = (int)Math.Ceiling((double)((60 / AutoInterval1) * 100 + float.Epsilon));
                if (!AutoIntTimer1.Enabled)
                    AutoIntTimer1.Enabled = true;
                Cash -= upgradecost2;
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
            upgradecost3 = AutoAmmount2 * 10;
            AutoMoneyUpCost2.Text = upgradecost3.ToString();
            if (cash >= upgradecost3)
            {
                AutoAmmount2 += 100;
                MoneyPTTxtBox2.Text = AutoAmmount2.ToString();
                Cash -= upgradecost3;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cash += AutoAmmount2;
        }

        private void Interval2_Click(object sender, EventArgs e)
        {
            upgradecost4 = AutoInterval2 * 100;
            IntUpCostTxtBox2.Text = upgradecost4.ToString();
            if (Cash >= upgradecost4)
            {
                AutoInterval2++;
                AutoIntTxtBox2.Text = AutoInterval2.ToString();
                AutoIntTimer2.Interval = (int)Math.Ceiling((double)((60 / AutoInterval2) * 100 + float.Epsilon));
                if (!AutoIntTimer2.Enabled)
                    AutoIntTimer2.Enabled = true;
                Cash -= upgradecost4;
            }
        }

        private void Auto3_Click(object sender, EventArgs e)
        {
            upgradecost5 = AutoAmmount3 * 10;
            AutoMoneyUpCost3.Text = upgradecost5.ToString();
            if (cash >= upgradecost5)
            {
                AutoAmmount3 += 1000;
                MoneyPTTxtBox3.Text = AutoAmmount3.ToString();
                Cash -= upgradecost5;
            }
        }

        private void Interval3_Click(object sender, EventArgs e)
        {
            upgradecost6 = AutoInterval3 * 100;
            IntUpCostTxtBox3.Text = upgradecost6.ToString();
            if (Cash >= upgradecost6)
            {
                AutoInterval3++;
                AutoIntTxtBox3.Text = AutoInterval3.ToString();
                AutoIntTimer3.Interval = (int)Math.Ceiling((double)((60 / AutoInterval3) * 100 + float.Epsilon));
                if (!AutoIntTimer3.Enabled)
                    AutoIntTimer3.Enabled = true;
                Cash -= upgradecost6;
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

        private void Moni_Click(object sender, EventArgs e)
        {

        }

        private void Moni_TextChanged(object sender, EventArgs e)
        {
            if (upgradecost1 <= Cash)
            {
                Auto1.Enabled = true;
            } else
            {
                Auto1.Enabled=false;
            }
            if (upgradecost2 <= Cash)
            {
                Interval1.Enabled = true;
            }
            else
            {
                Interval1.Enabled = false;
            }
            if (upgradecost3 <= Cash)
            {
                Auto2.Enabled = true;
            }
            else
            {
                Auto2.Enabled = false;
            }
            if (upgradecost4 <= Cash)
            {
                Interval2.Enabled = true;
            }
            else
            {
                Interval2.Enabled = false;
            }
            if (upgradecost5 <= Cash)
            {
                Auto3.Enabled = true;
            }
            else
            {
                Auto3.Enabled = false;
            }
            if (upgradecost6 <= Cash)
            {
                Interval3.Enabled = true;
            }
            else
            {
                Interval3.Enabled = false;
            }
        }
    }
}