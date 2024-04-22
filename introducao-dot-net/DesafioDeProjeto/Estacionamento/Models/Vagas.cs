using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Vagas
    {
        public List<string> vagas = new List<string>();

        public void CadastraVeiculo(string placa)
        {
            vagas.Add(placa);
        }

        public void RemoveVeiculo(string placa)
        {
            vagas.Remove(placa);
        }

        public void ListarVeiculos()
        {
            for(int i = 0; i < vagas.Count; i++)
            {
                Console.WriteLine(vagas[i]);
            }
        }

    }
}
