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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (this.tbPassword.Text == "" || this.tbPhone.Text == "")
            {
                MessageBox.Show("Please Enter Password and user name");
            }
            else
            {
                Login log = new Login();
                log.UserName = tbPhone.Text;
                log.Passsword = tbPassword.Text;

                LoginRepository loginRepository = new LoginRepository();
                log = loginRepository.Validation(log);
                if (log.UserType == 1)
                {
                    Admin admin = new Admin();
                    admin.Phone = log.UserName;

                    AdminRepository adminRepository = new AdminRepository();
                    admin = adminRepository.Get(admin);

                    AdminForm adminForm = new AdminForm(admin);
                    adminForm.Show();
                    this.Hide();
                }
                else if (log.UserType == 2)
                {
                    Doctor doctor = new Doctor();
                    doctor.Phone = log.UserName;

                    DoctorRepository adminRepository = new DoctorRepository();
                    doctor = adminRepository.Get(doctor);

                    DoctorForm doctorForm = new DoctorForm(doctor);
                    doctorForm.Show();
                    this.Hide();
                }
                else if (log.UserType == 3)
                {
                    Staff staff = new Staff();
                    staff.Phone = log.UserName;

                    StaffRepository adminRepository = new StaffRepository();
                    staff = adminRepository.Get(staff);

                    StaffForm staffForm = new StaffForm(staff);
                    staffForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password wrong");
                }







        }   }       
    }
}
