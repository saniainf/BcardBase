using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bcard;

namespace BusinessCardsBase
{
    public partial class frmBaseManagers : Form
    {

        #region field

        BcardBase dbBCard;

        #endregion

        public frmBaseManagers(BcardBase dbBCard)
        {
            this.dbBCard = dbBCard;

            GlobalEvents.eventReload = new GlobalEvents.reloadDataGrid(this.loadDataTable); // подписка на загрузку таблицы
            PassingDataSupport.dataNewManager = new PassingDataSupport.ofNewManager(this.newManger); // подписка на данные из NewManager
            
            InitializeComponent();
            
            GlobalEvents.eventReload("frmBaseManagers"); // загрузить таблицу
            dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Ascending);
        }

        // кнопка добавить
        private void btAddManager_Click(object sender, EventArgs e)
        {
            frmNewManager frmNM = new frmNewManager();
            frmNM.ShowInTaskbar = false;
            frmNM.ShowDialog(this);
        }

        // кнопка удалить
        private void btDeleteManager_Click(object sender, EventArgs e)
        {
            Guid i = (Guid)dataGridView.CurrentRow.Cells[0].Value; // взять индекс из 0 ячейки

            var delId = from d in dbBCard.Managers
                        where d.GuId == i
                        select d;

            foreach (var d in delId)
                dbBCard.Managers.DeleteOnSubmit(d); // выполнение запроса удалить

            GlobalEvents.eventSubmit("frmBaseManagers");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        #region supportMethods

        // load / reload таблицы
        void loadDataTable(string title)
        {
            if (title == "frmBaseManagers")
            {
                var dgView = from d in dbBCard.Managers
                             select new { guid = d.GuId, fname = d.Fname, lname = d.Lname, id = d.Id };

                dataGridView.DataSource = dgView;

                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].HeaderText = "Имя";
                dataGridView.Columns[2].HeaderText = "Фамилия";
                dataGridView.Columns[3].HeaderText = "Идентификатор";
            }
        }

        // добавить нового манагера
        void newManger(string fn, string ln, string ids)
        {
            Guid key = Guid.NewGuid();

            Manager addClass = new Manager // класс добавления в таблицу
            {
                Fname = fn,
                Lname = ln,
                Color = null,
                Id  = ids,
                GuId = key
            };

            dbBCard.Managers.InsertOnSubmit(addClass);
            GlobalEvents.eventSubmit("frmBaseManagers");
        }

        #endregion
    }
}
