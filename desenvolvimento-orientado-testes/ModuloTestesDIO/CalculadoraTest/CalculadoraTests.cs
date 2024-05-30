using Calculadora.Services;

namespace CalculadoraTest
{
    public class CalculadoraTests
    {
        private CalculadoraImp _calc;

        public CalculadoraTests()
        {
            _calc = new CalculadoraImp();
        }
        
        [Fact]
        public void DeveSomar5Com10ERetornar15()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int resultado = _calc.Somar(num1, num2);

            // Assert
            Assert.Equal(15, resultado);

        }

        [Fact]
        public void VerificaSe2EhPar()
        {
            // Arrange
            int num = 2;

            // Act
            bool resultado = _calc.EhPar(num);

            // Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData( new int[] { 2, 4 })]
        [InlineData( new int[] { 6, 8, 10 })]
        public void VerificaSeNumerosSaoParesERetornaTrue(int[] numeros)
        {
            // Act / Assert
            Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

        }
    }
}