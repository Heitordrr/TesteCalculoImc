using TurmaOiAplicTestes;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void Test1()
        {
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;


            var resultado = Calculadora.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(4, 4, 8)]
        [InlineData(7, 2, 9)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var resultado = Calculadora.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }
    }
}