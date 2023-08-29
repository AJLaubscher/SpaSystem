
namespace Spa_Information_System_Group6
{
    partial class Maintain_Treatments
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
            this.tabControlTreatments = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.groupBoxSearchTreatments = new System.Windows.Forms.GroupBox();
            this.txbxSearchTreatments = new System.Windows.Forms.TextBox();
            this.cmboBoxTeatments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAllTreatments = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbx_Type = new System.Windows.Forms.ComboBox();
            this.txbxDurationAdd = new System.Windows.Forms.TextBox();
            this.txbxPriceAdd = new System.Windows.Forms.TextBox();
            this.txbxNameAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbxSrchName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.txbxDuration = new System.Windows.Forms.TextBox();
            this.txbxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dGrdViewUptTreat = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetDelete = new System.Windows.Forms.Button();
            this.cmboDelete = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbxSrchDelete = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDur_Del = new System.Windows.Forms.Label();
            this.lblName_Del = new System.Windows.Forms.Label();
            this.lblPrice_Del = new System.Windows.Forms.Label();
            this.lblType_Del = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.errorProviderTreatments = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlTreatments.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSearchTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTreatments)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewUptTreat)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTreatments
            // 
            this.tabControlTreatments.Controls.Add(this.tabPage1);
            this.tabControlTreatments.Controls.Add(this.tabPage2);
            this.tabControlTreatments.Controls.Add(this.tabPage3);
            this.tabControlTreatments.Controls.Add(this.tabPage4);
            this.tabControlTreatments.Location = new System.Drawing.Point(2, 1);
            this.tabControlTreatments.Name = "tabControlTreatments";
            this.tabControlTreatments.SelectedIndex = 0;
            this.tabControlTreatments.Size = new System.Drawing.Size(798, 446);
            this.tabControlTreatments.TabIndex = 0;
            this.tabControlTreatments.SelectedIndexChanged += new System.EventHandler(this.tabControlTreatments_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDisplayAll);
            this.tabPage1.Controls.Add(this.groupBoxSearchTreatments);
            this.tabPage1.Controls.Add(this.dataGridViewAllTreatments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Treatments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(515, 79);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(186, 51);
            this.btnDisplayAll.TabIndex = 2;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // groupBoxSearchTreatments
            // 
            this.groupBoxSearchTreatments.Controls.Add(this.txbxSearchTreatments);
            this.groupBoxSearchTreatments.Controls.Add(this.cmboBoxTeatments);
            this.groupBoxSearchTreatments.Controls.Add(this.label2);
            this.groupBoxSearchTreatments.Controls.Add(this.label1);
            this.groupBoxSearchTreatments.Location = new System.Drawing.Point(44, 27);
            this.groupBoxSearchTreatments.Name = "groupBoxSearchTreatments";
            this.groupBoxSearchTreatments.Size = new System.Drawing.Size(371, 148);
            this.groupBoxSearchTreatments.TabIndex = 1;
            this.groupBoxSearchTreatments.TabStop = false;
            this.groupBoxSearchTreatments.Text = "Search Treatments";
            // 
            // txbxSearchTreatments
            // 
            this.txbxSearchTreatments.Location = new System.Drawing.Point(142, 40);
            this.txbxSearchTreatments.Name = "txbxSearchTreatments";
            this.txbxSearchTreatments.Size = new System.Drawing.Size(190, 20);
            this.txbxSearchTreatments.TabIndex = 3;
            this.txbxSearchTreatments.TextChanged += new System.EventHandler(this.textBoxSearchTreatments_TextChanged);
            // 
            // cmboBoxTeatments
            // 
            this.cmboBoxTeatments.FormattingEnabled = true;
            this.cmboBoxTeatments.Location = new System.Drawing.Point(142, 82);
            this.cmboBoxTeatments.Name = "cmboBoxTeatments";
            this.cmboBoxTeatments.Size = new System.Drawing.Size(190, 21);
            this.cmboBoxTeatments.TabIndex = 2;
            this.cmboBoxTeatments.SelectedIndexChanged += new System.EventHandler(this.cmboBoxTeatments_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Treatment Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Treatment:";
            // 
            // dataGridViewAllTreatments
            // 
            this.dataGridViewAllTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllTreatments.Location = new System.Drawing.Point(15, 206);
            this.dataGridViewAllTreatments.Name = "dataGridViewAllTreatments";
            this.dataGridViewAllTreatments.Size = new System.Drawing.Size(767, 178);
            this.dataGridViewAllTreatments.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.cmbx_Type);
            this.tabPage2.Controls.Add(this.txbxDurationAdd);
            this.tabPage2.Controls.Add(this.txbxPriceAdd);
            this.tabPage2.Controls.Add(this.txbxNameAdd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Treatment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Treatment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbx_Type
            // 
            this.cmbx_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Type.FormattingEnabled = true;
            this.cmbx_Type.Items.AddRange(new object[] {
            "Massages",
            "Facials",
            "Tinting",
            "Wax",
            "Gel_Overlay"});
            this.cmbx_Type.Location = new System.Drawing.Point(356, 28);
            this.cmbx_Type.Name = "cmbx_Type";
            this.cmbx_Type.Size = new System.Drawing.Size(169, 32);
            this.cmbx_Type.TabIndex = 7;
            this.cmbx_Type.SelectedIndexChanged += new System.EventHandler(this.cmbx_Type_SelectedIndexChanged);
            // 
            // txbxDurationAdd
            // 
            this.txbxDurationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDurationAdd.Location = new System.Drawing.Point(356, 238);
            this.txbxDurationAdd.Name = "txbxDurationAdd";
            this.txbxDurationAdd.Size = new System.Drawing.Size(169, 29);
            this.txbxDurationAdd.TabIndex = 6;
            // 
            // txbxPriceAdd
            // 
            this.txbxPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPriceAdd.Location = new System.Drawing.Point(356, 168);
            this.txbxPriceAdd.Name = "txbxPriceAdd";
            this.txbxPriceAdd.Size = new System.Drawing.Size(169, 29);
            this.txbxPriceAdd.TabIndex = 5;
            // 
            // txbxNameAdd
            // 
            this.txbxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNameAdd.Location = new System.Drawing.Point(356, 99);
            this.txbxNameAdd.Name = "txbxNameAdd";
            this.txbxNameAdd.Size = new System.Drawing.Size(169, 29);
            this.txbxNameAdd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Treatment Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Treatment Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Treatment Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dGrdViewUptTreat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Treatment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbxSrchName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(29, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 216);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Treatment";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(24, 118);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(154, 28);
            this.cmbType.TabIndex = 13;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Treatment Type:";
            // 
            // txbxSrchName
            // 
            this.txbxSrchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSrchName.Location = new System.Drawing.Point(24, 49);
            this.txbxSrchName.Name = "txbxSrchName";
            this.txbxSrchName.Size = new System.Drawing.Size(154, 26);
            this.txbxSrchName.TabIndex = 11;
            this.txbxSrchName.TextChanged += new System.EventHandler(this.txbxSrchName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Treatment Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txbxName);
            this.groupBox1.Controls.Add(this.txbxDuration);
            this.groupBox1.Controls.Add(this.txbxPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(258, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(34, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(154, 23);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "...";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 32);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbxName
            // 
            this.txbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxName.Location = new System.Drawing.Point(34, 130);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(154, 26);
            this.txbxName.TabIndex = 10;
            // 
            // txbxDuration
            // 
            this.txbxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDuration.Location = new System.Drawing.Point(289, 130);
            this.txbxDuration.Name = "txbxDuration";
            this.txbxDuration.Size = new System.Drawing.Size(154, 26);
            this.txbxDuration.TabIndex = 9;
            // 
            // txbxPrice
            // 
            this.txbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPrice.Location = new System.Drawing.Point(289, 49);
            this.txbxPrice.Name = "txbxPrice";
            this.txbxPrice.Size = new System.Drawing.Size(154, 26);
            this.txbxPrice.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Treatment Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Treatment Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Duration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Treatment Price:";
            // 
            // dGrdViewUptTreat
            // 
            this.dGrdViewUptTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdViewUptTreat.Location = new System.Drawing.Point(29, 239);
            this.dGrdViewUptTreat.Name = "dGrdViewUptTreat";
            this.dGrdViewUptTreat.Size = new System.Drawing.Size(713, 150);
            this.dGrdViewUptTreat.TabIndex = 0;
            this.dGrdViewUptTreat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrdViewUptTreat_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewDelete);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Treatment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(27, 244);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.Size = new System.Drawing.Size(713, 150);
            this.dataGridViewDelete.TabIndex = 12;
            this.dataGridViewDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelete_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResetDelete);
            this.groupBox3.Controls.Add(this.cmboDelete);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txbxSrchDelete);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(27, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 216);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Treatment";
            // 
            // btnResetDelete
            // 
            this.btnResetDelete.Location = new System.Drawing.Point(55, 165);
            this.btnResetDelete.Name = "btnResetDelete";
            this.btnResetDelete.Size = new System.Drawing.Size(89, 32);
            this.btnResetDelete.TabIndex = 14;
            this.btnResetDelete.Text = "Reset";
            this.btnResetDelete.UseVisualStyleBackColor = true;
            this.btnResetDelete.Click += new System.EventHandler(this.btnResetDelete_Click);
            // 
            // cmboDelete
            // 
            this.cmboDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDelete.FormattingEnabled = true;
            this.cmboDelete.Location = new System.Drawing.Point(24, 115);
            this.cmboDelete.Name = "cmboDelete";
            this.cmboDelete.Size = new System.Drawing.Size(154, 28);
            this.cmboDelete.TabIndex = 13;
            this.cmboDelete.SelectedIndexChanged += new System.EventHandler(this.cmboDelete_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Treatment Type:";
            // 
            // txbxSrchDelete
            // 
            this.txbxSrchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSrchDelete.Location = new System.Drawing.Point(24, 49);
            this.txbxSrchDelete.Name = "txbxSrchDelete";
            this.txbxSrchDelete.Size = new System.Drawing.Size(154, 26);
            this.txbxSrchDelete.TabIndex = 11;
            this.txbxSrchDelete.TextChanged += new System.EventHandler(this.txbxSrchDelete_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Treatment Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDur_Del);
            this.groupBox4.Controls.Add(this.lblName_Del);
            this.groupBox4.Controls.Add(this.lblPrice_Del);
            this.groupBox4.Controls.Add(this.lblType_Del);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(256, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 216);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // lblDur_Del
            // 
            this.lblDur_Del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDur_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDur_Del.Location = new System.Drawing.Point(289, 132);
            this.lblDur_Del.Name = "lblDur_Del";
            this.lblDur_Del.Size = new System.Drawing.Size(154, 23);
            this.lblDur_Del.TabIndex = 16;
            this.lblDur_Del.Text = "...";
            this.lblDur_Del.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblName_Del
            // 
            this.lblName_Del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_Del.Location = new System.Drawing.Point(34, 132);
            this.lblName_Del.Name = "lblName_Del";
            this.lblName_Del.Size = new System.Drawing.Size(154, 23);
            this.lblName_Del.TabIndex = 15;
            this.lblName_Del.Text = "...";
            this.lblName_Del.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPrice_Del
            // 
            this.lblPrice_Del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice_Del.Location = new System.Drawing.Point(289, 52);
            this.lblPrice_Del.Name = "lblPrice_Del";
            this.lblPrice_Del.Size = new System.Drawing.Size(154, 23);
            this.lblPrice_Del.TabIndex = 14;
            this.lblPrice_Del.Text = "...";
            this.lblPrice_Del.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblType_Del
            // 
            this.lblType_Del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType_Del.Location = new System.Drawing.Point(34, 52);
            this.lblType_Del.Name = "lblType_Del";
            this.lblType_Del.Size = new System.Drawing.Size(149, 23);
            this.lblType_Del.TabIndex = 13;
            this.lblType_Del.Text = "...";
            this.lblType_Del.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Treatment Type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Treatment Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(285, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Duration:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(285, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Treatment Price:";
            // 
            // errorProviderTreatments
            // 
            this.errorProviderTreatments.ContainerControl = this;
            // 
            // Maintain_Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTreatments);
            this.Name = "Maintain_Treatments";
            this.Text = "Maintain_Treatments";
            this.Load += new System.EventHandler(this.Maintain_Treatments_Load);
            this.tabControlTreatments.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSearchTreatments.ResumeLayout(false);
            this.groupBoxSearchTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTreatments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewUptTreat)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTreatments;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewAllTreatments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBoxSearchTreatments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.TextBox txbxSearchTreatments;
        private System.Windows.Forms.ComboBox cmboBoxTeatments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGrdViewUptTreat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbx_Type;
        private System.Windows.Forms.TextBox txbxDurationAdd;
        private System.Windows.Forms.TextBox txbxPriceAdd;
        private System.Windows.Forms.TextBox txbxNameAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbxSrchName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.TextBox txbxDuration;
        private System.Windows.Forms.TextBox txbxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProviderTreatments;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmboDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbxSrchDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDur_Del;
        private System.Windows.Forms.Label lblName_Del;
        private System.Windows.Forms.Label lblPrice_Del;
        private System.Windows.Forms.Label lblType_Del;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnResetDelete;
    }
}