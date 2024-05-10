using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
