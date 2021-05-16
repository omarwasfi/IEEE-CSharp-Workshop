using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_Five
{
    public partial class Form1 : Form
    {
        List<string> Names = new List<string>();
        List<int> PhoneNum = new List<int>();
        List<string> Address = new List<string>();
        List<DateTime> DateTime = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
           dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
           // dateTimePicker1.ShowUpDown = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            DialogResult dr = MessageBox.Show("Are You Sure you want to update the lists?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Names.Add(textBox1.Text);
                PhoneNum.Add(Convert.ToInt32(textBox2.Text));
                Address.Add(textBox3.Text);
                DateTime.Add(dateTimePicker1.Value);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i =0; i< dataGridView1.Columns.Count; i++)
            {
                if(dataGridView1.Columns[i].HeaderText == "Name")
                {
                    for ( int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for ( int j = 0; j< Names.Count; j++)
                        {
                            if(k ==j)
                            dataGridView1.Rows[k].Cells[0].Value = Names[j];

                        }
                    }
                }
                if (dataGridView1.Columns[i].HeaderText == "Phone Number")
                {
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for (int j = 0; j < PhoneNum.Count; j++)
                        {
                            if (k == j)
                                dataGridView1.Rows[k].Cells[1].Value = PhoneNum[j];

                        }
                    }
                }
                if (dataGridView1.Columns[i].HeaderText == "Address")
                {
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for (int j = 0; j < Address.Count; j++)
                        {
                            if (k == j)
                                dataGridView1.Rows[k].Cells[2].Value = Address[j];

                        }
                    }
                }
                if (dataGridView1.Columns[i].HeaderText == "Date and time")
                {
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for (int j = 0; j < DateTime.Count; j++)
                        {
                            if (k == j)
                                dataGridView1.Rows[k].Cells[3].Value = DateTime[j];

                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
        }
    }
}
