using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    /*
    struct Point
    {
        public double X, Y;
    }
    */
    /*abstract*/ class Polygon
    {
        /*
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        abstract public double GetArea();
        */
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }
    class Triangle: Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing: Trianlge");
        }
    }
    class Rectangle : Polygon, IComparable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Length * Width;
        }
        public int CompareTo(object obj)
        {
            if ((obj == null))
                return 1;
            if (!(obj is Rectangle))
                throw new ArgumentException();

            Rectangle target = (Rectangle)obj;
            double diff = this.GetArea() - target.GetArea();

            if (diff == 0)
                return 0;
            else if (diff > 0)
                return 1;
            else return -1;
        }
        /*
        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }        
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double GetArea()
        {
            return Width * Length;
        }
        public override string ToString()
        {
            return String.Format("Width = {0}, Length = {1}", Width, Length);
        }
        
        public static string ShapeName
        {
            get { return "Rectangle"; }
        }
        */

        /*
        public double GetArea()
        {
            return this.Length * this.Width;
        }
        
        
        public event EventHandler Changed;
        private double length;
        //private double width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                Changed(this, EventArgs.Empty);
            }
        }
        /*
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                Changed(this, EventArgs.Empty);
            }
        }
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public void InitFields(double l, double w)
        {
            length = l;
            width = w;
        }
        */
    }
}