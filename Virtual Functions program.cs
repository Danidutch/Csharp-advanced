using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2virtualfunctions
{ }
    class MyClass
    {
        class Shape { 
            public const double PI = Math.PI;
            private double Volume = 0;

            public void SetVolume(double val)
            {
                Volume = val;
            }
            public virtual double Area()
            {
                return Volume;
            }
        }
    class Rect : Shape {
        private double heights= 0;
        private double widhts = 0;
        
        public void SetVolume(double h,double w)
        {
            heights = h;
            widhts = w;
        }
        public override double Area()
        {
            return heights * widhts;
        }
    }
    class Circle : Shape
    {
        private double radius = 0;


        public void SetRadius(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return PI * radius;
        }
    }












    static void Main()
            {

            Shape sh = new Shape();
            sh.SetVolume(5.6);
            Console.WriteLine("Shape Volume :" +sh.Area());
        Rect rc = new Rect();
        rc.SetVolume(5.5, 2.5);
        Console.WriteLine("Rect Area : " + rc.Area());

        Circle crl = new Circle();
        crl.SetRadius(2.5);
        Console.WriteLine("Circle Area : "+ crl.Area());





        Console.ReadLine();
            

            




        }
    }

