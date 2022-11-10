
namespace HMS.Forms
{
    partial class DoctorForm
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
            this.StaffButtonPanel = new System.Windows.Forms.Panel();
            this.btnLogoutStaff = new System.Windows.Forms.Button();
            this.btnChangePasswordStaff = new System.Windows.Forms.Button();
            this.btnPrescriptionPanel = new System.Windows.Forms.Button();
            this.btnPatientPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientInfoForDoctor1 = new HMS.Forms.User_Controll.PatientInfoForDoctor();
            this.prescription1 = new HMS.Forms.User_Controll.Prescription();
            this.doctorPasswordChange1 = new HMS.Forms.User_Controll.DoctorPasswordChange();
            this.StaffButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffButtonPanel
            // 
            this.StaffButtonPanel.AccessibleName = "adminLeftPanel";
            this.StaffButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffButtonPanel.Controls.Add(this.btnLogoutStaff);
            this.StaffButtonPanel.Controls.Add(this.btnChangePasswordStaff);
            this.StaffButtonPanel.Controls.Add(this.btnPrescriptionPanel);
            this.StaffButtonPanel.Controls.Add(this.btnPatientPanel);
            this.StaffButtonPanel.Location = new System.Drawing.Point(9, 9);
            this.StaffButtonPanel.Name = "StaffButtonPanel";
            this.StaffButtonPanel.Size = new System.Drawing.Size(782, 70);
            this.StaffButtonPanel.TabIndex = 5;
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
            // btnPrescriptionPanel
            // 
            this.btnPrescriptionPanel.AccessibleName = "btnPrescriptionPanel";
            this.btnPrescriptionPanel.Location = new System.Drawing.Point(164, 5);
            this.btnPrescriptionPanel.Name = "btnPrescriptionPanel";
            this.btnPrescriptionPanel.Size = new System.Drawing.Size(132, 52);
            this.btnPrescriptionPanel.TabIndex = 2;
            this.btnPrescriptionPanel.Text = "Prescription";
            this.btnPrescriptionPanel.UseVisualStyleBackColor = true;
            this.btnPrescriptionPanel.Click += new System.EventHandler(this.btnPrescriptionPanel_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.doctorPasswordChange1);
            this.panel1.Controls.Add(this.prescription1);
            this.panel1.Controls.Add(this.patientInfoForDoctor1);
            this.panel1.Location = new System.Drawing.Point(9, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 437);
            this.panel1.TabIndex = 6;
            // 
            // patientInfoForDoctor1
            // 
            this.patientInfoForDoctor1.Location = new System.Drawing.Point(6, 0);
            this.patientInfoForDoctor1.Name = "patientInfoForDoctor1";
            this.patientInfoForDoctor1.Size = new System.Drawing.Size(776, 395);
            this.patientInfoForDoctor1.TabIndex = 0;
            this.patientInfoForDoctor1.Visible = false;
            // 
            // prescription1
            // 
            this.prescription1.Location = new System.Drawing.Point(50, 3);
            this.prescription1.Name = "prescription1";
            this.prescription1.Size = new System.Drawing.Size(653, 410);
            this.prescription1.TabIndex = 1;
            this.prescription1.Visible = false;
            // 
            // doctorPasswordChange1
            // 
            this.doctorPasswordChange1.Admin1 = null;
            this.doctorPasswordChange1.Doctor1 = null;
            this.doctorPasswordChange1.Location = new System.Drawing.Point(0, 20);
            this.doctorPasswordChange1.Name = "doctorPasswordChange1";
            this.doctorPasswordChange1.Size = new System.Drawing.Size(782, 321);
            this.doctorPasswordChange1.Staff1 = null;
            this.doctorPasswordChange1.TabIndex = 2;
            this.doctorPasswordChange1.Visible = false;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.StaffButtonPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.StaffButtonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StaffButtonPanel;
        private System.Windows.Forms.Button btnLogoutStaff;
        private System.Windows.Forms.Button btnChangePasswordStaff;
        private System.Windows.Forms.Button btnPrescriptionPanel;
        private System.Windows.Forms.Button btnPatientPanel;
        private System.Windows.Forms.Panel panel1;
        private User_Controll.DoctorPasswordChange doctorPasswordChange1;
        private User_Controll.Prescription prescription1;
        private User_Controll.PatientInfoForDoctor patientInfoForDoctor1;
    }
}