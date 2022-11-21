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
    public partial class Uchebniy_Plan : Form
    {

        public Uchebniy_Plan()
        {
            InitializeComponent();
            
        }
        

        public static string conect = "Data Source=62.78.81.19;Initial Catalog=PZKUP;User ID=stud;Password=123456789";
        public SqlConnection SqlConnection = new SqlConnection(conect);
        private void select(string SqlAdapter)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlAdapter, conect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uchebbniy_Plan_Search sf = new Uchebbniy_Plan_Search();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comand = @"select Название, курс, семестр, Тип_дисциплины, Полное, Количество_часов from Учебный_план, Специальности, Дисциплины
where Специальности.код_специальности = Учебный_план.Код_специальности 
and Дисциплины.Код = Учебный_план.Код_дисциплины";
            select(comand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string scrptq = $@" select [название],[Курс],[Семестр],[Тип_дисциплины],[Полное],[Количество_часов] from [dbo].[Специальности],[dbo].[Учебный_план],[dbo].[Дисциплины] where [dbo].[Учебный_план].Код_дисциплины=[dbo].[Дисциплины].Код and [dbo].[Учебный_план].[Код_специальности]=[dbo].[Специальности].код_специальности and Название like '%" + textBox1.Text + "%'";
                ;

                SqlConnection = new SqlConnection(conect);
                SqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(scrptq, conect);
                DataSet db = new DataSet();

                sqlDataAdapter.Fill(db);

                dataGridView1.DataSource = db.Tables[0];

                



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox1.Text}%'";

            }

            if (radioButton2.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Тип_дисциплины LIKE '%{textBox1.Text}%'";
            }

            if (radioButton3.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Полное LIKE '%{textBox1.Text}%'";
            }
        }


       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Uchebniy_Plan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();

        }
    }
}
