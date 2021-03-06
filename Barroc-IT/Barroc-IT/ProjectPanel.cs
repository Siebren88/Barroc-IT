﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class ProjectPanel : UserControl
    {
        bool opened = false;
        enum projectStatusCode
        {
            New_Project=0, 
            In_Progress=1, 
            Halted=2, 
            Stopped=3, 
            Done=4
        };

        enum ProjectMaintenanceContract
        {
            Yes = 0,
            No = 1
        };

        enum LedgerAccountNumber
        {
            Small_Project = 0,
            Big_Project = 1
        };

        public ProjectPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();

            int projectStatus = Convert.ToInt16(dt.Rows[rowNr]["project_status"]);
            int maintenance_contract = Convert.ToInt16(dt.Rows[rowNr]["maintenance_contract"]);
            int ledger_account_number = Convert.ToInt16(dt.Rows[rowNr]["ledger_account_number"]);

            foreach (string s in dt.Rows[rowNr]["software"].ToString().Split(','))
            {
                rtb_Software.Text += s + "\n";
            }

            lbl_Project_Id.Text = dt.Rows[rowNr]["project_id"].ToString();
            lbl_Project_Name.Text = dt.Rows[rowNr]["project_name"].ToString();
            lbl_Project_Status.Text = ((projectStatusCode)projectStatus).ToString();
            lbl_Deadline.Text = dt.Rows[rowNr]["deadline_date"].ToString();
            lbl_Internal_Contact_Person.Text = dt.Rows[rowNr]["contact_person"].ToString();
            lbl_Maintenance_Contract.Text = ((ProjectMaintenanceContract)maintenance_contract).ToString();
            lbl_Operating_System.Text = dt.Rows[rowNr]["operating_system"].ToString();
            lbl_Hardware.Text = dt.Rows[rowNr]["hardware"].ToString();
            lbl_Amount_Invoices.Text = dt.Rows[rowNr]["amount_invoice"].ToString();
            lbl_Project_Ledger_Account_Number_Data.Text = ((LedgerAccountNumber)ledger_account_number).ToString();

            lbl_Customer_Name.Text = dt.Rows[rowNr]["customer_name"].ToString();
            lbl_Company_Name.Text = dt.Rows[rowNr]["company_name"].ToString();
            lbl_Total_Price.Text = "\u20AC " + dt.Rows[rowNr]["price"].ToString();
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
