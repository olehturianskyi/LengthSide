using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Создать классы Point и Figure.

Класс Point должен содержать два целочисленных поля и одно строковое поле.

Создать три свойства с одним методом доступа get.

Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. 

Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.

Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.

Написать программу, которая выводит на экран название и периметр многоугольника.
*/
namespace LengthSide
{
    class Point
    {
        private  int coordinX;
        private  int coordinY;
        private  string pointName;
        public int CoordinX
        {
            get { return coordinX; }
        }
        public int CoordinY
        {
            get { return coordinY; }
        }
        public string PointName
        {
            get { return pointName; }
        }
        public Point(int coordinX, int coordinY, string pointName)
        {
            this.coordinX = coordinX;
            this.coordinY = coordinY;
            this.pointName = pointName;
        }              
    }
    
    class Figure
    {   // запрашиваем количество вершин фигуры ? запускаем нужный конструктор - формируем фигуру
        public Figure(Point A, Point B,Point C)
        {
            // triangle
        }
        public Figure (Point A,Point B, Point C, Point D)
        {
            // quadrilateral
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            // pentagon
        }

        double length;



        public double LengthSide(Point A, Point B)
        {
            // определяем длины сторон (логика, перебираем пары точек, в зависимости от того какая фигура образована ?)
            return length;
        }
        public static void PerimeterCalculator()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, i = 0;  string name=null;
            Console.WriteLine("=> FIGURE: 1 - triangle;  2 - quadrilateral;   3 - pentagon");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(new string ('_', 50));
            Point point1 = new Point(x, y, name);
            Point point2 = new Point(x, y, name);
            Point point3 = new Point(x, y, name);
            Point point4 = new Point(x, y, name);
            Point point5 = new Point(x, y, name);
            switch (i)
            {
                case 1:                    
                    Console.WriteLine("       FIGURE: triangle");
                    for (int j = 1; j<4; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {                            
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());                            
                            point1 = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point2 = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point3 = new Point(x, y, name);
                        }
                    }
                    Figure figure1 = new Figure(point1, point2, point3);  
                    
                    break;
                case 2:
                    Console.WriteLine("       FIGURE: quadrilateral");
                    for (int j = 1; j < 5; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point1 = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point2 = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point3 = new Point(x, y, name);
                        }
                        if (j == 4)
                        {
                            name = "D";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point4 = new Point(x, y, name);
                        }
                    }
                    Figure figure2 = new Figure(point1, point2, point3, point4);
                    break;                
                case 3:
                    Console.WriteLine("       FIGURE: pentagon");
                    for (int j = 1; j < 6; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point1 = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point2 = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point3 = new Point(x, y, name);
                        }
                        if (j == 4)
                        {
                            name = "D";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point4 = new Point(x, y, name);
                        }
                        if (j == 5)
                        {
                            name = "E";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            point4 = new Point(x, y, name);
                        }
                    }
                    Figure figure3 = new Figure(point1, point2, point3, point4,point5);
                    break;
                default:
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;
            }


            Console.ReadKey();
        }
        
    }
}
