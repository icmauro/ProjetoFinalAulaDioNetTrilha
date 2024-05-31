using Aula.Data.Testes.Entities;

namespace Aula.Data.Testes
{
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void DeveSomar5Com15Retorno20()
        {
            //arrange
            int num1 = 5;
            int num2 = 15;

            //act
            var retornoSoma = _calculadora.Somar(num1, num2);

            //assert

            Assert.Equal(20,retornoSoma);

        }

        [Fact]
        public void DeveSubtrair21De40Retorno19()
        {
            //arrange
            int num1 = 40;
            int num2 = 21;

            //act
            var retornoSoma = _calculadora.Subtrair(num1, num2);

            //assert

            Assert.Equal(19, retornoSoma);

        }

        [Fact]
        public void DeveMultiplicar5De40Retorno200()
        {
            //arrange
            int num1 = 5;
            int num2 = 40;

            //act
            var retornoSoma = _calculadora.Multiplicar(num1, num2);

            //assert

            Assert.Equal(200, retornoSoma);

        }

        [Fact]
        public void DeveDividir2por10Retorno2()
        {
            //arrange
            int num1 = 20;
            int num2 = 10;

            //act
            var retornoSoma = _calculadora.Dividir(num1, num2);

            //assert

            Assert.Equal(2, retornoSoma);

        }

        [Fact]
        public void DivisaoPorZeroRetornoException()
        {
            //arrange
            int num1 = 20;
            int num2 = 0;

            //act

            //assert

            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(num1, num2));

        }

        [Fact]
        public void Numero4DeveRetornarVerdadeiroParaPar()
        {
            //arrange
            int num1 = 4;

            //act
            var retornoPar = _calculadora.EhPar(num1);

            //assert

            Assert.True(retornoPar);

        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(10)]
        public void VerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
        {
            //arrange

            //act
            var retornoPar = _calculadora.EhPar(numero);

            //assert

            Assert.True(retornoPar);

        }

        //refatorando
        [Theory]
        [InlineData(new int[] { 2,4,6,8,10 })]
        public void VerificarSeOsNumerosSaoParesERetornarVerdadeiroRefatorado(int[] numeros)
        {
            //arrange

            //act

            //assert

            Assert.All(numeros, x => _calculadora.EhPar(x));

        }

        [Theory]
        [InlineData(new int[] { 2, 3, 4, -8, -9 }, new int[] { 2, 3, 4 } )]
        [InlineData(new int[] { 10, -15, 20, -21}, new int[] { 10, 20 })]
        [InlineData(new int[] { -40, 40, -50 }, new int[] { 40 })]
        public void VerificarListadeInteirosEDeveRetornarApenasNumerosPositivos(int[] listaInteiros, int[] retornoEsperado)
        { 
            //arrange
            var Lista = listaInteiros.ToList();
            var ListaRetornoEsperado = retornoEsperado.ToList();

            //act
            var retornoApenasInteiros = _calculadora.RetornarSomenteNumerosPositivos(Lista);

            //assert
            Assert.Equal(ListaRetornoEsperado, retornoApenasInteiros);
        }
    }
}