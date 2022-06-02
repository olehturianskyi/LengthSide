using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthSide
{
    internal class Figure
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;
        private Point pointD;
        private Point pointE;

        public Figure(Point _pointA, Point _pointB, Point _pointC)
        {
            pointA = _pointA;
            pointB = _pointB;
            pointC = _pointC;
        }

        public Figure(Point _pointA, Point _pointB, Point _pointC, Point _pointD) :
            this(_pointA, _pointB, _pointC)
        {
            pointD = _pointD;
        }
        public Figure(Point _pointA, Point _pointB, Point _pointC, Point _pointD, Point _pointE) :
             this(_pointA, _pointB, _pointC, _pointD)
        {
            pointE = _pointE;
        }
        public double Length_Side(Point _pointA, Point _pointB)
        {
            int x1 = _pointA.CoordinX;
            int y1 = _pointA.CoordinY;
            int x2 = _pointB.CoordinX;
            int y2 = _pointB.CoordinY;
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
        public void PerimeterCalculator()
        {
            int x = 0, y = 0; string name = null;
            Console.WriteLine("=> Number of shape vertices (value in the range from 3 to 5)");
            int i = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine(new string('_', 50));
                    Figure triangle = new Figure(pointA, pointB, pointC);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    Console.WriteLine(new string('_', 50));
                    double ab_lenqth = Length_Side(pointA, pointB);
                    Console.WriteLine("Side length AB: " + ab_lenqth);
                    double bc_lenqth = Length_Side(pointB, pointC);
                    Console.WriteLine("Side length BC: " + bc_lenqth);
                    double ca_lenqth = Length_Side(pointC, pointA);
                    Console.WriteLine("Side length CA: " + ca_lenqth);
                    Console.WriteLine(new string('_', 50));
                    Console.WriteLine(new string('_', 50));
                    double perimetr = ab_lenqth + bc_lenqth + ca_lenqth;
                    Console.WriteLine(" Perimeter triangle = " + perimetr);
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

                    Figure quadrilateral = new Figure(pointA, pointB, pointC, pointD);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    Console.WriteLine(pointD.PointName + ":   x=" + pointD.CoordinX + ":   y=" + pointD.CoordinY);

                    ab_lenqth = Length_Side(pointA, pointB);
                    Console.WriteLine("Side length AB: " + ab_lenqth);
                    bc_lenqth = Length_Side(pointB, pointC);
                    Console.WriteLine("Side length BC: " + bc_lenqth);
                    double cd_lenqth = Length_Side(pointC, pointD);
                    Console.WriteLine("Side length CD: " + cd_lenqth);
                    double da_lenqth = Length_Side(pointD, pointA);
                    Console.WriteLine("Side length DE: " + da_lenqth);
                    Console.WriteLine(new string('_', 50));
                    Console.WriteLine(new string('_', 50));
                    perimetr = ab_lenqth + bc_lenqth + cd_lenqth + da_lenqth;
                    Console.WriteLine(" Perimeter quadrilateral = " + perimetr);
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

                    Figure pentagon = new Figure(pointA, pointB, pointC, pointD, pointE);
                    Console.WriteLine(pointA.PointName + ":   x=" + pointA.CoordinX + ":   y=" + pointA.CoordinY);
                    Console.WriteLine(pointB.PointName + ":   x=" + pointB.CoordinX + ":   y=" + pointB.CoordinY);
                    Console.WriteLine(pointC.PointName + ":   x=" + pointC.CoordinX + ":   y=" + pointC.CoordinY);
                    Console.WriteLine(pointD.PointName + ":   x=" + pointD.CoordinX + ":   y=" + pointD.CoordinY);
                    Console.WriteLine(pointE.PointName + ":   x=" + pointE.CoordinX + ":   y=" + pointE.CoordinY);

                    ab_lenqth = Length_Side(pointA, pointB);
                    Console.WriteLine("Side length AB: " + ab_lenqth);
                    bc_lenqth = Length_Side(pointB, pointC);
                    Console.WriteLine("Side length BC: " + bc_lenqth);
                    cd_lenqth = Length_Side(pointC, pointD);
                    Console.WriteLine("Side length CD: " + cd_lenqth);
                    double de_lenqth = Length_Side(pointD, pointE);
                    Console.WriteLine("Side length DE: " + de_lenqth);
                    double ea_lenqth = Length_Side(pointE, pointA);
                    Console.WriteLine("Side length EA: " + ea_lenqth);
                    Console.WriteLine(new string('_', 50));
                    Console.WriteLine(new string('_', 50));
                    perimetr = ab_lenqth + bc_lenqth + cd_lenqth + de_lenqth+ ea_lenqth;
                    Console.WriteLine(" Perimeter pentagon = " + perimetr);
                    break;
                default:
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;
            }

        }
    }
}
