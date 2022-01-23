using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_перегрузки_операторов
{
    class Circle : Figure
    {
        public double R { get; set; }

        public Circle()
        {
            R = 0;
        }
        public Circle (string name, double r ) : base(name)
        {
            R = r;
        }
        //абстрактные методы
        public override double P()
        {
            return 2 * Math.PI * R;
        }
        public override double S()
        {
            return Math.PI * R * R;
        }

        // //переопределение Tostring
        public override string ToString()
        {
            return $"Circle {Name}: r = {R}";
        }
    }
}
