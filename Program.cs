﻿using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            nome = "eu";
            Console.WriteLine(nome);

            Double valor = 2.2;
            Double quantidade = 6;
            Double resultado = valor * quantidade;
            System.Console.WriteLine(resultado);

            Boolean maiorQueDez = (resultado > 10);

            if (maiorQueDez) {
                System.Console.WriteLine($"{resultado} é maior que 10");
            } else {
                System.Console.WriteLine($"{resultado} é menor que 10");
            }

            calcsoma calcsoma = new calcsoma();
            System.Console.WriteLine(calcsoma.soma(10, 5));
        }
    }
}