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
using Data.Models;

namespace ProduceRecovery
{
    public partial class AddPomp : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        public int Id = 0;
        public AddPomp()
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
                categorySelect.Properties.DataSource = _db.CategoriesRepo.Get(c => !c.IsDelete && c.UnitId== unitId);
                categorySelect.Properties.DisplayMember = "CatName";
                categorySelect.Properties.ValueMember = "Id";
            }
        }
        private void AddUnit_Load(object sender, EventArgs e)
        {
            GetUnits();
            if (this.Id != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.PompsRepo.GetById(this.Id);
                    unitSelect.EditValue = q.Categories.UnitId;
                    categorySelect.EditValue = q.CatId;
                    PompName.Text = q.PompName;
                    InWorkDuration.Text = q.InWorkDuration.ToString();
                    remark.Text = q.Remark;
                    _db.Dispose();
                }
            }
            
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(categorySelect.Text))
            {
                dxErrorProvider1.SetError(categorySelect, "این فیلد نباید خالی باشد");
                return;
            }

            if (string.IsNullOrEmpty(PompName.Text))
            {
                dxErrorProvider1.SetError(PompName, "این فیلد نباید خالی باشد");
                return;
            }

            if (string.IsNullOrEmpty(InWorkDuration.Text))
            {
                dxErrorProvider1.SetError(InWorkDuration, "این فیلد نباید خالی باشد");
                return;
            }

            try
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = new Pomps()
                    {
                        CatId = (int) categorySelect.EditValue,
                        PompName = PompName.Text,
                        InWorkDuration = Convert.ToInt32(InWorkDuration.Text),
                        Remark = remark.Text
                    };
                    if (Id == 0)
                    {
                        _db.PompsRepo.Insert(tbl);
                        PompName.Focus();
                    }
                    else
                    {
                        tbl.Id = this.Id;
                        _db.PompsRepo.Update(tbl);
                    }
                    _db.Save();
                    _db.Dispose();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            try
            {
                PompsList.form.GetList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            this.Close();
        }

        private void cancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void unitSelect_EditValueChanged(object sender, EventArgs e)
        {
            int unitId = (int) unitSelect.EditValue;
            GetCategories(unitId);
        }
    }
}