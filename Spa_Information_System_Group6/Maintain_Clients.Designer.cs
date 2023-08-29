namespace Spa_Information_System_Group6
{
    partial class Maintain_Clients
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
            this.dgvDisplayClients = new System.Windows.Forms.DataGridView();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtCellNumberSearch = new System.Windows.Forms.TextBox();
            this.edtSurnameSearch = new System.Windows.Forms.TextBox();
            this.edtNameSearch = new System.Windows.Forms.TextBox();
            this.lblCellNumberSearch = new System.Windows.Forms.Label();
            this.lblSurnameSearch = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.calClientDateOfBirthAdd = new System.Windows.Forms.MonthCalendar();
            this.edtClientCellNumberAdd = new System.Windows.Forms.TextBox();
            this.edtClientSurnameAdd = new System.Windows.Forms.TextBox();
            this.edtClientNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblClientMedicalConditionAdd = new System.Windows.Forms.Label();
            this.lblClientCellNumberAdd = new System.Windows.Forms.Label();
            this.lblClientDateOfBirth = new System.Windows.Forms.Label();
            this.lblClientSurnameAdd = new System.Windows.Forms.Label();
            this.lblClientNameAdd = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClientMedicalConditionUpdate = new System.Windows.Forms.Label();
            this.lblClientCellNumberUpdate = new System.Windows.Forms.Label();
            this.lblClientDateOfBirthUpdate = new System.Windows.Forms.Label();
            this.lblClientSurnameUpdate = new System.Windows.Forms.Label();
            this.lblClientNameUpdate = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.edtClientSurnameUpdate = new System.Windows.Forms.TextBox();
            this.edtClientCellNumberUpdate = new System.Windows.Forms.TextBox();
            this.edtClientMedicalConditionUpdate = new System.Windows.Forms.TextBox();
            this.dgvUpdateClients = new System.Windows.Forms.DataGridView();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.dgvDeleteClients = new System.Windows.Forms.DataGridView();
            this.lblClientNameDelete = new System.Windows.Forms.Label();
            this.lblClientSurnameDelete = new System.Windows.Forms.Label();
            this.lblClientCellNumberDelete = new System.Windows.Forms.Label();
            this.lblClientDateOfBirthDelete = new System.Windows.Forms.Label();
            this.lblNameClientUpdate = new System.Windows.Forms.Label();
            this.lblDateOfBirthClientUpdate = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNameClientSearch = new System.Windows.Forms.TextBox();
            this.lblClientDeleteName = new System.Windows.Forms.Label();
            this.lblClientDeleteDateOfBirth = new System.Windows.Forms.Label();
            this.lblClientDeleteSurname = new System.Windows.Forms.Label();
            this.lblClientDeleteCellNumber = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtClientSearchName = new System.Windows.Forms.TextBox();
            this.cbxClientMedicalCondition = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateClients)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteClients)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDisplayClients);
            this.tabPage1.Controls.Add(this.btnDisplayAll);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDisplayClients
            // 
            this.dgvDisplayClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayClients.Location = new System.Drawing.Point(6, 187);
            this.dgvDisplayClients.Name = "dgvDisplayClients";
            this.dgvDisplayClients.Size = new System.Drawing.Size(756, 207);
            this.dgvDisplayClients.TabIndex = 2;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(475, 83);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(220, 57);
            this.btnDisplayAll.TabIndex = 1;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtCellNumberSearch);
            this.groupBox1.Controls.Add(this.edtSurnameSearch);
            this.groupBox1.Controls.Add(this.edtNameSearch);
            this.groupBox1.Controls.Add(this.lblCellNumberSearch);
            this.groupBox1.Controls.Add(this.lblSurnameSearch);
            this.groupBox1.Controls.Add(this.lblNameSearch);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Clients";
            // 
            // edtCellNumberSearch
            // 
            this.edtCellNumberSearch.Location = new System.Drawing.Point(95, 118);
            this.edtCellNumberSearch.Name = "edtCellNumberSearch";
            this.edtCellNumberSearch.Size = new System.Drawing.Size(235, 20);
            this.edtCellNumberSearch.TabIndex = 5;
            // 
            // edtSurnameSearch
            // 
            this.edtSurnameSearch.Location = new System.Drawing.Point(95, 74);
            this.edtSurnameSearch.Name = "edtSurnameSearch";
            this.edtSurnameSearch.Size = new System.Drawing.Size(235, 20);
            this.edtSurnameSearch.TabIndex = 4;
            // 
            // edtNameSearch
            // 
            this.edtNameSearch.Location = new System.Drawing.Point(95, 24);
            this.edtNameSearch.Name = "edtNameSearch";
            this.edtNameSearch.Size = new System.Drawing.Size(235, 20);
            this.edtNameSearch.TabIndex = 3;
            // 
            // lblCellNumberSearch
            // 
            this.lblCellNumberSearch.AutoSize = true;
            this.lblCellNumberSearch.Location = new System.Drawing.Point(12, 121);
            this.lblCellNumberSearch.Name = "lblCellNumberSearch";
            this.lblCellNumberSearch.Size = new System.Drawing.Size(67, 13);
            this.lblCellNumberSearch.TabIndex = 2;
            this.lblCellNumberSearch.Text = "Cell Number:";
            // 
            // lblSurnameSearch
            // 
            this.lblSurnameSearch.AutoSize = true;
            this.lblSurnameSearch.Location = new System.Drawing.Point(12, 74);
            this.lblSurnameSearch.Name = "lblSurnameSearch";
            this.lblSurnameSearch.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameSearch.TabIndex = 1;
            this.lblSurnameSearch.Text = "Surname:";
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Location = new System.Drawing.Point(12, 27);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(38, 13);
            this.lblNameSearch.TabIndex = 0;
            this.lblNameSearch.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxClientMedicalCondition);
            this.tabPage2.Controls.Add(this.calClientDateOfBirthAdd);
            this.tabPage2.Controls.Add(this.edtClientCellNumberAdd);
            this.tabPage2.Controls.Add(this.edtClientSurnameAdd);
            this.tabPage2.Controls.Add(this.edtClientNameAdd);
            this.tabPage2.Controls.Add(this.btnAddClient);
            this.tabPage2.Controls.Add(this.lblClientMedicalConditionAdd);
            this.tabPage2.Controls.Add(this.lblClientCellNumberAdd);
            this.tabPage2.Controls.Add(this.lblClientDateOfBirth);
            this.tabPage2.Controls.Add(this.lblClientSurnameAdd);
            this.tabPage2.Controls.Add(this.lblClientNameAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // calClientDateOfBirthAdd
            // 
            this.calClientDateOfBirthAdd.Location = new System.Drawing.Point(325, 91);
            this.calClientDateOfBirthAdd.Name = "calClientDateOfBirthAdd";
            this.calClientDateOfBirthAdd.TabIndex = 11;
            // 
            // edtClientCellNumberAdd
            // 
            this.edtClientCellNumberAdd.Location = new System.Drawing.Point(325, 262);
            this.edtClientCellNumberAdd.Name = "edtClientCellNumberAdd";
            this.edtClientCellNumberAdd.Size = new System.Drawing.Size(227, 20);
            this.edtClientCellNumberAdd.TabIndex = 9;
            // 
            // edtClientSurnameAdd
            // 
            this.edtClientSurnameAdd.Location = new System.Drawing.Point(325, 59);
            this.edtClientSurnameAdd.Name = "edtClientSurnameAdd";
            this.edtClientSurnameAdd.Size = new System.Drawing.Size(227, 20);
            this.edtClientSurnameAdd.TabIndex = 7;
            // 
            // edtClientNameAdd
            // 
            this.edtClientNameAdd.Location = new System.Drawing.Point(325, 19);
            this.edtClientNameAdd.Name = "edtClientNameAdd";
            this.edtClientNameAdd.Size = new System.Drawing.Size(227, 20);
            this.edtClientNameAdd.TabIndex = 6;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(248, 334);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(273, 49);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // lblClientMedicalConditionAdd
            // 
            this.lblClientMedicalConditionAdd.AutoSize = true;
            this.lblClientMedicalConditionAdd.Location = new System.Drawing.Point(174, 303);
            this.lblClientMedicalConditionAdd.Name = "lblClientMedicalConditionAdd";
            this.lblClientMedicalConditionAdd.Size = new System.Drawing.Size(143, 13);
            this.lblClientMedicalConditionAdd.TabIndex = 4;
            this.lblClientMedicalConditionAdd.Text = "Client has Medical Condition:";
            // 
            // lblClientCellNumberAdd
            // 
            this.lblClientCellNumberAdd.AutoSize = true;
            this.lblClientCellNumberAdd.Location = new System.Drawing.Point(174, 265);
            this.lblClientCellNumberAdd.Name = "lblClientCellNumberAdd";
            this.lblClientCellNumberAdd.Size = new System.Drawing.Size(96, 13);
            this.lblClientCellNumberAdd.TabIndex = 3;
            this.lblClientCellNumberAdd.Text = "Client Cell Number:";
            // 
            // lblClientDateOfBirth
            // 
            this.lblClientDateOfBirth.AutoSize = true;
            this.lblClientDateOfBirth.Location = new System.Drawing.Point(174, 133);
            this.lblClientDateOfBirth.Name = "lblClientDateOfBirth";
            this.lblClientDateOfBirth.Size = new System.Drawing.Size(100, 13);
            this.lblClientDateOfBirth.TabIndex = 2;
            this.lblClientDateOfBirth.Text = "Client Date Of Birth:";
            // 
            // lblClientSurnameAdd
            // 
            this.lblClientSurnameAdd.AutoSize = true;
            this.lblClientSurnameAdd.Location = new System.Drawing.Point(174, 59);
            this.lblClientSurnameAdd.Name = "lblClientSurnameAdd";
            this.lblClientSurnameAdd.Size = new System.Drawing.Size(81, 13);
            this.lblClientSurnameAdd.TabIndex = 1;
            this.lblClientSurnameAdd.Text = "Client Surname:";
            // 
            // lblClientNameAdd
            // 
            this.lblClientNameAdd.AutoSize = true;
            this.lblClientNameAdd.Location = new System.Drawing.Point(174, 22);
            this.lblClientNameAdd.Name = "lblClientNameAdd";
            this.lblClientNameAdd.Size = new System.Drawing.Size(67, 13);
            this.lblClientNameAdd.TabIndex = 0;
            this.lblClientNameAdd.Text = "Client Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClientUpdate);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.dgvUpdateClients);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDateOfBirthClientUpdate);
            this.groupBox2.Controls.Add(this.lblNameClientUpdate);
            this.groupBox2.Controls.Add(this.edtClientMedicalConditionUpdate);
            this.groupBox2.Controls.Add(this.edtClientCellNumberUpdate);
            this.groupBox2.Controls.Add(this.edtClientSurnameUpdate);
            this.groupBox2.Controls.Add(this.lblClientMedicalConditionUpdate);
            this.groupBox2.Controls.Add(this.lblClientCellNumberUpdate);
            this.groupBox2.Controls.Add(this.lblClientDateOfBirthUpdate);
            this.groupBox2.Controls.Add(this.lblClientSurnameUpdate);
            this.groupBox2.Controls.Add(this.lblClientNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 168);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Clients";
            // 
            // lblClientMedicalConditionUpdate
            // 
            this.lblClientMedicalConditionUpdate.AutoSize = true;
            this.lblClientMedicalConditionUpdate.Location = new System.Drawing.Point(219, 16);
            this.lblClientMedicalConditionUpdate.Name = "lblClientMedicalConditionUpdate";
            this.lblClientMedicalConditionUpdate.Size = new System.Drawing.Size(123, 13);
            this.lblClientMedicalConditionUpdate.TabIndex = 4;
            this.lblClientMedicalConditionUpdate.Text = "Client Medical Condition:";
            // 
            // lblClientCellNumberUpdate
            // 
            this.lblClientCellNumberUpdate.AutoSize = true;
            this.lblClientCellNumberUpdate.Location = new System.Drawing.Point(18, 125);
            this.lblClientCellNumberUpdate.Name = "lblClientCellNumberUpdate";
            this.lblClientCellNumberUpdate.Size = new System.Drawing.Size(96, 13);
            this.lblClientCellNumberUpdate.TabIndex = 3;
            this.lblClientCellNumberUpdate.Text = "Client Cell Number:";
            // 
            // lblClientDateOfBirthUpdate
            // 
            this.lblClientDateOfBirthUpdate.AutoSize = true;
            this.lblClientDateOfBirthUpdate.Location = new System.Drawing.Point(219, 74);
            this.lblClientDateOfBirthUpdate.Name = "lblClientDateOfBirthUpdate";
            this.lblClientDateOfBirthUpdate.Size = new System.Drawing.Size(100, 13);
            this.lblClientDateOfBirthUpdate.TabIndex = 2;
            this.lblClientDateOfBirthUpdate.Text = "Client Date Of Birth:";
            // 
            // lblClientSurnameUpdate
            // 
            this.lblClientSurnameUpdate.AutoSize = true;
            this.lblClientSurnameUpdate.Location = new System.Drawing.Point(21, 74);
            this.lblClientSurnameUpdate.Name = "lblClientSurnameUpdate";
            this.lblClientSurnameUpdate.Size = new System.Drawing.Size(81, 13);
            this.lblClientSurnameUpdate.TabIndex = 1;
            this.lblClientSurnameUpdate.Text = "Client Surname:";
            // 
            // lblClientNameUpdate
            // 
            this.lblClientNameUpdate.AutoSize = true;
            this.lblClientNameUpdate.Location = new System.Drawing.Point(21, 22);
            this.lblClientNameUpdate.Name = "lblClientNameUpdate";
            this.lblClientNameUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblClientNameUpdate.TabIndex = 0;
            this.lblClientNameUpdate.Text = "Client Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.dgvDeleteClients);
            this.tabPage4.Controls.Add(this.btnClientDelete);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Client";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // edtClientSurnameUpdate
            // 
            this.edtClientSurnameUpdate.Location = new System.Drawing.Point(24, 90);
            this.edtClientSurnameUpdate.Name = "edtClientSurnameUpdate";
            this.edtClientSurnameUpdate.Size = new System.Drawing.Size(173, 20);
            this.edtClientSurnameUpdate.TabIndex = 7;
            // 
            // edtClientCellNumberUpdate
            // 
            this.edtClientCellNumberUpdate.Location = new System.Drawing.Point(24, 141);
            this.edtClientCellNumberUpdate.Name = "edtClientCellNumberUpdate";
            this.edtClientCellNumberUpdate.Size = new System.Drawing.Size(173, 20);
            this.edtClientCellNumberUpdate.TabIndex = 8;
            // 
            // edtClientMedicalConditionUpdate
            // 
            this.edtClientMedicalConditionUpdate.Location = new System.Drawing.Point(222, 35);
            this.edtClientMedicalConditionUpdate.Name = "edtClientMedicalConditionUpdate";
            this.edtClientMedicalConditionUpdate.Size = new System.Drawing.Size(173, 20);
            this.edtClientMedicalConditionUpdate.TabIndex = 9;
            // 
            // dgvUpdateClients
            // 
            this.dgvUpdateClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateClients.Location = new System.Drawing.Point(6, 180);
            this.dgvUpdateClients.Name = "dgvUpdateClients";
            this.dgvUpdateClients.Size = new System.Drawing.Size(756, 214);
            this.dgvUpdateClients.TabIndex = 1;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(455, 99);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(307, 75);
            this.btnClientUpdate.TabIndex = 2;
            this.btnClientUpdate.Text = "Update Client";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblClientDeleteCellNumber);
            this.groupBox3.Controls.Add(this.lblClientDeleteSurname);
            this.groupBox3.Controls.Add(this.lblClientDeleteDateOfBirth);
            this.groupBox3.Controls.Add(this.lblClientDeleteName);
            this.groupBox3.Controls.Add(this.lblClientDateOfBirthDelete);
            this.groupBox3.Controls.Add(this.lblClientCellNumberDelete);
            this.groupBox3.Controls.Add(this.lblClientSurnameDelete);
            this.groupBox3.Controls.Add(this.lblClientNameDelete);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Clients";
            // 
            // btnClientDelete
            // 
            this.btnClientDelete.Location = new System.Drawing.Point(428, 100);
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.Size = new System.Drawing.Size(334, 53);
            this.btnClientDelete.TabIndex = 1;
            this.btnClientDelete.Text = "Delete Client";
            this.btnClientDelete.UseVisualStyleBackColor = true;
            // 
            // dgvDeleteClients
            // 
            this.dgvDeleteClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteClients.Location = new System.Drawing.Point(6, 159);
            this.dgvDeleteClients.Name = "dgvDeleteClients";
            this.dgvDeleteClients.Size = new System.Drawing.Size(756, 235);
            this.dgvDeleteClients.TabIndex = 2;
            // 
            // lblClientNameDelete
            // 
            this.lblClientNameDelete.AutoSize = true;
            this.lblClientNameDelete.Location = new System.Drawing.Point(21, 16);
            this.lblClientNameDelete.Name = "lblClientNameDelete";
            this.lblClientNameDelete.Size = new System.Drawing.Size(67, 13);
            this.lblClientNameDelete.TabIndex = 0;
            this.lblClientNameDelete.Text = "Client Name:";
            // 
            // lblClientSurnameDelete
            // 
            this.lblClientSurnameDelete.AutoSize = true;
            this.lblClientSurnameDelete.Location = new System.Drawing.Point(21, 57);
            this.lblClientSurnameDelete.Name = "lblClientSurnameDelete";
            this.lblClientSurnameDelete.Size = new System.Drawing.Size(81, 13);
            this.lblClientSurnameDelete.TabIndex = 1;
            this.lblClientSurnameDelete.Text = "Client Surname:";
            // 
            // lblClientCellNumberDelete
            // 
            this.lblClientCellNumberDelete.AutoSize = true;
            this.lblClientCellNumberDelete.Location = new System.Drawing.Point(222, 13);
            this.lblClientCellNumberDelete.Name = "lblClientCellNumberDelete";
            this.lblClientCellNumberDelete.Size = new System.Drawing.Size(96, 13);
            this.lblClientCellNumberDelete.TabIndex = 2;
            this.lblClientCellNumberDelete.Text = "Client Cell Number:";
            // 
            // lblClientDateOfBirthDelete
            // 
            this.lblClientDateOfBirthDelete.AutoSize = true;
            this.lblClientDateOfBirthDelete.Location = new System.Drawing.Point(222, 57);
            this.lblClientDateOfBirthDelete.Name = "lblClientDateOfBirthDelete";
            this.lblClientDateOfBirthDelete.Size = new System.Drawing.Size(100, 13);
            this.lblClientDateOfBirthDelete.TabIndex = 4;
            this.lblClientDateOfBirthDelete.Text = "Client Date Of Birth:";
            // 
            // lblNameClientUpdate
            // 
            this.lblNameClientUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameClientUpdate.Location = new System.Drawing.Point(21, 35);
            this.lblNameClientUpdate.Name = "lblNameClientUpdate";
            this.lblNameClientUpdate.Size = new System.Drawing.Size(176, 23);
            this.lblNameClientUpdate.TabIndex = 10;
            this.lblNameClientUpdate.Text = "label1";
            this.lblNameClientUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateOfBirthClientUpdate
            // 
            this.lblDateOfBirthClientUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateOfBirthClientUpdate.Location = new System.Drawing.Point(222, 87);
            this.lblDateOfBirthClientUpdate.Name = "lblDateOfBirthClientUpdate";
            this.lblDateOfBirthClientUpdate.Size = new System.Drawing.Size(176, 23);
            this.lblDateOfBirthClientUpdate.TabIndex = 11;
            this.lblDateOfBirthClientUpdate.Text = "label2";
            this.lblDateOfBirthClientUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edtNameClientSearch);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(455, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 87);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name:";
            // 
            // edtNameClientSearch
            // 
            this.edtNameClientSearch.Location = new System.Drawing.Point(9, 49);
            this.edtNameClientSearch.Name = "edtNameClientSearch";
            this.edtNameClientSearch.Size = new System.Drawing.Size(292, 20);
            this.edtNameClientSearch.TabIndex = 1;
            // 
            // lblClientDeleteName
            // 
            this.lblClientDeleteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientDeleteName.Location = new System.Drawing.Point(24, 28);
            this.lblClientDeleteName.Name = "lblClientDeleteName";
            this.lblClientDeleteName.Size = new System.Drawing.Size(176, 23);
            this.lblClientDeleteName.TabIndex = 11;
            this.lblClientDeleteName.Text = "label1";
            this.lblClientDeleteName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClientDeleteDateOfBirth
            // 
            this.lblClientDeleteDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientDeleteDateOfBirth.Location = new System.Drawing.Point(225, 77);
            this.lblClientDeleteDateOfBirth.Name = "lblClientDeleteDateOfBirth";
            this.lblClientDeleteDateOfBirth.Size = new System.Drawing.Size(176, 23);
            this.lblClientDeleteDateOfBirth.TabIndex = 12;
            this.lblClientDeleteDateOfBirth.Text = "label1";
            this.lblClientDeleteDateOfBirth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClientDeleteSurname
            // 
            this.lblClientDeleteSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientDeleteSurname.Location = new System.Drawing.Point(24, 77);
            this.lblClientDeleteSurname.Name = "lblClientDeleteSurname";
            this.lblClientDeleteSurname.Size = new System.Drawing.Size(176, 23);
            this.lblClientDeleteSurname.TabIndex = 13;
            this.lblClientDeleteSurname.Text = "label1";
            this.lblClientDeleteSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClientDeleteCellNumber
            // 
            this.lblClientDeleteCellNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientDeleteCellNumber.Location = new System.Drawing.Point(225, 26);
            this.lblClientDeleteCellNumber.Name = "lblClientDeleteCellNumber";
            this.lblClientDeleteCellNumber.Size = new System.Drawing.Size(176, 23);
            this.lblClientDeleteCellNumber.TabIndex = 14;
            this.lblClientDeleteCellNumber.Text = "label1";
            this.lblClientDeleteCellNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.edtClientSearchName);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(428, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 88);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Name:";
            // 
            // edtClientSearchName
            // 
            this.edtClientSearchName.Location = new System.Drawing.Point(17, 50);
            this.edtClientSearchName.Name = "edtClientSearchName";
            this.edtClientSearchName.Size = new System.Drawing.Size(311, 20);
            this.edtClientSearchName.TabIndex = 1;
            // 
            // cbxClientMedicalCondition
            // 
            this.cbxClientMedicalCondition.AutoSize = true;
            this.cbxClientMedicalCondition.Location = new System.Drawing.Point(331, 299);
            this.cbxClientMedicalCondition.Name = "cbxClientMedicalCondition";
            this.cbxClientMedicalCondition.Size = new System.Drawing.Size(15, 14);
            this.cbxClientMedicalCondition.TabIndex = 12;
            this.cbxClientMedicalCondition.UseVisualStyleBackColor = true;
            // 
            // Maintain_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Maintain_Clients";
            this.Text = "Maintain_Clients";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateClients)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteClients)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDisplayClients;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.TextBox edtCellNumberSearch;
        private System.Windows.Forms.TextBox edtSurnameSearch;
        private System.Windows.Forms.TextBox edtNameSearch;
        private System.Windows.Forms.Label lblCellNumberSearch;
        private System.Windows.Forms.Label lblSurnameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Label lblClientMedicalConditionAdd;
        private System.Windows.Forms.Label lblClientCellNumberAdd;
        private System.Windows.Forms.Label lblClientDateOfBirth;
        private System.Windows.Forms.Label lblClientSurnameAdd;
        private System.Windows.Forms.Label lblClientNameAdd;
        private System.Windows.Forms.TextBox edtClientCellNumberAdd;
        private System.Windows.Forms.TextBox edtClientSurnameAdd;
        private System.Windows.Forms.TextBox edtClientNameAdd;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.MonthCalendar calClientDateOfBirthAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblClientMedicalConditionUpdate;
        private System.Windows.Forms.Label lblClientCellNumberUpdate;
        private System.Windows.Forms.Label lblClientDateOfBirthUpdate;
        private System.Windows.Forms.Label lblClientSurnameUpdate;
        private System.Windows.Forms.Label lblClientNameUpdate;
        private System.Windows.Forms.TextBox edtClientMedicalConditionUpdate;
        private System.Windows.Forms.TextBox edtClientCellNumberUpdate;
        private System.Windows.Forms.TextBox edtClientSurnameUpdate;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.DataGridView dgvUpdateClients;
        private System.Windows.Forms.DataGridView dgvDeleteClients;
        private System.Windows.Forms.Button btnClientDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblClientDateOfBirthDelete;
        private System.Windows.Forms.Label lblClientCellNumberDelete;
        private System.Windows.Forms.Label lblClientSurnameDelete;
        private System.Windows.Forms.Label lblClientNameDelete;
        private System.Windows.Forms.Label lblDateOfBirthClientUpdate;
        private System.Windows.Forms.Label lblNameClientUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox edtNameClientSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientDeleteCellNumber;
        private System.Windows.Forms.Label lblClientDeleteSurname;
        private System.Windows.Forms.Label lblClientDeleteDateOfBirth;
        private System.Windows.Forms.Label lblClientDeleteName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox edtClientSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxClientMedicalCondition;
    }
}