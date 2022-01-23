using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_перегрузки_операторов
{
    class Program
    {
        //реализовать базовый класс фигура с абстрактными методами получения площади и периметра
        //сделать наследников, кот переопределяют данные методы

        //сделать класс-агрегатор фигур - пул-фигур
        // реализовать методы получения общей площади, периметра, имен

        //IPrintable - для печати фигуры на консоли
        //IDrawtable - для отрисовки фигуры на консоли

        static void Task_1 ()
        {
            Figure figure = new Rectangle("ABCD", 5, 6);
            Console.WriteLine(figure.P());
            figure = new Circle("OS", 3.14);
            Console.WriteLine(figure);
            Console.WriteLine(figure.P());
        }
        static void Task_2()
        {
            FigurePool pool = new FigurePool();
            Console.WriteLine(pool);
            pool.AddFigure(new Rectangle("ABCD", 10, 20));
            Console.WriteLine(pool);
            pool.AddFigure(new Circle("AO", 3));
            Console.WriteLine(pool);

        }
        static void Task_3()
        {
            FigurePool pool = new FigurePool();
            Console.WriteLine(pool);
            pool.AddFigure(new Rectangle("ABCD", 1, 2)); //P==6
            Console.WriteLine(pool);
            pool.AddFigure(new Circle("AO", 1/Math.PI)); //P==2
            Console.WriteLine(pool);

            Console.WriteLine($"Common P = {pool.getTotalP()}");
        }
        static void Task_4()
        {
            IPrintable printable = new Rectangle();
            printable.Print();
            IDrawable drawable = new Rectangle("ABCD", 5, 3);
            drawable.Draw();
        }

        static void Task_5()
        {
            FigurePool pool = new FigurePool();
            pool.AddFigure(new Rectangle("ABCD", 4, 5)); //P==6
            pool.AddFigure(new Circle("AO", 1 / Math.PI)); //P==2
            pool.AddFigure(new Circle("Big", 200));
            pool.AddFigure(new Rectangle("Big rect", 20, 40));
            pool.Print();
            pool.Draw();
        }
        static void Main(string[] args)
        {
            Task_5();
        }
    }
}
