namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numele:" );
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + '!');
            Console.WriteLine("Varsta:");
                int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + "in varsta de" + ''  age);

                
        }
    }
}