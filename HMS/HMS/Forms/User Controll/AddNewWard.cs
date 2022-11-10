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
    public partial class AddNewWard : UserControl
    {
        public AddNewWard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtName.Text==""|| this.txtPrice.Text==""|| this.txtBedCount.Text=="")
            {
                MessageBox.Show("Provide all Information");
            }
            else
            {
                WardRepository wardRepository = new WardRepository();
                Ward ward = new Ward();
                ward.Name = this.txtName.Text;
                ward.BedCount = Int32.Parse(this.txtBedCount.Text);
                ward.Price = Convert.ToDouble(this.txtPrice.Text);


                bool insert = wardRepository.Insert(ward);
                if (insert)
                {
                    MessageBox.Show("Ward Created");
                }
                else
                    MessageBox.Show("Error");
            }
           
        }
    }
}
