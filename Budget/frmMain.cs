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
            string startDate = Convert.ToInt32(year) + "-" + monthNum + "-" + "1";
            string endDate = Convert.ToInt32(year) + "-" + monthNum + "-" + "31";

            lblMain.Text = "Monthly Budget For " + month + ", " + year;

            cmbMonth.SelectedIndex = date.currentMonthInt() - 1;
            cmbYear.SelectedItem = date.currentYear();

            DataTable dt = new DataTable();
            txtIncomeMain.Text = Convert.ToString(business.getIncome(startDate, endDate, dt));
            dgvMain.DataSource = dt;

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

        private void txtEatingOut_MouseClick(object sender, MouseEventArgs e)
        {
            BusinessLayer business = new BusinessLayer();
            string startDate = cmbYear.SelectedItem + "-" + (cmbMonth.SelectedIndex + 1) + "-" + "01";
            DataTable dt = new DataTable();
            string endDate;
            if (chkRange.Checked == false)
                endDate = cmbYear.SelectedItem + "-" + (cmbMonth.SelectedIndex + 1) + "-" + "31";
            else
                endDate = cmbYearRange.SelectedItem + "-" + (cmbMonthRange.SelectedIndex + 1) + "-" + "31";

            txtEatingOut.Text = Convert.ToString(business.getEatingOut(startDate, endDate, dt));
            dgvMain.DataSource = dt;
        }

        private void txtIncomeMain_Click(object sender, EventArgs e)
        {
            BusinessLayer business = new BusinessLayer();
            string startDate = cmbYear.SelectedItem + "-" + (cmbMonth.SelectedIndex + 1) + "-" + "01";
            DataTable dt = new DataTable();
            string endDate;
            if (chkRange.Checked == false)
                endDate = cmbYear.SelectedItem + "-" + (cmbMonth.SelectedIndex + 1) + "-" + "31";
            else
                endDate = cmbYearRange.SelectedItem + "-" + (cmbMonthRange.SelectedIndex + 1) + "-" + "31";

            txtIncomeMain.Text = Convert.ToString(business.getIncome(startDate, endDate, dt));
            dgvMain.DataSource = dt;
        }

        private void groceryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrocery grocery = new frmGrocery();
            grocery.Show();
        }
    }
}
