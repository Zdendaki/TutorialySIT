using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public class NonSelectableButton : Button
    {
        public NonSelectableButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
