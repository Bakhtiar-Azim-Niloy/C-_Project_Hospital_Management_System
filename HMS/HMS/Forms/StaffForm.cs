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
    public partial class StaffForm : Form
    {
        private StaffRepository adminRepository = new StaffRepository();
        public Staff staff1;
        public StaffForm(Staff staff)
        {
            InitializeComponent();
            this.staff1 = staff;
        }

        private void btnPatientPanel_Click(object sender, EventArgs e)
        {
           this.checkOutUserControl1.Hide();
           this.staffPasswordChange1.Hide();
           this.addNewPatient1.Show();
        }

        private void btnCheckoutPanel_Click(object sender, EventArgs e)
        {
            this.addNewPatient1.Hide();
           this.staffPasswordChange1.Hide();
            this.checkOutUserControl1.Show();
        }

        private void btnChangePasswordStaff_Click(object sender, EventArgs e)
        {
             this.checkOutUserControl1.Hide();
             this.addNewPatient1.Hide();
              this.staffPasswordChange1.Show();
            staffPasswordChange1.Staff1 = this.staff1;
        }

        private void btnLogoutStaff_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }
    }
}
