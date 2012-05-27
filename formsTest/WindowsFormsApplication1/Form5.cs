using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bcard;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5(IQueryable<Manager> managers)
        {
            InitializeComponent();

            var Tst = from c in managers
                      select new { Name = c.Fname };
            dataGridView1.DataSource = Tst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addManager fadd = new addManager();
            fadd.ShowInTaskbar = false;
            fadd.ShowDialog(this);
        }
    }
}
