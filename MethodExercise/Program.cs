using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MadLibs();

            Console.WriteLine("What is the value of x?");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the value of y?");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of {x} and {y} is {Sum(x, y)}");

            Console.WriteLine($"{x} minus {y} is equal to {Subtract(x, y)}");

            Console.WriteLine($"{x} multiplied by {y} is equal to {Multiply(x, y)}");   

            Console.WriteLine($"{x} divided by {y} is equal to {Division(x, y)}");  

            Console.WriteLine($"The remainder when dividing {x} by {y} is equal to {Modulus(x, y)}");   
        }
        static void MadLibs()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band/musician?");
            string band = Console.ReadLine();

            Console.WriteLine($"One day, {name} went to a concert, to see his favorite musician peform, {band}. While " +
                $"he was in the moshpit, somebody threw {color} paint on him. He did not mind, as {color} was his favorite color, " +
                $"and he was wearing his least favorite shirt. When he got home, his pet {animal} jumped on him, which resulted in him " +
                $"getting the aforementioned paint all over him. The {animal} then proceeded to jump on the couch and get {color} paint " +
                $"all over the couch. {name} was not happy.");
        }
        static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static int Subtract(int x, int y)
        {
            int sub = x - y;
            return sub;
        }
        static int Multiply(int x, int y)
        {
            int mul = x * y;
            return mul;
        }
        static int Division(int x, int y )
        {
            int div = x / y;
            return div;
        }
        static int Modulus(int x, int y)
        {
            int mod = x % y;
            return mod;
        }
    }
}
