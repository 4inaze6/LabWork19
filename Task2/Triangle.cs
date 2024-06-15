using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task2
{
    internal class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Triangle::Draw() method.");
        }
    }
}
