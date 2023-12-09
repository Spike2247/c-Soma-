// See https://aka.ms/new-console-template for more information


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os numeros a serem somados");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O resultado da soma é {Soma(num1, num2)}");
            Console.WriteLine("Aperte enter para finalizar");
            Console.ReadLine();
            

        }

        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
