using System;

namespace ConsoleApp1
{
    class Parking
    {
        private string plateNum;
        private string vehType;
        private string brand;
        private DateTime parkIn;

        public Parking(string plateNum, string vehType, string brand, DateTime parkIn)
        {
            this.plateNum = plateNum;
            this.vehType = vehType;
            this.brand = brand;
            this.parkIn = parkIn;
        }

        public void ComputeParking(DateTime parkOut, int flagDown, int succeedingPay)
        {
            Console.WriteLine("Date/Time In:" + parkIn + "\n         Out:" + parkOut);

            TimeSpan duration = parkOut - parkIn;

            double totalHours = duration.TotalHours;

            Console.WriteLine("Parking Time: " + totalHours.ToString("0.00") + " Hour/s");

            double amount = flagDown;
            double totalAmount = amount;

            if (totalHours > 1)
            {
                totalAmount += succeedingPay * (totalHours - 1); // Subtract 1 hour because the first hour is included in flagDown
            }

            Console.WriteLine("Parking Fee:" + totalAmount.ToString("0.00"));
            Console.Write("\nThank you and have a safe trip!");
        }

        public void ShowParkingInfo()
        {
            Console.WriteLine("Plate No: " + plateNum);
            Console.WriteLine("Type: " + vehType);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("ParkedIn(Date/Time): " + parkIn);
        }
    }
}