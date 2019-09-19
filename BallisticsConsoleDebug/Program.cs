using System;

namespace BallisticsConsoleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Ballistics
    {

        /// <summary>
        ///  INPUT PARAMS
        /// </summary>
        // speed of the projectile in meters/second

        public string velocity { get; set; }
        public string mass { get; set; }
        public string diameter { get; set; }
        public string distance { get; set; }
        public string tempFarenheit { get; set; }
        public string sAirDensity { get; set; }
        public string dragCoef { get; set; }

        // String Props
        public double meterVelocity { get; set; }
        public double areaMeters { get; set; }
        public double massKilos { get; set; }
        // density of air pressure
        public double pAirDensity { get; set; }
        // Pressure in atmospheres
        // Temperature in Celcius
        public double tempCelcius { get; set; }
        // drag Coefficient of the projectile
        //       public double dragCoefficient { get; set; }

        public string CalculatePressure(double tempCelcius)
        {
            // using defaul of 1ATM
            double pAtmospheres = 1.2;
            pAirDensity = 353.03 * (pAtmospheres / tempCelcius);
            this.sAirDensity = pAirDensity.ToString();
            return sAirDensity;
        }


        /// Meters per second from feet per second.
        /// 
        public double FromFeetPerSecond(string velocity)
        {
            this.meterVelocity = Convert.ToDouble(velocity) * 0.3048;
            return meterVelocity;
        }

        /// Farenheight to Celcius
        /// 
        public double SetTemp(string tempFarenheit)
        {
            double t = (Convert.ToDouble(tempFarenheit));
            this.tempCelcius = (t - 32) * (5 / 9);
            return tempCelcius;
        }

        /// Grains to kilograms
        /// 
        public double ToKilograms(string mass)
        {
            this.massKilos = Convert.ToDouble(mass) * .0000648;
            return massKilos;
        }

        /// Area of projectile from diameter
        /// 
        public double ToArea(string diameter)
        {
            double d = Convert.ToDouble(diameter);
            // Convert inch diameter to meter diameter
            d = d * 0.0254;
            // pass in projectile diameter, return area
            double radius = d / 2;
            this.areaMeters = Math.PI * Math.Pow(radius, 2);
            return areaMeters;
        }
    }
}
}
