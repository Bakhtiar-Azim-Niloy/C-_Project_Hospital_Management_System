
namespace HMS.Forms
{
    partial class StaffForm
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
            this.StaffDownPanel = new System.Windows.Forms.Panel();
            this.btnPatientPanel = new System.Windows.Forms.Button();
            this.btnCheckoutPanel = new System.Windows.Forms.Button();
            this.btnChangePasswordStaff = new System.Windows.Forms.Button();
            this.btnLogoutStaff = new System.Windows.Forms.Button();
            this.StaffButtonPanel = new System.Windows.Forms.Panel();
            this.staffPasswordChange1 = new HMS.Forms.User_Controll.StaffPasswordChange();
            this.checkOutUserControl1 = new HMS.Forms.User_Controll.CheckOutUserControl();
            this.addNewPatient1 = new HMS.Forms.User_Controll.AddNewPatient();
            this.StaffDownPanel.SuspendLayout();
            this.StaffButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffDownPanel
            // 
            this.StaffDownPanel.Controls.Add(this.staffPasswordChange1);
            this.StaffDownPanel.Controls.Add(this.checkOutUserControl1);
            this.StaffDownPanel.Controls.Add(this.addNewPatient1);
            this.StaffDownPanel.Location = new System.Drawing.Point(12, 75);
            this.StaffDownPanel.Name = "StaffDownPanel";
            this.StaffDownPanel.Size = new System.Drawing.Size(779, 394);
            this.StaffDownPanel.TabIndex = 5;
            // 
            // btnPatientPanel
            // 
            this.btnPatientPanel.AccessibleName = "btnPatientPanelStaff";
            this.btnPatientPanel.Location = new System.Drawing.Point(12, 4);
            this.btnPatientPanel.Name = "btnPatientPanel";
            this.btnPatientPanel.Size = new System.Drawing.Size(122, 53);
            this.btnPatientPanel.TabIndex = 1;
            this.btnPatientPanel.Text = "Patient panel";
            this.btnPatientPanel.UseVisualStyleBackColor = true;
            this.btnPatientPanel.Click += new System.EventHandler(this.btnPatientPanel_Click);
            // 
            // btnCheckoutPanel
            // 
            this.btnCheckoutPanel.AccessibleName = "btnPrescriptionPanel";
            this.btnCheckoutPanel.Location = new System.Drawing.Point(164, 5);
            this.btnCheckoutPanel.Name = "btnCheckoutPanel";
            this.btnCheckoutPanel.Size = new System.Drawing.Size(132, 52);
            this.btnCheckoutPanel.TabIndex = 2;
            this.btnCheckoutPanel.Text = "Check Out";
            this.btnCheckoutPanel.UseVisualStyleBackColor = true;
            this.btnCheckoutPanel.Click += new System.EventHandler(this.btnCheckoutPanel_Click);
            // 
            // btnChangePasswordStaff
            // 
            this.btnChangePasswordStaff.AccessibleName = "btnChangePassword";
            this.btnChangePasswordStaff.Location = new System.Drawing.Point(339, 5);
            this.btnChangePasswordStaff.Name = "btnChangePasswordStaff";
            this.btnChangePasswordStaff.Size = new System.Drawing.Size(131, 52);
            this.btnChangePasswordStaff.TabIndex = 4;
            this.btnChangePasswordStaff.Text = "Change Password";
            this.btnChangePasswordStaff.UseVisualStyleBackColor = true;
            this.btnChangePasswordStaff.Click += new System.EventHandler(this.btnChangePasswordStaff_Click);
            // 
            // btnLogoutStaff
            // 
            this.btnLogoutStaff.AccessibleName = "btnLogout";
            this.btnLogoutStaff.Location = new System.Drawing.Point(648, 5);
            this.btnLogoutStaff.Name = "btnLogoutStaff";
            this.btnLogoutStaff.Size = new System.Drawing.Size(75, 52);
            this.btnLogoutStaff.TabIndex = 5;
            this.btnLogoutStaff.Text = "Log out";
            this.btnLogoutStaff.UseVisualStyleBackColor = true;
            this.btnLogoutStaff.Click += new System.EventHandler(this.btnLogoutStaff_Click);
            // 
            // StaffButtonPanel
            // 
            this.StaffButtonPanel.AccessibleName = "adminLeftPanel";
            this.StaffButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffButtonPanel.Controls.Add(this.btnLogoutStaff);
            this.StaffButtonPanel.Controls.Add(this.btnChangePasswordStaff);
            this.StaffButtonPanel.Controls.Add(this.btnCheckoutPanel);
            this.StaffButtonPanel.Controls.Add(this.btnPatientPanel);
            this.StaffButtonPanel.Location = new System.Drawing.Point(13, 10);
            this.StaffButtonPanel.Name = "StaffButtonPanel";
            this.StaffButtonPanel.Size = new System.Drawing.Size(779, 59);
            this.StaffButtonPanel.TabIndex = 4;
            // 
            // staffPasswordChange1
            // 
            this.staffPasswordChange1.Admin1 = null;
            this.staffPasswordChange1.Doctor1 = null;
            this.staffPasswordChange1.Location = new System.Drawing.Point(1, 14);
            this.staffPasswordChange1.Name = "staffPasswordChange1";
            this.staffPasswordChange1.Size = new System.Drawing.Size(778, 321);
            this.staffPasswordChange1.Staff1 = null;
            this.staffPasswordChange1.TabIndex = 2;
            this.staffPasswordChange1.Visible = false;
            // 
            // checkOutUserControl1
            // 
            this.checkOutUserControl1.Location = new System.Drawing.Point(60, 3);
            this.checkOutUserControl1.Name = "checkOutUserControl1";
            this.checkOutUserControl1.Size = new System.Drawing.Size(603, 364);
            this.checkOutUserControl1.TabIndex = 1;
            this.checkOutUserControl1.Visible = false;
            // 
            // addNewPatient1
            // 
            this.addNewPatient1.Location = new System.Drawing.Point(60, 0);
            this.addNewPatient1.Name = "addNewPatient1";
            this.addNewPatient1.Size = new System.Drawing.Size(603, 382);
            this.addNewPatient1.TabIndex = 0;
            this.addNewPatient1.Visible = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.StaffButtonPanel);
            this.Controls.Add(this.StaffDownPanel);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.StaffDownPanel.ResumeLayout(false);
            this.StaffButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StaffDownPanel;
        private System.Windows.Forms.Button btnPatientPanel;
        private System.Windows.Forms.Button btnCheckoutPanel;
        private System.Windows.Forms.Button btnChangePasswordStaff;
        private System.Windows.Forms.Button btnLogoutStaff;
        private System.Windows.Forms.Panel StaffButtonPanel;
        private User_Controll.AddNewPatient addNewPatient1;
        private User_Controll.StaffPasswordChange staffPasswordChange1;
        private User_Controll.CheckOutUserControl checkOutUserControl1;
    }
}