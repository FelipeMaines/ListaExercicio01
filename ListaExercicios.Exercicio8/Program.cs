namespace ListaExercicios.Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a altura da lata: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o raio da lata: ");
            double raio = double.Parse(Console.ReadLine());

            double valumeLata = 3.14 * Math.Pow(raio, 2) * altura;

            Console.WriteLine(valumeLata);
        }
    }
}