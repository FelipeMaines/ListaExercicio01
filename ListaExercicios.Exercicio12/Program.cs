namespace ListaExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quais a primeira dimencao do terreno retangular (base): ");
            int bases = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais a segunda dimencao do terreno retangular (altura): ");
            int altura = int.Parse(Console.ReadLine());

            int area = bases * altura;

            Console.WriteLine($"A area do terreno tem {area} m2");
        }
    }
}