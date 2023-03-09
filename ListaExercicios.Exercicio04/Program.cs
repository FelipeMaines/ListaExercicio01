namespace ListaExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual foi a km inicial: ");
            double kmInicial= double.Parse(Console.ReadLine());

            Console.Write("Qual foi a km final: ");
            double kmFinal = double.Parse(Console.ReadLine());


            Console.Write("Qual foi a quantidade de L de gasolina: ");
            double gasolinaUsada = double.Parse(Console.ReadLine());

            double kmTotal = kmFinal - kmInicial;

            double rendimentoGasolina = kmTotal / gasolinaUsada ;

            Console.WriteLine($"A quantidade de gasolina rodada por L  em Km eh  {rendimentoGasolina}L/km" );




        }
    }
}