namespace ListaExercicios.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario: ");
            double salarioInicial = double.Parse(Console.ReadLine());

            double salarioAumentado = salarioInicial * 1.15;

            double salarioImposto = salarioAumentado * 0.92;


            Console.WriteLine($"O salario inicial era: {salarioInicial}");
            Console.WriteLine($"O salario com os 15% de aumento ficou: {salarioAumentado}");
            Console.WriteLine($"O salario com o desconto de 8% ficou: {salarioImposto}");
        }
    }
}