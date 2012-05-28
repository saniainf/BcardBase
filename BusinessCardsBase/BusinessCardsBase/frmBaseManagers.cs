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
            InitializeComponent();
            this.dbBCard = dbBCard;

            PassingDataSupport.eventReload += new System.EventHandler(this.loadDataTable); // подписка на загрузку таблицы
            PassingDataSupport.eventReload(this, null); // событие загрузки таблицы
        }

        private void btAddManager_Click(object sender, EventArgs e)
        {
            frmNewManager frmNM = new frmNewManager();
            frmNM.ShowInTaskbar = false;
            frmNM.ShowDialog(this);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region supportMethods

        void loadDataTable(object sender, EventArgs e)
        {
            var dgView = from d in dbBCard.Managers
                         select new { guid = d.GuId, fname = d.Fname, lname = d.Lname, id = d.Id};

            dataGridView.DataSource = dgView;

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Имя";
            dataGridView.Columns[2].HeaderText = "Фамилия";
            dataGridView.Columns[3].HeaderText = "Идентификатор";
        }

        #endregion
    }
}
