using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_перегрузки_операторов
{
    class FigurePool: IDrawable,IPrintable
    {
        //клас, кот содержит 

        //поле для хранения фигур
        List<Figure> figures; //список для хранения фигур

        //конструктор
        public FigurePool()
        {
            figures = new List<Figure>();

        }
        //метод добавл фигуры в пул
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

        public double getTotalP()
        {
            double sum = 0;
            foreach (Figure figure in figures)
                sum += figure.P();
            return sum;
        }
        public double getTotalS()
        {
            double sum = 0;
            foreach (Figure figure in figures)
                sum += figure.S();
            return sum;
        }
        public override string ToString()
        {
            string res = "Figures Pool: \n";
            foreach (Figure figure in figures)
                res += figure.ToString() + "\n";
            res += "----------------------------\n";
            return res;
        }

        public void Print ()
        {
            foreach (var figure in figures) //var - определяет тип
            {
                if (figure is IPrintable)//если фигура реализует интерфейс
                {
                    ((IPrintable)figure).Print(); //вызвать Print фигуры
                }
                else { Console.WriteLine("Figure does not implement this interface"); }
            }
        }

        public void Draw()
        {
            foreach (var figure in figures) //var - определяет тип
            {
                if (figure is IDrawable)//если фигура реализует интерфейс
                {
                    ((IDrawable)figure).Draw(); //вызвать Print фигуры
                }
                else { Console.WriteLine("Figure does not implement this interface"); }
            }
        }
    }

}
