namespace FristProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"No really ,{num} is my favorite number");
        }
    }
}
