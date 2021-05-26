using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonClass
{
    class BasicUtils
    {
        public static void ToggleButton(Button btn)
        {
            btn.Enabled = !btn.Enabled;
            btn.Visible = btn.Enabled;
        }
    }

}
