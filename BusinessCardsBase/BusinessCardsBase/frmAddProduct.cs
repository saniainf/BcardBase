﻿using System;
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
    public partial class frmAddProduct : Form
    {

        #region field

        BcardBase dbBCard;

        #endregion

        public frmAddProduct(BcardBase dbBCard)
        {
            this.dbBCard = dbBCard;

            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Guid key = Guid.NewGuid();
            DateTime date = dateGet.Value;

            Bcard addClass = new Bcard // класс добавления в таблицу
            {
                Manager = cbManager.Text,
                Client = "default",
                NameFile = "default",
                GuId = key,
                Date = date
            };

            dbBCard.Bcards.InsertOnSubmit(addClass);

            GlobalEvents.eventSubmit("MainFormBase");
            Close();
        }
    }
}
