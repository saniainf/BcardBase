using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bbox;

namespace baseInOut
{
    public partial class Form1 : Form
    {
        BlackBox db = new BlackBox(@"Data Source=.\SQLEXPRESS;Initial Catalog=BlackBox;Integrated Security=True");

        IQueryable<Box1> boxQ; // реплика таблицы Box1

        public Form1()
        {
            InitializeComponent();

            LoadTable();
        }

        // добавить строку
        private void button1_Click(object sender, EventArgs e)
        {
            string pTxt = textBox1.Text;
            int pInt = int.Parse(textBox2.Text); // переменые для добавления в таблицу
            //int pKey = int.Parse(textBox3.Text);
            Guid pKey = Guid.NewGuid();

            Box1 addClass = new Box1 // класс добавления в таблицу
            {
                PTxt = pTxt,
                PInt = pInt,
                PKey = pKey
            };

            db.Box1s.InsertOnSubmit(addClass); // вставить строку

            saveChanges();
        
            LoadTable();
        }

        // загрузка таблицы
        void LoadTable()
        {
            //boxQ = from b in db.Box1s // запроc для реплики
            //       //where b.PTxt == "test" // работает
            //       select b;

            boxQ = db.Box1s;

            var datagv = from dgv in boxQ
                         select new { text = dgv.PTxt, number = dgv.PInt, key = dgv.PKey }; // запрос для datagridview

            dataGridView1.DataSource = datagv; // заполнение datagrid

            //dataGridView1.Columns[2].Visible = false; // скрыть столбец с индексом
        }

        // отправить изменения
        void saveChanges()
        {
            try
            {
                db.SubmitChanges(); // отправить изменения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // удалить строку
        private void button2_Click(object sender, EventArgs e)
        {
            Guid i = (Guid)dataGridView1.CurrentRow.Cells[2].Value;

            var delId = from d in boxQ // запрос в реплике
                        where d.PKey == i // поиск в реплике Id
                        select d;

            foreach (var d in delId)
                db.Box1s.DeleteOnSubmit(d); // выполнение запроса

            saveChanges();

            LoadTable();
        }

        // save
        private void button5_Click(object sender, EventArgs e)
        {
            saveChanges();

            LoadTable();
        }

        // reload
        private void button6_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        // cancel
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        // test
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(db);
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
        }
    }
}
