using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Contexts;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using DevExpress.XtraEditors;
using ProduceRecovery.Models;

namespace ProduceRecovery
{
    public partial class PompsList : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        public static PompsList form;
        int id;
        string celTXT;
        public PompsList()
        {
            InitializeComponent();
            form = this;
        }
        private void SelectGrid()
        {
            id = 0;
            try
            {
                id = Convert.ToInt32(gv.GetRowCellDisplayText(gv.FocusedRowHandle, gv.Columns["Id"]));
                celTXT = gv.GetRowCellDisplayText(gv.FocusedRowHandle, gv.Columns["PompName"]);
            }
            catch
            {
                // ignored
            }
        }
        private void UnitList_Load(object sender, EventArgs e)
        {
            
        }
        public void GetList()
        {
            using (_db = new UnitOfWork())
            {
                gc.DataSource = _db.PompsRepo.Include(x => x.Categories)/*.Include(c=>c.Categories.Units)*/.Where(c => !c.IsDelete);
            }

            count.Caption = gv.RowCount.ToString();
        }

        private void gv_Click(object sender, EventArgs e)
        {
            SelectGrid();
        }

        private void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (Convert.ToInt32(e.RowHandle.ToString()) + 1).ToString();
        }

        private void addNewBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AddPomp();
            frm.ShowDialog();
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectGrid();
            if (id == 0)
            {
                XtraMessageBox.Show("ردیفی انتخاب نشده است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new AddPomp { Id = id};
            frm.ShowDialog();
        }

        private void trashBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectGrid();
            if (id == 0)
            {
                XtraMessageBox.Show("ردیفی انتخاب نشده است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var respons = DialogResult.None;
            respons = XtraMessageBox.Show(celTXT + " را حذف می کنید؟", "تأیید می کنید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (respons == DialogResult.Yes)
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = _db.PompsRepo.GetById(this.id);
                    tbl.IsDelete = true;
                    _db.PompsRepo.Update(tbl);
                    _db.Save();
                    _db.Dispose();
                }
                this.id = 0;
                GetList();
            }
            else if (respons == DialogResult.No)
            {
                return;
            }
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectGrid();
            if (id == 0)
            {
                XtraMessageBox.Show("ردیفی انتخاب نشده است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var respons = DialogResult.None;
            respons = XtraMessageBox.Show(celTXT+ " را حذف می کنید؟", "تأیید می کنید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (respons == DialogResult.Yes)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.PompsRepo.GetById(this.id);
                    _db.PompsRepo.Delete(q);
                    _db.Save();
                    _db.Dispose();
                }
                this.id = 0;
                GetList();
            }
            else if (respons == DialogResult.No)
            {
                return;
            }
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetList();
        }

        private void xlsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraSaveFileDialog1.Filter = "Excel Old (*.xls)|*.xls|Excel New (*.xlsx)|*.xlsx";
            ExportToFiles.ExportToFile("excel", xtraSaveFileDialog1, gv);
        }

        private void printBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            gv.PrintDialog();
        }

        private void PompsList_Shown(object sender, EventArgs e)
        {
            GetList();
        }
    }
}