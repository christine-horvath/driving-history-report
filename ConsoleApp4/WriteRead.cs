using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class WriteRead
    {
        public static void WriteToFile(string filepath)
        {
            Trip tripOne = new Trip();
            Trip tripTwo = new Trip();
            Trip tripThree = new Trip();
            List<decimal> doesQualify = new List<decimal>(3);

            //what if one of the trips is < 5 or > 100 - my distance loop doesn't account for it.
            //add each trip to a new array or list and compare distances that way... instead?
            //create a loop for these trips 
            //sort by miles driven

            //method will write to console 
            //array format = Trip / Name / Start Time / End Time / Distance
            string[] trip3 = new string[] { "Trip ", "Amy ", "11:30 ", "12:00 ", "50 " };
            string[] trip2 = new string[] { "Trip ", "Sam ", "8:00 ", "9:00 ", "65 " };
            string[] trip1 = new string[] { "Trip ", "Christine ", "10:00 ", "11:00 ", "60 " };
            string[] Drivers = new string[] { "Driver Christine", "Driver Amy", "Driver Max" };

            tripOne.driver = trip1[1];
            tripOne.startTime = Convert.ToDateTime(trip1[2]);
            tripOne.endTime = Convert.ToDateTime(trip1[3]);
            tripOne.distance = Convert.ToInt32(trip1[4]);
            tripOne.diff = tripOne.endTime.Subtract(tripOne.startTime);
            tripOne.timeinmins = (tripOne.diff.Hours * 60) + tripOne.diff.Minutes;
            tripOne.speed = Math.Round((decimal)tripOne.distance / (decimal)tripOne.timeinmins, 2);
            tripOne.mph = Math.Round(tripOne.speed * 60);
            if (tripOne.mph > 5 && tripOne.mph < 100)
            {
                doesQualify.Add(tripOne.mph);
            }

            tripTwo.driver = trip2[1];
            tripTwo.startTime = Convert.ToDateTime(trip2[2]);
            tripTwo.endTime = Convert.ToDateTime(trip2[3]);
            tripTwo.distance = Convert.ToInt32(trip2[4]);
            tripTwo.diff = tripTwo.endTime.Subtract(tripTwo.startTime);
            tripTwo.timeinmins = (tripTwo.diff.Hours * 60) + tripTwo.diff.Minutes;
            tripTwo.speed = Math.Round((decimal)tripTwo.distance / (decimal)tripTwo.timeinmins, 2);
            tripTwo.mph = Math.Round(tripTwo.speed * 60);

            if (tripTwo.mph > 5 && tripTwo.mph < 100)
            {
                doesQualify.Add(tripTwo.mph);
            }

            //if (tripTwo.mph > 5 || tripTwo.mph < 100)
            //{
            //    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
            //}

            tripThree.driver = trip3[1];
            tripThree.startTime = Convert.ToDateTime(trip3[2]);
            tripThree.endTime = Convert.ToDateTime(trip3[3]);
            tripThree.distance = Convert.ToInt32(trip3[4]);
            tripThree.diff = tripThree.endTime.Subtract(tripThree.startTime);
            tripThree.timeinmins = (tripThree.diff.Hours * 60) + tripThree.diff.Minutes;
            tripThree.speed = Math.Round((decimal)tripThree.distance / (decimal)tripThree.timeinmins, 2);
            tripThree.mph = Math.Round(tripThree.speed * 60);
            if (tripThree.mph > 5 && tripThree.mph < 100)
            {
                doesQualify.Add(tripThree.mph);
            }

            if (doesQualify.Contains(tripThree.mph) == true && doesQualify.Contains(tripTwo.mph) == true && doesQualify.Contains(tripOne.mph) == true)
            {
                if (tripOne.distance > tripTwo.distance && tripOne.mph > tripThree.distance && tripTwo.distance > tripThree.distance)
                {
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                }
                else if (tripOne.distance > tripTwo.distance && tripOne.distance > tripThree.distance && tripThree.distance > tripTwo.distance)
                {
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");

                }
                else if (tripTwo.distance > tripOne.distance && tripTwo.distance > tripThree.distance && tripOne.distance > tripThree.distance)
                {
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");

                }
                else if (tripTwo.distance > tripOne.distance && tripTwo.distance > tripThree.distance && tripThree.distance > tripOne.distance)
                {
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                }
                else if (tripThree.distance > tripOne.distance && tripThree.distance > tripTwo.distance && tripOne.distance > tripTwo.distance)
                {
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                }
                else if (tripThree.distance > tripOne.distance && tripThree.distance > tripTwo.distance && tripTwo.distance > tripOne.distance)
                {
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                }
            }
            else if (doesQualify.Contains(tripThree.mph) == false && doesQualify.Contains(tripTwo.mph) == true && doesQualify.Contains(tripOne.mph) == true)
            {
                if (tripOne.distance > tripTwo.distance)
                {
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                }
                else if (tripOne.distance < tripTwo.distance)
                {
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                }
            }
            else if (doesQualify.Contains(tripThree.mph) == true && doesQualify.Contains(tripTwo.mph) == false && doesQualify.Contains(tripOne.mph) == true)
            {
                if (tripOne.distance > tripThree.distance)
                {
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                }
                else if (tripOne.distance < tripThree.distance)
                {
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
                }
            }
            else if (doesQualify.Contains(tripThree.mph) == true && doesQualify.Contains(tripTwo.mph) == true && doesQualify.Contains(tripOne.mph) == false)
            {
                if (tripTwo.distance > tripThree.distance)
                {
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                }
                else if (tripOne.distance < tripThree.distance)
                {
                    Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
                    Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
                }
            }
            else if (doesQualify.Contains(tripThree.mph) == false && doesQualify.Contains(tripTwo.mph) == false && doesQualify.Contains(tripOne.mph) == true)
            {
                Console.WriteLine(tripOne.driver + ": " + tripOne.distance + " miles @ " + tripOne.mph + "mph");
            }
            else if (doesQualify.Contains(tripThree.mph) == false && doesQualify.Contains(tripTwo.mph) == true && doesQualify.Contains(tripOne.mph) == false)
            {
                Console.WriteLine(tripTwo.driver + ": " + tripTwo.distance + " miles @ " + tripTwo.mph + "mph");
            }
            else if (doesQualify.Contains(tripThree.mph) == true && doesQualify.Contains(tripTwo.mph) == false && doesQualify.Contains(tripOne.mph) == false)
            {
                Console.WriteLine(tripThree.driver + ": " + tripThree.distance + " miles @ " + tripThree.mph + "mph");
            }
            else if (doesQualify.Contains(tripThree.mph) == false && doesQualify.Contains(tripTwo.mph) == false && doesQualify.Contains(tripOne.mph) == false)
            {
                Console.WriteLine("No trips qualify.");
            }
            else
            {
                Console.WriteLine("woof");
            }

            Console.ReadLine();
        }

    }

}




