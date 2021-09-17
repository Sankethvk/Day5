using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirst
{
        public abstract class Shape
        {
            public string Color;

            public void setColor(string name)
            {
                Color = name;

            }
            public string getColor()
            {
                return Color;
            }
            public abstract double Area();
        }
        public class Rectangle : Shape
        {
            public int length;
            public int width;

            public Rectangle(int length,int width, string name)
            {
                setColor(name);
                this.length = length;
                this.width = width;

            }
            public override double Area()
            {
                return this.length * this.width;
           
            }
            public void displayArea()
            {
                Console.WriteLine("area is {0}", Area());
            }
        }

    }
