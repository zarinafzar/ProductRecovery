
namespace ProduceRecovery
{
    partial class PompsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PompsList));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addNewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.trashBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.xlsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.printBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.count = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.identity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PompName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Categories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.catId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addNewBtn,
            this.editBtn,
            this.trashBtn,
            this.deleteBtn,
            this.refreshBtn,
            this.xlsBtn,
            this.printBtn,
            this.barStaticItem1,
            this.count});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RightToLeft = DevExpress.Utils.DefaultBoolean.True;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addNewBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.trashBtn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.refreshBtn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.xlsBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.printBtn, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // addNewBtn
            // 
            this.addNewBtn.Caption = "جدید";
            this.addNewBtn.Id = 0;
            this.addNewBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addNewBtn.ImageOptions.Image")));
            this.addNewBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addNewBtn.ImageOptions.LargeImage")));
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "ویرایش";
            this.editBtn.Id = 1;
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.Image")));
            this.editBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.LargeImage")));
            this.editBtn.Name = "editBtn";
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // trashBtn
            // 
            this.trashBtn.Caption = "زباله دان";
            this.trashBtn.Id = 2;
            this.trashBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("trashBtn.ImageOptions.Image")));
            this.trashBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("trashBtn.ImageOptions.LargeImage")));
            this.trashBtn.Name = "trashBtn";
            this.trashBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.trashBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "حذف";
            this.deleteBtn.Id = 3;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "نوسازی جدول";
            this.refreshBtn.Id = 4;
            this.refreshBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.ImageOptions.Image")));
            this.refreshBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.ImageOptions.LargeImage")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // xlsBtn
            // 
            this.xlsBtn.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.xlsBtn.Caption = "اکسل";
            this.xlsBtn.Id = 5;
            this.xlsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xlsBtn.ImageOptions.Image")));
            this.xlsBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("xlsBtn.ImageOptions.LargeImage")));
            this.xlsBtn.Name = "xlsBtn";
            this.xlsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xlsBtn_ItemClick);
            // 
            // printBtn
            // 
            this.printBtn.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printBtn.Caption = "چاپ";
            this.printBtn.Id = 6;
            this.printBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.ImageOptions.Image")));
            this.printBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("printBtn.ImageOptions.LargeImage")));
            this.printBtn.Name = "printBtn";
            this.printBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.count)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "تعداد:";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // count
            // 
            this.count.Caption = "0";
            this.count.Id = 8;
            this.count.Name = "count";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(813, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(813, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(813, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // gc
            // 
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.Location = new System.Drawing.Point(0, 71);
            this.gc.MainView = this.gv;
            this.gc.MenuManager = this.barManager1;
            this.gc.Name = "gc";
            this.gc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gc.Size = new System.Drawing.Size(813, 454);
            this.gc.TabIndex = 4;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.identity,
            this.PompName,
            this.gridColumn1,
            this.UnitNames,
            this.Categories,
            this.gridColumn3,
            this.UnitId,
            this.catId});
            this.gv.GridControl = this.gc;
            this.gv.IndicatorWidth = 40;
            this.gv.Name = "gv";
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.OptionsView.ShowViewCaption = true;
            this.gv.ViewCaption = "لیست پمپها";
            this.gv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_CustomDrawRowIndicator);
            this.gv.Click += new System.EventHandler(this.gv_Click);
            // 
            // identity
            // 
            this.identity.Caption = "Id";
            this.identity.FieldName = "Id";
            this.identity.Name = "identity";
            // 
            // PompName
            // 
            this.PompName.Caption = "نام پمپ";
            this.PompName.FieldName = "PompName";
            this.PompName.Name = "PompName";
            this.PompName.OptionsColumn.AllowEdit = false;
            this.PompName.OptionsColumn.AllowSize = false;
            this.PompName.OptionsColumn.FixedWidth = true;
            this.PompName.Visible = true;
            this.PompName.VisibleIndex = 0;
            this.PompName.Width = 150;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "دوره فعالیت";
            this.gridColumn1.FieldName = "InWorkDuration";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 100;
            // 
            // UnitNames
            // 
            this.UnitNames.Caption = "نام بخش";
            this.UnitNames.FieldName = "Categories.Units.UnitName";
            this.UnitNames.Name = "UnitNames";
            this.UnitNames.OptionsColumn.AllowEdit = false;
            this.UnitNames.OptionsColumn.AllowSize = false;
            this.UnitNames.Visible = true;
            this.UnitNames.VisibleIndex = 2;
            this.UnitNames.Width = 140;
            // 
            // Categories
            // 
            this.Categories.Caption = "نام ناحیه";
            this.Categories.FieldName = "Categories.CatName";
            this.Categories.Name = "Categories";
            this.Categories.OptionsColumn.AllowEdit = false;
            this.Categories.OptionsColumn.AllowSize = false;
            this.Categories.Visible = true;
            this.Categories.VisibleIndex = 3;
            this.Categories.Width = 140;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "توضیحات";
            this.gridColumn3.FieldName = "Remark";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 239;
            // 
            // UnitId
            // 
            this.UnitId.Caption = "UnitId";
            this.UnitId.FieldName = "Categories.Units.Id";
            this.UnitId.Name = "UnitId";
            // 
            // catId
            // 
            this.catId.Caption = "catId";
            this.catId.FieldName = "Categories.Id";
            this.catId.Name = "catId";
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gc;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchControl1.Location = new System.Drawing.Point(0, 31);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gc;
            this.searchControl1.Properties.NullValuePrompt = "عبارتی را جهت جستجو وارد کنید";
            this.searchControl1.Size = new System.Drawing.Size(813, 40);
            this.searchControl1.TabIndex = 9;
            // 
            // PompsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::ProduceRecovery.Properties.Resources.motor_pump;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PompsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست پمپها";
            this.Load += new System.EventHandler(this.UnitList_Load);
            this.Shown += new System.EventHandler(this.PompsList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addNewBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem trashBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.BarButtonItem xlsBtn;
        private DevExpress.XtraBars.BarButtonItem printBtn;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn identity;
        private DevExpress.XtraGrid.Columns.GridColumn PompName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem count;
        private DevExpress.XtraGrid.Columns.GridColumn UnitNames;
        private DevExpress.XtraGrid.Columns.GridColumn UnitId;
        private DevExpress.XtraGrid.Columns.GridColumn Categories;
        private DevExpress.XtraGrid.Columns.GridColumn catId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}