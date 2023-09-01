﻿namespace Spa_Information_System_Group6
{
    partial class Maintain_Bookings
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
            this.components = new System.ComponentModel.Container();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.BookingsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchStartTime = new System.Windows.Forms.TextBox();
            this.lblStartTimeSearch = new System.Windows.Forms.Label();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.dataGridViewAllBookings = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInfoHeading = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpClientInfo = new System.Windows.Forms.GroupBox();
            this.txtAddClientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddClientSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbEmpInfo = new System.Windows.Forms.GroupBox();
            this.txtAddEmpName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddEmpSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpTreatmentInfo = new System.Windows.Forms.GroupBox();
            this.txtTreatmentType = new System.Windows.Forms.TextBox();
            this.txtAddTreatmentName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnSelectInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.pnlPage2 = new System.Windows.Forms.Panel();
            this.chbTreatmentProv = new System.Windows.Forms.CheckBox();
            this.chbPayed = new System.Windows.Forms.CheckBox();
            this.chbCancelled = new System.Windows.Forms.CheckBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.txtTreatmentPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BookingsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpClientInfo.SuspendLayout();
            this.gbEmpInfo.SuspendLayout();
            this.gpTreatmentInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(498, 281);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(291, 54);
            this.btnDisplayAll.TabIndex = 0;
            this.btnDisplayAll.Text = "DisplayAll";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // BookingsTabControl
            // 
            this.BookingsTabControl.Controls.Add(this.tabPage1);
            this.BookingsTabControl.Controls.Add(this.tabPage2);
            this.BookingsTabControl.Controls.Add(this.tabPage3);
            this.BookingsTabControl.Controls.Add(this.tabPage4);
            this.BookingsTabControl.Location = new System.Drawing.Point(3, 3);
            this.BookingsTabControl.Multiline = true;
            this.BookingsTabControl.Name = "BookingsTabControl";
            this.BookingsTabControl.SelectedIndex = 0;
            this.BookingsTabControl.Size = new System.Drawing.Size(902, 498);
            this.BookingsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbSearch);
            this.tabPage1.Controls.Add(this.dataGridViewAllBookings);
            this.tabPage1.Controls.Add(this.btnDisplayAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View all Bookings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnClear);
            this.gbSearch.Controls.Add(this.panel1);
            this.gbSearch.Location = new System.Drawing.Point(6, 266);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(373, 193);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Bookings Searches";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(328, 26);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchStartTime);
            this.panel1.Controls.Add(this.lblStartTimeSearch);
            this.panel1.Controls.Add(this.txtSearchDate);
            this.panel1.Controls.Add(this.lblSearchDate);
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 103);
            this.panel1.TabIndex = 4;
            // 
            // txtSearchStartTime
            // 
            this.txtSearchStartTime.Location = new System.Drawing.Point(101, 61);
            this.txtSearchStartTime.Name = "txtSearchStartTime";
            this.txtSearchStartTime.Size = new System.Drawing.Size(181, 20);
            this.txtSearchStartTime.TabIndex = 3;
            this.txtSearchStartTime.TextChanged += new System.EventHandler(this.txtSearchStartTime_TextChanged);
            // 
            // lblStartTimeSearch
            // 
            this.lblStartTimeSearch.AutoSize = true;
            this.lblStartTimeSearch.Location = new System.Drawing.Point(3, 61);
            this.lblStartTimeSearch.Name = "lblStartTimeSearch";
            this.lblStartTimeSearch.Size = new System.Drawing.Size(92, 13);
            this.lblStartTimeSearch.TabIndex = 2;
            this.lblStartTimeSearch.Text = "Search start time :";
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(101, 22);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(181, 20);
            this.txtSearchDate.TabIndex = 0;
            this.txtSearchDate.TextChanged += new System.EventHandler(this.txtSearchDate_TextChanged);
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(22, 25);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(73, 13);
            this.lblSearchDate.TabIndex = 1;
            this.lblSearchDate.Text = "Search Date :";
            // 
            // dataGridViewAllBookings
            // 
            this.dataGridViewAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBookings.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewAllBookings.Name = "dataGridViewAllBookings";
            this.dataGridViewAllBookings.ReadOnly = true;
            this.dataGridViewAllBookings.Size = new System.Drawing.Size(871, 254);
            this.dataGridViewAllBookings.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblInfoHeading);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.btnAddBooking);
            this.tabPage2.Controls.Add(this.lblHeading);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInfoHeading
            // 
            this.lblInfoHeading.AutoSize = true;
            this.lblInfoHeading.Location = new System.Drawing.Point(486, 15);
            this.lblInfoHeading.Name = "lblInfoHeading";
            this.lblInfoHeading.Size = new System.Drawing.Size(104, 13);
            this.lblInfoHeading.TabIndex = 26;
            this.lblInfoHeading.Text = "Selected Information";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gpClientInfo);
            this.panel3.Controls.Add(this.gbEmpInfo);
            this.panel3.Controls.Add(this.gpTreatmentInfo);
            this.panel3.Location = new System.Drawing.Point(489, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 346);
            this.panel3.TabIndex = 25;
            // 
            // gpClientInfo
            // 
            this.gpClientInfo.Controls.Add(this.txtAddClientName);
            this.gpClientInfo.Controls.Add(this.label7);
            this.gpClientInfo.Controls.Add(this.txtAddClientSurname);
            this.gpClientInfo.Controls.Add(this.label6);
            this.gpClientInfo.Location = new System.Drawing.Point(49, 5);
            this.gpClientInfo.Name = "gpClientInfo";
            this.gpClientInfo.Size = new System.Drawing.Size(304, 106);
            this.gpClientInfo.TabIndex = 19;
            this.gpClientInfo.TabStop = false;
            this.gpClientInfo.Text = "Client Information";
            // 
            // txtAddClientName
            // 
            this.txtAddClientName.Location = new System.Drawing.Point(124, 21);
            this.txtAddClientName.Multiline = true;
            this.txtAddClientName.Name = "txtAddClientName";
            this.txtAddClientName.Size = new System.Drawing.Size(164, 24);
            this.txtAddClientName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Client Surname :";
            // 
            // txtAddClientSurname
            // 
            this.txtAddClientSurname.Location = new System.Drawing.Point(124, 61);
            this.txtAddClientSurname.Multiline = true;
            this.txtAddClientSurname.Name = "txtAddClientSurname";
            this.txtAddClientSurname.Size = new System.Drawing.Size(164, 24);
            this.txtAddClientSurname.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Client Name :";
            // 
            // gbEmpInfo
            // 
            this.gbEmpInfo.Controls.Add(this.txtAddEmpName);
            this.gbEmpInfo.Controls.Add(this.label8);
            this.gbEmpInfo.Controls.Add(this.txtAddEmpSurname);
            this.gbEmpInfo.Controls.Add(this.label9);
            this.gbEmpInfo.Location = new System.Drawing.Point(49, 117);
            this.gbEmpInfo.Name = "gbEmpInfo";
            this.gbEmpInfo.Size = new System.Drawing.Size(304, 107);
            this.gbEmpInfo.TabIndex = 20;
            this.gbEmpInfo.TabStop = false;
            this.gbEmpInfo.Text = "Employee Information";
            // 
            // txtAddEmpName
            // 
            this.txtAddEmpName.Location = new System.Drawing.Point(124, 19);
            this.txtAddEmpName.Multiline = true;
            this.txtAddEmpName.Name = "txtAddEmpName";
            this.txtAddEmpName.Size = new System.Drawing.Size(164, 24);
            this.txtAddEmpName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Employee Surname :";
            // 
            // txtAddEmpSurname
            // 
            this.txtAddEmpSurname.Location = new System.Drawing.Point(124, 61);
            this.txtAddEmpSurname.Multiline = true;
            this.txtAddEmpSurname.Name = "txtAddEmpSurname";
            this.txtAddEmpSurname.Size = new System.Drawing.Size(164, 24);
            this.txtAddEmpSurname.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Employee name :";
            // 
            // gpTreatmentInfo
            // 
            this.gpTreatmentInfo.Controls.Add(this.txtTreatmentType);
            this.gpTreatmentInfo.Controls.Add(this.txtAddTreatmentName);
            this.gpTreatmentInfo.Controls.Add(this.label10);
            this.gpTreatmentInfo.Controls.Add(this.label11);
            this.gpTreatmentInfo.Location = new System.Drawing.Point(49, 225);
            this.gpTreatmentInfo.Name = "gpTreatmentInfo";
            this.gpTreatmentInfo.Size = new System.Drawing.Size(304, 110);
            this.gpTreatmentInfo.TabIndex = 21;
            this.gpTreatmentInfo.TabStop = false;
            this.gpTreatmentInfo.Text = "Treatment Information";
            // 
            // txtTreatmentType
            // 
            this.txtTreatmentType.Location = new System.Drawing.Point(124, 69);
            this.txtTreatmentType.Multiline = true;
            this.txtTreatmentType.Name = "txtTreatmentType";
            this.txtTreatmentType.Size = new System.Drawing.Size(164, 24);
            this.txtTreatmentType.TabIndex = 18;
            // 
            // txtAddTreatmentName
            // 
            this.txtAddTreatmentName.Location = new System.Drawing.Point(124, 21);
            this.txtAddTreatmentName.Multiline = true;
            this.txtAddTreatmentName.Name = "txtAddTreatmentName";
            this.txtAddTreatmentName.Size = new System.Drawing.Size(164, 24);
            this.txtAddTreatmentName.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Treatment Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Treatment Name :";
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(66, 412);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(355, 28);
            this.btnAddBooking.TabIndex = 24;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(19, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(123, 13);
            this.lblHeading.TabIndex = 23;
            this.lblHeading.Text = "Add Booking Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.btnSelectInformation);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtStartTime);
            this.panel2.Controls.Add(this.pnlPage2);
            this.panel2.Controls.Add(this.txtEndTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAmountDue);
            this.panel2.Controls.Add(this.txtTreatmentPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(19, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 346);
            this.panel2.TabIndex = 22;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(117, 13);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 24);
            this.txtDate.TabIndex = 8;
            // 
            // btnSelectInformation
            // 
            this.btnSelectInformation.Location = new System.Drawing.Point(326, 24);
            this.btnSelectInformation.Name = "btnSelectInformation";
            this.btnSelectInformation.Size = new System.Drawing.Size(111, 159);
            this.btnSelectInformation.TabIndex = 19;
            this.btnSelectInformation.Text = "Select Information";
            this.btnSelectInformation.UseVisualStyleBackColor = true;
            this.btnSelectInformation.Click += new System.EventHandler(this.btnSelectInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time :";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(117, 51);
            this.txtStartTime.Multiline = true;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(164, 24);
            this.txtStartTime.TabIndex = 9;
            // 
            // pnlPage2
            // 
            this.pnlPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPage2.Controls.Add(this.chbTreatmentProv);
            this.pnlPage2.Controls.Add(this.chbPayed);
            this.pnlPage2.Controls.Add(this.chbCancelled);
            this.pnlPage2.Location = new System.Drawing.Point(15, 238);
            this.pnlPage2.Name = "pnlPage2";
            this.pnlPage2.Size = new System.Drawing.Size(360, 72);
            this.pnlPage2.TabIndex = 20;
            // 
            // chbTreatmentProv
            // 
            this.chbTreatmentProv.AutoSize = true;
            this.chbTreatmentProv.Location = new System.Drawing.Point(12, 13);
            this.chbTreatmentProv.Name = "chbTreatmentProv";
            this.chbTreatmentProv.Size = new System.Drawing.Size(119, 17);
            this.chbTreatmentProv.TabIndex = 13;
            this.chbTreatmentProv.Text = "Treatment Provided";
            this.chbTreatmentProv.UseVisualStyleBackColor = true;
            // 
            // chbPayed
            // 
            this.chbPayed.AutoSize = true;
            this.chbPayed.Location = new System.Drawing.Point(137, 13);
            this.chbPayed.Name = "chbPayed";
            this.chbPayed.Size = new System.Drawing.Size(98, 17);
            this.chbPayed.TabIndex = 14;
            this.chbPayed.Text = "Booking Payed";
            this.chbPayed.UseVisualStyleBackColor = true;
            // 
            // chbCancelled
            // 
            this.chbCancelled.AutoSize = true;
            this.chbCancelled.Location = new System.Drawing.Point(241, 13);
            this.chbCancelled.Name = "chbCancelled";
            this.chbCancelled.Size = new System.Drawing.Size(115, 17);
            this.chbCancelled.TabIndex = 15;
            this.chbCancelled.Text = "Booking Cancelled";
            this.chbCancelled.UseVisualStyleBackColor = true;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(117, 94);
            this.txtEndTime.Multiline = true;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(164, 24);
            this.txtEndTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount_Due :";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(117, 178);
            this.txtAmountDue.Multiline = true;
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(164, 24);
            this.txtAmountDue.TabIndex = 12;
            // 
            // txtTreatmentPrice
            // 
            this.txtTreatmentPrice.Location = new System.Drawing.Point(117, 139);
            this.txtTreatmentPrice.Multiline = true;
            this.txtTreatmentPrice.Name = "txtTreatmentPrice";
            this.txtTreatmentPrice.Size = new System.Drawing.Size(164, 24);
            this.txtTreatmentPrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Treatment Price :";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(894, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Bookings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(894, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Bookings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Maintain_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.BookingsTabControl);
            this.Name = "Maintain_Bookings";
            this.Text = "Maintain_Bookings";
            this.Load += new System.EventHandler(this.Maintain_Bookings_Load);
            this.BookingsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gpClientInfo.ResumeLayout(false);
            this.gpClientInfo.PerformLayout();
            this.gbEmpInfo.ResumeLayout(false);
            this.gbEmpInfo.PerformLayout();
            this.gpTreatmentInfo.ResumeLayout(false);
            this.gpTreatmentInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPage2.ResumeLayout(false);
            this.pnlPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.TabControl BookingsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewAllBookings;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchStartTime;
        private System.Windows.Forms.Label lblStartTimeSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTreatmentPrice;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.CheckBox chbPayed;
        private System.Windows.Forms.CheckBox chbCancelled;
        private System.Windows.Forms.CheckBox chbTreatmentProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddClientSurname;
        private System.Windows.Forms.TextBox txtAddClientName;
        private System.Windows.Forms.GroupBox gpClientInfo;
        private System.Windows.Forms.Panel pnlPage2;
        private System.Windows.Forms.GroupBox gpTreatmentInfo;
        private System.Windows.Forms.TextBox txtAddTreatmentName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbEmpInfo;
        private System.Windows.Forms.TextBox txtAddEmpName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddEmpSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectInformation;
        private System.Windows.Forms.TextBox txtTreatmentType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInfoHeading;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}