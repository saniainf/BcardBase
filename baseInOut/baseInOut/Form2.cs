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
    public partial class Form2 : Form
    {
        IQueryable<Box1> boxQ; // реплика таблицы Box1
        BlackBox db;

        public Form2(BlackBox db)
        {
            InitializeComponent();
            this.db = db;
            LoadTable();
        }

        void LoadTable()
        {
            boxQ = db.Box1s;

            var datagv = from dgv in boxQ
                         select new { text = dgv.PTxt, number = dgv.PInt, key = dgv.PKey }; // запрос для datagridview

            dataGridView1.DataSource = datagv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pTxt = "test2";
            int pInt = 12345; // переменые для добавления в таблицу
            Guid pKey = Guid.NewGuid();

            Box1 addClass = new Box1 // класс добавления в таблицу
            {
                PTxt = pTxt,
                PInt = pInt,
                PKey = pKey
            };

            db.Box1s.InsertOnSubmit(addClass); // вставить строку
        }
    }
}
