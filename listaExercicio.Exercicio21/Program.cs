namespace listaExercicio.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            int c = 0;

            if (valor1 == valor2)
            {
                c = (valor1 + valor2);
               
            }
            else
            {
               c = (valor1 * valor2);
                
            }

            Console.WriteLine(c);
        }
    }
}