using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class TrianglePrism : Triangle
    {
        protected float Heigh { get; set; }
        protected float Volume { get; set; }
        public TrianglePrism(float sideA, float sideB, float sideC, float heigh) : base(sideA, sideB, sideC)
        {
            Heigh = heigh;
            Perimeter += 3 * heigh;
            Volume = Area * heigh;
            Area = 2 * Area + sideA * heigh + sideB * heigh + sideC * heigh;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nTriangle prism fields:\nSide A = {SideA}\nSide B = {SideB}\n" +
                $"Side C = {SideC}\nHeigh = {Heigh}\nPerimeter = {Perimeter}\nArea = {Area}\nVolume = {Volume}\n");
        }
    }
}
