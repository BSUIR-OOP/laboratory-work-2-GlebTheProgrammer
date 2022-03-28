using FiguresInheritanceForUser.domain;
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
                            FiguresFactory figuresFactory = new FiguresCreator("ООО Figures_Creator");
                            ShowPossibleFigures();
                            int action = int.Parse(Console.ReadLine());

                            switch (action)
                            {
                                // Back
                                case 0:
                                    break;

                                // Figure DONE  
                                case 1:
                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Line segment DONE
                                case 2:
                                    figuresFactory = new LineSegmentCreator("OOO LineSegment_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Square DONE
                                case 3:
                                    figuresFactory = new SquareCreator("ООО Square_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cube DONE
                                case 4:
                                    figuresFactory = new CubeCreator("ООО Cube_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Rectangle DONE
                                case 5:
                                    figuresFactory = new RectangleCreator("ООО Rectangle_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Rhombus DONE
                                case 6:
                                    figuresFactory = new RhombusCreator("ООО Rhombus_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Triangle DONE
                                case 7:
                                    figuresFactory = new TriangleCreator("ООО Triangle_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Triangle prism DONE
                                case 8:
                                    figuresFactory = new TrianglePrismCreator("ООО TrianglePrism_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Circle DONE
                                case 9:
                                    figuresFactory = new CircleCreator("ООО Circle_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cylinder DONE
                                case 10:
                                    figuresFactory = new CylinderCreator("ООО Cylinder_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
                                    Console.WriteLine("Done");
                                    Console.ReadLine();
                                    break;

                                // Cone DONE
                                case 11:
                                    figuresFactory = new ConeCreator("ООО Cone_Creator");

                                    figuresContainer.Add(figuresFactory.AddFigure());
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
