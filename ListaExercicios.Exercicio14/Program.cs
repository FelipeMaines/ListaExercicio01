namespace ListaExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int totalDias = idade * 365;

            Console.WriteLine($"{nome} voce tem {totalDias} de vida!");
        }
    }
}