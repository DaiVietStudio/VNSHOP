namespace VNShop
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtThanhTien = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlReceipt = new DevExpress.XtraGrid.GridControl();
            this.gridViewReceipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDel);
            this.layoutControl1.Controls.Add(this.gridControlDetail);
            this.layoutControl1.Controls.Add(this.gridControlReceipt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1942, 1044);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(19, 339);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(143, 29);
            this.btnDel.StyleController = this.layoutControl1;
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gridControlDetail.Location = new System.Drawing.Point(19, 374);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtThanhTien});
            this.gridControlDetail.Size = new System.Drawing.Size(1904, 652);
            this.gridControlDetail.TabIndex = 5;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewDetail.DetailHeight = 525;
            this.gridViewDetail.FixedLineWidth = 3;
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sản phẩm";
            this.gridColumn5.FieldName = "SanPham1.TenSanPham";
            this.gridColumn5.MinWidth = 31;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 118;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lượng";
            this.gridColumn6.FieldName = "SoLuong";
            this.gridColumn6.MinWidth = 31;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 118;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Giá bán";
            this.gridColumn7.FieldName = "GiaBan";
            this.gridColumn7.MinWidth = 31;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 118;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Đơn vị tính";
            this.gridColumn8.FieldName = "DonViTinh";
            this.gridColumn8.MinWidth = 31;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 118;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoHeight = false;
            this.txtThanhTien.Name = "txtThanhTien";
            // 
            // gridControlReceipt
            // 
            this.gridControlReceipt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gridControlReceipt.Location = new System.Drawing.Point(19, 18);
            this.gridControlReceipt.MainView = this.gridViewReceipt;
            this.gridControlReceipt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControlReceipt.Name = "gridControlReceipt";
            this.gridControlReceipt.Size = new System.Drawing.Size(1904, 315);
            this.gridControlReceipt.TabIndex = 4;
            this.gridControlReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceipt});
            // 
            // gridViewReceipt
            // 
            this.gridViewReceipt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewReceipt.DetailHeight = 525;
            this.gridViewReceipt.FixedLineWidth = 3;
            this.gridViewReceipt.GridControl = this.gridControlReceipt;
            this.gridViewReceipt.Name = "gridViewReceipt";
            this.gridViewReceipt.OptionsBehavior.Editable = false;
            this.gridViewReceipt.OptionsView.ShowGroupPanel = false;
            this.gridViewReceipt.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewReceipt_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.MinWidth = 31;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 118;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã phiếu";
            this.gridColumn2.FieldName = "MaSo";
            this.gridColumn2.MinWidth = 31;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 476;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày nhập";
            this.gridColumn3.FieldName = "NgayNhap";
            this.gridColumn3.MinWidth = 31;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 476;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Khách hàng";
            this.gridColumn4.FieldName = "KhachHang1.TenKhachHang";
            this.gridColumn4.MinWidth = 31;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 839;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1942, 1044);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlReceipt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1910, 321);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlDetail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 356);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1910, 658);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDel;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 321);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(149, 35);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(149, 321);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1761, 35);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1044);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Receipt";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceipt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}