using FiguresInheritanceForUser.Interfaces;
using FiguresInheritanceForUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser.domain
{
    internal abstract class FiguresFactory
    {
        private string Name { get;  set; }

        public FiguresFactory(string name)
        {
            Name = name;
        }

        abstract public Figure AddFigure();
    }

    internal class FiguresCreator : FiguresFactory
    {
        public FiguresCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            return new Figure();
        }
    }

    internal class LineSegmentCreator : FiguresFactory
    {
        public LineSegmentCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Length = ");
            bool isRightParam = float.TryParse(Console.ReadLine(), out float length);
            if (!isRightParam || length <= 0)
                throw new ArgumentException(nameof(length));
            else
                return new LineSegment(length);
        }
    }

    internal class SquareCreator : FiguresFactory
    {
        public SquareCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Side = ");
            bool isRightParam = float.TryParse(Console.ReadLine(), out float side);
            if (!isRightParam || side <= 0)
                throw new ArgumentException(nameof(side));
            else
                return new Square(side);
        }
    }

    internal class CubeCreator : FiguresFactory
    {
        public CubeCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Side = ");
            bool isRightParam = float.TryParse(Console.ReadLine(), out float side);
            if (!isRightParam || side <= 0)
                throw new ArgumentException(nameof(side));
            else
                return new Cube(side);
        }
    }

    internal class RectangleCreator : FiguresFactory
    {
        public RectangleCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Length = ");
            bool isRightLength = float.TryParse(Console.ReadLine(), out float length);
            Console.Write("Width = ");
            bool isRightWidth = float.TryParse(Console.ReadLine(), out float width);
            if (!isRightLength || !isRightWidth || length <= 0 || width <= 0)
                throw new ArgumentException(nameof(length) + " " + nameof(width));
            else
                return new Rectangle(length, width);
        }
    }

    internal class RhombusCreator : FiguresFactory
    {
        public RhombusCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Length = ");
            bool isRightLength = float.TryParse(Console.ReadLine(), out float length);
            Console.Write("Heigh = ");
            bool isRightHeigh = float.TryParse(Console.ReadLine(), out float heigh);
            if (!isRightLength || !isRightHeigh || length <= 0 || heigh <= 0)
                throw new ArgumentException(nameof(length) + " " + nameof(heigh));
            else
                return new Rhombus(length, heigh);
        }
    }

    internal class TriangleCreator : FiguresFactory
    {
        public TriangleCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Side A = ");
            bool isRightSideA = float.TryParse(Console.ReadLine(), out float sideA);
            Console.Write("Side B = ");
            bool isRightSideB = float.TryParse(Console.ReadLine(), out float sideB);
            Console.Write("Side C = ");
            bool isRightSideC = float.TryParse(Console.ReadLine(), out float sideC);
            if (!isRightSideA || !isRightSideB || !isRightSideC || sideA <= 0 || sideB <= 0 || sideC <= 0 ||
                sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
                throw new ArgumentException(nameof(sideA) + " " + nameof(sideB) + " " + nameof(sideC));
            else
                return new Triangle(sideA, sideB, sideC);
        }
    }

    internal class TrianglePrismCreator : FiguresFactory
    {
        public TrianglePrismCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Side A = ");
            bool isRightSideA = float.TryParse(Console.ReadLine(), out float sideA);
            Console.Write("Side B = ");
            bool isRightSideB = float.TryParse(Console.ReadLine(), out float sideB);
            Console.Write("Side C = ");
            bool isRightSideC = float.TryParse(Console.ReadLine(), out float sideC);
            Console.Write("Heigh = ");
            bool isRightHeigh = float.TryParse(Console.ReadLine(), out float heigh);
            if (!isRightSideA || !isRightSideB || !isRightSideC || !isRightHeigh ||
                sideA <= 0 || sideB <= 0 || sideC <= 0 || heigh <= 0 ||
                sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
                throw new ArgumentException(nameof(sideA) + " " + nameof(sideB) + " " + nameof(sideC) + " " + nameof(heigh));
            else
                return new TrianglePrism(sideA, sideB, sideC, heigh);
        }
    }

    internal class CircleCreator : FiguresFactory
    {
        public CircleCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Radius = ");
            bool isRightRadius = float.TryParse(Console.ReadLine(), out float radius);
            if (!isRightRadius || radius <= 0)
                throw new ArgumentException(nameof(radius));
            else
                return new Circle(radius);
        }
    }

    internal class CylinderCreator : FiguresFactory
    {
        public CylinderCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Radius = ");
            bool isRightRadius = float.TryParse(Console.ReadLine(), out float radius);
            Console.Write("Heigh = ");
            bool isRightHeigh = float.TryParse(Console.ReadLine(), out float heigh);
            if (!isRightRadius || !isRightHeigh || radius <= 0 || heigh <= 0)
                throw new ArgumentException(nameof(radius) + " " + nameof(heigh));
            else
                return new Cylinder(radius, heigh);
        }
    }

    internal class ConeCreator : FiguresFactory
    {
        public ConeCreator(string name) : base(name)
        {
        }

        public override Figure AddFigure()
        {
            Console.Write("Radius = ");
            bool isRightRadius = float.TryParse(Console.ReadLine(), out float radius);
            Console.Write("Heigh = ");
            bool isRightHeigh = float.TryParse(Console.ReadLine(), out float heigh);
            if (!isRightRadius || !isRightHeigh || radius <= 0 || heigh <= 0)
                throw new ArgumentException(nameof(radius) + " " + nameof(heigh));
            else
                return new Cone(radius, heigh);
        }
    }
}
