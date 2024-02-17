using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.State
{
    public class Paint
    {
        public ColorPen ColorPen { get; set; }

        public Paint(ColorPen colorPen)
        {
            ColorPen = colorPen;
        }
        public void SetColorPen(ColorPen colorPen)
        {
            ColorPen = colorPen;
        }
        public void DrawLine()
        {
            ColorPen.Draw(this);
        }
    }
}
