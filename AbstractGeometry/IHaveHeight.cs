using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal interface IHaveHeight
    {
        double GetHeight();
        void DrawHeight(PaintEventArgs e);
    }
}
