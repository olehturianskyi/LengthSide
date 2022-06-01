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
        private int coordinX;
        private int coordinY;
        private string pointName;
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
    {   
        public Figure(Point A, Point B, Point C)
        {
            int aX = A.CoordinX;
            int bX = B.CoordinX;
            int cX = C.CoordinX;
            int aY = A.CoordinY;
            int bY = B.CoordinY;
            int cY = C.CoordinY;
            string aName = A.PointName;
            string bName = B.PointName;
            string cName = C.PointName;
        }
        public Figure(Point A, Point B, Point C, Point D)           
        {
            int aX = A.CoordinX;
            int bX = B.CoordinX;
            int cX = C.CoordinX;
            int dX = D.CoordinX;

            int aY = A.CoordinY;
            int bY = B.CoordinY;
            int cY = C.CoordinY;
            int dY = D.CoordinX;

            string aName = A.PointName;
            string bName = B.PointName;
            string cName = C.PointName;
            string dName = D.PointName;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            int aX = A.CoordinX;
            int bX = B.CoordinX;
            int cX = C.CoordinX;
            int dX = D.CoordinX;
            int eX = E.CoordinX;

            int aY = A.CoordinY;
            int bY = B.CoordinY;
            int cY = C.CoordinY;
            int dY = D.CoordinY;
            int eY = E.CoordinY;

            string aName = A.PointName;
            string bName = B.PointName;
            string cName = C.PointName;
            string dName = D.PointName;
            string eName = E.PointName;
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
            int x = 0, y = 0, i = 0; string name = null;
            Console.WriteLine("=> Number of shape vertices (value in the range from 3 to 5)");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(new string('_', 50));
            Point pointA = new Point(x, y, name);
            Point pointB = new Point(x, y, name);
            Point pointC = new Point(x, y, name);
            Point pointD = new Point(x, y, name);
            Point pointE = new Point(x, y, name);
            switch (i)
            {
                case 3:
                    Console.WriteLine("       FIGURE: triangle");
                    for (int j = 1; j < 4; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointA = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointB = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointC = new Point(x, y, name);
                        }                        
                    }
                    
                    Console.WriteLine(new string('_', 50));

                    Figure triangle = new Figure(pointA, pointB, pointC);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    break;
                case 4:
                    Console.WriteLine("       FIGURE: quadrilateral");
                    for (int j = 1; j < 5; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointA = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointB = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointC = new Point(x, y, name);
                        }
                        if (j == 4)
                        {
                            name = "D";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointD = new Point(x, y, name);
                        }
                    }
                    
                    Console.WriteLine(new string('_', 50));

                    Figure quadrilateral = new Figure(pointA, pointB, pointC);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    Console.WriteLine(pointD.PointName + ":   x=" + pointD.CoordinX + ":   y=" + pointD.CoordinY);

                    break;
                case 5:
                    Console.WriteLine("       FIGURE: pentagon");
                    for (int j = 1; j < 6; j++)
                    {
                        Console.WriteLine(" " + j + "-я точка: ");
                        if (j == 1)
                        {
                            name = "A";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointA = new Point(x, y, name);
                        }
                        if (j == 2)
                        {
                            name = "B";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointB = new Point(x, y, name);
                        }
                        if (j == 3)
                        {
                            name = "C";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointC = new Point(x, y, name);
                        }
                        if (j == 4)
                        {
                            name = "D";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointD = new Point(x, y, name);
                        }
                        if (j == 5)
                        {
                            name = "E";
                            x = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());
                            pointE = new Point(x, y, name);
                        }
                    }
                    Console.WriteLine(new string('_', 50));

                    Figure pentagon = new Figure(pointA, pointB, pointC);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    Console.WriteLine(pointD.PointName + ":   x=" + pointD.CoordinX + ":   y=" + pointD.CoordinY);
                    Console.WriteLine(pointE.PointName + ":   x=" + pointE.CoordinX + ":   y=" + pointE.CoordinY);

                    break;
                default:
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;
            }
            
            Console.ReadKey();
        }

    }
}