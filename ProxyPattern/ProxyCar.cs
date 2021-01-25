using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyCar : ICar
    {
        private Driver Driver;
        private ICar RealCar;

        public ProxyCar(Driver driver)
        {
            this.Driver = driver;
            this.RealCar = new Car();
        }


        public void DriveCar()
        {
            if (Driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                this.RealCar.DriveCar();

        }
    }
}
