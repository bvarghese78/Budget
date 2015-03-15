using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BJ.Common;

namespace Budget
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            DateTimeMethods date = new DateTimeMethods();
            string month = date.currentMonth();
            string year = date.currentYear();
            lblMain.Text = "Monthly Budget For " + month + ", " + year;
            getIncome();
            
        }

        private void getIncome()
        {
            List<Income> ret = new List<Income>();
            MySqlConnection mysql = Helper.NewMySqlConnection();
            mysql.Open();

            var command = mysql.CreateCommand();
            command.CommandText = "select * from income where paydate between '2015-03-01' AND '2015-03-31'";

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(new Income(reader));
            }
        }
    }
}
