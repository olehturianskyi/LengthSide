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
        private  int coordX;
        private  int coordY;
        private  string pointName;
        public int CoordX
        {
            get { return coordX; }
        }
        public int CoordY
        {
            get { return coordY; }
        }
        public string PointName
        {
            get { return pointName; }
        }
        public Point(int coordX, int coordY, string pointName)

        {           
            var vertex = new List<string>() { "A", "B", "C", "D", "E" };           
            
            Console.WriteLine("=> Number of shape vertices (value in the range from 3 to 5)");
            int numVert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(new string('_', 50));

            for (int i = 0; i < numVert; i++)
            {
                pointName = vertex[i];
                Console.Write("point " + pointName + " coordinate X: ");
                coordX = Convert.ToInt32(Console.ReadLine());
                Console.Write("point " + pointName + " coordinate Y: ");
                coordY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('_', 50));
                this.coordX = coordX;
                this.coordY = coordY;
                this.pointName = pointName;
                

            }
            
            
        }
      
    }
    
    class Figure
    {   // запрашиваем количество вершин фигуры ? запускаем нужный конструктор - формируем фигуру

        public Figure(Point A, Point B,Point C)
        {
            

            

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
        public void PerimeterCalculator()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.ReadKey();

            
        }
        
    }
}
