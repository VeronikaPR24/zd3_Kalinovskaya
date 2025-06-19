using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_ind
{
    public class Car
    {
        private double Mileage { get; set; }//пробег
        private double FuelConsumption { get; set; }//расход топлива
        private string Brand { get; set; }//марка

        public Car(double mileage, double consumption, string brand)
        {
            Mileage = mileage;
            FuelConsumption = consumption;
            Brand = brand;
        }

        public virtual double CalculateQ()
        {
            if(FuelConsumption == 0)
            {
                return 0;
            }
            return Mileage / FuelConsumption;
        }

        public override string ToString()
        {
            return $"{Brand} - {Mileage} км, {FuelConsumption} l/км, Q: {CalculateQ():F2}";
        }
    }
}
