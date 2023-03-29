using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form3 : Form
    {
        private BindingList<Complete> listform3 = new BindingList<Complete>();
        public Form3(BindingList<Complete> dane)
        {
            InitializeComponent();
            listform3 = dane;
            dataGridView1.DataSource = listform3;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                dataGridView1.DataSource = listform3;
                return;
            }
            BindingList<Complete> temp = new BindingList<Complete>();
            temp = listform3;
            string pattern = @"^.*" + textBox2.Text + @".*$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            BindingList<Complete> filtered = new BindingList<Complete>(temp.Where(x => r.IsMatch(x.ToString())).ToList<Complete>());
            dataGridView1.DataSource = filtered;

            /*try
            {
                string Filter = textBox2.Text.Trim().Replace("'","''");
                dataGridView1.DataSource = new BindingList<Complete>(listform3.Where(m => m.Contains(Filter)).ToList<Complete>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
