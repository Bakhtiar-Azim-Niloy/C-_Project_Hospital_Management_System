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

namespace HMS.Forms.UserControll
{
    public partial class DetailsUserControll : UserControl
    {
       
        
        public DetailsUserControll()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.txtSearch.Text=="")
            {
                MessageBox.Show("Provide Phone Number");
            }
            else
            {
                string phone = this.txtSearch.Text;
                AdminRepository adminRepository = new AdminRepository();
                Admin admin = new Admin();
                admin.Phone = phone;
                admin = adminRepository.Get(admin);
                if (admin.Name == null)
                {
                    MessageBox.Show("No data");
                }
                else
                {
                    this.txtAddress.Text = admin.Address;
                    this.txtName.Text = admin.Name;
                    this.txtPhone.Text = admin.Phone;
                    this.txtSalary.Text = admin.Salary.ToString();
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


                Admin admin = new Admin();
                admin.Address = this.txtAddress.Text;
                admin.Name = this.txtName.Text;
                admin.Phone = this.txtPhone.Text;
                admin.Salary = Double.Parse(this.txtSalary.Text);

                AdminRepository adminRepository = new AdminRepository();
                bool update = adminRepository.Update(admin);
                if (update)
                {
                    MessageBox.Show("Updated");
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "" || this.txtName.Text == "" || this.txtPhone.Text == "" || this.txtSalary.Text == "")
            {
                MessageBox.Show("Search");
            }
            else
            {
                Admin admin = new Admin();
                admin.Phone = this.txtPhone.Text;

                AdminRepository adminRepository = new AdminRepository();
                adminRepository.Delete(admin);
                MessageBox.Show("Deleted");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            addNewAdmin1.Show();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            addNewAdmin1.Hide();
            dataGridView1.Show();
            AdminRepository adminRepository = new AdminRepository();
            dataGridView1.DataSource = adminRepository.GetAll();
            
        }
    }
}
