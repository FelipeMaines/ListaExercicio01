namespace listaExercicio.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o numero: ");
            int num = int.Parse(Console.ReadLine());


            //if (num == 0)
            //{
            //    Console.WriteLine("Numero Par!");
            //}

             if (num % 2 == 0)
            {
                Console.WriteLine("Numero Par!");
            }
            
            else
            {
                Console.WriteLine("Numero Impar!");
            }

        }
    }
}