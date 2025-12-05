namespace Application;

public class Figura261E09
{
    public static double Perimetro(double lado_a, double lado_b, double lado_c)
    {
        return lado_a + lado_b + lado_c;
    }
    public static double Area(double lado_b, double lado_d)
    {
        return lado_b * lado_d / 2;
    }
    public static double Volumen(double area, double altura)
    {
        return area * altura;
    }
    
}
