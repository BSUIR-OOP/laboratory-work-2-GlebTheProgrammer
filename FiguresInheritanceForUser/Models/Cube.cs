using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Cube : Square
    {
        protected float Heigh { get; set; }
        protected float Volume { get; set; }
        public Cube(float side) : base(side)
        {
            Heigh = side;
            Perimeter = 12 * side;
            Area *= 6;
            Volume = side * side * side;
        }
        public override void GetAllFields()
        {
            Console.WriteLine($"\nCube fields:\nLength = {Length}\nWidth = {Width}\nHeigh = {Heigh}\n" +
                $"Perimeter = {Perimeter}\nArea of surface = {Area}\nVolume = {Volume}\n");
        }
    }
}
