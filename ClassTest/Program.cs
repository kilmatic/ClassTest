using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle { Length = 10, Width = 20 };
            Rectangle rect2 = new Rectangle { Length = 10, Width = 20 };
            Console.WriteLine(rect1.CompareTo(rect2));

            /*
            Triangle t = new Triangle();
            t.Draw();
            Polygon p = t;
            p.Draw();

            
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());
            foreach(Polygon p in polygons)
            {
                p.Draw();
            }

            
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine("Width = {0}, Length = {1}, Area = {2}", rect.Width, rect.Length, rect.GetArea());
            
            
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            Point p2 = p1;
            p2.X = 100;
            Console.WriteLine("p1.X = {0}", p1.X);
            Rectangle rect1 = new Rectangle { Length = 10.0, Width = 20.0 };
            Rectangle rect2 = rect1;
            rect2.Length = 100.0;
            Console.WriteLine("rect1.Length = {0}", rect1.Length);
            
            
            Rectangle rect = new Rectangle { Length = 10.0, Width = 20.0 };
            Console.WriteLine("Shape Name : {0}, Area: {1}", 
                Rectangle.ShapeName, 
                rect.GetArea());
            
            Rectangle r = new Rectangle();
            r.Changed += new EventHandler(r_Changed);
            r.Length = 10;
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
            */

        }
        /*
        static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", r.Length);
        }
        */
        /*
        static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }
        */
        /*
        static int Partition(int[] numbers, int left, int right, int pivotIndex)
        {
            int pivotValue = numbers[pivotIndex];
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;
            int newPivot = left;

            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= pivotValue )
                {
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;
                    newPivot++;
                }
            }

            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;

            return newPivot;
        }
        static int[] QuickSort(int[] numbers, int left, int right)
        {
            if (right > left)
            {
                int pivotIndex = left + (right - left) / 2;
                pivotIndex = Partition(numbers, left, right, pivotIndex);
                QuickSort(numbers, left, pivotIndex - 1);
                QuickSort(numbers, pivotIndex + 1, right);
            }
            return numbers;
        }
        */
    }
}