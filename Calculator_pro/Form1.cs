namespace Calculator_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + ".";
        }



        private void button13_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "";
            this.label2.Text = this.label1.Text;
            this.label1.ResetText();
            this.label3.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label3.Text = "+";
            if(this.label1.Text != "")
            {
                this.label2.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.label3.Text = "-";
            if (this.label1.Text != "")
            {
                this.label2.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label3.Text = "x"; if (this.label1.Text != "")
            {
                this.label2.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label3.Text = "%"; if (this.label1.Text != "")
            {
                this.label2.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            double.TryParse(this.label2.Text, out num1);
            double.TryParse(this.label1.Text, out num2);

            if (this.label3.Text == "+")
            {
                this.label1.Text = (num1 + num2).ToString();
            }
            if (this.label3.Text == "-")
            {
                this.label1.Text = (num1 - num2).ToString();
            }
            if (this.label3.Text == "x")
            {
                this.label1.Text = (num1 * num2).ToString();
            }
            if (this.label3.Text == "%")
            {
                this.label1.Text = (num1 / num2).ToString();
            }
        }
    }
}