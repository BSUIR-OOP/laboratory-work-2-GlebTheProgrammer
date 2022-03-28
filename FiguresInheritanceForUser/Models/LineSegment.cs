using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class LineSegment : Figure
    {
        protected float Length { get; set; }

        public LineSegment(float length)
        {
            Length = length;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nLine Segment fields:\nLength = {Length}\n");
        }

    }
}
