using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_ind
{
    public class CarYear : Car
    {
        private int Year { get; set; }//Год выпуска

        public CarYear(double mileage, double consumption, string brand, int year) : base(mileage, consumption, brand)
        {
            Year = year;
        }

        public override double CalculateQ()
        {
            return base.CalculateQ() * 1.15 * Year;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Год выпуска: {Year}, Qp: {CalculateQ():F2}";
        }
    }
}
