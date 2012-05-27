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
    public partial class Form1 : Form
    {
        BcardBase db = new BcardBase(@"Data Source=.\SQLEXPRESS;Initial Catalog=BcardBase;Integrated Security=True");
        public IQueryable<Bcard> bCards;
        public IQueryable<Manager> Managers;

        public Form1()
        {
            InitializeComponent();

            bCards = db.Bcards;
            Managers = db.Managers;
            reloadAll();

            // Добавляем обработчик события
            SelectUser.EventHandler += new SelectUser.selectUserEvent(this.userSelect);
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
            dataGridView1.DataSource = bCards;
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
            Form2 f2 = new Form2(Managers);
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
            //toolStripStatusLabel2.Text = f2.testStr;
        }

        private void первыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5(Managers);
            f2.ShowInTaskbar = false;
            f2.Owner = this;
            f2.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Manager vz = new Manager
            {
                Fname = "asdasd",
                Color = null
            };

            db.Managers.InsertOnSubmit(vz);

            db.SubmitChanges();
        }

        void userSelect(string name)
        {
            toolStripStatusLabel2.Text = name;
        }
    }
}
