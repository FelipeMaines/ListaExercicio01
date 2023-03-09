namespace listaExercicio.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor: ");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 1;
            string sequencia = numero.ToString();


            while (numero != 0)
            {
                resultado = resultado * numero;
                sequencia += " X " + (numero - 1).ToString();
                numero--;
            }

            Console.WriteLine("{0}! = {1}", numero, sequencia);

        }
    }
}

//Dificuldade para mostrar no console corretamente!