using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nwind;

namespace TestLinq
{
    public partial class Form1 : Form
    {
        Northwind db = new Northwind(@"Data Source=SANIAPC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

        public IQueryable<Contact> cust;

        DataGridViewButtonColumn editButton;

        public Form1()
        {
            InitializeComponent();

            cust = from c in db.Contacts
                   //where c.ContactID > 10 & c.ContactID < 35
                   select c;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //int v = int.Parse(toolStripTextBox1.Text);
            //var custTst = from c in cust
            //              where c.ContactID < v
            //              select c;

            int v = int.Parse(toolStripTextBox1.Text);
            var custTst = from c in cust
                          where c.ContactID < v
                          select new { Id = c.ContactID, Name = c.ContactName }; // вывод в анонимный класс

            dataGridView1.DataSource = custTst;

            for (int i = 0; i < dataGridView1.RowCount; i++) // закрашивание ячейки по id
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1[j, i].Style.ForeColor = Color.Black;

                    switch (dataGridView1[j, i].FormattedValue.ToString())
                    {
                        case "5": dataGridView1[j, i].Style.BackColor = Color.Green;
                            break;
                        case "4": dataGridView1[j, i].Style.BackColor = Color.Coral;
                            break;
                        case "3": dataGridView1[j, i].Style.BackColor = Color.Blue;
                            break;
                        case "2": dataGridView1[j, i].Style.BackColor = Color.Red;
                            break;
                    }
                }
            }

        }

        private void dataGrid_Sort(object sender, EventArgs e) // метод на событие сортировки 
        {
            for (int i = 0; i < dataGridView1.RowCount; i++) // закрашивание ячейки по id
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1[j, i].Style.ForeColor = Color.Black;

                    switch (dataGridView1[j, i].FormattedValue.ToString())
                    {
                        case "5": dataGridView1[j, i].Style.BackColor = Color.Green;
                            break;
                        case "4": dataGridView1[j, i].Style.BackColor = Color.Coral;
                            break;
                        case "3": dataGridView1[j, i].Style.BackColor = Color.Blue;
                            break;
                        case "2": dataGridView1[j, i].Style.BackColor = Color.Red;
                            break;
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // поиск и закрашивание ячейки
        {
            string search = toolStripTextBox2.Text.Trim();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1["Name", i].Style.BackColor = Color.White;
                if (dataGridView1["Name", i].FormattedValue.ToString().Contains(toolStripTextBox2.Text.Trim())) dataGridView1["Name", i].Style.BackColor = Color.Red;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;
            dataGridView1.Columns.Add(editButton);
        }
    }
}
