using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_17_18_для_делда
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            this.Show();
            MyForm2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            this.Show();
            MyForm3.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            this.Show();
            MyForm4.Close();
        }
    }
}
