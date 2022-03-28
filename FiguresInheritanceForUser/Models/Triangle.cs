using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Triangle : Figure
    {
        protected float SideA { get; set; }
        protected float SideB { get; set; }

        private float sideC;
        protected float SideC
        {
            get { return sideC; }
            set
            {
                if (SideA + SideB > value && SideB + value > SideA && SideA + value > SideB)
                    sideC = value;
                else
                    throw new ArgumentException("Wrong parameters. Sum of 2 other sides need to me greater then 3rd.");
            }
        }

        protected float Perimeter { get; set; }
        protected float Area { get; set; }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Perimeter = sideA + sideB + sideC;
            Area = (float)Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - sideA) * ((Perimeter / 2) - sideB) * ((Perimeter / 2) - sideC));
        }
        public override void GetAllFields()
        {
            Console.WriteLine($"\nTriangle fields:\nSide A = {SideA}\nSide B = {SideB}\n" +
                $"Side C = {SideC}\nPerimeter = {Perimeter}\nArea = {Area}\n");
        }
    }
}
