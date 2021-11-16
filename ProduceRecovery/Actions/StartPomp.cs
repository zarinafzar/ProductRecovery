using Data.Contexts;
using Data.Models;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProduceRecovery.Actions
{
    public partial class StartPomp : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        public int Id = 0;
        public StartPomp()
        {
            InitializeComponent();
        }
        private void GetUnits()
        {
            using (_db = new UnitOfWork())
            {
                unitSelect.Properties.DataSource = _db.UnitsRepo.Get(c => !c.IsDelete);
                unitSelect.Properties.DisplayMember = "UnitName";
                unitSelect.Properties.ValueMember = "Id";
            }
        }
        private void GetCategories(int unitId)
        {
            using (_db = new UnitOfWork())
            {
                categorySelect.Properties.DataSource = _db.CategoriesRepo.Get(c => !c.IsDelete && c.UnitId == unitId);
                categorySelect.Properties.DisplayMember = "CatName";
                categorySelect.Properties.ValueMember = "Id";
            }
        }

        private void GetPompsByCategories(int catId)
        {
            using (_db = new UnitOfWork())
            {
                pompSelect.Properties.DataSource = _db.PompsRepo.Get(c => !c.IsDelete && c.CatId == catId);
                pompSelect.Properties.DisplayMember = "PompName";
                pompSelect.Properties.ValueMember = "Id";
            }
        }

        private void StartPomp_Load(object sender, EventArgs e)
        {
            Clear();
            GetUnits();
            if (this.Id != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.PompsEventsRepo.GetById(this.Id);
                    unitSelect.Enabled = false;
                    categorySelect.Enabled = false;
                    pompSelect.Enabled = false;

                    unitSelect.EditValue = q.Pomps.Categories.UnitId;
                    categorySelect.EditValue = q.Pomps.CatId;
                    pompSelect.EditValue = q.PompId;
                    date.EditValue = q.StartDate;
                    descriptions.Text = q.Descriptions;
                    offBtn.Enabled = true;
                    onBtn.Enabled = true;
                    _db.Dispose();
                }
            }
        }

        private void unitSelect_EditValueChanged(object sender, EventArgs e)
        {
            int unitId = (int)unitSelect.EditValue;
            GetCategories(unitId);
           
        }

        private void cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void categorySelect_EditValueChanged(object sender, EventArgs e)
        {
            int catId = (int)categorySelect.EditValue;
            GetPompsByCategories(catId);
        }

        private void pompSelect_EditValueChanged(object sender, EventArgs e)
        {
            var pompId = (int)pompSelect.EditValue;
            if (pompId != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.PompsRepo.GetById(pompId);
                    durations.EditValue = q.InWorkDuration;
                    remark.Text = q.Remark;

                    var events = _db.PompsEventsRepo.Get(x => x.PompId == pompId)
                        .OrderByDescending(x => x.Id)
                        .FirstOrDefault();

                    if (events == null)
                    {
                        nextEventsHint.Visible = false;
                        lastEvent.EditValue = "ندارد";
                        nextEvents.EditValue = "ندارد";
                        isStart.EditValue = false;
                        gc.DataSource = null;
                        offBtn.Enabled = true;
                        onBtn.Enabled = true;
                    }
                    else
                    {

                        LoadGv(pompId);

                        nextEventsHint.Visible = true;
                        if (events.StopDate <= DateTime.Now)
                            nextEventsHint.Properties.State = ValidationHintState.Invalid;
                        else
                            nextEventsHint.Properties.State = ValidationHintState.Valid;

                        lastEvent.EditValue = events.StartDate.ToString("yyyy/MM/dd");
                        nextEvents.EditValue = events.StopDate.ToString("yyyy/MM/dd");
                        isStart.EditValue = events.IsStart;
                        if (events.IsStart)
                        {
                            offBtn.Enabled = true;
                            onBtn.Enabled = false;
                        }
                        else if (!events.IsStart)
                        {
                            offBtn.Enabled = false;
                            onBtn.Enabled = true;
                        }
                        

                    }

                    _db.Dispose();
                }
            }
        }

        private void LoadGv(int pompId)
        {
            using (_db = new UnitOfWork())
            {
                var gridv = _db.PompsEventsRepo
                            .Include(x => x.Pomps)
                            .Where(x => x.PompId == pompId)
                            .OrderByDescending(x => x.Id);
                gc.DataSource = gridv;
            }
        }

        private void Clear()
        {
            date.EditValue = DateTime.Now;
            pompSelect.EditValue = 0;
            descriptions.Text = "";
            offBtn.Enabled = false;
            onBtn.Enabled = false;
            unitSelect.Enabled = true;
            categorySelect.Enabled = true;
            pompSelect.Enabled = true;
        }

        private void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (Convert.ToInt32(e.RowHandle.ToString()) + 1).ToString();
        }
        private void SelectGrid()
        {
            Id = 0;
            try
            {
                Id = Convert.ToInt32(gv.GetRowCellDisplayText(gv.FocusedRowHandle, gv.Columns["Id"]));
            }
            catch
            {
                Id = 0;
            }
        }
        private void evgrp_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString() == "print")
            {
                gv.ShowPrintPreview();
            }

            if (e.Button.Properties.Tag.ToString() == "delete")
            {
                SelectGrid();
                if (Id == 0)
                {
                    XtraMessageBox.Show("ردیفی انتخاب نشده است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var pump = 0;
                var respons = DialogResult.None;
                respons = XtraMessageBox.Show(" رکورد را حذف می کنید؟", "تأیید می کنید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (respons == DialogResult.Yes)
                {
                    using (_db = new UnitOfWork())
                    {
                        var q = _db.PompsEventsRepo.GetById(this.Id);
                        pump = q.PompId;
                        _db.PompsEventsRepo.Delete(q);
                        _db.Save();
                        _db.Dispose();
                    }
                    this.Id = 0;
                    LoadGv(pump);
                    Clear();
                }
                else if (respons == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void pumpEvGrp_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            pompSelect.PerformClick(null);
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pompSelect.Text))
            {
                XtraMessageBox.Show(
                   text: "پمپ را انتخاب کنید",
                   caption: "Error",
                   icon: MessageBoxIcon.Error,
                   buttons: MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(date.Text))
                date.EditValue = DateTime.Now;

            if (string.IsNullOrEmpty(descriptions.Text))
                descriptions.Text = "روشن شد";

            var dur = Convert.ToInt32(durations.Text);
            var pump = Convert.ToInt32(pompSelect.EditValue);

            try
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = new PompsEvents()
                    {
                        PompId = pump,
                        StartDate = date.DateTime,
                        StopDate = date.DateTime.AddMonths(dur),
                        IsStart = true,
                        Descriptions = descriptions.Text
                    };
                    if (Id == 0)
                    {
                        _db.PompsEventsRepo.Insert(tbl);
                    }
                    else
                    {
                        tbl.Id = this.Id;
                        _db.PompsEventsRepo.Update(tbl);
                    }
                    _db.Save();
                    _db.Dispose();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(
                   text: exception.Message,
                   caption: "Error",
                   icon: MessageBoxIcon.Error,
                   buttons: MessageBoxButtons.OK);
            }
            try
            {
                LoadGv(pump);
                Id = 0;
                Clear();
                MainView.form.GetData();
                alertControl1.Show(this, "پاسخ", "روشن شد");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

           
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pompSelect.Text))
            {
                XtraMessageBox.Show(
                   text: "پمپ را انتخاب کنید",
                   caption: "Error",
                   icon: MessageBoxIcon.Error,
                   buttons: MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(date.Text))
                date.EditValue = DateTime.Now;

            if (string.IsNullOrEmpty(descriptions.Text))
                descriptions.Text = "خاموش شد";

            var dur = Convert.ToInt32(durations.Text);
            var pump = Convert.ToInt32(pompSelect.EditValue);

            try
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = new PompsEvents()
                    {
                        PompId = pump,
                        StartDate = date.DateTime,
                        StopDate = date.DateTime.AddMonths(dur),
                        IsStart = false,
                        Descriptions = descriptions.Text
                    };
                    if (Id == 0)
                    {
                        _db.PompsEventsRepo.Insert(tbl);
                    }
                    else
                    {
                        tbl.Id = this.Id;
                        _db.PompsEventsRepo.Update(tbl);
                    }
                    _db.Save();
                    _db.Dispose();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(
                   text: exception.Message,
                   caption: "Error",
                   icon: MessageBoxIcon.Error,
                   buttons: MessageBoxButtons.OK);
            }
            try
            {
                LoadGv(pump);
                Id = 0;
                Clear();
                MainView.form.GetData();
                alertControl1.Show(this, "پاسخ", "خاموش شد");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

           
        }

        private void gv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectGrid();

            using (_db = new UnitOfWork())
            {
                var pompEv = _db.PompsEventsRepo.GetById(Id);

                unitSelect.Enabled = false;
                categorySelect.Enabled = false;
                pompSelect.Enabled = false;

                unitSelect.EditValue = pompEv.Pomps.Categories.UnitId;
                categorySelect.EditValue = pompEv.Pomps.CatId;
                pompSelect.EditValue = pompEv.PompId;
                pompSelect.PerformClick(null);
                date.EditValue = pompEv.StartDate;
                descriptions.Text = pompEv.Descriptions;
                offBtn.Enabled = true;
                onBtn.Enabled = true;

            }
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            Id = 0;
            Clear();
        }
    }
}