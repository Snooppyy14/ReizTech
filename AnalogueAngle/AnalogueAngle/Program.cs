using System;

namespace AnalogueAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter desired hour and minutes");

            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());


            while ((hours > 12 || hours < 0) || (minutes > 59 || minutes < 0))
            {

                Console.WriteLine("Invalid time entered");
                Console.WriteLine("Enter hours between 1-12 and minutes between 1-59");
                hours = Convert.ToInt32(Console.ReadLine());
                minutes = Convert.ToInt32(Console.ReadLine());

            }
            //30 degrees between two hours on clock
            //0.5 degrees every minute (hour hand)
            //6 degrees every minute (minute hand)


            if (minutes == 0)
            { //base case
                Console.WriteLine("Angle between hour hand and minute hand is : "+ hours * 30);
            }
            else { 
            int minuteHandAngle = 6 * minutes;
            float hourHandAngle = (30 * hours) + (0.5f * minutes); //calculate angle of hours passed and for every minute calculate hand displacement
            float finalAngle = Math.Abs(hourHandAngle - minuteHandAngle);
                if (finalAngle > 180) {

                    finalAngle = 360 - finalAngle;

                   }
            Console.WriteLine("Angle between hour hand and minute hand is : "+finalAngle);
        }

            
        }
    }
}
