using System;

namespace atividadeVIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n = new Numero();

            Console.WriteLine("Entre com as idades entre 14 e 17 anos: ");
            n.Num = int.Parse(Console.ReadLine());
            if (n.Num >= 14 && n.Num <= 17 )
                {
            }
                else 
                {
                    Console.WriteLine("Desculpe, entre com uma idade nova.");
                }


        }
    }
}
