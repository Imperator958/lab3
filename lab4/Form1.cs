namespace lab4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                catch(System.InvalidOperationException)
                {
                    MessageBox.Show("Nie mo¿na usun¹æ pierwszego wiersza!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Form2.Game_Name == " " && Form2.Genre == " " && Form2.Publisher == " " && Form2.Prize == " " && Form2.Data == " ")
            {
                ;
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Form2.Game_Name;
                row.Cells[1].Value = Form2.Genre;
                row.Cells[2].Value = Form2.Publisher;
                row.Cells[3].Value = Form2.Prize;
                row.Cells[4].Value = Form2.Data;
                dataGridView1.Rows.Add(row);

            }
        }
    }
}