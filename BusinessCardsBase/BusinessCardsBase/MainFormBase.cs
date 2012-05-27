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
    public partial class MainFormBase : Form
    {
        #region field

        BcardBase dbBCard = new BcardBase(@"Data Source=.\SQLEXPRESS;Initial Catalog=BcardBase;Integrated Security=True");

        #endregion

        #region constructor

        public MainFormBase()
        {
            PassingDataSupport.eventSelectUser += new PassingDataSupport.selectUserEvent(this.changeUser); // подписаться на событие select user
            PassingDataSupport.eventReload += new System.EventHandler(this.loadDataTable); // подписка на загрузку таблицы
            InitializeComponent();
        }

        #endregion

        #region event menuStrip

        private void menuStripServiceMangerBase_Click(object sender, EventArgs e)
        {
            frmBaseManagers frmBM = new frmBaseManagers();
            frmBM.ShowInTaskbar = false;
            frmBM.Owner = this;
            frmBM.Show();
        }

        private void menuStripOptionsChangeUser_Click(object sender, EventArgs e)
        {
            showUserSelectForm();
        }

        #endregion

        #region supportMethods

        void showUserSelectForm()
        {
            frmUserSelect frmUS = new frmUserSelect();
            frmUS.ShowInTaskbar = false;
            frmUS.Owner = this;
            frmUS.Show();
        }

        void changeUser(string name)
        {
            statusStripLbUserSelect.Text = name;
        }

        void loadDataTable(object sender, EventArgs e)
        {
            statusStripLbUserSelect.Text = "ok";
        }

        #endregion
    }
}
