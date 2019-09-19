using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BallisticsCalcApp.Models
{
    public class BallisticsInitializer
    {
        public void Initialize() {

            /// Default Values for ballistics calculator.
            /// TODO  Need to seed to Index somehow?
            var b = new Models.Ballistics
            {
                diameter = ".308",
                mass = "175",
                velocity = "2200",
                tempFarenheit = "68",
                distance = "100",
                dragCoefficient = .470,
                pAirDensity = 6.229941176470588,
                meterVelocity = 670.56,
                areaMeters = 0.0000480439297184
            };
        }
    }
}