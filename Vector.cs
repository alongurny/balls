using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    public struct Vector
    {

        public static readonly Vector Zero = new Vector(0, 0);
        public static readonly Vector NaN = new Vector(double.NaN, double.NaN);

        public static Vector operator +(Vector v)
        {
            return v;
        }

        public static Vector operator -(Vector v) {
            return new Vector(-v.x, -v.y);
        }

        public static Vector operator +(Vector u, Vector v)
        {
            return new Vector(u.x + v.x, u.y + v.y);
        }

        public static Vector operator -(Vector u, Vector v)
        {
            return u + (-v);
        }

        public static Vector operator *(Vector v, double t)
        {
            return new Vector(t * v.x, t * v.y);
        }

        public static Vector operator *(double t, Vector v)
        {
            return v * t;
        }

        public static Vector operator /(Vector v, double t)
        {
            if (0 != t)
            {
                return v*(1/t);
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public static Vector operator *(Vector u, Vector g) {
            return Zero;
        }

        private double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length
        {
            get { return Math.Sqrt(x * x + y * y); }
        }

        public double X {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return "Vector(" + x + ", " + y + ")";
        }
    }
}
