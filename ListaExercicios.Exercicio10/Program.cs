namespace ListaExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso da primeira nota: ");
            int peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso da segunda nota: ");
            int peso2 = int.Parse(Console.ReadLine());

            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine(Math.Round(mediaPonderada, 2));


        }
    }
}