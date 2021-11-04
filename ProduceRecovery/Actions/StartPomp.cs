using Data.Contexts;
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
        private void StartPomp_Load(object sender, EventArgs e)
        {
            //startDate.EditValue = DateTime.Now;
            GetUnits();
            if (this.Id != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.PompsRepo.GetById(this.Id);
                    unitSelect.EditValue = q.Categories.UnitId;
                    categorySelect.EditValue = q.CatId;
                    PompName.Text = q.PompName;
                    remark.Text = q.Remark;
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
    }
}