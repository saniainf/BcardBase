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
    public partial class frmSelectUser : Form
    {
        #region field

        BcardBase dbBCard;

        Properties.Settings set = Properties.Settings.Default;

        #endregion

        public frmSelectUser(BcardBase dbBCard)
        {
            InitializeComponent();
            this.dbBCard = dbBCard;
            loadUserList();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string i = dataGridView.CurrentRow.Cells[0].Value.ToString(); // взять индекс из 0 ячейки
            set.user = i;
            set.Save();
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void loadUserList()
        {
            var list = from lst in dbBCard.Managers
                       select new { id = lst.Id, fname = lst.Fname, lname = lst.Lname };

            dataGridView.DataSource = list;

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Имя";
            dataGridView.Columns[2].HeaderText = "Фамилия";
        }
    }
}
