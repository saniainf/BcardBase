using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using vizit;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Vizitki db = new Vizitki(@"Data Source=SANIAPC\SQLEXPRESS;Initial Catalog=Vizitki;Integrated Security=True");
        public IQueryable<Vizitki1> viz;
        public IQueryable<Manager> managers;

        public Form1()
        {
            InitializeComponent();

            viz = db.Vizitkis;
            managers = db.Managers;
            reloadAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowInTaskbar = false;
            f4.Owner = this;
            f4.Show();
        }

        public void reloadAll()
        {
            dataGridView1.DataSource = viz;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            reloadAll();
        }

        private void первыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeManagersForms();
        }

        public void ChangeBottomInfo(string str)
        {
            toolStripStatusLabel2.Text = str;
        }

        void ChangeManagersForms()
        {
            Form2 f2 = new Form2(managers);
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
            //toolStripStatusLabel2.Text = f2.testStr;
        }

        private void первыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5(managers);
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Manager vz = new Manager
            {
                Name  = "asdasd",
                Color = null
            };

            db.Managers.InsertOnSubmit(vz);

            db.SubmitChanges();
        }
    }
}
