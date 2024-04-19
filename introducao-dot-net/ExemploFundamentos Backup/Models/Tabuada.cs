using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    internal class Tabuada
    {
        public void CalculaTabuada10(int numero)
        {
            for (int i = 1; i <=10; i++)
            {
                int res = numero * i;
                Console.WriteLine($"{numero} x {i} = {res}");
            }
        }
        public void CalculaTabuadaNVezes(int numero, int vezes)
        {
            for (int i = 1; i <= vezes; i++)
            {
                int res = numero * i;
                Console.WriteLine($"{numero} x {i} = {res}");
            }
        }
    }
}
