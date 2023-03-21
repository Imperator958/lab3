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
            Form2 form2 = new Form2(this);
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
            /*if (Form2.Game_Name == "" && Form2.Genre == "" && Form2.Publisher == "" && Form2.Prize == "" && Form2.Data == "")
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
                    Form2.Game_Name = "";
                    Form2.Genre = "";
                    Form2.Publisher = "";
                    Form2.Prize = "";
                    Form2.Data = "";

            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {

        }

        public void AddRow(string Name, string Genre, string Publisher, string Price, string Data)
        {
            dataGridView1.Rows.Add(Name, Genre, Publisher, Price, Data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Zapisanie danych do pliku nie by³o mo¿liwe!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv);
                            MessageBox.Show("Wyeksportowane dane do pliku!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Blad:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak danych do wyeksportowania!", "Info");
            }
        }
        void readFile()
        {
            var lines = File.ReadAllLines(@"C:\Users\HP\OneDrive\Pulpit\Visual_Studio\lab4\lab4\bin\Debug\net6.0-windows\Output.csv");
            foreach (var line in lines)
            {
                var cell = line.Split(',');
                if (cell.Length == 6)
                {
                    
                    var load = new Complete() { Name = cell[0], Genre = cell[1], Publisher = cell[2], Price = cell[3], Data = cell[4] };
                    dataGridView1.Rows.Add(load.Name, load.Genre, load.Publisher, load.Price, load.Data);
                }
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.RowCount-2);
            dataGridView1.Rows.RemoveAt(0);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            readFile();
        }
    }
}