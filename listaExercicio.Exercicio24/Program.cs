using System.Globalization;

namespace listaExercicio.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;


            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 1)
                {
                    j = j + i;
                    Console.WriteLine(j);
                }

                
            }
        }
    }
}