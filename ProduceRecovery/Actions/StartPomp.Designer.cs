
namespace ProduceRecovery.Actions
{
    partial class StartPomp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPomp));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.onPomp = new DevExpress.XtraBars.BarButtonItem();
            this.cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.isStart = new DevExpress.XtraEditors.ToggleSwitch();
            this.remark = new DevExpress.XtraEditors.MemoEdit();
            this.date = new FarsiLibrary.Win.DevExpress.XtraFADateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.categorySelect = new DevExpress.XtraEditors.LookUpEdit();
            this.unitSelect = new DevExpress.XtraEditors.LookUpEdit();
            this.PompName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.offpomp = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PompName.Properties)).BeginInit();
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
            this.onPomp,
            this.cancel,
            this.offpomp});
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.onPomp, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.offpomp, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // onPomp
            // 
            this.onPomp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.onPomp.Caption = "روشن شود";
            this.onPomp.Id = 0;
            this.onPomp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("save.ImageOptions.SvgImage")));
            this.onPomp.Name = "onPomp";
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
            this.barDockControlTop.Size = new System.Drawing.Size(456, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 363);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(456, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 363);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(456, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 363);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.categorySelect);
            this.groupControl1.Controls.Add(this.unitSelect);
            this.groupControl1.Controls.Add(this.PompName);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.isStart);
            this.groupControl1.Controls.Add(this.remark);
            this.groupControl1.Location = new System.Drawing.Point(23, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(409, 332);
            this.groupControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 295);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 21);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "وضعیت پمپ";
            // 
            // isStart
            // 
            this.isStart.Location = new System.Drawing.Point(222, 285);
            this.isStart.MenuManager = this.barManager1;
            this.isStart.Name = "isStart";
            this.isStart.Properties.OffText = "خاموش";
            this.isStart.Properties.OnText = "روشن";
            this.isStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isStart.Size = new System.Drawing.Size(155, 31);
            this.isStart.TabIndex = 6;
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(22, 202);
            this.remark.MenuManager = this.barManager1;
            this.remark.Name = "remark";
            this.remark.Properties.NullValuePrompt = "توضیحات";
            this.remark.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remark.Size = new System.Drawing.Size(355, 77);
            this.remark.TabIndex = 3;
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(22, 156);
            this.date.MenuManager = this.barManager1;
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(266, 40);
            this.date.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(313, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 21);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "انتخاب پمپ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "انتخاب ناحیه";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(309, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 21);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "انتخاب کارگاه";
            // 
            // categorySelect
            // 
            this.categorySelect.Location = new System.Drawing.Point(22, 64);
            this.categorySelect.MenuManager = this.barManager1;
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categorySelect.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CatName", "ناحیه", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.categorySelect.Properties.DropDownRows = 3;
            this.categorySelect.Properties.NullText = "";
            this.categorySelect.Properties.NullValuePrompt = "انتخاب ناحیه";
            this.categorySelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorySelect.Size = new System.Drawing.Size(266, 40);
            this.categorySelect.TabIndex = 28;
            // 
            // unitSelect
            // 
            this.unitSelect.Location = new System.Drawing.Point(22, 18);
            this.unitSelect.MenuManager = this.barManager1;
            this.unitSelect.Name = "unitSelect";
            this.unitSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unitSelect.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "واحد", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.unitSelect.Properties.DropDownRows = 3;
            this.unitSelect.Properties.NullText = "";
            this.unitSelect.Properties.NullValuePrompt = "انتخاب کارگاه";
            this.unitSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitSelect.Size = new System.Drawing.Size(266, 40);
            this.unitSelect.TabIndex = 27;
            this.unitSelect.EditValueChanged += new System.EventHandler(this.unitSelect_EditValueChanged);
            // 
            // PompName
            // 
            this.PompName.Location = new System.Drawing.Point(22, 110);
            this.PompName.MenuManager = this.barManager1;
            this.PompName.Name = "PompName";
            this.PompName.Properties.NullValuePrompt = "نام پمپ";
            this.PompName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PompName.Size = new System.Drawing.Size(266, 40);
            this.PompName.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(318, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 21);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "تاریخ رویداد";
            // 
            // offpomp
            // 
            this.offpomp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.offpomp.Caption = "خاموش شود";
            this.offpomp.Id = 2;
            this.offpomp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("offpomp.ImageOptions.SvgImage")));
            this.offpomp.Name = "offpomp";
            // 
            // StartPomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 395);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "StartPomp";
            this.Text = "ثبت رویداد پمپ";
            this.Load += new System.EventHandler(this.StartPomp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PompName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem onPomp;
        private DevExpress.XtraBars.BarButtonItem cancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit remark;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch isStart;
        private FarsiLibrary.Win.DevExpress.XtraFADateEdit date;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit categorySelect;
        private DevExpress.XtraEditors.LookUpEdit unitSelect;
        private DevExpress.XtraEditors.TextEdit PompName;
        private DevExpress.XtraBars.BarButtonItem offpomp;
    }
}