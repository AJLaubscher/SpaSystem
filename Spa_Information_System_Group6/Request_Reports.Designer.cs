namespace Spa_Information_System_Group6
{
    partial class Request_Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDisplayIncome = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenerateTop10 = new System.Windows.Forms.Button();
            this.top10_dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.top10_dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.lstTop10 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listClients = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDisplayIncome);
            this.tabPage1.Controls.Add(this.dtEndDate);
            this.tabPage1.Controls.Add(this.dtStartDate);
            this.tabPage1.Controls.Add(this.lstDisplay);
            this.tabPage1.Controls.Add(this.lblEndDate);
            this.tabPage1.Controls.Add(this.lblStartDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Income Per Time Period";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDisplayIncome
            // 
            this.btnDisplayIncome.Location = new System.Drawing.Point(28, 74);
            this.btnDisplayIncome.Name = "btnDisplayIncome";
            this.btnDisplayIncome.Size = new System.Drawing.Size(716, 41);
            this.btnDisplayIncome.TabIndex = 5;
            this.btnDisplayIncome.Text = "Display income per time period";
            this.btnDisplayIncome.UseVisualStyleBackColor = true;
            this.btnDisplayIncome.Click += new System.EventHandler(this.btnDisplayIncome_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(461, 18);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 4;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(100, 18);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 3;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(28, 121);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(716, 264);
            this.lstDisplay.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(387, 18);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(25, 18);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxSchedule);
            this.tabPage2.Controls.Add(this.btnSchedule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daily Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.Location = new System.Drawing.Point(16, 60);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(730, 316);
            this.listBoxSchedule.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(16, 19);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(730, 35);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "Generate Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGenerateTop10);
            this.tabPage3.Controls.Add(this.top10_dateTime_end);
            this.tabPage3.Controls.Add(this.top10_dateTime_start);
            this.tabPage3.Controls.Add(this.lstTop10);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Top 10 Treatments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenerateTop10
            // 
            this.btnGenerateTop10.Location = new System.Drawing.Point(16, 73);
            this.btnGenerateTop10.Name = "btnGenerateTop10";
            this.btnGenerateTop10.Size = new System.Drawing.Size(728, 41);
            this.btnGenerateTop10.TabIndex = 11;
            this.btnGenerateTop10.Text = "Generate Top 10 Treatments per Time Period";
            this.btnGenerateTop10.UseVisualStyleBackColor = true;
            this.btnGenerateTop10.Click += new System.EventHandler(this.btnGenerateTop10_Click);
            // 
            // top10_dateTime_end
            // 
            this.top10_dateTime_end.Location = new System.Drawing.Point(461, 17);
            this.top10_dateTime_end.Name = "top10_dateTime_end";
            this.top10_dateTime_end.Size = new System.Drawing.Size(200, 20);
            this.top10_dateTime_end.TabIndex = 10;
            // 
            // top10_dateTime_start
            // 
            this.top10_dateTime_start.Location = new System.Drawing.Point(100, 17);
            this.top10_dateTime_start.Name = "top10_dateTime_start";
            this.top10_dateTime_start.Size = new System.Drawing.Size(200, 20);
            this.top10_dateTime_start.TabIndex = 9;
            // 
            // lstTop10
            // 
            this.lstTop10.FormattingEnabled = true;
            this.lstTop10.Location = new System.Drawing.Point(16, 120);
            this.lstTop10.Name = "lstTop10";
            this.lstTop10.Size = new System.Drawing.Size(728, 264);
            this.lstTop10.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Date:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listClients);
            this.tabPage4.Controls.Add(this.btnGenerate);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Client History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.Location = new System.Drawing.Point(6, 131);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(759, 264);
            this.listClients.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 95);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(762, 30);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Client Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCell);
            this.groupBox2.Controls.Add(this.lblSurname);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(598, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Client";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cell:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // lblCell
            // 
            this.lblCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell.Location = new System.Drawing.Point(397, 34);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(134, 20);
            this.lblCell.TabIndex = 5;
            this.lblCell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSurname
            // 
            this.lblSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurname.Location = new System.Drawing.Point(202, 34);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(134, 20);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(15, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 20);
            this.lblName.TabIndex = 3;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(690, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Request_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl1);
            this.Name = "Request_Reports";
            this.Text = "Request_Reports";
            this.Load += new System.EventHandler(this.Request_Reports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDisplayIncome;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGenerateTop10;
        private System.Windows.Forms.DateTimePicker top10_dateTime_end;
        private System.Windows.Forms.DateTimePicker top10_dateTime_start;
        private System.Windows.Forms.ListBox lstTop10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button btnHelp;
    }
}