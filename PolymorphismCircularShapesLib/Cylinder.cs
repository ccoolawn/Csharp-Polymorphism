using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCircularShapesLib
{
    public class Cylinder : CircularShapes
    {
        public Cylinder(double r, double h) : base(r, h)
        {

        }

        public override double Area()
        {
            double a = 2 * Math.PI * R * H;
            return a;
        }

        public override double Volume()
        {
            double v = Math.PI * R * R * H;
            return v;
        }
    }
}
