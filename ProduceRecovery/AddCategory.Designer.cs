
namespace ProduceRecovery
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            this.cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.categoryName = new DevExpress.XtraEditors.TextEdit();
            this.remark = new DevExpress.XtraEditors.MemoEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.unitSelect = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitSelect.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.save,
            this.cancel});
            this.barManager1.MaxItemId = 2;
            this.barManager1.RightToLeft = DevExpress.Utils.DefaultBoolean.True;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // save
            // 
            this.save.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.save.Caption = "ذخیره";
            this.save.Id = 0;
            this.save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("save.ImageOptions.Image")));
            this.save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("save.ImageOptions.LargeImage")));
            this.save.Name = "save";
            this.save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.save_ItemClick);
            // 
            // cancel
            // 
            this.cancel.Caption = "انصراف";
            this.cancel.Id = 1;
            this.cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancel.ImageOptions.Image")));
            this.cancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cancel.ImageOptions.LargeImage")));
            this.cancel.Name = "cancel";
            this.cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(433, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 272);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(433, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 272);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(433, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 272);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.categoryName);
            this.groupControl1.Controls.Add(this.remark);
            this.groupControl1.Controls.Add(this.unitSelect);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(409, 248);
            this.groupControl1.TabIndex = 4;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(20, 64);
            this.categoryName.MenuManager = this.barManager1;
            this.categoryName.Name = "categoryName";
            this.categoryName.Properties.NullValuePrompt = "نام ناحیه";
            this.categoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryName.Size = new System.Drawing.Size(365, 40);
            this.categoryName.TabIndex = 1;
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(20, 110);
            this.remark.MenuManager = this.barManager1;
            this.remark.Name = "remark";
            this.remark.Properties.NullValuePrompt = "توضیحات";
            this.remark.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remark.Size = new System.Drawing.Size(365, 124);
            this.remark.TabIndex = 2;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // unitSelect
            // 
            this.unitSelect.Location = new System.Drawing.Point(20, 18);
            this.unitSelect.MenuManager = this.barManager1;
            this.unitSelect.Name = "unitSelect";
            this.unitSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unitSelect.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "واحد", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.unitSelect.Properties.DropDownRows = 3;
            this.unitSelect.Properties.NullText = "";
            this.unitSelect.Properties.NullValuePrompt = "نام واحد";
            this.unitSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitSelect.Size = new System.Drawing.Size(365, 40);
            this.unitSelect.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 304);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف/ویرایش ناحیه";
            this.Load += new System.EventHandler(this.AddUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitSelect.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem save;
        private DevExpress.XtraBars.BarButtonItem cancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit categoryName;
        private DevExpress.XtraEditors.MemoEdit remark;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.LookUpEdit unitSelect;
    }
}