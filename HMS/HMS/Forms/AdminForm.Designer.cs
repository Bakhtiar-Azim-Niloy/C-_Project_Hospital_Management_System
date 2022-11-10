
namespace HMS.Forms
{
    partial class AdminForm
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
            this.adminLeftPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnWardPanel = new System.Windows.Forms.Button();
            this.btnStaffPanel = new System.Windows.Forms.Button();
            this.btnDoctorPanel = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wardUserControll1 = new HMS.Forms.User_Controll.WardUserControll();
            this.doctorUserControll1 = new HMS.Forms.User_Controll.DoctorUserControll();
            this.staffUserControll2 = new HMS.Forms.User_Controll.StaffUserControll();
            this.changePasswordUserControll1 = new HMS.Forms.User_Controll.ChangePasswordUserControll();
            this.detailsUserControll1 = new HMS.Forms.UserControll.DetailsUserControll();
            this.adminLeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLeftPanel
            // 
            this.adminLeftPanel.AccessibleName = "adminLeftPanel";
            this.adminLeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminLeftPanel.Controls.Add(this.btnLogout);
            this.adminLeftPanel.Controls.Add(this.btnChangePassword);
            this.adminLeftPanel.Controls.Add(this.btnWardPanel);
            this.adminLeftPanel.Controls.Add(this.btnStaffPanel);
            this.adminLeftPanel.Controls.Add(this.btnDoctorPanel);
            this.adminLeftPanel.Controls.Add(this.btnAdminPanel);
            this.adminLeftPanel.Location = new System.Drawing.Point(1, 12);
            this.adminLeftPanel.Name = "adminLeftPanel";
            this.adminLeftPanel.Size = new System.Drawing.Size(921, 70);
            this.adminLeftPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleName = "btnLogout";
            this.btnLogout.Location = new System.Drawing.Point(843, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 52);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AccessibleName = "btnChangePassword";
            this.btnChangePassword.Location = new System.Drawing.Point(542, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 52);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnWardPanel
            // 
            this.btnWardPanel.AccessibleName = "btnWardPanel";
            this.btnWardPanel.Location = new System.Drawing.Point(402, 5);
            this.btnWardPanel.Name = "btnWardPanel";
            this.btnWardPanel.Size = new System.Drawing.Size(134, 52);
            this.btnWardPanel.TabIndex = 3;
            this.btnWardPanel.Text = "Ward Panel";
            this.btnWardPanel.UseVisualStyleBackColor = true;
            this.btnWardPanel.Click += new System.EventHandler(this.btnWardPanel_Click);
            // 
            // btnStaffPanel
            // 
            this.btnStaffPanel.AccessibleName = "btnStaffPanel";
            this.btnStaffPanel.Location = new System.Drawing.Point(264, 5);
            this.btnStaffPanel.Name = "btnStaffPanel";
            this.btnStaffPanel.Size = new System.Drawing.Size(132, 52);
            this.btnStaffPanel.TabIndex = 2;
            this.btnStaffPanel.Text = "Staff Panel";
            this.btnStaffPanel.UseVisualStyleBackColor = true;
            this.btnStaffPanel.Click += new System.EventHandler(this.btnStaffPanel_Click);
            // 
            // btnDoctorPanel
            // 
            this.btnDoctorPanel.AccessibleName = "btnDoctorPanel";
            this.btnDoctorPanel.Location = new System.Drawing.Point(136, 3);
            this.btnDoctorPanel.Name = "btnDoctorPanel";
            this.btnDoctorPanel.Size = new System.Drawing.Size(122, 53);
            this.btnDoctorPanel.TabIndex = 1;
            this.btnDoctorPanel.Text = "Doctor panel";
            this.btnDoctorPanel.UseVisualStyleBackColor = true;
            this.btnDoctorPanel.Click += new System.EventHandler(this.btnDoctorPanel_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.AccessibleName = "btnAdminPanel";
            this.btnAdminPanel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(130, 53);
            this.btnAdminPanel.TabIndex = 0;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wardUserControll1);
            this.panel1.Controls.Add(this.doctorUserControll1);
            this.panel1.Controls.Add(this.staffUserControll2);
            this.panel1.Controls.Add(this.changePasswordUserControll1);
            this.panel1.Controls.Add(this.detailsUserControll1);
            this.panel1.Location = new System.Drawing.Point(1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 521);
            this.panel1.TabIndex = 1;
            // 
            // wardUserControll1
            // 
            this.wardUserControll1.Location = new System.Drawing.Point(436, 358);
            this.wardUserControll1.Name = "wardUserControll1";
            this.wardUserControll1.Size = new System.Drawing.Size(458, 142);
            this.wardUserControll1.TabIndex = 4;
            this.wardUserControll1.Visible = false;
            // 
            // doctorUserControll1
            // 
            this.doctorUserControll1.Location = new System.Drawing.Point(21, 311);
            this.doctorUserControll1.Name = "doctorUserControll1";
            this.doctorUserControll1.Size = new System.Drawing.Size(375, 207);
            this.doctorUserControll1.TabIndex = 3;
            this.doctorUserControll1.Visible = false;
            // 
            // staffUserControll2
            // 
            this.staffUserControll2.Location = new System.Drawing.Point(637, 35);
            this.staffUserControll2.Name = "staffUserControll2";
            this.staffUserControll2.Size = new System.Drawing.Size(247, 265);
            this.staffUserControll2.TabIndex = 2;
            this.staffUserControll2.Visible = false;
            // 
            // changePasswordUserControll1
            // 
            this.changePasswordUserControll1.Admin1 = null;
            this.changePasswordUserControll1.Doctor1 = null;
            this.changePasswordUserControll1.Location = new System.Drawing.Point(387, 3);
            this.changePasswordUserControll1.Name = "changePasswordUserControll1";
            this.changePasswordUserControll1.Size = new System.Drawing.Size(209, 237);
            this.changePasswordUserControll1.Staff1 = null;
            this.changePasswordUserControll1.TabIndex = 1;
            this.changePasswordUserControll1.Visible = false;
            // 
            // detailsUserControll1
            // 
            this.detailsUserControll1.Location = new System.Drawing.Point(10, 18);
            this.detailsUserControll1.Name = "detailsUserControll1";
            this.detailsUserControll1.Size = new System.Drawing.Size(322, 211);
            this.detailsUserControll1.TabIndex = 0;
            this.detailsUserControll1.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminLeftPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.adminLeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminLeftPanel;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnWardPanel;
        private System.Windows.Forms.Button btnStaffPanel;
        private System.Windows.Forms.Button btnDoctorPanel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private UserControll.DetailsUserControll detailsUserControll1;
        private User_Controll.ChangePasswordUserControll changePasswordUserControll1;
        
        private User_Controll.StaffUserControll staffUserControll2;
        private User_Controll.DoctorUserControll doctorUserControll1;
        private User_Controll.WardUserControll wardUserControll1;
    }
}