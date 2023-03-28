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
        Form1 form1;
        public static string Game_Name = "";
        public static string Genre = "";
        public static string Publisher = "";
        public static string Price = "";
        public static string Data = "";

        public Form2(Form1 form2)
        {
            InitializeComponent();
            this.form1 = form2;
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

            form1.complete.Add(new Complete() { Name = textBox1.Text, Genre = textBox2.Text, Publisher = textBox3.Text, Price = textBox4.Text, Data = textBox5.Text });
                /*complete.Genre = textBox2.Text;
                complete.Publisher = textBox3.Text;
                complete.Price = textBox4.Text;
                complete.Data = textBox5.Text;
                form1.AddRow(complete.Name, complete.Genre, complete.Publisher, complete.Price, complete.Data);*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
