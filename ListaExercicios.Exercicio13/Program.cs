namespace ListaExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantiade de paes franceses vendidos no dia: ");
            int frances = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantiade de broas vendidos no dia: ");
            int broas = int.Parse(Console.ReadLine());

            double totalVendas = (frances * 0.12) + (broas * 1.5);

            double investimento = totalVendas * 0.1;

            Console.WriteLine($"O valor total das vendas no dia foi de R${totalVendas}, sendoa assim deve-se investir R${investimento}");
        }
    }
}