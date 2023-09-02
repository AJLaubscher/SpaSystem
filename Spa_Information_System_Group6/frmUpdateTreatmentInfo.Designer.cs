namespace Spa_Information_System_Group6
{
    partial class frmUpdateTreatmentInfo
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
            this.dbGridTreatmentInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearTreatmentInfo = new System.Windows.Forms.Button();
            this.txtTreatmentType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTreatmentName = new System.Windows.Forms.TextBox();
            this.btnChangeTreatment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTreatmentInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridTreatmentInfo
            // 
            this.dbGridTreatmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridTreatmentInfo.Location = new System.Drawing.Point(12, 12);
            this.dbGridTreatmentInfo.Name = "dbGridTreatmentInfo";
            this.dbGridTreatmentInfo.Size = new System.Drawing.Size(512, 224);
            this.dbGridTreatmentInfo.TabIndex = 0;
            this.dbGridTreatmentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridTreatmentInfo_CellClick);
            this.dbGridTreatmentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridTreatmentInfo_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnClearTreatmentInfo);
            this.panel3.Controls.Add(this.txtTreatmentType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTreatmentName);
            this.panel3.Location = new System.Drawing.Point(12, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 149);
            this.panel3.TabIndex = 4;
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
            this.txtTreatmentType.Location = new System.Drawing.Point(145, 61);
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
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search Treatment Type :";
            // 
            // txtTreatmentName
            // 
            this.txtTreatmentName.Location = new System.Drawing.Point(145, 14);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(155, 20);
            this.txtTreatmentName.TabIndex = 2;
            this.txtTreatmentName.TextChanged += new System.EventHandler(this.txtTreatmentName_TextChanged);
            // 
            // btnChangeTreatment
            // 
            this.btnChangeTreatment.Location = new System.Drawing.Point(367, 293);
            this.btnChangeTreatment.Name = "btnChangeTreatment";
            this.btnChangeTreatment.Size = new System.Drawing.Size(157, 23);
            this.btnChangeTreatment.TabIndex = 5;
            this.btnChangeTreatment.Text = "Update TreatmentID";
            this.btnChangeTreatment.UseVisualStyleBackColor = true;
            this.btnChangeTreatment.Click += new System.EventHandler(this.btnChangeTreatment_Click);
            // 
            // frmUpdateTreatmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 413);
            this.Controls.Add(this.btnChangeTreatment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dbGridTreatmentInfo);
            this.Name = "frmUpdateTreatmentInfo";
            this.Text = "frmUpdateTreatmentInfo";
            this.Load += new System.EventHandler(this.frmUpdateTreatmentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTreatmentInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridTreatmentInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearTreatmentInfo;
        private System.Windows.Forms.TextBox txtTreatmentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTreatmentName;
        private System.Windows.Forms.Button btnChangeTreatment;
    }
}