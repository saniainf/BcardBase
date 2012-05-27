using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessCardsBase
{
    public partial class frmUserSelect : Form
    {
        public frmUserSelect()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            PassingDataSupport.eventHandler("test"); // вызвать событие "выбор пользователя"
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            PassingDataSupport.eventReload(this, null);
        }
    }
}
