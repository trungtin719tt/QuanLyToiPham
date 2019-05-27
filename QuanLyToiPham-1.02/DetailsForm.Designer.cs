namespace QuanLyToiPham_1._02
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancelEditing = new System.Windows.Forms.Button();
            this.dgvCriminal = new System.Windows.Forms.DataGridView();
            this.commitedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFamily = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtHousehold = new System.Windows.Forms.TextBox();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.txtCharacteristics = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lvPictureList = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại tội phạm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hộ khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ hiện nay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đặc điểm";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(510, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancelEditing
            // 
            this.btnCancelEditing.Location = new System.Drawing.Point(652, 27);
            this.btnCancelEditing.Name = "btnCancelEditing";
            this.btnCancelEditing.Size = new System.Drawing.Size(120, 39);
            this.btnCancelEditing.TabIndex = 8;
            this.btnCancelEditing.Text = "Hủy chỉnh sửa";
            this.btnCancelEditing.UseVisualStyleBackColor = true;
            this.btnCancelEditing.Click += new System.EventHandler(this.btnCancelEditing_Click);
            // 
            // dgvCriminal
            // 
            this.dgvCriminal.AutoGenerateColumns = false;
            this.dgvCriminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commitedDateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvCriminal.DataSource = this.criminalBindingSource;
            this.dgvCriminal.Location = new System.Drawing.Point(16, 371);
            this.dgvCriminal.Name = "dgvCriminal";
            this.dgvCriminal.RowTemplate.Height = 24;
            this.dgvCriminal.Size = new System.Drawing.Size(776, 130);
            this.dgvCriminal.TabIndex = 9;
            // 
            // commitedDateDataGridViewTextBoxColumn
            // 
            this.commitedDateDataGridViewTextBoxColumn.DataPropertyName = "CommitedDate";
            this.commitedDateDataGridViewTextBoxColumn.HeaderText = "Ngày xảy ra";
            this.commitedDateDataGridViewTextBoxColumn.Name = "commitedDateDataGridViewTextBoxColumn";
            this.commitedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Loại tội phạm";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // criminalBindingSource
            // 
            this.criminalBindingSource.DataSource = typeof(Data.Criminal);
            // 
            // dgvFamily
            // 
            this.dgvFamily.AutoGenerateColumns = false;
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn,
            this.currentAddressDataGridViewTextBoxColumn});
            this.dgvFamily.DataSource = this.familyBindingSource;
            this.dgvFamily.Location = new System.Drawing.Point(16, 542);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.RowTemplate.Height = 24;
            this.dgvFamily.Size = new System.Drawing.Size(776, 150);
            this.dgvFamily.TabIndex = 10;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            this.relationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship";
            this.relationshipDataGridViewTextBoxColumn.HeaderText = "Quan hệ với đối tượng";
            this.relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            this.relationshipDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentAddressDataGridViewTextBoxColumn
            // 
            this.currentAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currentAddressDataGridViewTextBoxColumn.DataPropertyName = "CurrentAddress";
            this.currentAddressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ hiện nay";
            this.currentAddressDataGridViewTextBoxColumn.Name = "currentAddressDataGridViewTextBoxColumn";
            this.currentAddressDataGridViewTextBoxColumn.Width = 128;
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataSource = typeof(Data.Family);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tiền án tiền sự";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 30);
            this.txtName.TabIndex = 12;
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(106, 69);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(341, 30);
            this.txtDoB.TabIndex = 13;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(137, 113);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(310, 30);
            this.txtType.TabIndex = 14;
            // 
            // txtHousehold
            // 
            this.txtHousehold.Location = new System.Drawing.Point(93, 162);
            this.txtHousehold.Name = "txtHousehold";
            this.txtHousehold.Size = new System.Drawing.Size(699, 30);
            this.txtHousehold.TabIndex = 15;
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(156, 210);
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(636, 30);
            this.txtCurrentAddress.TabIndex = 16;
            // 
            // txtCharacteristics
            // 
            this.txtCharacteristics.Location = new System.Drawing.Point(106, 258);
            this.txtCharacteristics.Name = "txtCharacteristics";
            this.txtCharacteristics.Size = new System.Drawing.Size(686, 30);
            this.txtCharacteristics.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gia đình";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lvPictureList
            // 
            this.lvPictureList.Location = new System.Drawing.Point(829, 162);
            this.lvPictureList.Name = "lvPictureList";
            this.lvPictureList.Size = new System.Drawing.Size(269, 530);
            this.lvPictureList.TabIndex = 20;
            this.lvPictureList.UseCompatibleStateImageBehavior = false;
            this.lvPictureList.ItemActivate += new System.EventHandler(this.lvPictureList_ItemActivate);
            this.lvPictureList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPictureList_KeyDown);
            this.lvPictureList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvPictureList_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(835, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ảnh";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(964, 113);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(134, 46);
            this.btnAddPicture.TabIndex = 22;
            this.btnAddPicture.Text = "Thêm ảnh";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 44);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa người này";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa bàn";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(106, 308);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(686, 30);
            this.txtArea.TabIndex = 25;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 710);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lvPictureList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCharacteristics);
            this.Controls.Add(this.txtCurrentAddress);
            this.Controls.Add(this.txtHousehold);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvFamily);
            this.Controls.Add(this.dgvCriminal);
            this.Controls.Add(this.btnCancelEditing);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancelEditing;
        private System.Windows.Forms.DataGridView dgvCriminal;
        private System.Windows.Forms.DataGridView dgvFamily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtHousehold;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.TextBox txtCharacteristics;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource criminalBindingSource;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView lvPictureList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
    }
}