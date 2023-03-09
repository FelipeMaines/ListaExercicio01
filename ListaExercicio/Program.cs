namespace ListaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE VOLUME DE UM RETANGULO \n");

            Console.Write("Qual o valor da aresta (a): ");
            int arestaA = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor da aresta (b): ");
            int arestaB = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor da aresta (c): ");
            int arestaC = int.Parse(Console.ReadLine());

            int volume = arestaA * arestaB * arestaC;

            Console.WriteLine($"O valome do retangulo eh {volume}");
        }
    }
}