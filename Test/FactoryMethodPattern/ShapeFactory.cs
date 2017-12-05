using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern
{
    public class ShapeFactory
    {
        public Shape GetShape(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.None:
                    return null;
                case ShapeTypes.Rectangle:
                    return new Rectangle();
                case ShapeTypes.Circle:
                    return new Circle();
                case ShapeTypes.Square:
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
