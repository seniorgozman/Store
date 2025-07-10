namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gozman's Stores");
            Console.WriteLine("What do you want to buy? Please select your options");
            Console.WriteLine("1. Laptops");
            Console.WriteLine("2. Phones");

            var options = Console.ReadLine();

            if(options == "1")
            {
                Console.WriteLine("What type of laptop do you want to buy?");
                Console.WriteLine("1. Macbook");
                Console.WriteLine("2. Windows");
            }

            var laptops = Console.ReadLine();
            if (laptops == "1")
            {
                Console.WriteLine("We have Macbook Air at 5000.");
                Console.WriteLine("Do you want to proceed to buy?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
            }

            var response = Console.ReadLine();
            if(response == "1")
            {
                Console.WriteLine("You have purchased a macbook air. Thannk you for shopping with us");
            }
            else
            {
                Console.WriteLine("Bye. We hope you shop with us soon");
            }
        }
    }
}
