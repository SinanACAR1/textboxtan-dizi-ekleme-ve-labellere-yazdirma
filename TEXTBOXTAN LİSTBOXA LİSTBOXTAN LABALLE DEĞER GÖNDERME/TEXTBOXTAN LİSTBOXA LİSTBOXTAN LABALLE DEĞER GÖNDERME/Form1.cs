using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
           
            textBox1.Clear();
            textBox1.Focus();
        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items[sayac].ToString();
            sayac++;
        }
    }
}
