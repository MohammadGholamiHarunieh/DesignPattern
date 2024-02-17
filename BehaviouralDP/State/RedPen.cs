using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.State
{
    public class RedPen : ColorPen
    {
        public override void Draw(Paint paint)
        {
            Console.WriteLine("a 'red' line drawed");
            paint.SetColorPen(this);
        }
    }
}
