namespace listaExercicio.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua altura (metros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine(imc);


            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso normal!");
            }

            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso!");
            }

            else if (imc > 30)
            {
                Console.WriteLine("Obeso!");
            }
        }
    }
}