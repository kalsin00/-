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
    public partial class Tarifikaciya : Form
    {


        public Tarifikaciya()
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

        private void Tarifikaciya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pZKUPDataSet8.Учебный_план". При необходимости она может быть перемещена или удалена.
            this.учебный_планTableAdapter.Fill(this.pZKUPDataSet8.Учебный_план);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pZKUPDataSet7.Тарификация". При необходимости она может быть перемещена или удалена.
            this.тарификацияTableAdapter.Fill(this.pZKUPDataSet7.Тарификация);
            dataGridView1.AutoResizeColumns();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarifikaciya_Search sf = new Tarifikaciya_Search();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comand = @"select группа, полное, фио, Отделение from Тарификация, Группы, Учебный_план, Преподаватели, Дисциплины
where Тарификация.Код_группы = Группы.код_группы and Преподаватели.код_преподавателя = Тарификация.Код_преподавателя
and Тарификация.Код_учебного_плана = Учебный_план.Код_учебного_плана and Учебный_план.Код_дисциплины = Дисциплины.Код";
            select(comand);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Полное LIKE '%{textBox1.Text}%'";
            }
            if (radioButton2.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Группа LIKE '%{textBox1.Text}%'";
            }
            if (radioButton3.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"фио LIKE '%{textBox1.Text}%'";
            }
        }
    }
}
