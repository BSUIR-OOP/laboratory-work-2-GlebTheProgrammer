using FiguresInheritanceForUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresInheritanceForUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figuresContainer = new List<Figure>();

            figuresContainer.Add(new Figure());
            figuresContainer.Add(new LineSegment(10.5f));
            figuresContainer.Add(new Square(7.8f));
            figuresContainer.Add(new Cube(15.6f));
            figuresContainer.Add(new Rectangle(4.2f, 2.1f));
            figuresContainer.Add(new Rhombus(11, 5.5f));
            figuresContainer.Add(new Triangle(5, 8, 10));
            figuresContainer.Add(new TrianglePrism(5.5f, 8.8f, 10.1f, 12.4f));
            figuresContainer.Add(new Circle(11.1f));
            figuresContainer.Add(new Cylinder(21.3f, 7));
            figuresContainer.Add(new Cone(18.2f, 8.9f));

            PrintAllFigures(figuresContainer);
            Console.WriteLine("-------------------------------------------------------");
            PrintFigureByID(figuresContainer, 3);
            Console.WriteLine("-------------------------------------------------------");
            DeleteFigureByID(figuresContainer, 3);
            Console.WriteLine("-------------------------------------------------------");
            PrintAllFigures(figuresContainer);

            Console.WriteLine("Done :)");
            Console.ReadLine();
        }

        static void PrintAllFigures(List<Figure> figuresList)
        {
            foreach (var figure in figuresList)
            {
                Console.Write($"Figure ID {figure.Id}");
                figure.GetAllFields();
            }
        }

        static void PrintFigureByID(List<Figure> figuresList, uint id)
        {
            int index = 0;
            foreach (var figure in figuresList)
            {
                if (figure.Id == id)
                {
                    Console.WriteLine("Here is the figure info:");
                    figuresList[index].GetAllFields();
                    return;
                }
                index++;
            }
            Console.Write($"Figure with such index was not found.");
        }

        static void DeleteFigureByID(List<Figure> figuresList, uint id)
        {
            int index = 0;
            foreach (var figure in figuresList)
            {
                if (figure.Id == id)
                {
                    figuresList.RemoveAt(index);
                    Console.WriteLine("Figure was deleted successfully.");
                    return;
                }
                index++;
            }
            Console.WriteLine("Figure with that index does not exist. Nothing happened.");
            return;
        }
    }
}
