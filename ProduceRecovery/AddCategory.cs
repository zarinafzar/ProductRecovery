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
    public partial class AddCategory : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        public int Id = 0;
        public AddCategory()
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
        private void AddUnit_Load(object sender, EventArgs e)
        {
            GetUnits();

            if (this.Id != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.CategoriesRepo.GetById(this.Id);
                    unitSelect.EditValue = q.UnitId;
                    categoryName.Text = q.CatName;
                    remark.Text = q.Remark;
                    _db.Dispose();
                }
            }
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(unitSelect.Text))
            {
                dxErrorProvider1.SetError(unitSelect, "این فیلد نباید خالی باشد");
                return;
            }
            if (string.IsNullOrEmpty(categoryName.Text))
            {
                dxErrorProvider1.SetError(categoryName, "این فیلد نباید خالی باشد");
                return;
            }

            try
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = new Categories()
                    {
                        CatName = categoryName.Text,
                        UnitId = (int) unitSelect.EditValue,
                        Remark = remark.Text
                    };
                    if (Id == 0)
                    {
                        _db.CategoriesRepo.Insert(tbl);
                        categoryName.Focus();
                    }
                    else
                    {
                        tbl.Id = this.Id;
                        _db.CategoriesRepo.Update(tbl);
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
                CategoriesList.form.GetList();
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
    }
}