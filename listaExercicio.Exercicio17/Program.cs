namespace listaExercicio.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor de a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de c:");
            int c = int.Parse(Console.ReadLine());

            if (c > a + b)
            {
                Console.WriteLine("Imprimido");
            }
        }
    }
}