using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp8
{
    public partial class PoiskForm : Form
    {
        public PoiskForm()
        {
            InitializeComponent();
        }

        string conect = "Data Source=62.78.81.19;Initial Catalog=PZKUP;User ID=stud;Password=123456789";
        private void select(string SqlAdapter)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlAdapter, conect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

            private void PoiskForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pZKUPDataSet5.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.pZKUPDataSet5.Преподаватели);
            dataGridView1.AutoResizeColumns();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comand = @"select фио, дата_рождения, адрес, телефон , название, председатель from Преподаватели, ПЦК
where пцк = номер_пцк";
            select(comand);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox1.Text}%'";
            }
            if (radioButton2.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Адрес LIKE '%{textBox1.Text}%'";
            }
            if (radioButton3.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"фио LIKE '%{textBox1.Text}%'";
            }
            if (radioButton4.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Председатель LIKE '%{textBox1.Text}%'";
            }
        }
    }
}
