using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Rectangle : LineSegment
    {
        protected float Width { get; set; }
        protected float Perimeter { get; set; }
        protected float Area { get; set; }

        public Rectangle(float length, float width) : base(length)
        {
            Width = width;
            Area = length * width;
            Perimeter = 2 * length + 2 * width;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nRectangle fields:\nLength = {Length}\nWidth = {Width}\n" +
                $"Perimeter = {Perimeter}\nArea = {Area}\n");
        }
    }
}
