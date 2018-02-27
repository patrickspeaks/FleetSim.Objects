using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;
//using FleetSim.Objects.Interface;

namespace FleetSim.Console
{

    class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car("Charger", "Red", 2017);
            Car car2 = new Car("Corolla", "Blue", 2014);
            Car car3 = new Car("Cruise", "Red", 2008);
            Car car4 = new Car("Corvette", "Blue", 1997);
            Car car5 = new Car("Trailblazer", "White", 2015);



            var theCars = new List<Car>
            {
               car1,
               car2,
               car3,
               car4,
               car5
            };


            Random rnd = new Random();  

            for (var i = 0; i <= 9; i++)   
            {
                foreach (Car theCar in theCars)
                {
                    theCar.VinNbr = Guid.NewGuid();
                    theCar.MileageNbr = rnd.Next(30000, 105000);
                    theCar.TuneUp();

                    System.Console.ReadLine();
                }



            }

            var input = System.Console.ReadLine();  
        }
    }

}
