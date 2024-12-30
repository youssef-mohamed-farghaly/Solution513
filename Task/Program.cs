namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PriceSmall = 25;
            int PriceBig = 30;
            Console.WriteLine("Hello for currnet clean");
            Console.Write("Enter number of small currnet : ");
            int smallCurnet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of big currnet : ");
            int bigCurnet = Convert.ToInt32(Console.ReadLine());
            int Cost = (smallCurnet * PriceSmall) + (bigCurnet * PriceBig);
            double Tax = Cost * .06 ;
            double Total = Cost + Tax;
            Console.WriteLine($"The cost is : {Cost}");
            Console.WriteLine($"The tax is : {Tax}");
            Console.WriteLine($"Total is : {Total}");
            Console.WriteLine("Thanks for uses program.");

        }
    }
}
