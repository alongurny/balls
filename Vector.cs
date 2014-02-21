using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    public struct Vector
    {
        public static bool operator ==(Vector u, Vector v)
        {
            return u.Equals(v);
        }

        public static bool operator !=(Vector u, Vector v)
        {
            return !(u == v);
        }

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

        public static double operator *(Vector u, Vector v) {
            return u.x * v.x + u.y * v.y;
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

        public double Arg
        {
            get { return Math.Atan2(y, x); }
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

        public override bool Equals(object o)
        {
            if (!(o is Vector))
            {
                return false;
            }
            Vector v = (Vector)o;
            return this.x == v.x && this.y == v.y;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
    }
}
