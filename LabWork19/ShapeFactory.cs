using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.EqualsIgnoreCase("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.EqualsIgnoreCase("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.EqualsIgnoreCase("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
