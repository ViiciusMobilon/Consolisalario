using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolisalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite se vocâ e assalariado, comissioonado, Horista");
            string tipo = Console.ReadLine().ToLower();
            
            double sal2 = 0;
            switch (tipo)
            {
                case "assalariado":
                    Console.WriteLine("Qual o seu salario bruto ");
                    double sal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o desconto ");
                    double d = double.Parse(Console.ReadLine());
                     sal2 = sal-d  ;

                    break;

                case "comissionado":
                    Console.WriteLine("Qual a quantidade de peças produzidas ");
                    int pecas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor de cada de peças produzidas ");
                    int Ppecas = int.Parse(Console.ReadLine());
                    sal2 = Ppecas * pecas;

                    break;
                case "horista":
                 Console.WriteLine("Digite a quantidades de horas trabalhadas ");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidades de horas trabalhadas ");
                    int ht = int.Parse(Console.ReadLine());
                    sal2 = h * ht;
                    break;
            }

                    if (sal2 <= 2000)
                    {
                        sal2 = 10*(sal2 * 0.075);

                    }
                    else if (sal2 <= 4000)
                    {
                        sal2 = 10*(sal2 * 0.12);
                    }
                    else if (sal2 > 4000)
                    {
                        sal2 = 10 * (sal2 * 0.15);
                    }


                    Console.WriteLine("O sário líquido é de " + sal2);
                    Console.ReadKey();

            

        }
    }
}
