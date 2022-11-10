using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Entities;
using HMS.Repository;

namespace HMS.Forms
{
    public partial class DoctorForm : Form
    {
        private DoctorRepository adminRepository = new DoctorRepository();
        public Doctor doctor1;
        public DoctorForm(Doctor doctor)
        {
            InitializeComponent();
            this.doctor1 = doctor;
        }

        private void btnPatientPanel_Click(object sender, EventArgs e)
        {
            this.prescription1.Hide();
            this.doctorPasswordChange1.Hide();
            this.patientInfoForDoctor1.Show();
        }

        private void btnPrescriptionPanel_Click(object sender, EventArgs e)
        {
            this.patientInfoForDoctor1.Hide();
            this.doctorPasswordChange1.Hide();
            this.prescription1.Show();
        }

        private void btnChangePasswordStaff_Click(object sender, EventArgs e)
        {
            this.patientInfoForDoctor1.Hide();
            this.prescription1.Hide();
            this.doctorPasswordChange1.Show();
            doctorPasswordChange1.Doctor1 = this.doctor1;
        }

        private void btnLogoutStaff_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }
    }
}
