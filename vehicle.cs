using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PracticeLoop
{
    public class vehicle
    {
        int vehicleID;
        String brand;
        String model;
        double rentalPricePerDay;
        Boolean isAvailable = true;
        
        public vehicle(int vehicleID, String brand, String model, double rentalPricePerDay)
        {
            this.vehicleID = vehicleID;
            this.brand = brand;
            this.model = model;
            this.rentalPricePerDay = rentalPricePerDay;
        }

        public bool RentVehicle()
        {
            Console.WriteLine("Enter Vehicle Brand");
            String Vbrand = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Model");
            String Vmodel = Console.ReadLine();

            if (isAvailable)
            {
                Console.WriteLine("You have rented " + Vbrand + "" + "" + Vmodel + " with rent price " + rentalPricePerDay);
               
            }
           

            else if (!isAvailable)

            {
                
                Console.WriteLine("Car unavailable");

            }
          
            isAvailable = false;
            return isAvailable;

        }
        public void ReturnVehicle()
        {

        }

        public void DisplayVehicleInfo(bool is1)
        {
            if (is1)
            {
                Console.WriteLine("Car Details" + vehicleID + brand + model);
            }

        }
        class Execute
        {

            //public static void Main(String[] args)
            //{

            //    vehicle v1 = new vehicle(1, "tata", "nexon", 250.1122);
            //    bool is1=v1.RentVehicle();
            //    v1.DisplayVehicleInfo(is1);
            //    v1.RentVehicle();
               
               
            //}
        }
    }
}