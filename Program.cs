using System;

namespace Aula_Nulable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            double? z = null;
            double? w = 10.0;

            double a = z ?? 5; // Condicao que joga um valor padrão(5) caso o z seja null
            double b = w ?? 5; // Condicao que joga um valor padrão(5) caso o w seja null

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(x.GetValueOrDefault()); // Retorna o Valor de X caso tenha ou retorna Padrão(0) caso seja null
            Console.WriteLine(y.GetValueOrDefault()); 

            Console.WriteLine(x.HasValue);// Booleano que retorna False caso nao tenha valor e True caso exista algum valor
            Console.WriteLine(x.HasValue);// 

            // Console.WriteLine(x.Value); // Retorna o valore caso exista, caso não, retorna excessão. 

            Console.WriteLine(a); //Imprime 5 pois z era nulo
            Console.WriteLine(b); // imprime 10 pois w não era nulo



        }
    }
}
