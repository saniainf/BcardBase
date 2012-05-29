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

        #endregion

        public frmSelectUser(BcardBase dbBCard)
        {
            InitializeComponent();
            this.dbBCard = dbBCard;
            loadLbSelectUser();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string nameUser;
            nameUser = lbSelectUser.Items[lbSelectUser.SelectedIndex].ToString();
            PassingDataSupport.dataSelectUser(nameUser); // вызвать событие "выбор пользователя"
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void loadLbSelectUser()
        {
            var list = from lst in dbBCard.Managers
                         select new { fname = lst.Fname, lname = lst.Lname, id = lst.Id };

            foreach (var l in list)
            {
                lbSelectUser.Items.Add(l.fname + " " + l.lname);
            }
                
        }
    }
}
