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
    public partial class Form1 : Form
    {

        string conect = "Data Source=62.78.81.19;Initial Catalog=PZKUP;User ID=stud;Password=123456789";
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void select(string SqlAdapter)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlAdapter, conect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void вывестиВсеЗаписиТаблицыПреподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string comand = "Select * from Преподаватели";
            select(comand);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void вывестиФамилииИменаИОтчестваПреподавателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фамилия,имя, отчество from Преподаватели";
            select(comand);
        }

        private void вывестиФамилииИменаИОтчестваПреподавателейОтсортироватьПоПолюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фамилия,имя, отчество from Преподаватели order by фамилия";
            select(comand);
        }

        private void вывестиВсеЗаписиИзТаблицыУчебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_План";
            select(comand);
        }

        private void вывестиВсеЗаписиИзТаблицыУчебныйПланПриУсловииКоличествоЧасовРавно10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_План where Количество_часов = 10";
            select(comand);
        }

        private void вывестиЗаписиЕслиКоличествоЧасовОт30До60ОтсортироватьПоПолюКоличествочасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_План where Количество_часов BETWEEN 30 and 60 order by Количество_часов ";
            select(comand);
        }

        private void выведитеВывестиЗаписиЕслиКоддисциплиныРавен8156711ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_план
             where Код_дисциплины = 8 or Код_дисциплины = 156 or Код_дисциплины =  7 or Код_дисциплины = 11";
            select(comand);
        }

        private void вывестиПолеКодучебногопланаЕслиСеместрРавен4ИКоддисциплиныНаходитсяВПромежуткиОт3До6ВключительноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Код_учебного_плана from Учебный_план
                                                                        where Семестр = 4 and Код_дисциплины BETWEEN  3 and 6";
            select(comand);
        }

        private void вывестиЗаписиОтсортированныеПоКоличествуЧасовЕслиВТипеДисциплиныВтораяБукваАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_план
                                                     where Тип_дисциплины like '_а%'
                                                                                  order by Количество_часов";
            select(comand);
        }

        private void вывестиЗаписиОтсортированныйСписокПоПолюКоличествочасовПоУбываниюЕслиВКоличествеЧасовСодержитсяХотяБыОднаЦифраОт7До9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_план
                                                      where Количество_часов like '%7%' or Количество_часов like '%8%' or Количество_часов like '%9%'
                                                                        order by Количество_часов desc";
            select(comand);
        }

        private void вывестиЗаписиЕслиКоддисциплиныРавен7712247816339574ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select *from Учебный_план
            where Код_дисциплины in (77,12,24,78,163,39,5,74)";
            select(comand);
        }

        private void вывестиКоличествоЗаписейВТаблицеУчебныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select count(*) as Количество_записей_втаблице from Учебный_план";
            select(comand);
        }

        private void вывестиСуммуЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select sum(Количество_часов) as Сумма from Учебный_план";
            select(comand);
        }

        private void вывестиМинимальноеКоличествоЧасовОтводимоеНаДисциплинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select min(Количество_часов) as Минимальное from Учебный_план";
            select(comand);
        }

        private void вывестиСреднееЗначениеПоПолюКоличествоЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select avg(Количество_часов) as Среднее from Учебный_план";
            select(comand);
        }

        private void посчитатьКоличествоЧасовОтводимыхНа2КурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select sum(Количество_часов) as Количество_часов from Учебный_план where Курс = 2";
            select(comand);

        }

        private void вывестиКоличествоЧасовОтведенныхНаКаждыйКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Курс, sum (Количество_часов) as Количество_часов from Учебный_план group by Курс";
            select(comand);
        }

        private void вывестиКоличествоЧасовОтводимыхНаКаждыйСеместрКаждойСпециальностиОтсортироватьПоКодуСпециальностиАВнутриПоКурсуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Код_специальности, Курс,   sum (Количество_часов) as Количество_часов from Учебный_план group by Код_специальности, Курс order by Код_специальности";
            select(comand);
        }

        private void напишитеЗапросПозволяющийВыводитьИнформациюОПреподавателяхВСледующемВидеЗдравствуйтеЯФамилияИмяОтчествоПроживаюПоАдресуАдресМойКонтактныйНомерТелефонаТелефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select 'Здраввствуйте, Я ', Фамилия, Имя, отчество, '.Проживаю по адресу -', адрес, 'мой контактный номер телефона –', телефон from Преподаватели";
            select(comand);
        }

        private void выведитеТужеИнформациюНоВОдинСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select 'Здраввствуйте, Я '+ Фамилия + ' '+ Имя + ' ' +  отчество + '. ' + 'Проживаю по адресу -' + ' ' + адрес + ' ' +  'мой контактный номер телефона –' + ' ' + телефон from Преподаватели";
            select(comand);
        }

        private void вывестиФамилииИменаОтчестваПреподавателейАТакЖеНазваниеПцкИПредседателяПцкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фио,название, председатель from Преподаватели,ПЦК where номер_пцк = пцк";
            select(comand);
        }

        private void вывестиНазваниеГруппыКлассногоРуководителяФинансированиеАудиториюКотораяЗакрепленаЗаГруппойИЗавкабинетаОтсортировавПоЗавкабинетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select группа, классный_руководитель, финансирование, аудитория, руководитель from группы,Аудитория where  группы.код_аудитории = Аудитория.код_аудитории order by руководитель";
            select(comand);
        }

        private void вывестиНазваниеГруппыКлассногоРуководителяФинансированиеВсеАудиторииДажеЕслиЗаНейНеЗакрепленаГруппаИЗавкабинетаОтсортировавПоЗавкабинетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select группа, классный_руководитель, финансирование, аудитория, руководитель from группы full join Аудитория on группы.код_аудитории = Аудитория.код_аудитории order by руководитель";
            select(comand);
        }

        private void вывестиСписокГруппСпециальностиИАудиторииЗакрепленныеЗаГруппойОтсортироватьПоГруппеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select  группа, Специальности.название, аудитория from группы, Аудитория, Специальности where группы.код_аудитории = Аудитория.код_аудитории and Специальности.код = Группы.код_специальности order by группа";
            select(comand);
        }

        private void вывестиСписокГруппСпециальностиИАудиторииЗакрепленныеЗаГруппойЕслиСпециальностьСокращенноТПОтсортироватьПоГруппеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select  группа, Специальности.название, аудитория from группы, Аудитория, Специальности where сокращенно = 'ТП' and  группы.код_аудитории = Аудитория.код_аудитории and Специальности.код = Группы.код_специальности order by группа";
            select(comand);
        }

        private void выведитеУчебныйПланИСоответствующиеДисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select   *from Учебный_план, Дисциплины where Код_дисциплины = Код";
            select(comand);
        }

        private void вывестиУчебныйПланПоДисциплинеРиЭУБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select   *from Учебный_план, Дисциплины where Код_дисциплины = Код and Для_подгруппы = 'РиЭУБД'";
            select(comand);
        }

        private void вывестиСписокЛекцийЕслиКодСпециальностиРавен2КурсРавен2КоличествоЧасовБольше50ВыполнивОбратнуюСортировкуПоНаименованиюДисциплинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Код_дисциплины, Курс, Тип_дисциплины,Полное, Количество_часов  from Учебный_план, Дисциплины where Код_дисциплины = Код and Тип_дисциплины = 'Лекция'  and Код_специальности = 2 and Курс = 2  and Количество_часов > 50 order by Полное desc";
            select(comand);
        }

        private void вывестиОтсортированныйСписокДисциплинНаКоторыеНеСоставленУчебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Полное from Учебный_план  full join  Дисциплины on Код_дисциплины = Код where Количество_часов is null order by Полное";
            select(comand);
        }

        private void вывестиКурсСеместрТипДисциплиныКоличествоЧасовНазваниеДисциплиныИСпециальностиПолученныеЗаписиОтсортироватьПоКоличествуЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select Курс, Семестр, Тип_дисциплины, Количество_часов, Полное, название  from Учебный_план, Дисциплины, Специальности where Код_дисциплины = Дисциплины.Код and Специальности.код_специальности = Учебный_план.Код_специальности order by Количество_часов";
            select(comand);
        }

        private void вывестиСписокДисциплинПреподаваемыхДляСпециальности030503На6СеместреПолученныйСписокОтсортироватьПоДисциплинамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select название, Полное  from Учебный_план, Дисциплины, Специальности where Код_дисциплины = Дисциплины.Код and Специальности.код_специальности = Учебный_план.Код_специальности  and Специальности.код = 030503 and Семестр = 6 order by Полное";
            select(comand);
        }

        private void вывестиНеПовторяющийсяОтсортированныйСписокДисциплинИСпециальностейПриУсловииЧтоПерваяБукваДисциплиныМожетБытьЛюбойВПромежуткеАлфавитаОтТДоЯАПоследняяОтАДоСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select distinct Полное, Специальности.код  from Учебный_план, Дисциплины, Специальности where Код_дисциплины = Дисциплины.Код and Специальности.код_специальности = Учебный_план.Код_специальности and Полное  LIKE '[Т-Я]%' and Полное LIKE '%[А-С]' ";
            select(comand);
        }

        private void вывестиОтсортированныйСписокГруппДляКоторыхНеСоставленаТарификационнаяСеткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select группа from Группы Full join Тарификация on Группы.код_группы = Тарификация.Код_группы where Код_тарификации is null";
            select(comand);
        }

        private void дляВсехГруппВыяснитьКакиеПреподавателиБудетВестиУНихДисциплиныПолученныйСписокОтсортироватьПоГруппамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select distinct группа, фио from Группы, Тарификация, Преподаватели where Группы.код_группы = Тарификация.Код_группы and Тарификация.Код_преподавателя = Преподаватели.код_преподавателя order by группа";
            select(comand);
        }

        private void еслиТакПолучилосьЧтоКлассныйРуководительВедетДисциплиныУСвоейГруппыТоВывестиГруппуИКлассногоРуководителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select distinct группа, фио from Группы, Тарификация, Преподаватели where Группы.код_группы = Тарификация.Код_группы and Тарификация.Код_преподавателя = Преподаватели.код_преподавателя and классный_руководитель = фио";
            select(comand);
        }

        private void вывестиСписокПреподавателейВыяснивКакиеДисциплиныОнВедетСколькоЧасовОтводитсяНаКаждуюДисциплинуАТакЖеТипДисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фио, Тип_дисциплины, полное, Количество_часов from Группы, Учебный_план, Тарификация, Дисциплины, Преподаватели where Группы.код_группы = Тарификация.Код_группы and Тарификация.Код_преподавателя = Преподаватели.код_преподавателя and Учебный_план.Код_дисциплины = Дисциплины.Код and Тарификация.Код_учебного_плана = Учебный_план.Код_учебного_плана";
            select(comand);
        }

        private void вывестиПоставщиковИКоличествоПоставляемогоТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фио, Тип_дисциплины, полное, Количество_часов from Группы, Учебный_план, Тарификация, Дисциплины, Преподаватели where Группы.код_группы = Тарификация.Код_группы and Тарификация.Код_преподавателя = Преподаватели.код_преподавателя and Учебный_план.Код_дисциплины = Дисциплины.Код and Тарификация.Код_учебного_плана = Учебный_план.Код_учебного_плана";
            select(comand);
        }

        private void вывестиКоличествоЧасовОтводимыхНаРазныйТипЗанятийСпециальности080110ПолученныйСписокОтсортироватьПоТипуДисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"Select Тип_дисциплины, Sum(Количество_часов) as количество
from [dbo].[Учебный_план],[dbo].[Специальности]
where [dbo].[Специальности].Код_специальности =[dbo].[Учебный_план].Код_специальности
and[dbo].[Специальности].код =080110
group by Тип_дисциплины";
            select(comand);
        }

        private void вывестиКлиентовИКоличествоПриобретенногоТовараКаждымКлиентомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select фио, Тип_дисциплины, полное, Количество_часов from Группы, Учебный_план, Тарификация, Дисциплины, Преподаватели where Группы.код_группы = Тарификация.Код_группы and Тарификация.Код_преподавателя = Преподаватели.код_преподавателя and Учебный_план.Код_дисциплины = Дисциплины.Код and Тарификация.Код_учебного_плана = Учебный_план.Код_учебного_плана";
            select(comand);
        }

        private void выяснитьДляКакихГруппНаКурсовоеПроектированиеВыделилиМеньшеВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comand = @"select группа, количество_часов from Группы, Учебный_план, Тарификация where Группы.код_группы = Тарификация.Код_Группы and Учебный_план.Код_учебного_плана = Тарификация.Код_учебного_плана and Тип_дисциплины = 'курсовое проектирование' order by Количество_часов";
            select(comand);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void поискИФильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoiskForm sf = new PoiskForm();
            sf.Owner = this;
            sf.Show();
        }

        private void тарификацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarifikaciya sf = new Tarifikaciya();
            sf.Owner = this;
            sf.Show();
        }

        private void учебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uchebniy_Plan sf = new Uchebniy_Plan();
            sf.Owner = this;
            sf.Show();
        }
    }
}
