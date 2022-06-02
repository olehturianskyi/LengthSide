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
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(0, 0, "A"), new Point(0, 0, "B"), new Point(0, 0, "C"), new Point(0, 0, "D"));
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}