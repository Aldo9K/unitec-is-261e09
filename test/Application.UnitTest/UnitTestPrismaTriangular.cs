using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestPrismaTriangular
    {
        [Theory]
         // Params: area, hPrisma, esperado (Area * hPrisma)
        [InlineData(25, 10, 250)]
        [InlineData(6, 5, 30)]
        [InlineData(24, 2, 48)]
        [InlineData(25, 4, 100)]
        [InlineData(100, 1, 100)]
        [InlineData(16, 10, 160)]
        [InlineData(4.5, 2, 9)]
        [InlineData(72, 10, 720)]
        [InlineData(100, 5, 500)]
        [InlineData(0.5, 10, 5)]
        [InlineData(10.5, 2, 21)]
        [InlineData(40.5, 10, 405)]
        [InlineData(30, 3, 90)]
        [InlineData(5, 4, 20)]
        [InlineData(6.25, 2, 12.5)]
        [InlineData(2.5, 10, 25)]
        [InlineData(1250, 2, 2500)]
        [InlineData(100, 0.5, 50)]
        [InlineData(27.5, 2, 55)]
        [InlineData(18, 3, 54)]
        public void Testvolumen(double area, double altura, double volumen)
        {
            double resultado = Figura261E09.Volumen(area, altura);
            Assert.Equal(resultado, volumen, 1);
        }
    }
}