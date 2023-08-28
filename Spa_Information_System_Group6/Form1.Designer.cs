
namespace Spa_Information_System_Group6
{
    partial class LogIn
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
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(100, 136);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(61, 13);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password :";
            // 
            // txbxPassword
            // 
            this.txbxPassword.Location = new System.Drawing.Point(182, 187);
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Size = new System.Drawing.Size(157, 20);
            this.txbxPassword.TabIndex = 1;
            this.txbxPassword.UseSystemPasswordChar = true;
            // 
            // txbxUsername
            // 
            this.txbxUsername.Location = new System.Drawing.Point(182, 133);
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(157, 20);
            this.txbxUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rest Assured Spa ";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbxUsername);
            this.Controls.Add(this.txbxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLbl);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxPassword;
        private System.Windows.Forms.TextBox txbxUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
    }
}

