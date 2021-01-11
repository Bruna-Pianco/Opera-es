using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02_OPERACOES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, total; // 3 variaveis do tipo inteiro
            n1 = 10;
            n2 = 3;


            Console.WriteLine("Realização de operações aritméticas com 2 valores inteiros\n");
            total = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + total);
            Console.WriteLine("A soma de + n1 + );
            Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
            Console.WriteLine(n1 + " x " + n2 + " = " + (n1 * n2));
            Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));
            Console.WriteLine(n1 + " % " + n2 + " = " + (n1 % n2));
            total = n1 % n2;
            Console.WriteLine(" O resto da divisão inteira " + n1 + " por " + n2 + " Resulta em " + total);
            Console.Write("\n \n Pressione qualquer tecla para sair...");
            Console.ReadKey();


        }
    }
}
