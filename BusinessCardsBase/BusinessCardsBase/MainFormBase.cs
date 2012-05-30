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
        Properties.Settings set = Properties.Settings.Default;

        #endregion

        #region constructor

        public MainFormBase()
        {
            //PassingDataSupport.dataSelectUser = new PassingDataSupport.ofSelectUser(this.changeUser); // event selectUser
            GlobalEvents.eventReload += new GlobalEvents.reloadDataGrid(this.loadDataTable); // event load dataGridView
            GlobalEvents.eventSubmit = new GlobalEvents.submitChangeBase(this.submitChange); // event сохранить изменение базы
            set.PropertyChanged += new PropertyChangedEventHandler(this.set_PropertyChanged);

            InitializeComponent();

            loadDataTable("MainFormBase");
            loadUser();
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

        #region event toolStrip

        private void toolStripBtAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAP = new frmAddProduct(dbBCard);
            frmAP.ShowInTaskbar = false;
            frmAP.Owner = this;
            frmAP.Show();
        }

        private void toolStripBtUpdate_Click(object sender, EventArgs e)
        {
            loadDataTable("MainFormBase");
            //GlobalEvents.eventReload("MainFormBase"); // reload таблицы
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

        // загрузить пользователя
        void loadUser()
        {
            string name = null;

            var user = from u in dbBCard.Managers
                       where u.Id == set.user
                       select u;
            
            foreach (var u in user)
            {
                name += u.Fname + " " + u.Lname;
            }

            statusStripLbUserSelect.Text = name;
        }


        // load / reload таблицы
        void loadDataTable(string title)
        {
            if (title == "MainFormBase")
            {
                DataGridView.DataSource = null;
                DataGridView.Columns.Clear();
                /*----------------------------------*/
                var dgView = from d in dbBCard.Bcards
                             select new
                             {
                                 guid = d.GuId,
                                 date = d.Date,
                                 manager = d.Manager,
                                 client = d.Client,
                                 namefile = d.NameFile,
                                 status = d.Status
                             };

                DataGridView.DataSource = dgView;

                DataGridView.Columns[0].Visible = false;
                DataGridView.Columns[0].HeaderText = "guid";
                DataGridView.Columns[1].HeaderText = "Дата приема";
                DataGridView.Columns[2].HeaderText = "Менеджер";
                DataGridView.Columns[3].HeaderText = "Заказчик";
                DataGridView.Columns[4].HeaderText = "Название";
                DataGridView.Columns[5].HeaderText = "Статус";

                //сортировка по 2 столбцу 
                //DataGridView.Sort(DataGridView.Columns[1], ListSortDirection.Ascending);
                addEditButton();
                addDeleteButton();
            }
        }

        // изменение пользователя
        void set_PropertyChanged(object sender, EventArgs e)
        {
            loadUser();
        }

        // сохранение изменений в базе
        void submitChange(string oftitle)
        {
            try
            {
                dbBCard.SubmitChanges(); // отправить изменения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GlobalEvents.eventReload(oftitle);
        }

        #endregion

        #region test
   
        DataGridViewButtonColumn editButton;
        DataGridViewButtonColumn deleteButton;

        void addEditButton()
        {
            editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;
            DataGridView.Columns.Insert(6, editButton);
        }

        void addDeleteButton()
        {
            deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 80;
            DataGridView.Columns.Insert(7, deleteButton);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());

            if (DataGridView.Columns[e.ColumnIndex] == deleteButton)
            {
                Guid i = (Guid)DataGridView[0, currentRow].Value; // взять индекс удаляемой строки из 0 ячейки
                System.Diagnostics.Debug.WriteLine(DataGridView[0, currentRow].Value);
                var delId = from d in dbBCard.Bcards
                            where d.GuId == i
                            select d;

                foreach (var d in delId)
                    dbBCard.Bcards.DeleteOnSubmit(d); // выполнение запроса удалить

                GlobalEvents.eventSubmit("MainFormBase");
            }
        }

        // переделать на клик
        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DataGridView.Rows[e.RowIndex].Selected = false;
        }

        #endregion
    }
}
