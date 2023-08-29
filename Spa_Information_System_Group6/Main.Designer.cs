
namespace Spa_Information_System_Group6
{
    partial class Main
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
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTreatments = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(445, 279);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(157, 78);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employee Manager";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Visible = false;
            // 
            // btnTreatments
            // 
            this.btnTreatments.Location = new System.Drawing.Point(200, 279);
            this.btnTreatments.Name = "btnTreatments";
            this.btnTreatments.Size = new System.Drawing.Size(157, 78);
            this.btnTreatments.TabIndex = 2;
            this.btnTreatments.Text = "Treatment Manager";
            this.btnTreatments.UseVisualStyleBackColor = true;
            this.btnTreatments.Visible = false;
            this.btnTreatments.Click += new System.EventHandler(this.btnTreatments_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(200, 128);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(157, 78);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Client Manager";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(445, 128);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(157, 78);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Booking Manager";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spa management system.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnTreatments);
            this.Controls.Add(this.btnEmployees);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnTreatments;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label label1;
    }
}