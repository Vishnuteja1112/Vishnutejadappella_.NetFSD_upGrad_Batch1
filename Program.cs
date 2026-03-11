namespace ASSIG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:-");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:- ");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine($"The quoitent of the number is {a / b}");
        }
    }
}
