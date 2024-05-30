using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTest
{
    public class ValidacoesStringTests
    {
        private ValidacaoString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacaoString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Olá"
;
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Asssert
            Assert.Equal(3, resultado);

        }
    }
}
