using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int produtoA = 5;
            int produtoB = 6;
            int produtoC = 7;
            int produtoD = 8;

            int diferenca = produtoA * produtoB - produtoC * produtoD;
            Console.WriteLine($"DIFERENCA = {diferenca}");


            int produtoA1 = 4;
            int produtoB1 = 7;
            int produtoC1 = 3;
            int produtoD1 = 28;

            int diferenca_ = produtoA1 * produtoB1 - produtoC1 * produtoD1;
            Console.WriteLine($"DIFERENCA = {diferenca_}");

            int produtoA2 = 5;
            int produtoB2 = 10;
            int produtoC2 = 12;
            int produtoD2 = -3;

            int diferenca_1 = produtoA2 * produtoB2 - produtoC2 * produtoD2;
            Console.WriteLine($"DIFERENCA = {diferenca_1}");

            Console.ReadLine();

        }
    }
}
