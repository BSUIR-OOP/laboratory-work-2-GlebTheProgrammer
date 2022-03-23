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
            Console.WriteLine("Welcome. Select the work mode, type it and press ENTER button:\n" +
                              "1 - Laboratory work №1 (Test mode)\n" +
                              "2 - Laboratory work №2 (User mode)\n");

            Console.Write("Type the mode: ");
            int num = int.Parse(Console.ReadLine());

            var figuresContainer = new List<Figure>();

            switch (num)
            {
                case (1):
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
                    break;


                case 2:
                    while (true)
                    {
                        ShowExistingMethods();
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 0)  // Exit
                            break;

                        if (choice == 1)  // Add figure
                        {
                            ShowPossibleFigures();
                            int action = int.Parse(Console.ReadLine());

                            switch (action)
                            {
                                // Back
                                case 0:
                                    break;

                                // Figure
                                case 1:
                                    figuresContainer.Add(new Figure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Line segment
                                case 2:
                                    Console.Write("Length = ");
                                    float length = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new LineSegment(length));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Square
                                case 3:
                                    Console.Write("Side = ");
                                    float side = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Square(side));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cube
                                case 4:
                                    Console.Write("Side = ");
                                    side = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Cube(side));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Rectangle
                                case 5:
                                    Console.Write("Length = ");
                                    length = float.Parse(Console.ReadLine());
                                    Console.Write("Width = ");
                                    float width = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Rectangle(length, width));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Rhombus
                                case 6:
                                    Console.Write("Length = ");
                                    length = float.Parse(Console.ReadLine());
                                    Console.Write("Heigh = ");
                                    float heigh = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Rhombus(length, heigh));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Triangle
                                case 7:
                                    Console.Write("Side A = ");
                                    float sideA = float.Parse(Console.ReadLine());
                                    Console.Write("Side B = ");
                                    float sideB = float.Parse(Console.ReadLine());
                                    Console.Write("Side C = ");
                                    float sideC = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Triangle(sideA, sideB, sideC));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Triangle prism
                                case 8:
                                    Console.Write("Side A = ");
                                    sideA = float.Parse(Console.ReadLine());
                                    Console.Write("Side B = ");
                                    sideB = float.Parse(Console.ReadLine());
                                    Console.Write("Side C = ");
                                    sideC = float.Parse(Console.ReadLine());
                                    Console.Write("Heigh = ");
                                    heigh = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new TrianglePrism(sideA, sideB, sideC, heigh));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Circle
                                case 9:
                                    Console.Write("Radius = ");
                                    float radius = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Circle(radius));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cylinder
                                case 10:
                                    Console.Write("Radius = ");
                                    radius = float.Parse(Console.ReadLine());
                                    Console.Write("Heigh = ");
                                    heigh = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Cylinder(radius, heigh));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cone
                                case 11:
                                    Console.Write("Radius = ");
                                    radius = float.Parse(Console.ReadLine());
                                    Console.Write("Heigh = ");
                                    heigh = float.Parse(Console.ReadLine());
                                    figuresContainer.Add(new Cone(radius, heigh));
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Not found exception
                                default:
                                    Console.WriteLine("Action does not exist. Please, type an existing one.");
                                    Console.ReadLine();
                                    break;
                            }
                        }

                        if (choice == 2)  // Delete figure by ID
                        {
                            Console.Clear();
                            Console.Write("Figure ID: ");
                            uint Id = uint.Parse(Console.ReadLine());
                            DeleteFigureByID(figuresContainer, Id);
                            Console.ReadLine();
                        }

                        if (choice == 3)  // Print figure by ID
                        {
                            Console.Clear();
                            Console.Write("Figure index: ");
                            uint Id = uint.Parse(Console.ReadLine());
                            Console.WriteLine();

                            PrintFigureByID(figuresContainer, Id);
                            Console.WriteLine("Done");
                            Console.ReadLine();
                        }

                        if (choice == 4)  // Print all figures
                        {
                            Console.Clear();
                            PrintAllFigures(figuresContainer);
                            Console.WriteLine("Done");
                            Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Progarm was executed. Press ENTER button.");
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("You've typed wrong number. Program was executed. Press ENTER button.");
                    Console.ReadLine();
                    break;
            }
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

        static void ShowExistingMethods()
        {
            Console.Clear();
            Console.WriteLine("Please, choose any action: ");
            Console.WriteLine("1 - Add new figure");
            Console.WriteLine("2 - Delete figure by index");
            Console.WriteLine("3 - Print figure by index");
            Console.WriteLine("4 - Print all figures");
            Console.WriteLine("0 - Exit\n");

            Console.Write("Write down an action: ");
        }

        static void ShowPossibleFigures()
        {
            Console.Clear();
            Console.WriteLine("Please, choose the figure to add: ");
            Console.WriteLine("1 - Figure interpritation");
            Console.WriteLine("2 - Line segment");
            Console.WriteLine("3 - Square");
            Console.WriteLine("4 - Cube");
            Console.WriteLine("5 - Rectangle");
            Console.WriteLine("6 - Rhombus");
            Console.WriteLine("7 - Triangle");
            Console.WriteLine("8 - Triangle prism");
            Console.WriteLine("9 - Circle");
            Console.WriteLine("10 - Cylinder");
            Console.WriteLine("11 - Cone\n");
            Console.WriteLine("0 - Back\n");

            Console.Write("Write down an action: ");
        }
    }
}
