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


        public Form2(IQueryable<Box1> boxQ)
        {
            InitializeComponent();
            this.boxQ = boxQ;
            LoadTable();
        }

        void LoadTable()
        {
            var datagv = from dgv in boxQ
                         select new { text = dgv.PTxt, number = dgv.PInt, key = dgv.PKey }; // запрос для datagridview

            dataGridView1.DataSource = datagv;
        }
    }
}
