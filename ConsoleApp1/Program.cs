using System;

namespace ConsoleApp1
{
    class Program
    {
        class OOP
        {
            String name;
            double height;
            double weight;
            public OOP(String name, double height, double weight)
            {
                this.name = name;
                this.height = height;
                this.weight = weight;
            }
            public String getDetails()
            {
                return "Name: " + name + ", Height: " + height + "m" + ", Weight: " + weight + "kg";
            }
        }
        public static void Main(string[] args)
        {
            Dictionary<int, OOP> NBA = new Dictionary<int, OOP>();
            NBA.Add(0, new OOP("Russell Westbrook", 1.91, 91));
            NBA.Add(3, new OOP("Anthony Davis", 2.08, 115));
            NBA.Add(4, new OOP("Lonnie Walker IV", 1.93, 93));
            NBA.Add(6, new OOP("LeBron James", 2.06, 113));
            NBA.Add(7, new OOP("Troy Brown Jr.", 1.98, 98));
            NBA.Add(10, new OOP("Max Christie", 1.98, 86));
            NBA.Add(12, new OOP("Kendrick Nunn", 1.91, 86));
            NBA.Add(14, new OOP("Scotty Pippen Jr.", 1.85, 77));
            NBA.Add(15, new OOP("Austin Reaves", 1.96, 89));
            NBA.Add(17, new OOP("Dennis Schröder", 1.85, 78));
            NBA.Add(20, new OOP("Cole Swider", 2.06, 100));
            NBA.Add(21, new OOP("Patrick Beverley", 1.88, 82));
            NBA.Add(30, new OOP("Damnian Jones", 2.11, 111));
            NBA.Add(31, new OOP("Thomas Bryant", 2.08, 112));
            NBA.Add(35, new OOP("Wenyen Gabriel", 2.06, 93));
            NBA.Add(37, new OOP("Matt Ryan", 1.98, 98));
            NBA.Add(95, new OOP("Juan Anderson", 1.98, 95));
            Console.WriteLine("Which number of the lakers would you like to learn about?");
            try
            {
                Console.WriteLine(NBA[int.Parse(Console.ReadLine())].getDetails());
            }
               catch
            {
                Console.WriteLine("No player exists with that number");
            }
        }
    }
}
