using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.Models
{
    internal class Cone : Circle
    {
        protected float Heigh { get; set; }
        protected float Volume { get; set; }
        public Cone(float radius, float heigh, float piValue = (float)Math.PI) : base(radius, piValue)
        {
            Heigh = heigh;
            Volume = Area * heigh / 3;
        }
        public override void GetAllFields()
        {
            Console.WriteLine($"\nCone fields:\nRadius of surface = {Radius}\nDiameter = {Diameter}\n" +
                $"Area of surface = {Area}\nHeigh = {Heigh}\nVolume = {Volume}\n");
        }

    }
}
