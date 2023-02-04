using System.Net.Security;

namespace Assignment3
{
             internal static class CarSpeedLimit
        {
            public static void Main()
            {
                Console.WriteLine("Please enter the speed limit you drove: ");
                var speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the speed at which you were driving: ");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                if (carSpeed > speedLimit)
                {
                    var demeritPoints = 0;
                    while (carSpeed > speedLimit)
                    {
                        carSpeed -= 5;
                        demeritPoints++;
                    }

                    if (demeritPoints > 12)
                        Console.WriteLine("License Suspended.");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
        }
    }

 