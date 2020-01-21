using System;

namespace WeekTwoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grand Circus Room Calculator
            Console.WriteLine("Welcome to the Grand Circus Room Calculator!");
            string answer;
            var roomSize = "";
            do
            {
                Console.Write("Please enter room length: ");
                var inputLength = double.Parse(Console.ReadLine());

                Console.Write("Please enter room width: ");
                var inputWidth = double.Parse(Console.ReadLine());

                Console.Write("Please enter room height: ");
                var inputHeight = double.Parse(Console.ReadLine());


                var area = inputLength * inputWidth;
                var perimeter = (2 * inputWidth) + (2 * inputLength);
                var volume = inputHeight * inputLength * inputWidth;

                if (area <= 250)
                {
                    roomSize = "small";
                }
                else if (area < 650 && area > 250)
                {
                    roomSize = "medium";
                }
                else if (area >= 650)
                {
                    roomSize = "large";
                }

                Console.WriteLine($"\nThe area of the room is: {area} \nThe perimeter of the room is: {perimeter} \nThe volume of the room is: {volume}\nThis is a {roomSize} room.");
                Console.WriteLine("Would you like calculate the space of another room?\n Yes/No");
                answer = Console.ReadLine().ToLower();
                Console.Clear();
            } while (answer.Equals("y") || answer.Equals("yes"));

            Console.WriteLine("Thank you for using our calculator!");
        }
    }
}
