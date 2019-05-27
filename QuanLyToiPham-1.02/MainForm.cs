using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace QuanLyToiPham_1._02
{
    public partial class MainForm : Form
    {
        Entities dbcontext = new Entities();
        BindingList<Profile> bindingList;
        BindingList<Profile> currentList;

        public MainForm()
        {
            InitializeComponent();
            initData();
            dgvData.ReadOnly = true;

        }

        public void initData()
        {
            dbcontext = new Entities();
            bindingList = new BindingList<Profile>(dbcontext.Profiles.Where(p => p.IsActive == 1).ToList());
            currentList = new BindingList<Profile>(bindingList);
            dgvData.DataSource = currentList;
            currentList = new BindingList<Profile>
                (bindingList.Where(p => p.Name.ToLower().Contains(txtSearchBox.Text.ToLower())).ToList());
            dgvData.DataSource = currentList;
            dgvData.Update();
        }



        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            currentList = new BindingList<Profile>
                (bindingList
                .Where(p => p.Name.ToLower().Contains(txtSearchBox.Text.ToLower()) || p.Area.ToLower().Contains(txtSearchBox.Text.ToLower())

                ).ToList());
            dgvData.DataSource = currentList;
            dgvData.Update();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = currentList;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                DetailsForm detailForm = new DetailsForm(0, this, 0);
                detailForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void dgvData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DetailsForm detailForm = new DetailsForm(currentList[e.RowIndex].Id, this);
                detailForm.Show();
            }
            catch (Exception)
            {

            }

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetailsForm detailForm = new DetailsForm(currentList[e.RowIndex].Id, this);
                detailForm.Show();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
