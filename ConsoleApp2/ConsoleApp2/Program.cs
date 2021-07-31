using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double KG1 = 1.50;
            Console.WriteLine("Seja Bem Vindo ao mercado de prodotos naturais");
            Console.WriteLine("Olá, gostaria de comprar lentilha");
            Console.WriteLine("Coisa boa! Estamos com uma promoção para a lentilha");
            Console.WriteLine("Como estão os valores?");
            Console.WriteLine("Estamos vendendo por KG, quantos KG você gostaria de levar?");
            double KG2 = Convert.ToDouble(Console.ReadLine());
            double valor = KG1 * KG2;
            Console.WriteLine("Sua lentilha ficará no valor de " + valor);
        }
    }
}
