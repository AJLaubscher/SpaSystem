
namespace Spa_Information_System_Group6
{
    partial class MaintainEmployees
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
            this.lblEmpHeading = new System.Windows.Forms.Label();
            this.pnlManipulateEmp = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.gbShowAll = new System.Windows.Forms.GroupBox();
            this.dbEmployees = new System.Windows.Forms.DataGridView();
            this.lblListOfEmployees = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cbAdministrator = new System.Windows.Forms.CheckBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.lblDeleteHeading = new System.Windows.Forms.Label();
            this.dbDelete = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelUsername = new System.Windows.Forms.TextBox();
            this.dbEmp = new System.Windows.Forms.DataGridView();
            this.pnlManipulateEmp.SuspendLayout();
            this.gbShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployees)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.gbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpHeading
            // 
            this.lblEmpHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHeading.Location = new System.Drawing.Point(194, 25);
            this.lblEmpHeading.Name = "lblEmpHeading";
            this.lblEmpHeading.Size = new System.Drawing.Size(362, 49);
            this.lblEmpHeading.TabIndex = 0;
            this.lblEmpHeading.Text = "Employee Details";
            // 
            // pnlManipulateEmp
            // 
            this.pnlManipulateEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManipulateEmp.Controls.Add(this.btnBack);
            this.pnlManipulateEmp.Controls.Add(this.btnDelete);
            this.pnlManipulateEmp.Controls.Add(this.btnUpdateEmployee);
            this.pnlManipulateEmp.Controls.Add(this.btnAddEmployee);
            this.pnlManipulateEmp.Controls.Add(this.btnShowEmp);
            this.pnlManipulateEmp.Location = new System.Drawing.Point(12, 101);
            this.pnlManipulateEmp.Name = "pnlManipulateEmp";
            this.pnlManipulateEmp.Size = new System.Drawing.Size(203, 447);
            this.pnlManipulateEmp.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(4, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(4, 134);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(192, 33);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Update Employee Details";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(4, 73);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(192, 38);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.Location = new System.Drawing.Point(4, 18);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(192, 37);
            this.btnShowEmp.TabIndex = 2;
            this.btnShowEmp.Text = "Display All Employees";
            this.btnShowEmp.UseVisualStyleBackColor = true;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // gbShowAll
            // 
            this.gbShowAll.Controls.Add(this.dbEmployees);
            this.gbShowAll.Controls.Add(this.lblListOfEmployees);
            this.gbShowAll.Location = new System.Drawing.Point(222, 101);
            this.gbShowAll.Name = "gbShowAll";
            this.gbShowAll.Size = new System.Drawing.Size(556, 447);
            this.gbShowAll.TabIndex = 2;
            this.gbShowAll.TabStop = false;
            this.gbShowAll.Text = "Show All Employees";
            // 
            // dbEmployees
            // 
            this.dbEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEmployees.Location = new System.Drawing.Point(13, 56);
            this.dbEmployees.Name = "dbEmployees";
            this.dbEmployees.RowHeadersWidth = 62;
            this.dbEmployees.RowTemplate.Height = 28;
            this.dbEmployees.Size = new System.Drawing.Size(492, 374);
            this.dbEmployees.TabIndex = 1;
            // 
            // lblListOfEmployees
            // 
            this.lblListOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfEmployees.Location = new System.Drawing.Point(153, 22);
            this.lblListOfEmployees.Name = "lblListOfEmployees";
            this.lblListOfEmployees.Size = new System.Drawing.Size(183, 31);
            this.lblListOfEmployees.TabIndex = 0;
            this.lblListOfEmployees.Text = "List Of Employees";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnUpdate);
            this.gbAdd.Controls.Add(this.cmbGender);
            this.gbAdd.Controls.Add(this.cbAdministrator);
            this.gbAdd.Controls.Add(this.lblConfirm);
            this.gbAdd.Controls.Add(this.txtConfirm);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.lblPassword);
            this.gbAdd.Controls.Add(this.lblUsername);
            this.gbAdd.Controls.Add(this.lblAdministrator);
            this.gbAdd.Controls.Add(this.lblCellPhone);
            this.gbAdd.Controls.Add(this.lblEmployeeGender);
            this.gbAdd.Controls.Add(this.lblEmployeeSurname);
            this.gbAdd.Controls.Add(this.lblEmployeeName);
            this.gbAdd.Controls.Add(this.txtPassword);
            this.gbAdd.Controls.Add(this.txtUsername);
            this.gbAdd.Controls.Add(this.txtCell);
            this.gbAdd.Controls.Add(this.txtSurname);
            this.gbAdd.Controls.Add(this.txtName);
            this.gbAdd.Location = new System.Drawing.Point(221, 101);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(556, 447);
            this.gbAdd.TabIndex = 3;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Employee";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(257, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Employee Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(190, 118);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(209, 28);
            this.cmbGender.TabIndex = 18;
            // 
            // cbAdministrator
            // 
            this.cbAdministrator.AutoSize = true;
            this.cbAdministrator.Location = new System.Drawing.Point(190, 200);
            this.cbAdministrator.Name = "cbAdministrator";
            this.cbAdministrator.Size = new System.Drawing.Size(59, 24);
            this.cbAdministrator.TabIndex = 17;
            this.cbAdministrator.Text = "Yes";
            this.cbAdministrator.UseVisualStyleBackColor = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(13, 323);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(166, 26);
            this.lblConfirm.TabIndex = 16;
            this.lblConfirm.Text = "Confirm Password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(190, 323);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(209, 26);
            this.txtConfirm.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(257, 42);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 281);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 26);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 241);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 26);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username: ";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(13, 201);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(129, 23);
            this.lblAdministrator.TabIndex = 11;
            this.lblAdministrator.Text = "Administrator:";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.Location = new System.Drawing.Point(13, 159);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(171, 26);
            this.lblCellPhone.TabIndex = 10;
            this.lblCellPhone.Text = "Cell Phone Number:";
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeGender.Location = new System.Drawing.Point(13, 121);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(162, 22);
            this.lblEmployeeGender.TabIndex = 9;
            this.lblEmployeeGender.Text = "Employee Gender:";
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSurname.Location = new System.Drawing.Point(13, 74);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(171, 28);
            this.lblEmployeeSurname.TabIndex = 8;
            this.lblEmployeeSurname.Text = "Employee Surname:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(13, 30);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(162, 24);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(190, 281);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 26);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(190, 241);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(209, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(190, 159);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(209, 26);
            this.txtCell.TabIndex = 3;
            this.txtCell.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(190, 74);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(209, 26);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 26);
            this.txtName.TabIndex = 0;
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.lblDeleteHeading);
            this.gbDelete.Controls.Add(this.dbDelete);
            this.gbDelete.Controls.Add(this.button2);
            this.gbDelete.Controls.Add(this.button1);
            this.gbDelete.Controls.Add(this.label3);
            this.gbDelete.Controls.Add(this.txtDelUsername);
            this.gbDelete.Location = new System.Drawing.Point(227, 101);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(556, 447);
            this.gbDelete.TabIndex = 20;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete Employee";
            this.gbDelete.Enter += new System.EventHandler(this.gbDelete_Enter);
            // 
            // lblDeleteHeading
            // 
            this.lblDeleteHeading.AutoSize = true;
            this.lblDeleteHeading.Location = new System.Drawing.Point(125, 36);
            this.lblDeleteHeading.Name = "lblDeleteHeading";
            this.lblDeleteHeading.Size = new System.Drawing.Size(251, 20);
            this.lblDeleteHeading.TabIndex = 22;
            this.lblDeleteHeading.Text = "Select an Employee To Delete";
            // 
            // dbDelete
            // 
            this.dbDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDelete.Location = new System.Drawing.Point(31, 74);
            this.dbDelete.Name = "dbDelete";
            this.dbDelete.RowHeadersWidth = 62;
            this.dbDelete.RowTemplate.Height = 28;
            this.dbDelete.Size = new System.Drawing.Size(507, 230);
            this.dbDelete.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete All Employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username: ";
            // 
            // txtDelUsername
            // 
            this.txtDelUsername.Location = new System.Drawing.Point(148, 310);
            this.txtDelUsername.Name = "txtDelUsername";
            this.txtDelUsername.Size = new System.Drawing.Size(209, 26);
            this.txtDelUsername.TabIndex = 5;
            // 
            // dbEmp
            // 
            this.dbEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEmp.Location = new System.Drawing.Point(801, 110);
            this.dbEmp.Name = "dbEmp";
            this.dbEmp.RowHeadersWidth = 62;
            this.dbEmp.RowTemplate.Height = 28;
            this.dbEmp.Size = new System.Drawing.Size(513, 234);
            this.dbEmp.TabIndex = 21;
            this.dbEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbEmp_CellClick);
            this.dbEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbEmp_CellContentClick);
            this.dbEmp.SelectionChanged += new System.EventHandler(this.dbEmp_SelectionChanged);
            // 
            // MaintainEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 852);
            this.Controls.Add(this.dbEmp);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.gbShowAll);
            this.Controls.Add(this.pnlManipulateEmp);
            this.Controls.Add(this.lblEmpHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MaintainEmployees";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.MaintainEmployees_Load);
            this.pnlManipulateEmp.ResumeLayout(false);
            this.gbShowAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployees)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmpHeading;
        private System.Windows.Forms.Panel pnlManipulateEmp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.GroupBox gbShowAll;
        private System.Windows.Forms.DataGridView dbEmployees;
        private System.Windows.Forms.Label lblListOfEmployees;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.CheckBox cbAdministrator;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelUsername;
        private System.Windows.Forms.Label lblDeleteHeading;
        private System.Windows.Forms.DataGridView dbDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dbEmp;
    }
}