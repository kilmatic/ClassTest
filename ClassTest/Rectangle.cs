using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    struct Point
    {
        public double X, Y;
    }
    abstract class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        abstract public double GetArea();
    }
    class Rectangle : Polygon
    {   
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
        /*
        public static string ShapeName
        {
            get { return "Rectangle"; }
        }
        public double Length { get; set; }
        public double Width { get; set; }
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
        public double GetArea()
        {
            return length * width;
        }*/
    }
}