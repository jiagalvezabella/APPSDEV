using ConsoleApp1;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime parkIn = DateTime.Now;

            int outerLoop = 0;

            Console.Write("Enter Plate Number: ");
            string plateNumber = Console.ReadLine();

            Console.Write("\nEnter Vehicle Brand: ");
            string vehBrand = Console.ReadLine();

            string vehType = "";
            int outerSwitchLoop = 0;
            int initial = 0;
            int proceeding = 0;

            while (outerSwitchLoop < 1)
            {
                int vehOpt = 0;

                int innerSwitchLoop = 0;
                while (innerSwitchLoop < 1)
                {
                    try
                    {
                        Console.Write("\nVehicle Type:\n1.Motorcycle \n2.Car \n3.Truck ");
                        vehOpt = Convert.ToInt32(Console.ReadLine());
                        innerSwitchLoop = 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input! Integer input only!");
                    }
                }

                Car Car = new Car(" ", " ", " ");
                Motorcycle motor = new Motorcycle(" ", " ", " ");
                Truck Truck = new Truck(" ", " ", " ");
                switch (vehOpt)
                {
                    case 1:
                        vehType = "Motorcycle";
                        motor = new Motorcycle(vehBrand, plateNumber, "Motorcycle");
                        plateNumber = motor.PlateNum;
                        vehBrand = motor.Brand;
                        vehType = motor.Type;
                        initial = (int)Motorcycle.Amounts.value;
                        proceeding = (int)Motorcycle.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    case 2:
                        vehType = "Car";
                        Car = new Car(vehBrand, plateNumber, "Car");
                        plateNumber = Car.PlateNum;
                        vehBrand = Car.Brand;
                        vehType = Car.Type;
                        initial = (int)Car.Amounts.value;
                        proceeding = (int)Car.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    case 3:
                        vehType = "Truck";
                        Truck = new Truck(vehBrand, plateNumber, "Truck");
                        plateNumber = Truck.PlateNum;
                        vehBrand = Truck.Brand;
                        vehType = Truck.Type;
                        initial = (int)Truck.Amounts.value;
                        proceeding = (int)Truck.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
            Parking park = new Parking(plateNumber, vehType, vehBrand, parkIn);

            Console.WriteLine("\nVEHICLE PARKED DETAILS");
            park.ShowParkingInfo();

            int innerWhileLoop = 0;
            while (innerWhileLoop < 1)
            {
                Console.Write("\nDo you want to park out? \n1.Yes \n2.No: ");
                int parkChoice = Convert.ToInt32(Console.ReadLine());

                switch (parkChoice)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.Write("Enter Time Parked Out: ");
                                string parkOut = Console.ReadLine();
                                DateTime toParkOut = DateTime.Parse(parkOut);
                                if (toParkOut < parkIn) /*|| toParkOut.Month < parkIn.Month || toParkOut.Year < parkIn.Year || toParkOut.Hour < parkIn.Hour || toParkOut.Minute < parkIn.Minute || toParkOut.Second < parkIn.Second)*/
                                {
                                    Console.WriteLine("\nINVALID DATE\n");
                                    outerLoop = 1;
                                }
                                else
                                {
                                    park.ComputeParking(toParkOut, initial, proceeding);
                                    outerLoop = 0;
                                    innerWhileLoop = 1;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Write("\nINVALID FORMAT, PLEASE USE MM/DD/YYYY HH:MM:SS\n");
                                outerLoop = 1;
                            }
                        } while (outerLoop != 0);
                        break;
                    case 2:
                        park.ShowParkingInfo();
                        innerWhileLoop = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Please choose a valid option!");
                        innerWhileLoop = 0;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
