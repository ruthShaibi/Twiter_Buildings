using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twiter_Bildings
{
    internal class Program
    {
        public static void createRectangleEXP(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                Console.Write("*  *");
                Console.WriteLine();
            }
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
        }
        public static void createTriangularEXP(int height)
        {
            string spaceAfter = " ", spaceBefore = "", space = " ";
            for (int i = 0; i < height - 2; i++)
            {
                spaceBefore += " ";
            }
            Console.WriteLine(spaceBefore + " *");
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(spaceBefore + "*" + spaceAfter + "*");
                spaceAfter += "  ";
                spaceBefore = "";
                for (int j = i + 1; j < height - 2; j++)
                {
                    spaceBefore += space;
                }
            }
            for (int i = 0; i < height; i++)
            {
                Console.Write("* ");
            }
        }
        public static void createRealTriangular(int width, int height)
        {
            int Odd = 3, count = 0, res, space, remainer;
            bool first = true;
            for (int i = 2; i < width; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    
                }
            }
            res = (height - 2) / count;
            remainer = (height - 2) % count;

            for (int i = 0; i < count + Odd / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            for (int i = 0; i < (height - 2) / res; i++)
            {
                for (int j = 0; j < res; j++)
                {
                    for (int q = 0; q < remainer && first; q++)
                    {
                        j--;
                        if (q == 0 && res % 2 == 0)
                            i++;
                    }
                    first = false;
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < Odd && Odd < height; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Odd += 2;
                count--;
            }

            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            int button = 1, width, height, building = 1, answre = 1;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                createRectangleEXP(4, 5);
                Console.WriteLine();
                Console.WriteLine("-------1-------");
                createTriangularEXP(7);
                Console.WriteLine();
                Console.WriteLine("-------2-------");

                Console.WriteLine("for exit enter 3");
                Console.WriteLine("-------3-------");
                Console.WriteLine("enter your choise (1/2/3)");
                building = int.Parse(Console.ReadLine());
                if(building == 3)
                {
                    Console.WriteLine("Bye bye");
                    break;
                }  
                while (building <= 0 || building >= 4)
                {
                    Console.WriteLine("Invalid input- please try again:");
                    Console.WriteLine("choose one building (1/2)");
                    building = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("enter width");
                width = int.Parse(Console.ReadLine());
                while (width <= 0)
                {
                    Console.WriteLine("Invalid input- please try again:");
                    Console.Write("enter width");
                    width = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("enter height");
                height = int.Parse(Console.ReadLine());

                if (building == 1)
                {
                    if (height - width > 5)
                    {
                        Console.WriteLine("the area of the rectangle is" + height * width);
                    }
                    else
                    {
                        Console.WriteLine("The perimeter of the rectangle is " + (height * 2 + width * 2));
                    }
                }
                if (building == 2)
                {
                    Console.WriteLine("To calculate the perimeter of the triangle enter 1. To print the triangle enter 2");
                    answre = int.Parse(Console.ReadLine());
                    while (answre <= 0 || answre >= 3)
                    {
                        Console.WriteLine("Invalid input - please try again");
                        answre = int.Parse(Console.ReadLine());
                    }
                    if (answre == 1)
                    {
                        Console.WriteLine("The perimeter of the triangle is " + (width + height * 2));
                    }
                    if (answre == 2)
                    {
                        if (width % 2 == 0 || width > height * 2)
                        {
                            Console.WriteLine("The triangle cannot be printed!");
                        }
                        else
                        {
                            if (width % 2 != 0 && width < height * 2)
                            {
                                createRealTriangular(width, height);
                            }
                        }

                    }
                    
                }


            }
        }
    }
}

