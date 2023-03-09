

    internal class Program
    {

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("CONVERTOR DE TEMPERATURA \n");

                Console.Write("Qual a temperatura em Fahrenheit: ");
                double temperaturaF = double.Parse(Console.ReadLine());

                double celcius = (temperaturaF - 32) / 1.8;

                Console.WriteLine($"A temperatura em Celcius eh {celcius}");
            }
        }
    }


