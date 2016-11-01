﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class AppointmentPanel : UserControl
    {
        bool opened = false;
        DatabaseHandler dbh;

        public AppointmentPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();
            dbh = new DatabaseHandler();

            lbl_Appointment_Address_Data.Text = dt.Rows[rowNr]["appointment_address"].ToString();
            lbl_Appointment_Zipcode_Data.Text = dt.Rows[rowNr]["appointment_zipcode"].ToString();
            lbl_Appointment_Residence_Data.Text = dt.Rows[rowNr]["appointment_residence"].ToString();
            lbl_Appointment_Made_Data.Text = dt.Rows[rowNr]["appointment_made"].ToString();
            lbl_Appointment_Date.Text = dt.Rows[rowNr]["appointment_date"].ToString();
            lbl_Appointment_Time_Data.Text = dt.Rows[rowNr]["appointment_time"].ToString();
            rtb_Summary.Text = dt.Rows[rowNr]["appointment_summary"].ToString();
            lbl_CustomerName.Text = dt.Rows[rowNr]["customer_id"].ToString();
        }

        private void OpenMoreInfo(object sender, EventArgs e)
        {
            if (opened)
            {
                panel2.Hide();
                opened = false;
            }
            else
            {
                panel2.Show();
                opened = true;
            }
        }
    }
}