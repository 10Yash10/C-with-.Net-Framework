namespace phone_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            About_us about = new About_us();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}