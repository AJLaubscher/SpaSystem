namespace Spa_Information_System_Group6
{
    partial class frmBookingInformationAdd
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
            this.dbGridClient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearClientInfo = new System.Windows.Forms.Button();
            this.txtClientCell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearTreatmentInfo = new System.Windows.Forms.Button();
            this.txtTreatmentType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTreatmentName = new System.Windows.Forms.TextBox();
            this.dbGridTreatment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearEmployeeInfo = new System.Windows.Forms.Button();
            this.txtEmployeeCell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.dbGridEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTreatment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGridClient
            // 
            this.dbGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridClient.Location = new System.Drawing.Point(9, 19);
            this.dbGridClient.Name = "dbGridClient";
            this.dbGridClient.ReadOnly = true;
            this.dbGridClient.Size = new System.Drawing.Size(686, 149);
            this.dbGridClient.TabIndex = 0;
            this.dbGridClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridClient_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dbGridClient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClearClientInfo);
            this.panel1.Controls.Add(this.txtClientCell);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClientName);
            this.panel1.Location = new System.Drawing.Point(730, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 149);
            this.panel1.TabIndex = 3;
            // 
            // btnClearClientInfo
            // 
            this.btnClearClientInfo.Location = new System.Drawing.Point(105, 101);
            this.btnClearClientInfo.Name = "btnClearClientInfo";
            this.btnClearClientInfo.Size = new System.Drawing.Size(195, 31);
            this.btnClearClientInfo.TabIndex = 5;
            this.btnClearClientInfo.Text = "Clear Controls";
            this.btnClearClientInfo.UseVisualStyleBackColor = true;
            this.btnClearClientInfo.Click += new System.EventHandler(this.btnClearClientInfo_Click);
            // 
            // txtClientCell
            // 
            this.txtClientCell.Location = new System.Drawing.Point(145, 57);
            this.txtClientCell.Name = "txtClientCell";
            this.txtClientCell.Size = new System.Drawing.Size(155, 20);
            this.txtClientCell.TabIndex = 4;
            this.txtClientCell.TextChanged += new System.EventHandler(this.txtClientCell_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Client Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Client Cell number :";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(145, 17);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(155, 20);
            this.txtClientName.TabIndex = 2;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.dbGridTreatment);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1043, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Treatment Information";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnClearTreatmentInfo);
            this.panel3.Controls.Add(this.txtTreatmentType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTreatmentName);
            this.panel3.Location = new System.Drawing.Point(721, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 149);
            this.panel3.TabIndex = 3;
            // 
            // btnClearTreatmentInfo
            // 
            this.btnClearTreatmentInfo.Location = new System.Drawing.Point(109, 101);
            this.btnClearTreatmentInfo.Name = "btnClearTreatmentInfo";
            this.btnClearTreatmentInfo.Size = new System.Drawing.Size(195, 31);
            this.btnClearTreatmentInfo.TabIndex = 5;
            this.btnClearTreatmentInfo.Text = "Clear Controls";
            this.btnClearTreatmentInfo.UseVisualStyleBackColor = true;
            this.btnClearTreatmentInfo.Click += new System.EventHandler(this.btnClearTreatmentInfo_Click);
            // 
            // txtTreatmentType
            // 
            this.txtTreatmentType.Location = new System.Drawing.Point(145, 57);
            this.txtTreatmentType.Name = "txtTreatmentType";
            this.txtTreatmentType.Size = new System.Drawing.Size(155, 20);
            this.txtTreatmentType.TabIndex = 4;
            this.txtTreatmentType.TextChanged += new System.EventHandler(this.txtTreatmentType_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Treatment Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search Treatment type:";
            // 
            // txtTreatmentName
            // 
            this.txtTreatmentName.Location = new System.Drawing.Point(145, 14);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(155, 20);
            this.txtTreatmentName.TabIndex = 2;
            this.txtTreatmentName.TextChanged += new System.EventHandler(this.txtTreatmentName_TextChanged);
            // 
            // dbGridTreatment
            // 
            this.dbGridTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridTreatment.Location = new System.Drawing.Point(9, 19);
            this.dbGridTreatment.Name = "dbGridTreatment";
            this.dbGridTreatment.ReadOnly = true;
            this.dbGridTreatment.Size = new System.Drawing.Size(686, 149);
            this.dbGridTreatment.TabIndex = 0;
            this.dbGridTreatment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridTreatment_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.dbGridEmployee);
            this.groupBox2.Location = new System.Drawing.Point(12, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClearEmployeeInfo);
            this.panel2.Controls.Add(this.txtEmployeeCell);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmployeeName);
            this.panel2.Location = new System.Drawing.Point(701, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 149);
            this.panel2.TabIndex = 3;
            // 
            // btnClearEmployeeInfo
            // 
            this.btnClearEmployeeInfo.Location = new System.Drawing.Point(134, 102);
            this.btnClearEmployeeInfo.Name = "btnClearEmployeeInfo";
            this.btnClearEmployeeInfo.Size = new System.Drawing.Size(195, 31);
            this.btnClearEmployeeInfo.TabIndex = 5;
            this.btnClearEmployeeInfo.Text = "Clear Controls";
            this.btnClearEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnClearEmployeeInfo.Click += new System.EventHandler(this.btnClearEmployeeInfo_Click);
            // 
            // txtEmployeeCell
            // 
            this.txtEmployeeCell.Location = new System.Drawing.Point(169, 57);
            this.txtEmployeeCell.Name = "txtEmployeeCell";
            this.txtEmployeeCell.Size = new System.Drawing.Size(155, 20);
            this.txtEmployeeCell.TabIndex = 4;
            this.txtEmployeeCell.TextChanged += new System.EventHandler(this.txtEmployeeCell_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search Employee Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search Employee Cell number :";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(169, 14);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(155, 20);
            this.txtEmployeeName.TabIndex = 2;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // dbGridEmployee
            // 
            this.dbGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridEmployee.Location = new System.Drawing.Point(9, 19);
            this.dbGridEmployee.Name = "dbGridEmployee";
            this.dbGridEmployee.ReadOnly = true;
            this.dbGridEmployee.Size = new System.Drawing.Size(686, 149);
            this.dbGridEmployee.TabIndex = 0;
            this.dbGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridEmployee_CellClick);
            // 
            // btnAddInformation
            // 
            this.btnAddInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddInformation.Location = new System.Drawing.Point(0, 589);
            this.btnAddInformation.Name = "btnAddInformation";
            this.btnAddInformation.Size = new System.Drawing.Size(1067, 42);
            this.btnAddInformation.TabIndex = 6;
            this.btnAddInformation.Text = "Add Information";
            this.btnAddInformation.UseVisualStyleBackColor = true;
            this.btnAddInformation.Click += new System.EventHandler(this.btnAddInformation_Click);
            // 
            // frmBookingInformationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 631);
            this.Controls.Add(this.btnAddInformation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBookingInformationAdd";
            this.Text = "Select Booking Information";
            this.Load += new System.EventHandler(this.frmBookingInformationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTreatment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearClientInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearTreatmentInfo;
        private System.Windows.Forms.TextBox txtTreatmentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTreatmentName;
        private System.Windows.Forms.DataGridView dbGridTreatment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearEmployeeInfo;
        private System.Windows.Forms.TextBox txtEmployeeCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.DataGridView dbGridEmployee;
        private System.Windows.Forms.Button btnAddInformation;
    }
}