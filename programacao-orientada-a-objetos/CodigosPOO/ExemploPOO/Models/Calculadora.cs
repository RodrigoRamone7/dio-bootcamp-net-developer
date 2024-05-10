using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    internal class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
