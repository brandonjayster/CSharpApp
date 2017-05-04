using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//allows for socket programming
namespace WhtsMyIP
{
    public partial class Form1 : Form// .net form
    {
        public Form1()// soruce code for form
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// send button to process request for the ip host entred into text box
        {
            try
            {
                IPHostEntry hostname = Dns.GetHostEntry(textBox1.Text);// enter is computer name or website
                IPAddress[] ip = hostname.AddressList;//finds address
                textBox2.Text = ip[0].ToString();// display ip address
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
