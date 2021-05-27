using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ProduceRecovery.Models
{
    class ExportToFiles
    {
        public static void ExportToFile(string format, XtraSaveFileDialog sfd, GridView gv)
        {
            try
            {
                sfd.FileName = string.Empty;
                var result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fs = new FileStream(sfd.FileName, FileMode.Create);
                    fs.Close();
                }

                if (format == "excel")
                    gv.ExportToXls(sfd.FileName);
                if (format == "doc")
                    gv.ExportToDocx(sfd.FileName);
                if (format == "pdf")
                    gv.ExportToPdf(sfd.FileName);

            }
            catch (Exception ex)
            {
                string appendText =ex.Message + Environment.NewLine;
                File.AppendAllText(Application.StartupPath + "\\logs", appendText, Encoding.UTF8);
            }
        }
    }
}
