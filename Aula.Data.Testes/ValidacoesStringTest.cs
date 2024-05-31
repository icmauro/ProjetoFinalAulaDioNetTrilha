using Aula.Data.Testes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Data.Testes
{

    public class ValidacoesStringTest
    {
        private ValidacoesString _validacoesString;

        public ValidacoesStringTest()
        {
           _validacoesString = new ValidacoesString(); 
        }

        [Fact]
        public void PalavraFomeDeveConter4Caracteres()
        {
            //arrange
            string texto = "Fome";

            //act
            var retornoTexto = _validacoesString.ContarCaracteresPalavra(texto);


            //assert
            Assert.Equal(4, retornoTexto);
        }

        [Theory]
        [InlineData("Rua da Pamonha Perdida","Perdida")]
        [InlineData("Hoje andando pela rua, achei 10 reais", "pela rua")]
        [InlineData("Bora trabalhar que nao nasci de pais ricos", "trabalhar")]
        public void PalavaDeveConternoTextoInformado(string texto, string palavraProcurada)
        {
            //arrange

            //act
            var retornoTexto = _validacoesString.PalavraDeveConterNaFrase(texto, palavraProcurada);


            //assert
            Assert.True(retornoTexto);
        }
    }
}
