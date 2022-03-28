using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Cylinder : Circle
    {
        protected float Heigh { get; set; }
        protected float Volume { get; set; }
        public Cylinder(float radius, float heigh, float piValue = (float)Math.PI) : base(radius, piValue)
        {
            Heigh = heigh;
            Volume = Area * heigh;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nCylinder fields:\nRadius of surface = {Radius}\nDiameter = {Diameter}\n" +
                $"Area of surface = {Area}\nHeigh = {Heigh}\nVolume = {Volume}\n");
        }
    }
}
