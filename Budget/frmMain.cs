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
        }
    }
}
