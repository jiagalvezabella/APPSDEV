using System;
using System.Collections.Generic;

public class ParkingSystem
{
    static List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
    static void Main(string[] args)
    {
        Console.WriteLine("One Central Parking System!");
        Console.WriteLine("Enter the number of parking spots:");
        int numOfSpots = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfSpots; i++)
        {
            parkingSpots.Add(new ParkingSpot());
        }
        while (true)
        {
            Console.WriteLine("\n1. Park Vehicle");
            Console.WriteLine("2. Unpark Vehicle");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ParkVehicle();
                    break;
                case 2:
                    UnparkVehicle();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ParkVehicle()
    {
        Console.WriteLine("Enter the plate number:");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Enter the vehicle type (Car, Motorcycle, Truck):");
        string vehicleType = Console.ReadLine();
        Console.WriteLine("Enter the vehicle brand:");
        string vehicleBrand = Console.ReadLine();
        ParkingSpot spot = FindAvailableSpot();
        if (spot != null)
        {
            spot.Park(plateNumber, vehicleType, vehicleBrand);
            Console.WriteLine("Vehicle parked successfully.");
        }
        else
        {
            Console.WriteLine("No available parking spots.");
        }
    }

    static ParkingSpot FindAvailableSpot()
    {
        foreach (ParkingSpot spot in parkingSpots)
        {
            if (!spot.IsOccupied)
            {
                return spot;
            }
        }
        return null;
    }

    static void UnparkVehicle()
    {
        Console.WriteLine("Enter the plate number of the vehicle to unpark:");
        string plateNumber = Console.ReadLine();
        ParkingSpot spot = FindOccupiedSpot(plateNumber);
        if (spot != null)
        {
            spot.Unpark();
            Console.WriteLine("Vehicle unparked successfully.");
            Console.WriteLine($"Parked In: {spot.ParkedIn}");
            Console.WriteLine($"Parked Out: {spot.ParkedOut}");
            Console.WriteLine($"Parking Duration: {spot.ParkingDuration.TotalHours:F2} hours");
            Console.WriteLine($"Parking Fee: ₱{spot.ParkingFee:F2}");
        }
        else
        {
            Console.WriteLine("Vehicle not found in parking spots.");
        }
    }

    static ParkingSpot FindOccupiedSpot(string plateNumber)
    {
        foreach (ParkingSpot spot in parkingSpots)
        {
            if (spot.IsOccupied && spot.PlateNumber == plateNumber)
            {
                return spot;
            }
        }
        return null;
    }
}

class ParkingSpot
{
    public string PlateNumber { get; private set; }
    public string VehicleType { get; private set; }
    public string VehicleBrand { get; private set; }
    public bool IsOccupied { get; private set; }
    public DateTime ParkedIn { get; private set; }
    public DateTime ParkedOut { get; private set; }
    public TimeSpan ParkingDuration { get; private set; }
    public decimal ParkingFee { get; private set; }

    public void Park(string plateNumber, string vehicleType, string vehicleBrand)
    {
        PlateNumber = plateNumber;
        VehicleType = vehicleType;
        VehicleBrand = vehicleBrand;
        IsOccupied = true;
        ParkedIn = DateTime.Now; 
    }

    public void Unpark()
    {
        IsOccupied = false;
        ParkedOut = DateTime.Now; 
        ParkingDuration = ParkedOut - ParkedIn;
        ParkingFee = (decimal)ParkingDuration.TotalHours * 50;
    }
}
