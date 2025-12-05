using System;
using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Theory]
         // Params: b, d, hPrisma, esperado (Area * hPrisma)
        [InlineData(10, 5, 10, 250)]
        [InlineData(4, 3, 5, 30)]
        [InlineData(6, 8, 2, 48)]
        [InlineData(5, 10, 4, 100)]
        [InlineData(20, 10, 1, 100)]
        [InlineData(8, 4, 10, 160)]
        [InlineData(3, 3, 2, 9)]
        [InlineData(12, 12, 10, 720)]
        [InlineData(100, 2, 5, 500)]
        [InlineData(1, 1, 10, 5)]
        [InlineData(7, 3, 2, 21)]
        [InlineData(9, 9, 10, 405)]
        [InlineData(15, 4, 3, 90)]
        [InlineData(2.5, 4, 4, 20)]
        [InlineData(5, 2.5, 2, 12.5)]
        [InlineData(10, 0.5, 10, 25)]
        [InlineData(50, 50, 2, 2500)]
        [InlineData(2, 100, 0.5, 50)]
        [InlineData(11, 5, 2, 55)]
        [InlineData(6, 6, 3, 54)]
        public void TestVolumen( double lado_b, double lado_d, double altura, double volumen)
        {
            double area = Figura261E09.Area(lado_b, lado_d);
            double resultado = Figura261E09.Volumen(area, altura);
            
            Assert.Equal(resultado, volumen, 1);

        }
    }
}