using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestTriangulo
{
        [Theory]
         // Params: a, b, c, esperado
        [InlineData(3, 4, 5, 12)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(7, 24, 25, 56)]
        [InlineData(8, 15, 17, 40)]
        [InlineData(9, 40, 41, 90)]
        [InlineData(11, 60, 61, 132)]
        [InlineData(12, 35, 37, 84)]
        [InlineData(20, 21, 29, 70)]
        [InlineData(2, 2, 3, 7)]
        [InlineData(5, 5, 8, 18)]
        [InlineData(10, 10, 5, 25)]
        [InlineData(1.5, 2.5, 3.5, 7.5)]
        [InlineData(0.5, 0.5, 0.5, 1.5)]
        [InlineData(100, 100, 100, 300)]
        [InlineData(15, 20, 25, 60)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(50, 40, 30, 120)]
        [InlineData(9, 9, 9, 27)]
        public void TestPerimetro(double lado_a, double lado_b, double lado_c, double perimetro)
        {
            double resultado = Application.Figura261E09.Perimetro(lado_a, lado_b, lado_c);
            Assert.Equal(resultado, perimetro, 1);
        }

        [Theory]
         // Params: b (base), d (altura), esperado
        [InlineData(10, 5, 25)]
        [InlineData(4, 3, 6)]
        [InlineData(6, 8, 24)]
        [InlineData(5, 10, 25)]
        [InlineData(20, 10, 100)]
        [InlineData(8, 4, 16)]
        [InlineData(3, 3, 4.5)]
        [InlineData(12, 12, 72)]
        [InlineData(100, 2, 100)]
        [InlineData(1, 1, 0.5)]
        [InlineData(7, 3, 10.5)]
        [InlineData(9, 9, 40.5)]
        [InlineData(15, 4, 30)]
        [InlineData(2.5, 4, 5)]
        [InlineData(5, 2.5, 6.25)]
        [InlineData(10, 0.5, 2.5)]
        [InlineData(50, 50, 1250)]
        [InlineData(2, 100, 100)]
        [InlineData(11, 5, 27.5)]
        [InlineData(6, 6, 18)]
        public void TestArea(double lado_b, double lado_d, double area)
        {
            double resultado = Application.Figura261E09.Area(lado_b, lado_d);

             Assert.Equal (resultado, area, 3);
        
        }
    }
}