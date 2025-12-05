double lado_a = 6;
double lado_b = 10;
double lado_c = 6;
double lado_d = 3;
double altura = 5;
double perimetro = Application.Figura261E09.Perimetro(lado_a, lado_b, lado_c);
double area = Application.Figura261E09.Area(lado_b, lado_d);
double volumen = Application.Figura261E09.Volumen(area, altura);

Console.WriteLine($"El perimetro de la base de un Prisma Triangular de {lado_a}cm + {lado_b}cm + {lado_c}cm es {perimetro}cm");
Console.WriteLine($"El area de la base de un Prisma Triangular de {lado_b}cm por {lado_d}cm entre 2 es {area}cm2");
Console.WriteLine($"El volumen de un Prisma Triangular con un area de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");