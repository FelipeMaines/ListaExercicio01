namespace ListaExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONVERTOR DE TEMPERATURA \n");

            Console.Write("Qual a temperatura em Celcius: ");
            double tempCelcius = double.Parse(Console.ReadLine());

            double tempF = (tempCelcius * 1.8) + 32;

            Console.WriteLine($"A temperatura em F eh {tempF}F");
        }
    }
}