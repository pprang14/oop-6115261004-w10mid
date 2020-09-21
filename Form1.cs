using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261004_w11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nametitle = textBox1.Text;
            string FName = textBox2.Text;
            string LName = textBox3.Text;
            string Projectname = textBox4.Text;
            string Page = textBox5.Text;
            string place = textBox6.Text;
            string Date = textBox7.Text;
            string Quality = textBox8.Text;
            string weight = textBox9.Text;
            label10.Text = textBox1.Text + " / "+ textBox2.Text + " / "+ textBox3.Text + " / " + textBox4.Text + " / " + textBox5.Text + " / "
                + " / " + textBox6.Text + " / " + textBox7.Text + " / " + textBox8.Text + " / " + textBox9.Text;
        }
    }
}
