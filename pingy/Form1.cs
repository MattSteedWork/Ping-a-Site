using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace pingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string s;
            string tb;
            s = textBox1.Text;

            tb = textBox2.Text;
            int t = int.Parse(tb);

             
                for (int i = 0; i < t; i++)
                {
                Ping p = new Ping();
                PingReply r;
                r = p.Send(s);
                if (r.Status == IPStatus.Success)
                    {
                    lblResult.Text += "Ping to " +"www." + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    }
                }
           
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "")
            {
                MessageBox.Show("Please use valid IP or web address!!");
            }
        }
    
    }
}