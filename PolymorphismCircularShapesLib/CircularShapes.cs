using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCircularShapesLib
{
    public class CircularShapes
    {
        //fields
        private double r; //radius
        private double h; //height

        //Constructor
        public CircularShapes(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        //properties
        public virtual double R {get {return this.r;}}
        public virtual double H {get {return this.h;}}

        //Methods
        public virtual double Area()
        {

            double area = Math.PI * r * r;
            return area;
        }

        public virtual double Perimeter()
        {
            double peri = 2 * Math.PI * r;
            return peri;
        }

        public virtual double Volume()
        {
            return 0;
        }
    }
}
