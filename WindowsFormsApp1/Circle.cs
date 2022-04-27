using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
   public class Circle
    {
        private int radius;
        private string color;
        public int Radius
        {
            get { return radius; }

          private set { radius = value; }
        }
        public Circle(int r, string c)
        {
            radius = r;
            color = c;
        }
        public double Calculate_Area()
        {
            return radius * radius * 3.14;
        }
        public double Calculate_circumference()
        {
            return radius * 3.14;
        }
    }
}
