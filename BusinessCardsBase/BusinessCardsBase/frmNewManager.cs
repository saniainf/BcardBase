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
            string fn = tbFirstName.Text.Trim();
            string ln = tbLastName.Text.Trim();
            string ids = tbId.Text.Trim();
            PassingDataSupport.dataNewManager(fn, ln, ids, btSelectColor.BackColor);
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            idChanged();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            idChanged();
        }

        void idChanged()
        {
            string fn = tbFirstName.Text.ToLower().Trim();
            string ln = tbLastName.Text.ToLower().Trim();

            if (fn.Length >=3 && ln.Length >=3)
            {
                tbId.Text = fn.Substring(0, 3) + ln.Substring(0, 3);
            }
            
        }

        private void btSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog frmSelectColor = new ColorDialog();
            frmSelectColor.Color = btSelectColor.BackColor;
            if (frmSelectColor.ShowDialog() == DialogResult.OK)
                btSelectColor.BackColor = frmSelectColor.Color;
        }
    }
}
