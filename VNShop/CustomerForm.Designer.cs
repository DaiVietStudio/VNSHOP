namespace VNShop
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cbProvince = new DevExpress.XtraEditors.LookUpEdit();
            this.cbDistrict = new DevExpress.XtraEditors.LookUpEdit();
            this.cbWard = new DevExpress.XtraEditors.LookUpEdit();
            this.cbType = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExit);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.cbProvince);
            this.layoutControl1.Controls.Add(this.cbDistrict);
            this.layoutControl1.Controls.Add(this.cbWard);
            this.layoutControl1.Controls.Add(this.cbType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(637, 264);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(550, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 27);
            this.btnExit.StyleController = this.layoutControl1;
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(473, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(99, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(522, 22);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(99, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(522, 22);
            this.txtPhone.StyleController = this.layoutControl1;
            this.txtPhone.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(522, 22);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            // 
            // cbProvince
            // 
            this.cbProvince.Location = new System.Drawing.Point(99, 100);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProvince.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cbProvince.Properties.DisplayMember = "Ten";
            this.cbProvince.Properties.NullText = "";
            this.cbProvince.Properties.PopupSizeable = false;
            this.cbProvince.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbProvince.Properties.ValueMember = "id";
            this.cbProvince.Size = new System.Drawing.Size(522, 22);
            this.cbProvince.StyleController = this.layoutControl1;
            this.cbProvince.TabIndex = 7;
            this.cbProvince.EditValueChanged += new System.EventHandler(this.cbProvince_EditValueChanged);
            // 
            // cbDistrict
            // 
            this.cbDistrict.Location = new System.Drawing.Point(99, 128);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDistrict.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cbDistrict.Properties.DisplayMember = "Ten";
            this.cbDistrict.Properties.NullText = "";
            this.cbDistrict.Properties.PopupSizeable = false;
            this.cbDistrict.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbDistrict.Properties.ValueMember = "id";
            this.cbDistrict.Size = new System.Drawing.Size(522, 22);
            this.cbDistrict.StyleController = this.layoutControl1;
            this.cbDistrict.TabIndex = 8;
            this.cbDistrict.EditValueChanged += new System.EventHandler(this.cbDistrict_EditValueChanged);
            // 
            // cbWard
            // 
            this.cbWard.Location = new System.Drawing.Point(99, 156);
            this.cbWard.Name = "cbWard";
            this.cbWard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbWard.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên xã")});
            this.cbWard.Properties.DisplayMember = "Ten";
            this.cbWard.Properties.NullText = "";
            this.cbWard.Properties.PopupSizeable = false;
            this.cbWard.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbWard.Properties.ValueMember = "id";
            this.cbWard.Size = new System.Drawing.Size(522, 22);
            this.cbWard.StyleController = this.layoutControl1;
            this.cbWard.TabIndex = 9;
            // 
            // cbType
            // 
            this.cbType.Location = new System.Drawing.Point(99, 184);
            this.cbType.Name = "cbType";
            this.cbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cbType.Properties.DisplayMember = "Ten";
            this.cbType.Properties.NullText = "";
            this.cbType.Properties.PopupSizeable = false;
            this.cbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbType.Properties.ValueMember = "id";
            this.cbType.Size = new System.Drawing.Size(522, 22);
            this.cbType.StyleController = this.layoutControl1;
            this.cbType.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(637, 264);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem1.Text = "Họ và tên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 196);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(457, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPhone;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem2.Text = "Số điện thoại";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtAddress;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem3.Text = "Địa chỉ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbProvince;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem4.Text = "Tỉnh";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbDistrict;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem5.Text = "Huyện";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbWard;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem6.Text = "Xã";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbType;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(611, 28);
            this.layoutControlItem7.Text = "Loại";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(457, 196);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(77, 42);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnExit;
            this.layoutControlItem9.Location = new System.Drawing.Point(534, 196);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(77, 42);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // CustomerForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 264);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit cbProvince;
        private DevExpress.XtraEditors.LookUpEdit cbDistrict;
        private DevExpress.XtraEditors.LookUpEdit cbWard;
        private DevExpress.XtraEditors.LookUpEdit cbType;
    }
}