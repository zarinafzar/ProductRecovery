using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProduceRecovery.Actions;

namespace ProduceRecovery
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

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
    }
}
