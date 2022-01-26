using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;

namespace ProduceRecovery.Models
{
    public class Plugins
    {
        public static void ChangeSkin(string skinName, string pallete)
        {
            Properties.Settings.Default["skin"] = skinName;
            Properties.Settings.Default["pallete"] = pallete;
            Properties.Settings.Default.Save();
        }

        public static void CurrentSkin()
        {
            var skin = Properties.Settings.Default["skin"].ToString();
            var pallete = Properties.Settings.Default["pallete"].ToString();
            UserLookAndFeel.Default.SetSkinStyle(skin, pallete);
        }
    }
}
