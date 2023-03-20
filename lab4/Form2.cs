using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        public static string Game_Name = " ";
        public static string Genre = " ";
        public static string Publisher = " ";
        public static string Prize = " ";
        public static string Data = " ";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_Name = textBox1.Text;
            Genre = textBox2.Text;
            Publisher = textBox3.Text;
            Prize = textBox4.Text;
            Data = textBox5.Text;
        }
    }
}
