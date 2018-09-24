using System;

namespace WSR
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double oldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeIn1meter = double.Parse(Console.ReadLine());
           
            double speed = distance * timeIn1meter;
            double current = (Math.Floor(distance / 15)) * 12.5;
            double totalTime = speed + current;
            
            if (oldRecord <= totalTime)
            {
                double difference = Math.Abs(oldRecord - totalTime);
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", difference);
            }
            else if (oldRecord > totalTime)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", totalTime);
            }
        }
    }
}
