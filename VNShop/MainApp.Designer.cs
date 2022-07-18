﻿namespace VNShop
{
    partial class MainApp
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartControlMain = new DevExpress.XtraCharts.ChartControl();
            this.chartItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnStorage = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnRetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnWhole = new DevExpress.XtraBars.BarButtonItem();
            this.btnRecpiect = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuote = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenDoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.txtHello = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPriceReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatabse = new DevExpress.XtraBars.BarButtonItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chartControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 28);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1444, 635);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartControlMain
            // 
            this.chartControlMain.DataSource = this.chartItemBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlMain.Diagram = xyDiagram1;
            this.chartControlMain.Legend.Name = "Default Legend";
            this.chartControlMain.Location = new System.Drawing.Point(12, 12);
            this.chartControlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControlMain.Name = "chartControlMain";
            series1.ArgumentDataMember = "date";
            series1.Name = "Doanh số";
            series1.ValueDataMembersSerializable = "value";
            this.chartControlMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlMain.Size = new System.Drawing.Size(1420, 611);
            this.chartControlMain.TabIndex = 4;
            chartTitle1.Text = "Doanh số bán hàng";
            this.chartControlMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // chartItemBindingSource
            // 
            this.chartItemBindingSource.DataSource = typeof(VNShop.Models.ChartItem);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1444, 635);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControlMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1424, 615);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.barButtonItem2,
            this.barSubItem2,
            this.btnUnit,
            this.btnStorage,
            this.btnProduct,
            this.barSubItem3,
            this.btnRetail,
            this.btnPriceReport,
            this.barSubItem4,
            this.btnInfo,
            this.btnUser,
            this.btnWhole,
            this.btnCustomer,
            this.txtHello,
            this.btnRecpiect,
            this.btnSetting,
            this.btnQuote,
            this.btnBackup,
            this.btnDatabse,
            this.btnChuyenDoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 26;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenDoi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Danh mục";
            this.barSubItem2.Id = 3;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUnit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnStorage, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUser),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCustomer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnUnit
            // 
            this.btnUnit.Caption = "Đơn vị tính";
            this.btnUnit.Id = 4;
            this.btnUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnit.ImageOptions.Image")));
            this.btnUnit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUnit.ImageOptions.LargeImage")));
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnit_ItemClick);
            // 
            // btnStorage
            // 
            this.btnStorage.Caption = "Kho hàng";
            this.btnStorage.Id = 5;
            this.btnStorage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStorage.ImageOptions.Image")));
            this.btnStorage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStorage.ImageOptions.LargeImage")));
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStorage_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Sản phẩm";
            this.btnProduct.Id = 6;
            this.btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.Image")));
            this.btnProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.LargeImage")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnUser
            // 
            this.btnUser.Caption = "Nhân viên";
            this.btnUser.Id = 13;
            this.btnUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.Image")));
            this.btnUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.LargeImage")));
            this.btnUser.Name = "btnUser";
            this.btnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUser_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 15;
            this.btnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.Image")));
            this.btnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.LargeImage")));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Bán hàng";
            this.barSubItem3.Id = 8;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRetail, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWhole),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRecpiect),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQuote, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnRetail
            // 
            this.btnRetail.Caption = "Bán lẻ";
            this.btnRetail.Id = 9;
            this.btnRetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRetail.ImageOptions.Image")));
            this.btnRetail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRetail.ImageOptions.LargeImage")));
            this.btnRetail.Name = "btnRetail";
            this.btnRetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRetail_ItemClick);
            // 
            // btnWhole
            // 
            this.btnWhole.Caption = "Bán sỉ";
            this.btnWhole.Id = 14;
            this.btnWhole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWhole.ImageOptions.Image")));
            this.btnWhole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWhole.ImageOptions.LargeImage")));
            this.btnWhole.Name = "btnWhole";
            this.btnWhole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWhole_ItemClick);
            // 
            // btnRecpiect
            // 
            this.btnRecpiect.Caption = "Hóa đơn";
            this.btnRecpiect.Id = 17;
            this.btnRecpiect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecpiect.ImageOptions.Image")));
            this.btnRecpiect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRecpiect.ImageOptions.LargeImage")));
            this.btnRecpiect.Name = "btnRecpiect";
            this.btnRecpiect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecpiect_ItemClick);
            // 
            // btnQuote
            // 
            this.btnQuote.Caption = "Báo giá";
            this.btnQuote.Id = 20;
            this.btnQuote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuote.ImageOptions.Image")));
            this.btnQuote.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuote.ImageOptions.LargeImage")));
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuote_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Hệ thống";
            this.barSubItem4.Id = 11;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBackup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "Thông tin đơn vị";
            this.btnInfo.Id = 12;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.LargeImage")));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfo_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 22;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Caption = "Chuyển đổi";
            this.btnChuyenDoi.Id = 25;
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnChuyenDoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenDoi_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.txtHello)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // txtHello
            // 
            this.txtHello.Caption = "Xin chào ";
            this.txtHello.Id = 16;
            this.txtHello.Name = "txtHello";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1444, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 663);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1444, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1444, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bán hàng";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Hệ thống";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh mục";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnPriceReport
            // 
            this.btnPriceReport.Caption = "Báo giá";
            this.btnPriceReport.Id = 10;
            this.btnPriceReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPriceReport.ImageOptions.Image")));
            this.btnPriceReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPriceReport.ImageOptions.LargeImage")));
            this.btnPriceReport.Name = "btnPriceReport";
            // 
            // btnSetting
            // 
            this.btnSetting.Id = 21;
            this.btnSetting.Name = "btnSetting";
            // 
            // btnDatabse
            // 
            this.btnDatabse.Id = 24;
            this.btnDatabse.Name = "btnDatabse";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 694);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm bán hàng VNShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraCharts.ChartControl chartControlMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnUnit;
        private DevExpress.XtraBars.BarButtonItem btnStorage;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnRetail;
        private DevExpress.XtraBars.BarButtonItem btnPriceReport;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.BarButtonItem btnUser;
        private DevExpress.XtraBars.BarButtonItem btnWhole;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarHeaderItem txtHello;
        private DevExpress.XtraBars.BarButtonItem btnRecpiect;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.BindingSource chartItemBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.BarButtonItem btnQuote;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnDatabse;
        private DevExpress.XtraBars.BarButtonItem btnChuyenDoi;
    }
}