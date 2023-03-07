namespace TargetFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número positivo inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (EhFibonacci(numero))
            {
                Console.WriteLine(numero + " pertence à sequência de Fibonacci!");
            }
            else
            {
                Console.WriteLine(numero+ " não pertence à sequência de Fibonacci.");
            }
        }

        static bool EhFibonacci(int numero)
        {
            int a = 0, b = 1;

            while (b < numero)
            {
                int guarda = a;
                a = b;
                b = guarda + b;
            }

            return b == numero;
        }
    }
    
}