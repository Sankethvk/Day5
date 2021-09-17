using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirst
{
        interface shape
        {
            double area();
            double volume();
        }
        class Cube : shape
        {
            int x = 10;
            public double area()
            {
                return (6 * x * x);
            }

            public double volume()
            {
                return (x * x * x);
            }
        }
        class circle : shape
        {
            int radius = 10;

            public double area()
            {
                return (3.142 * radius * radius);
            }

            public double volume()
            {
                return (0);
            }

        }
    }
