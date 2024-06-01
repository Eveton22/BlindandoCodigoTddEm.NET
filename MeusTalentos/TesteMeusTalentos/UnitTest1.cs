using MeusTalentos;
namespace TesteMeusTalentos
{
    public class UnitTest1
    {

  

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 4, 8)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 4, 16)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 5, 20)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(4, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void testarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void testarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 4);
            calc.somar(4, 2);
            calc.somar(7, 2);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }





    }
}