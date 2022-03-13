using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_перегрузки_операторов
{
    //класс прямоугольник - наследник Figure
    class Rectangle: Figure, IPrintable, IDrawable      
    {
        //поля-автосвойства стороны прямуг
        public double A { get; set; }
        public double B { get; set; }
        //конструкторы
        public Rectangle()
        {
            A = B = 0;
        }
        public Rectangle (string name, double a, double b) : base (name)
        {
            A = a;
            B = b;
        }
        //переопределение абстр методов
        public override double P() { return (A + B) * 2; }
        public override double S() { return A * B; }


        //имлементация IPrintable

        //void Iprintable.Print()
        public void Print()
        {
            Console.WriteLine(this);
        }

        public void Draw()
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
        //переопределение Tostring 1
        public override string ToString()
        {
            return $"Rectangle {Name}: a = {A}, b = {B}";
        }
    }
}
