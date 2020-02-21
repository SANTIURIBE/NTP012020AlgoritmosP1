using System;

namespace Taller20_02_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int np, cont =1,numerom  = 0, numeromenor = 0;
            double num;

            Console.WriteLine("Digite la cantidad de nuemeros que va a registrar");
            np = int.Parse(Console.ReadLine());

           while (cont <= np)
            {
                cont = cont + 1;
                Console.WriteLine("Digite el numero");
                num = Convert.ToDouble(Console.ReadLine());

                if (num > 0)
                {
                    numerom = numerom + 1;
                }
                else
                {
                    numeromenor = numeromenor + 1;
                }
            }

            Console.WriteLine("El total de nuemros menores es: " + numeromenor );
            Console.WriteLine("El total de nuemros mayores es: " + numerom);

        }
    }
}