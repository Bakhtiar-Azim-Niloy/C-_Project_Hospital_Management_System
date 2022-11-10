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
    public partial class StaffUserControll : UserControl
    {
        public StaffUserControll()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            addNewStaff1.Hide();
            StaffRepository staffRepository = new StaffRepository();
            dataGridView1.Show();
            dataGridView1.DataSource = staffRepository.GetAll();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            addNewStaff1.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.txtSearch.Text=="")
            {
                MessageBox.Show("Provide Phone Number");
            }
            else
            {
                Staff staff = new Staff();
                staff.Phone = this.txtSearch.Text;
                StaffRepository staffRepository = new StaffRepository();
                staff = staffRepository.Get(staff);
                if (staff.Name == null)
                {
                    MessageBox.Show("No data found");
                }
                else
                {
                    this.txtAddress.Text = staff.Address;
                    this.txtName.Text = staff.Name;
                    this.txtPhone.Text = staff.Phone;
                    this.txtSalary.Text = staff.Salary.ToString();
                }
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "" || this.txtName.Text == "" || this.txtPhone.Text == "" || this.txtSalary.Text == "")
            {
                MessageBox.Show("Search");
            }
            else
            {
                Staff staff = new Staff();
                staff.Address = this.txtAddress.Text;
                staff.Name = this.txtName.Text;
                staff.Phone = this.txtPhone.Text;
                staff.Salary = Double.Parse(this.txtSalary.Text);
                StaffRepository staffRepository = new StaffRepository();
                bool update = staffRepository.Update(staff);
                if (update)
                {
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("update failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtSalary.Text==""| this.txtPhone.Text==""|| this.txtName.Text==""|| this.txtAddress.Text=="")
            {
                MessageBox.Show("Searcch Staff");
            }
            else {
                Staff staff = new Staff();
                staff.Phone = this.txtPhone.Text;
                StaffRepository staffRepository = new StaffRepository();

                bool delete = staffRepository.Delete(staff); ;
                if (delete)
                {
                    MessageBox.Show("deleted");
                }
                else
                    MessageBox.Show("delete failed");
            }
        }
    }
}
