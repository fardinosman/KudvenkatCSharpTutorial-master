using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiAndInstanceClassMembers
{
    class Circle
    {
        public static float _PI { get; set; }  //PI value is constant so we can use 
        //refernce so we avoid that every object make copy og the PI
        public int _Radius { get; set; }

        public Circle(int radius    )
        {
            Console.WriteLine("instance constructor");
            this._Radius = radius;
        }
         static Circle()
        {
            Console.WriteLine("static constructer");
            // we use static constructor to initialize static fields
            // static construcer is called only once
            // static constructer is called befor the instane constructer
            Circle._PI = 3.141F;
        }

        public float CalculateArea()
        {
           
            return _PI * this._Radius * this._Radius;
        }
        public static void Print()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            float resultcircleArea1 = circle1.CalculateArea();

            Console.WriteLine(" Area =  {0}",resultcircleArea1);
            Circle circle2 = new Circle(6);
            float resultcircleArea2 = circle2.CalculateArea();

            Console.WriteLine(" Area =  {0}", resultcircleArea2);

            Circle.Print(); // static member is invoked using only class name not class instance name

        }
    }
}
