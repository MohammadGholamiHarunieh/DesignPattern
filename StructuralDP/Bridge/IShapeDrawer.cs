using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Bridge
{
    public abstract class ShapeDrawer
    {
        public Shape _shape;
        public ShapeDrawer(Shape shape)
        {

            _shape = shape;

        }
        public abstract void Draw();

        public abstract void Clean();
    }

    public class ShapeDriver1 : ShapeDrawer
    {
        public ShapeDriver1(Shape shape) : base(shape)
        {
        }

        public override void Clean()
        {
            Console.WriteLine($"{nameof(ShapeDriver1)} is gonna to clean {_shape.WhatAmI}");
        }

        public override void Draw()
        {
            Console.WriteLine($"{nameof(ShapeDriver1)} is gonna to draw {_shape.WhatAmI}");
        }
    }

    public class ShapeDriver2 : ShapeDrawer
    {
        public ShapeDriver2(Shape shape) : base(shape)
        {
        }

        public override void Clean()
        {
            Console.WriteLine($"{nameof(ShapeDriver2)} is gonna to clean {_shape.WhatAmI}");
        }

        public override void Draw()
        {
            Console.WriteLine($"{nameof(ShapeDriver2)} is gonna to draw {_shape.WhatAmI}");
        }
    }
}
