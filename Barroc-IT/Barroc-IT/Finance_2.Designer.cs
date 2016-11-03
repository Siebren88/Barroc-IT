﻿namespace Barroc_IT
{
    partial class frm_Finance_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstrp_Menu = new System.Windows.Forms.MenuStrip();
            this.mnitem_Overview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Overview_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Department = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Type = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Projects_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Projects_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PID = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Projects_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_CuName = new System.Windows.Forms.ToolStripTextBox();
            this.mnitem_Appointments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Appointments_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_CuName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_CoName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_CoName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_Residence = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_Residence = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_Summary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Appointments_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tcp_Overview = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcp_Main = new System.Windows.Forms.TabControl();
            this.tcp_Invoices = new System.Windows.Forms.TabPage();
            this.tcp_AddInvoice = new System.Windows.Forms.TabPage();
            this.invoicesPanel = new System.Windows.Forms.Panel();
            this.btn_Project_Show_All = new System.Windows.Forms.Button();
            this.mstrp_Menu.SuspendLayout();
            this.tcp_Overview.SuspendLayout();
            this.tcp_Main.SuspendLayout();
            this.tcp_Invoices.SuspendLayout();
            this.invoicesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrp_Menu
            // 
            this.mstrp_Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mstrp_Menu.AutoSize = false;
            this.mstrp_Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mstrp_Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.mstrp_Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitem_Overview,
            this.mnfltr_Overview_Department,
            this.mnfltr_Overview_Type,
            this.mnfltr_Overview_Date,
            this.mnitem_Projects,
            this.mnfltr_Projects_Name,
            this.mnfltr_Projects_ID,
            this.mnfltr_Projects_CuName,
            this.mnitem_Appointments,
            this.mnfltr_Appointments_CuName,
            this.mnfltr_Appointments_CoName,
            this.mnfltr_Appointments_Residence,
            this.mnfltr_Appointments_Summary,
            this.mnfltr_Appointments_Date,
            this.mnitem_Logout});
            this.mstrp_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstrp_Menu.Location = new System.Drawing.Point(0, 1);
            this.mstrp_Menu.Name = "mstrp_Menu";
            this.mstrp_Menu.Size = new System.Drawing.Size(142, 464);
            this.mstrp_Menu.TabIndex = 2;
            // 
            // mnitem_Overview
            // 
            this.mnitem_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Overview.Name = "mnitem_Overview";
            this.mnitem_Overview.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Overview.Text = "Overview";
            this.mnitem_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Overview_Department
            // 
            this.mnfltr_Overview_Department.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmb_Overview_Department});
            this.mnfltr_Overview_Department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Department.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Department.Name = "mnfltr_Overview_Department";
            this.mnfltr_Overview_Department.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Department.Text = "Department";
            this.mnfltr_Overview_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tscmb_Overview_Department
            // 
            this.tscmb_Overview_Department.BackColor = System.Drawing.SystemColors.Window;
            this.tscmb_Overview_Department.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tscmb_Overview_Department.Items.AddRange(new object[] {
            "All",
            "Developement",
            "Finance",
            "Sales"});
            this.tscmb_Overview_Department.Name = "tscmb_Overview_Department";
            this.tscmb_Overview_Department.Size = new System.Drawing.Size(121, 23);
            this.tscmb_Overview_Department.Text = "All";
            // 
            // mnfltr_Overview_Type
            // 
            this.mnfltr_Overview_Type.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmb_Overview_Type});
            this.mnfltr_Overview_Type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Type.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Type.Name = "mnfltr_Overview_Type";
            this.mnfltr_Overview_Type.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Type.Text = "Type";
            this.mnfltr_Overview_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tscmb_Overview_Type
            // 
            this.tscmb_Overview_Type.Items.AddRange(new object[] {
            "All",
            "Type1",
            "Type2",
            "Type3"});
            this.tscmb_Overview_Type.Name = "tscmb_Overview_Type";
            this.tscmb_Overview_Type.Size = new System.Drawing.Size(121, 23);
            this.tscmb_Overview_Type.Text = "All";
            // 
            // mnfltr_Overview_Date
            // 
            this.mnfltr_Overview_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Date.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Date.Name = "mnfltr_Overview_Date";
            this.mnfltr_Overview_Date.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Date.Text = "Date";
            this.mnfltr_Overview_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Projects
            // 
            this.mnitem_Projects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Projects.Name = "mnitem_Projects";
            this.mnitem_Projects.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Projects.Text = "Projects";
            this.mnitem_Projects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Projects_Name
            // 
            this.mnfltr_Projects_Name.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PName});
            this.mnfltr_Projects_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_Name.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_Name.Name = "mnfltr_Projects_Name";
            this.mnfltr_Projects_Name.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_Name.Text = "Project Name";
            this.mnfltr_Projects_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PName
            // 
            this.tstxtb_Projects_PName.Name = "tstxtb_Projects_PName";
            this.tstxtb_Projects_PName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Projects_ID
            // 
            this.mnfltr_Projects_ID.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PID});
            this.mnfltr_Projects_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_ID.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_ID.Name = "mnfltr_Projects_ID";
            this.mnfltr_Projects_ID.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_ID.Text = "Project ID";
            this.mnfltr_Projects_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PID
            // 
            this.tstxtb_Projects_PID.Name = "tstxtb_Projects_PID";
            this.tstxtb_Projects_PID.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Projects_CuName
            // 
            this.mnfltr_Projects_CuName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_CuName});
            this.mnfltr_Projects_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_CuName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_CuName.Name = "mnfltr_Projects_CuName";
            this.mnfltr_Projects_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_CuName.Text = "Customer Name";
            this.mnfltr_Projects_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_CuName
            // 
            this.tstxtb_Projects_CuName.Name = "tstxtb_Projects_CuName";
            this.tstxtb_Projects_CuName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnitem_Appointments
            // 
            this.mnitem_Appointments.AutoSize = false;
            this.mnitem_Appointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Appointments.Name = "mnitem_Appointments";
            this.mnitem_Appointments.Size = new System.Drawing.Size(135, 30);
            this.mnitem_Appointments.Text = "Appointments";
            this.mnitem_Appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Appointments_CuName
            // 
            this.mnfltr_Appointments_CuName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_CuName});
            this.mnfltr_Appointments_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_CuName.Name = "mnfltr_Appointments_CuName";
            this.mnfltr_Appointments_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_CuName.Text = "Customer Name";
            this.mnfltr_Appointments_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_CuName
            // 
            this.tstxtb_Appointments_CuName.Name = "tstxtb_Appointments_CuName";
            this.tstxtb_Appointments_CuName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_CoName
            // 
            this.mnfltr_Appointments_CoName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_CoName});
            this.mnfltr_Appointments_CoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_CoName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_CoName.Name = "mnfltr_Appointments_CoName";
            this.mnfltr_Appointments_CoName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_CoName.Text = "Company Name";
            this.mnfltr_Appointments_CoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_CoName
            // 
            this.tstxtb_Appointments_CoName.Name = "tstxtb_Appointments_CoName";
            this.tstxtb_Appointments_CoName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_Residence
            // 
            this.mnfltr_Appointments_Residence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_Residence});
            this.mnfltr_Appointments_Residence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Residence.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Residence.Name = "mnfltr_Appointments_Residence";
            this.mnfltr_Appointments_Residence.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Residence.Text = "Residence";
            this.mnfltr_Appointments_Residence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_Residence
            // 
            this.tstxtb_Appointments_Residence.Name = "tstxtb_Appointments_Residence";
            this.tstxtb_Appointments_Residence.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_Summary
            // 
            this.mnfltr_Appointments_Summary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.mnfltr_Appointments_Summary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Summary.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Summary.Name = "mnfltr_Appointments_Summary";
            this.mnfltr_Appointments_Summary.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Summary.Text = "Summary";
            this.mnfltr_Appointments_Summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox3.Text = "All";
            // 
            // mnfltr_Appointments_Date
            // 
            this.mnfltr_Appointments_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Date.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Date.Name = "mnfltr_Appointments_Date";
            this.mnfltr_Appointments_Date.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Date.Text = "Date";
            this.mnfltr_Appointments_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Logout
            // 
            this.mnitem_Logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnitem_Logout.Checked = true;
            this.mnitem_Logout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnitem_Logout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnitem_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.mnitem_Logout.Name = "mnitem_Logout";
            this.mnitem_Logout.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Logout.Text = "Logout";
            this.mnitem_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcp_Overview
            // 
            this.tcp_Overview.AutoScroll = true;
            this.tcp_Overview.Controls.Add(this.label3);
            this.tcp_Overview.Controls.Add(this.label2);
            this.tcp_Overview.Location = new System.Drawing.Point(4, 22);
            this.tcp_Overview.Name = "tcp_Overview";
            this.tcp_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Overview.Size = new System.Drawing.Size(566, 438);
            this.tcp_Overview.TabIndex = 0;
            this.tcp_Overview.Text = "Overview";
            this.tcp_Overview.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // tcp_Main
            // 
            this.tcp_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcp_Main.Controls.Add(this.tcp_Overview);
            this.tcp_Main.Controls.Add(this.tcp_Invoices);
            this.tcp_Main.Controls.Add(this.tcp_AddInvoice);
            this.tcp_Main.Location = new System.Drawing.Point(142, 1);
            this.tcp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tcp_Main.Name = "tcp_Main";
            this.tcp_Main.SelectedIndex = 0;
            this.tcp_Main.Size = new System.Drawing.Size(574, 464);
            this.tcp_Main.TabIndex = 4;
            this.tcp_Main.TabStop = false;
            // 
            // tcp_Invoices
            // 
            this.tcp_Invoices.Controls.Add(this.invoicesPanel);
            this.tcp_Invoices.Location = new System.Drawing.Point(4, 22);
            this.tcp_Invoices.Name = "tcp_Invoices";
            this.tcp_Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Invoices.Size = new System.Drawing.Size(566, 438);
            this.tcp_Invoices.TabIndex = 1;
            this.tcp_Invoices.Text = "Invoices";
            this.tcp_Invoices.UseVisualStyleBackColor = true;
            // 
            // tcp_AddInvoice
            // 
            this.tcp_AddInvoice.Location = new System.Drawing.Point(4, 22);
            this.tcp_AddInvoice.Name = "tcp_AddInvoice";
            this.tcp_AddInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_AddInvoice.Size = new System.Drawing.Size(566, 438);
            this.tcp_AddInvoice.TabIndex = 2;
            this.tcp_AddInvoice.Text = "Add Invoice";
            this.tcp_AddInvoice.UseVisualStyleBackColor = true;
            // 
            // invoicesPanel
            // 
            this.invoicesPanel.AutoSize = true;
            this.invoicesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicesPanel.Controls.Add(this.btn_Project_Show_All);
            this.invoicesPanel.Location = new System.Drawing.Point(4, 35);
            this.invoicesPanel.MinimumSize = new System.Drawing.Size(540, 2);
            this.invoicesPanel.Name = "invoicesPanel";
            this.invoicesPanel.Size = new System.Drawing.Size(540, 25);
            this.invoicesPanel.TabIndex = 6;
            // 
            // btn_Project_Show_All
            // 
            this.btn_Project_Show_All.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Project_Show_All.Location = new System.Drawing.Point(0, 0);
            this.btn_Project_Show_All.Name = "btn_Project_Show_All";
            this.btn_Project_Show_All.Size = new System.Drawing.Size(538, 23);
            this.btn_Project_Show_All.TabIndex = 0;
            this.btn_Project_Show_All.Text = "Show All";
            this.btn_Project_Show_All.UseVisualStyleBackColor = true;
            // 
            // frm_Finance_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.tcp_Main);
            this.Controls.Add(this.mstrp_Menu);
            this.Name = "frm_Finance_2";
            this.Text = "Finance_2";
            this.mstrp_Menu.ResumeLayout(false);
            this.mstrp_Menu.PerformLayout();
            this.tcp_Overview.ResumeLayout(false);
            this.tcp_Overview.PerformLayout();
            this.tcp_Main.ResumeLayout(false);
            this.tcp_Invoices.ResumeLayout(false);
            this.tcp_Invoices.PerformLayout();
            this.invoicesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrp_Menu;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Overview;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Department;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Department;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Type;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Type;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Date;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Projects;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_Name;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_ID;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PID;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Appointments;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CoName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CoName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Residence;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_Residence;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Summary;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Date;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Logout;
        private System.Windows.Forms.TabPage tcp_Overview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcp_Main;
        private System.Windows.Forms.TabPage tcp_Invoices;
        private System.Windows.Forms.TabPage tcp_AddInvoice;
        private System.Windows.Forms.Panel invoicesPanel;
        private System.Windows.Forms.Button btn_Project_Show_All;
    }
}