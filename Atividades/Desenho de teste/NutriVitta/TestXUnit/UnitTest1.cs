using NutriVitta;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange
            double peso = 0;
            double altura = 0;
            string resultadoEsperado = "Peso e/ou altura n�o podem ser negativos ou ter valor igual a zero.";
            //Act
            var resultadoObtido = operacoes.ClassificacaoIMC(peso, altura);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Theory]
        [InlineData(-5, -5, "Peso e/ou altura n�o podem ser negativos ou ter valor igual a zero.")]
        [InlineData(70, 1.75, "IMC: 22,86 kg/m�\nPeso normal")]
        [InlineData(63, 1.85, "IMC: 18,41 kg/m�\nAbaixo do peso")]
        [InlineData(78, 1.65, "IMC: 28,65 kg/m�\nSobrepeso")]
        [InlineData(60, 1.40, "IMC: 30,61 kg/m�\nObesidade grau I")]
        [InlineData(90, 1.60, "IMC: 35,16 kg/m�\nObesidade grau II")]
        [InlineData(140, 1.80, "IMC: 43,21 kg/m�\nObesidade grau III")]
        public void CalcularImcLista(double peso, double altura, string resultadoEsperado)
        {
            var resultadoObtido = operacoes.ClassificacaoIMC(peso, altura);

            Assert.Equal(resultadoEsperado, resultadoObtido);
        }
    }
}