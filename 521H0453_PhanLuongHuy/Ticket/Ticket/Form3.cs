using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            button1.Hide();
            button2.Hide();
            pictureBox1.Show();
            buttonBack.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label2.Hide();
            buttonBack.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            button1.Hide();
            button2.Hide();
            label2.Show();
            buttonBack.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label2.Hide();
            label1.Show();
            button1.Show();
            button2.Show();
            buttonBack.Hide();
        }
    }
}
