using System;
using System.Globalization;

namespace estruturasequencial4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());

            salario = valorHora * horas;

            Console.WriteLine("Numero:" + numero);
            Console.WriteLine("Salario: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
