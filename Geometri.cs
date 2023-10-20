using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{


    internal class Geometri
    {

        public double area;

        public virtual void Area()
        {
            area = 0;
        }

        public class Rectangle : Geometri 
        {
            public double Radius { get; set; }
            public Rectangle()
            {
                Radius = 5;
            }
            public override void Area()
            {
                area = 0;
            }
        }

        public class Square : Geometri
        {
            public double Radius { get; set; }

            public Square()
            {
                Radius = 8;
            }

            public override void Area()
            {
                area = 0;
            }
        }

        public class Circle : Geometri
        {

            public double Radius { get; set; }

            public Circle()
            {
                Radius = 4;
            }


            public override void Area()
            {
                area = 0;
            }
        }
    }
}
