namespace listaExercicio.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor da tabuada desejada: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 0; i <= 10; i++)
            {
                resultado = i * n; 
                Console.WriteLine($"{i} X {n} = {resultado}");
            }
        }
    }
}