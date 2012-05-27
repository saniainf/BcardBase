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
            PassingDataSupport.eventHandler += new PassingDataSupport.selectUserEvent(this.changeUser); // подписаться на событие select user
            PassingDataSupport.eventReload += new System.EventHandler(this.testEvent);
            InitializeComponent();
        }

        #endregion

        #region event menuStrip

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

        void testEvent(object sender, EventArgs e)
        {
            statusStripLbUserSelect.Text = "ok";
        }

        #endregion
    }
}
