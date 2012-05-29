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
            PassingDataSupport.dataSelectUser = new PassingDataSupport.ofSelectUser(this.changeUser); // event selectUser
            GlobalEvents.eventReload = new GlobalEvents.reloadDataGrid(this.loadDataTable); // event load dataGridView
            GlobalEvents.eventSubmit = new GlobalEvents.submitChangeBase(this.submitChange); // event сохранить изменение базы
            InitializeComponent();
        }

        #endregion

        #region event menuStrip

        private void menuStripServiceMangerBase_Click(object sender, EventArgs e)
        {
            frmBaseManagers frmBM = new frmBaseManagers(dbBCard);
            frmBM.ShowInTaskbar = false;
            frmBM.Owner = this;
            frmBM.Show();
        }

        private void menuStripOptionsChangeUser_Click(object sender, EventArgs e)
        {
            showSelectUserForm();
        }

        #endregion

        #region supportMethods

        // вызов формы выбора пользователя
        void showSelectUserForm()
        {
            frmSelectUser frmUS = new frmSelectUser(dbBCard);
            frmUS.ShowInTaskbar = false;
            frmUS.Owner = this;
            frmUS.Show();
        }

        // для события сменить пользователя
        void changeUser(string name)
        {
            statusStripLbUserSelect.Text = name;
        }

        // load / reload таблицы
        void loadDataTable(string title)
        {
            if (title == "MainFormBase")
            {
                // load/reload datagridview
            }
        }

        // сохранение изменений в базе
        void submitChange(string oftitle)
        {
            //try
            //{
                dbBCard.SubmitChanges(); // отправить изменения
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            GlobalEvents.eventReload(oftitle);
        }

        #endregion
    }
}
