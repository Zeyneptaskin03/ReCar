using Business.Concrete;
using DataAccess.Concrete;
using System;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                CarTest();
               
               // ColorTest();
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId);
                    Console.WriteLine(car.BrandId);
                    Console.WriteLine(car.ColorId);
                    Console.WriteLine(car.DailyPrice); 
                    Console.WriteLine(car.Description);
                    Console.WriteLine("............");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        
    }
}
