using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Contexts;
using Data.Models;
using DevExpress.LookAndFeel;
using ProduceRecovery.Actions;
using ProduceRecovery.Models;

namespace ProduceRecovery
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        private int _id = 0;
        private int pumpId = 0;
        public static MainView form;
        public MainView()
        {
            InitializeComponent();
            Plugins.CurrentSkin();
            form = this;
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
        private void MainView_Shown(object sender, EventArgs e)
        {
            List<Units> un = null;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen1));
            using (_db = new UnitOfWork())
            {
                un = _db.UnitsRepo.Get().ToList();
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            if (un != null)
                GetData();
        }


        public void GetData()
        {
            pumpId = 0;
            _id = 0;
            void Action()
            {
                splashScreenManager1.ShowWaitForm();

                using (_db = new UnitOfWork())
                {
                    gcOnwork.DataSource = _db.PompsEventsRepo.Include(c => c.Pomps).Where(c => !c.Pomps.IsDelete && c.IsStart).OrderByDescending(x => x.StartDate);

                    gcOnAction.DataSource = _db.PompsEventsRepo.Include(c => c.Pomps).Where(c => !c.Pomps.IsDelete && c.IsStart && c.StopDate <= DateTime.Now.AddDays(7)).OrderByDescending(x => x.Pomps.CatId);

                    gcHistory.DataSource = _db.PompsEventsRepo.Include(c => c.Pomps).Where(c => !c.Pomps.IsDelete).OrderByDescending(x => x.StartDate);

                }

                splashScreenManager1.CloseWaitForm();
            }

            BeginInvoke(new Action(Action));
        }

        private void SelectGrid()
        {
            _id = 0;
            try
            {
                _id = Convert.ToInt32(gvOnHistory.GetRowCellDisplayText(gvOnHistory.FocusedRowHandle, gvOnHistory.Columns["Id"]));
            }
            catch
            {
                _id = 0;
            }
        }

        private void SelectGridOnWork()
        {
            pumpId = 0;
            try
            {
                pumpId = Convert.ToInt32(gvOnwork.GetRowCellDisplayText(gvOnwork.FocusedRowHandle, gvOnwork.Columns["PompId"]));
            }
            catch
            {
                pumpId = 0;
            }
        }

        private void SelectGridOnAction()
        {
            pumpId = 0;
            try
            {
                pumpId = Convert.ToInt32(gvOnAction.GetRowCellDisplayText(gvOnAction.FocusedRowHandle, gvOnAction.Columns["PompId"]));
            }
            catch
            {
                pumpId = 0;
            }
        }

        private void unitListBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new UnitList();
            frm.ShowDialog();
        }

        private void categoriesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new CategoriesList();
            frm.ShowDialog();
        }

        private void pompsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new PompsList();
            frm.ShowDialog();
        }

        private void addEventsOnPompBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new StartPomp();
            frm.ShowDialog();
        }

        private void gvOnwork_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //SelectGridOnWork();
            ////if (pumpId == 0)
            ////    return;

            //using (_db = new UnitOfWork())
            //{
            //    var gridv = _db.PompsEventsRepo
            //                .Include(x => x.Pomps)
            //                .Where(x => x.PompId == pumpId)
            //                .OrderByDescending(x => x.StartDate);
            //    gcHistory.DataSource = gridv;
            //}

        }

        private void gvOnAction_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //SelectGridOnAction();
            ////if (pumpId == 0)
            ////    return;

            //using (_db = new UnitOfWork())
            //{
            //    var gridv = _db.PompsEventsRepo
            //                .Include(x => x.Pomps)
            //                .Where(x => x.PompId == pumpId)
            //                .OrderByDescending(x => x.StartDate);
            //    gcHistory.DataSource = gridv;
            //}
        }

        private void gvOnHistory_DoubleClick(object sender, EventArgs e)
        {
            SelectGrid();
            if (_id == 0)
                return;

            var frm = new StartPomp();
            frm.Id = _id;
            frm.ShowDialog();
        }

        private void refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetData();
        }

        private void gvOnAction_Click(object sender, EventArgs e)
        {
            SelectGridOnAction();
            if (pumpId == 0)
                return;

            using (_db = new UnitOfWork())
            {
                var gridv = _db.PompsEventsRepo
                            .Include(x => x.Pomps)
                            .Where(x => x.PompId == pumpId)
                            .OrderByDescending(x => x.StartDate);
                gcHistory.DataSource = gridv;
            }
        }

        private void gvOnwork_Click(object sender, EventArgs e)
        {
            SelectGridOnWork();
            if (pumpId == 0)
                return;

            using (_db = new UnitOfWork())
            {
                var gridv = _db.PompsEventsRepo
                            .Include(x => x.Pomps)
                            .Where(x => x.PompId == pumpId)
                            .OrderByDescending(x => x.StartDate);
                gcHistory.DataSource = gridv;
            }
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ذریافت نام پوسته و پالت و ارسال به کلاس برای تغییر در تنظیمات
            var skinName = UserLookAndFeel.Default.ActiveSkinName;
            var pallete = UserLookAndFeel.Default.ActiveSvgPaletteName;
            Plugins.ChangeSkin(skinName, pallete);
            Application.Exit();
        }
    }
}
