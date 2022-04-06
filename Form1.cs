using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_UI_XDDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i gorf forgot to add", "goofy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wearedevs.net/");
        }

        private void exec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i gorf forgot to add", "goofy");
            Ad ad = new Ad();
            ad.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i gorf forgot to add", "goofy");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pornhub.com");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            int lp = 0;

            while (lp < 10)
            {
                await Task.Delay(7000);
                Ad ad = new Ad();
                ad.Show();
                lp++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i dont know how to make fornm sloe close*", "sorry");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i dont know how to make fornm minimise", "sorry");
        }
    }
}
