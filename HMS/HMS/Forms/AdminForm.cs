using HMS.Entities;
using HMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class AdminForm : Form
    {
        private AdminRepository adminRepository = new AdminRepository();
        public Admin admin1;
        public AdminForm( Admin admin)
        {
            InitializeComponent();
            this.admin1 = admin;

        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            wardUserControll1.Hide();
            doctorUserControll1.Hide();
            changePasswordUserControll1.Hide();
            detailsUserControll1.Dock = DockStyle.Fill;
            detailsUserControll1.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            wardUserControll1.Hide();
            doctorUserControll1.Hide();
            detailsUserControll1.Hide();
            changePasswordUserControll1.Dock = DockStyle.Fill;
            changePasswordUserControll1.Show();
            changePasswordUserControll1.Admin1 = this.admin1;

        }

        private void btnStaffPanel_Click(object sender, EventArgs e)
        {
            wardUserControll1.Hide();
            doctorUserControll1.Hide();
            detailsUserControll1.Hide();
            changePasswordUserControll1.Hide();
            staffUserControll2.Dock = DockStyle.Fill;
            staffUserControll2.Show();
            
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            wardUserControll1.Hide();
            detailsUserControll1.Hide();
            changePasswordUserControll1.Hide();
            staffUserControll2.Hide();
            doctorUserControll1.Dock = DockStyle.Fill;
            doctorUserControll1.Show();
        }

        private void btnWardPanel_Click(object sender, EventArgs e)
        {
            detailsUserControll1.Hide();
            changePasswordUserControll1.Hide();
            staffUserControll2.Hide();
            doctorUserControll1.Hide();
            wardUserControll1.Dock = DockStyle.Fill;
            wardUserControll1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }
    }
}
