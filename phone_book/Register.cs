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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.groupBox1.Enabled = true;
            //-------------------------------------
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.toolStripButton2.Enabled = false;
            this.toolStripButton1.Enabled = true;
            this.groupBox1.Enabled = false;
            //-------------------------------------
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Id!!");
                return;
            }
            string path = "D:\\Visual Studio 2022\\Files_IO\\";

            // For First Name
            string fn = path + this.textBox1.Text + "_firstName.txt";
            System.IO.File.WriteAllText(fn, this.textBox2.Text);
            // For Last Name
            string ln = path + this.textBox1.Text + "_LastName.txt";
            System.IO.File.WriteAllText(ln, this.textBox3.Text);
            // For Telephone
            string tel = path + this.textBox1.Text + "_Telephone.txt";
            System.IO.File.WriteAllText(tel, this.textBox4.Text);
            // For Cell Number
            string cell = path + this.textBox1.Text + "_cellNumber.txt";
            System.IO.File.WriteAllText(cell, this.textBox5.Text);
            // For Email
            string email = path + this.textBox1.Text + "_Email.txt";
            System.IO.File.WriteAllText(email, this.textBox6.Text);
            // For Address
            string address = path + this.textBox1.Text + "_Address.txt";
            System.IO.File.WriteAllText(address, this.textBox7.Text);
            // For Comment
            string comm = path + this.textBox1.Text + "_Comment.txt";
            System.IO.File.WriteAllText(comm, this.textBox8.Text);

            MessageBox.Show("Saved Successfully!!1");
        }
    }
}
