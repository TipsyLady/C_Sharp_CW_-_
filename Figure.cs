using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_перегрузки_операторов
{
    abstract class Figure
    {
        //поле имя фигуры
        public string Name { get; set; } //реализовать автосвойство

        //конструкторы
        public Figure() { Name = "underfined"; }
        public Figure (string name) { Name = name; }

        //аьстрактные методы
        public abstract double P();
        public abstract double S();
    }
}
