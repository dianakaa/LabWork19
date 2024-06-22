using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    internal class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
