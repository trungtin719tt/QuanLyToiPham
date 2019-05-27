using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyToiPham_1._02
{
    public partial class DetailsForm : Form
    {
        private Entities dbContext = new Entities();
        private bool isEdit = false;
        private Profile profile;
        private MainForm mainForm;
        private int mode;
        BindingList<Family> bindingFamilyList;
        BindingList<Criminal> bindingCriminalList;
        BindingList<Picture> bindingPictureList;
        ImageList imageList;

        public DetailsForm(long ProfileID, MainForm mainForm, int? mode = 1) //1: details, 0: add new
        {
            InitializeComponent();
            this.mode = mode.Value;
            if (mode == 0)
            {
                profile = new Profile();
                this.Text = "Thêm mới";
                isEdit = true;
                setEnableEdit();
            }
            else
            {
                profile = dbContext.Profiles.Find(ProfileID);
                setDisableEdit();
                this.Text = "Chi tiết";
            }

            this.mainForm = mainForm;
            lvPictureList.Activation = ItemActivation.TwoClick;
            lvPictureList.OwnerDraw = false;
            initData();
        }

        private void initData()
        {
            loadPicture();
            loadProfile();
            loadCriminal();
            loadFamily();

        }

        private void loadProfile()
        {
            txtCharacteristics.Text = profile.Characteristics;
            txtCurrentAddress.Text = profile.CurrentAddress;
            txtDoB.Text = profile.DoB;
            txtHousehold.Text = profile.Household;
            txtName.Text = profile.Name;
            txtType.Text = profile.Type;
            txtArea.Text = profile.Area;
        }

        private void loadFamily()
        {

            bindingFamilyList = new BindingList<Family>(dbContext.Families.Where(p => p.ProfileID == profile.Id && p.IsActive == 1).ToList());
            dgvFamily.DataSource = bindingFamilyList;
            dgvFamily.Update();

        }

        private void loadCriminal()
        {

            bindingCriminalList = new BindingList<Criminal>(dbContext.Criminals.Where(p => p.ProfileID == profile.Id).ToList());
            dgvCriminal.DataSource = bindingCriminalList;
            dgvCriminal.Update();
        }

        private void loadPicture()
        {
            bindingPictureList = new BindingList<Picture>(dbContext.Pictures.Where(p => p.ProfileID == profile.Id).ToList());
            imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            lvPictureList.Items.Clear();
            int count = 0;
            foreach (var item in bindingPictureList)
            {
                try
                {
                    using (FileStream stream = new FileStream("Picture/" + item.Name, FileMode.Open, FileAccess.Read))
                    {
                        imageList.Images.Add(Image.FromStream(stream));

                    }
                    lvPictureList.LargeImageList = imageList;

                    lvPictureList.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = item.Name,
                        Tag = item.Name
                    });
                    count++;
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void setEnableEdit()
        {
            btnEdit.Text = "Lưu";
            txtCharacteristics.ReadOnly = false;
            txtCurrentAddress.ReadOnly = false;
            txtDoB.ReadOnly = false;
            txtHousehold.ReadOnly = false;
            txtName.ReadOnly = false;
            txtType.ReadOnly = false;
            txtArea.ReadOnly = false;
            btnCancelEditing.Enabled = true;
            dgvCriminal.ReadOnly = false;
            dgvFamily.ReadOnly = false;
            btnAddPicture.Enabled = true;
        }

        private void setDisableEdit()
        {
            btnEdit.Text = "Chỉnh sửa";
            txtCharacteristics.ReadOnly = true;
            txtCurrentAddress.ReadOnly = true;
            txtDoB.ReadOnly = true;
            txtHousehold.ReadOnly = true;
            txtName.ReadOnly = true;
            txtType.ReadOnly = true;
            txtArea.ReadOnly = true;
            btnCancelEditing.Enabled = false;
            dgvCriminal.ReadOnly = true;
            dgvFamily.ReadOnly = true;
            btnAddPicture.Enabled = false;
        }

        private void updateProfile()
        {
            profile.Characteristics = txtCharacteristics.Text;
            profile.CurrentAddress = txtCurrentAddress.Text;
            profile.DoB = txtDoB.Text;
            profile.Household = txtHousehold.Text;
            profile.Name = txtName.Text;
            profile.Type = txtType.Text;
            profile.Area = txtArea.Text;
            if (profile.Id == 0)
            {
                profile.IsActive = 1;
                dbContext.Profiles.Add(profile);
            }
            else
            {
                dbContext.Entry(profile).State = EntityState.Modified;

            }
            dbContext.SaveChanges();

            //update family
            var familyList = (BindingList<Family>)dgvFamily.DataSource;
            foreach (var item in familyList)
            {
                if (item.Id == 0)
                {
                    item.IsActive = 1;
                    item.ProfileID = profile.Id;
                    dbContext.Families.Add(item);
                }
                else
                {
                    dbContext.Entry(item).State = EntityState.Modified;
                }
            }

            //update criminal
            var criminalList = (BindingList<Criminal>)dgvCriminal.DataSource;
            foreach (var item in criminalList)
            {
                if (item.Id == 0)
                {
                    item.ProfileID = profile.Id;
                    dbContext.Criminals.Add(item);
                }
                else
                {
                    dbContext.Entry(item).State = EntityState.Modified;
                }
            }

            //update picture
            var listName = new List<String>();
            foreach (ListViewItem item in lvPictureList.Items)
            {
                if (item.Tag.Equals("New"))
                {
                    try
                    {
                        Picture picture = new Picture()
                        {
                            Name = "",
                            ProfileID = profile.Id
                        };
                        dbContext.Pictures.Add(picture);
                        dbContext.SaveChanges();
                        picture.Name = profile.Id + "-" + picture.Id + Path.GetExtension(item.Name);
                        dbContext.Entry(picture).State = EntityState.Modified;
                        string directory = AppDomain.CurrentDomain.BaseDirectory;
                        System.IO.File.Copy(item.Name, Path.Combine(directory, "Picture", picture.Name));
                    }
                    catch (Exception ex)
                    {

                    }


                }
                else
                {
                    listName.Add(item.Text);
                }
            }
            var deletedList = bindingPictureList.Where(p => !listName.Contains(p.Name)).ToList();
            foreach (var item in deletedList)
            {
                dbContext.Pictures.Remove(item);
            }
            dbContext.SaveChanges();
            loadPicture();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                setEnableEdit();
                isEdit = true;
            }
            else
            {
                updateProfile();
                setDisableEdit();
                isEdit = false;
                mainForm.initData();
            }
        }

        private void btnCancelEditing_Click(object sender, EventArgs e)
        {
            initData();
            setDisableEdit();
            isEdit = false;
        }

        private void lvPictureList_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPictureList.SelectedItems)
            {
                string name = lvPictureList.Items[item.Index].Text /*bindingPictureList[item.Index].Name*/;
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                try
                {
                    //MessageBox.Show(Path.Combine(directory, "Picture", name));
                    if (item.Tag.Equals("New"))
                    {
                        System.Diagnostics.Process.Start(name);

                    }
                    else
                    {
                        System.Diagnostics.Process.Start(Path.Combine(directory, "Picture", name));

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                profile.IsActive = 0;
                dbContext.Entry(profile).State = EntityState.Modified;
                dbContext.SaveChanges();
                mainForm.initData();
                this.Close();
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            //add extension filter etc
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in ofd.FileNames)
                {
                    //Transform the list to a better presentation if needed
                    //Below code just adds the full path to list
                    try
                    {
                        using (FileStream stream = new FileStream(f, FileMode.Open, FileAccess.Read))
                        {
                            imageList.Images.Add(Image.FromStream(stream));
                            lvPictureList.LargeImageList = imageList;

                            lvPictureList.Items.Add(new ListViewItem
                            {
                                ImageIndex = imageList.Images.Count,
                                Text = stream.Name,
                                Tag = "New",
                                Name = stream.Name
                            });

                        }

                    }
                    catch (Exception ex)
                    {

                    }

                    //Or use below code to just add file names
                    //listView1.Items.Add (Path.GetFileName (f));
                }
                lvPictureList.Update();
            }
        }

        private void lvPictureList_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lvPictureList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && isEdit)
            {
                foreach (ListViewItem item in lvPictureList.SelectedItems)
                {
                    //if (!item.Tag.Equals("New"))
                    //{
                    //    var deletedItem = bindingPictureList.Where(p => p.Name.Equals(item.Text)).FirstOrDefault();
                    //    if (deletedItem != null)
                    //    {
                    //        dbContext.Pictures.Remove(deletedItem);
                    //        dbContext.SaveChanges();
                    //    }
                    //}
                    lvPictureList.Items.Remove(item);
                }
            }
        }
    }
}
