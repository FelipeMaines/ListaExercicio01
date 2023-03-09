namespace VolumeCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONVERTOR DE TEMPERATURA \n");

            Console.Write("Qual a temperatura em F: ");
            double tempFa = double.Parse(Console.ReadLine());

            double tempCe = (tempFa - 32) / 1.8;

            Console.WriteLine($"A temperatura em F eh {tempCe}F");
        }
    }
}