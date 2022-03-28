using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Rhombus : LineSegment
    {
        protected float Perimeter { get; set; }
        protected float Area { get; set; }
        public Rhombus(float length, float highForCalculatingArea = 0) : base(length)
        {
            Perimeter = 4 * length;
            Area = highForCalculatingArea * length;
        }
        public override void GetAllFields()
        {
            Console.Write($"\nRhombus fields:\nSide = {Length}\nPerimeter = {Perimeter}\n");
            if (Area > 0)
                Console.WriteLine($"Area = {Area}\n");
            else
                Console.WriteLine($"Area = Unable to calculate\n");
        }
    }
}
