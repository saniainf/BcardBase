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
    public partial class frmNewManager : Form
    {
        public frmNewManager()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string fn = tbFirstName.Text;
            string ln = tbLastName.Text;
            string ids = tbId.Text;
            PassingDataSupport.dataNewManager(fn, ln, ids);
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
