namespace ListaExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o salario base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor total de vendas: ");
            double totalDeVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a comissao? ");
            double comissao = double.Parse(Console.ReadLine());

            comissao = comissao / 100;

            double salarioTotal = salarioBase + (totalDeVendas * comissao);

            Console.WriteLine($"O salario total eh {salarioTotal} com uma comissao de {totalDeVendas * comissao}");
        }
    }
}