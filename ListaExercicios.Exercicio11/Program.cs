namespace ListaExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual número deseja verificar se é primo ou não: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("O número {0} não é um número primo.", numero);
            }

            bool ehPrimo = true;

            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine("O número {0} é um número primo.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} não é um número primo.", numero);
            }
        }
    }
    }
