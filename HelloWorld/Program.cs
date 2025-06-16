using System;
namespace HelloCI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Greet("CI/CD"));
        }

        public static string Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name");
            return $"Hello, {name}!";
        }
    }
}
