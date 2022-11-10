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

namespace HMS.Forms.User_Controll
{
    public partial class AddNewStaff : UserControl
    {
        public AddNewStaff()
        {
            InitializeComponent();
        }

        private void btnAddAdminSave_Click(object sender, EventArgs e)
        {
            if (this.dateTimePicker1.Text == "" || this.txtAddress.Text == "" || this.txtPhone.Text=="" || this.txtSalary.Text=="" || this.txtPassword.Text=="" || this.txtName.Text=="" )
            {
                MessageBox.Show("Probide All Information");
            }
            else
            {
                Staff staff = new Staff();
                staff.Name = this.txtName.Text;
                staff.Address = this.txtAddress.Text;
                staff.Dob = this.dateTimePicker1.Text;
                staff.Phone = this.txtPhone.Text;
                staff.Salary = Double.Parse(this.txtSalary.Text);
                staff.Password = this.txtPassword.Text;
                if (this.rbMale.Checked)
                {
                    staff.Gender = this.rbMale.Text;
                    StaffRepository staffRepository = new StaffRepository();
                    staffRepository.Insert(staff);
                    MessageBox.Show("Staff Created");



                }
                else if (this.rbFemale.Checked)
                {
                    staff.Gender = this.rbFemale.Text;
                    StaffRepository staffRepository = new StaffRepository();
                    staffRepository.Insert(staff);
                    MessageBox.Show("Staff Created");
                }
                else
                    MessageBox.Show("Choose a gender");
            }
           
        }
    }
}
