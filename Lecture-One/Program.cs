namespace Lecture_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = 6.6;
            int smallRoom = 25;
            int largeRoom = 35;


            Console.WriteLine($"Islam's Carpet Cleaning Service");

            Console.Write($"Please Enter Number Of Small Rooms : ");
            int numSmallRooms = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please Enter Number Of Large Rooms : ");
            int numLargeRooms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Price per small room : {smallRoom:c}");
            Console.WriteLine($"Price per large room : {largeRoom:c}");

            double cost = (numSmallRooms * smallRoom) + (numLargeRooms * largeRoom);
            Console.WriteLine($"Cost : {cost:c}");
            Console.WriteLine($"Tax : {tax:c1}");
            Console.WriteLine("======================================");

            Console.WriteLine($"Total estimate : {tax + cost:c1}");
            Console.WriteLine("Estimates are valid for 30 days");
        }
    }
}
