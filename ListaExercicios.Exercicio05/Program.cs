namespace ListaExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o raio: ");
            double raio = double.Parse(Console.ReadLine());

            double volume = (4 / 3) * 3.14 * Math.Pow(raio, 3);

            Console.WriteLine(volume);


        }
    }
}