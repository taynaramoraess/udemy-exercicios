﻿using System;

namespace estruturasequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B,soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;
            Console.WriteLine("Soma =" + soma);
        }
    }
}
