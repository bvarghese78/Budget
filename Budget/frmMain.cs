using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJ.Common;

namespace Budget
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            BusinessLayer business = new BusinessLayer();
            DateTimeMethods date = new DateTimeMethods();
            string month = date.currentMonth();
            string year = date.currentYear();
            int monthNum = date.currentMonthInt();
            lblMain.Text = "Monthly Budget For " + month + ", " + year;

            txtIncomeMain.Text = Convert.ToString(business.getIncome(monthNum, Convert.ToInt32(year)));

            cmbMonth.SelectedIndex = date.currentMonthInt() - 1;
            cmbYear.SelectedItem = date.currentYear();
        }

        private void txtEatingOut_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeMethods date = new DateTimeMethods();
            txtTime.Text = date.fullDateTime();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void chkRange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRange.Checked == true)
            {
                cmbMonthRange.Enabled = true;
                cmbYearRange.Enabled = true;
            }
            else
            {
                cmbMonthRange.Enabled = false;
                cmbMonthRange.SelectedIndex = 0;
                cmbYearRange.Enabled = false;
                cmbYearRange.SelectedIndex = 0;
            }
        }
    }
}
