using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox9.Text == "")
            {
                MessageBox.Show("Please Enter Id!!");
                return;
            }
            string path = "D:\\Visual Studio 2022\\Files_IO\\";


            
            //For First Name
            string fn = path + this.textBox9.Text + "_firstName.txt";
            if (System.IO.File.Exists(fn))
            {
                //======================================
                // For id
                this.textBox1.Text = this.textBox9.Text;
                //=======================================
                this.textBox2.Text = System.IO.File.ReadAllText(fn);
                // For Last Name
                string ln = path + this.textBox9.Text + "_LastName.txt";
                this.textBox3.Text = System.IO.File.ReadAllText(ln);
                // For Telephone
                string tel = path + this.textBox9.Text + "_Telephone.txt";
                this.textBox4.Text = System.IO.File.ReadAllText(tel);
                // For Cell Number
                string cell = path + this.textBox9.Text + "_cellNumber.txt";
                this.textBox5.Text = System.IO.File.ReadAllText(cell);
                // For Email
                string email = path + this.textBox9.Text + "_Email.txt";
                this.textBox6.Text = System.IO.File.ReadAllText(email);
                // For Address
                string address = path + this.textBox9.Text + "_Address.txt";
                this.textBox7.Text = System.IO.File.ReadAllText(address);
                // For Comment
                string comm = path + this.textBox9.Text + "_Comment.txt";
                this.textBox8.Text = System.IO.File.ReadAllText(comm);

                MessageBox.Show("Searched Successfully!!1");
            }
            else
            {
                MessageBox.Show("Invalid Id");
            }
        }
    }
}
