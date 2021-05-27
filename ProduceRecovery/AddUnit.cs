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
    public partial class AddUnit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork _db;
        public int Id = 0;
        public AddUnit()
        {
            InitializeComponent();
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            if (this.Id != 0)
            {
                using (_db = new UnitOfWork())
                {
                    var q = _db.UnitsRepo.GetById(this.Id);
                    unitName.Text = q.UnitName;
                    remark.Text = q.Remark;
                    _db.Dispose();
                }
            }
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(unitName.Text))
            {
                dxErrorProvider1.SetError(unitName, "این فیلد نباید خالی باشد");
                return;
            }

            try
            {
                using (_db = new UnitOfWork())
                {
                    var tbl = new Units()
                    {
                        UnitName = unitName.Text,
                        Remark = remark.Text
                    };
                    if (Id == 0)
                    {
                        _db.UnitsRepo.Insert(tbl);
                        unitName.Focus();
                    }
                    else
                    {
                        tbl.Id = this.Id;
                        _db.UnitsRepo.Update(tbl);
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
                UnitList.form.GetList();
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