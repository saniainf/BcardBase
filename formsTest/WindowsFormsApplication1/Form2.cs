﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bcard;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        //public string testStr
        //{
        //    get { listBox1.SelectedItem.ToString(); }
        //}
        Settings set = Settings.Default;

        public Form2(IQueryable<Manager> managers)
        {
            InitializeComponent();

            var Tst = from c in managers
                      select new { Name = c.Fname };

            foreach (var c in Tst)
                listBox1.Items.Add(c.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 frm = (Form1)this.Owner;
            //frm.ChangeBottomInfo(listBox1.SelectedItem.ToString());
            // событие
            SelectUser.EventHandler("test");

            set.nameUser = "test999";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
