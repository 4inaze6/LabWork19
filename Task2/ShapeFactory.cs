using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ShapeFactory
    {
        public IShape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                throw new ArgumentNullException("Значение не может быть пустым");
            }

            if (shapeType.ToUpper() == "CIRCLE")
            {
                return new Circle();
            }

            else if (shapeType.ToUpper() == "RECTANGLE")
            {
                return new Rectangle();

            }

            else if (shapeType.ToUpper() == "SQUARE")
            {
                return new Square();
            }

            else if (shapeType.ToUpper() == "TRIANGLE")
            {
                return new Triangle();
            }

            throw new ArgumentNullException("Введено некорректное значение");
        }
    }
}
