using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCircularShapesLib
{
    public class Cone : Cylinder
    {
        public Cone(double r, double h) : base(r, h)
        {

        }

        public override double Area()
        {
            double area = Math.PI * R * (R + Math.Pow(R, H));
            return area;
        }

        public override double Volume()
        {
            double volume = Math.PI * R * R * (H / 3);
            return volume;
        }

        //we can also override system methods
        public override string ToString()
        {
            string output = $"name: {GetType().Name} r: {R.ToString("F3")} " +
                            $"h: {H.ToString("F3")} area: {Area().ToString("F3")}";
            return output;
        }
    }
}
