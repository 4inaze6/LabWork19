using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Square : IShape
    {
        void IShape.Draw()
        {
            Console.WriteLine("Inside Square::Draw() method.");
        }
    }
}
