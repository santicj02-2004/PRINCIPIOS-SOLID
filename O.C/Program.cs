using EjemploOCInter_Abstract;

AreaTotal Calculador = new AreaTotal();

CIRCLE cir1 = new CIRCLE();
cir1.Radio = 5;
CIRCLE cir2 = new CIRCLE();
cir1.Radio = 3;
CIRCLE cir3 = new CIRCLE();
cir1.Radio = 2;

SQUARE cua1 = new SQUARE();
cua1.Lado = 5;
SQUARE cua2 = new SQUARE();
cua1.Lado = 7;
SQUARE cua3 = new SQUARE();
cua1.Lado = 4;

TRIANG tri1 = new TRIANG();
tri1.Base = 3;
tri1.Altura = 9;
TRIANG tri2 = new TRIANG();
tri2.Base = 10;
tri2.Altura = 2;
TRIANG tri3 = new TRIANG();
tri2.Altura = 5;
tri3.Base = 2;

TRAPECIO1 tra1 = new TRAPECIO1();
tra1.BaseMayor = 4;
tra1.BaseMenor = 2;
tra1.Altura = 5;
TRAPECIO1 tra2 = new TRAPECIO1();
tra1.BaseMayor = 10;
tra1.BaseMenor = 2;
tra1.Altura = 2;
TRAPECIO1 tra3 = new TRAPECIO1();
tra1.BaseMayor = 3;
tra1.BaseMenor = 2;
tra1.Altura = 5;

PARALELOGRAMO para1= new PARALELOGRAMO();
para1.Base = 4;
para1.Altura = 5;
PARALELOGRAMO para2 = new PARALELOGRAMO();
para1.Base = 4;
para1.Altura = 6;
PARALELOGRAMO para3 = new PARALELOGRAMO();
para1.Base = 6;
para1.Altura = 5;

List<Shape> Shapes = new List<Shape>();
Shapes.Add(cir1);
Shapes.Add(cir2);
Shapes.Add(cir3);

Shapes.Add(cua1);
Shapes.Add(cua2);
Shapes.Add(cua3);

Shapes.Add(tri1);
Shapes.Add(tri2);
Shapes.Add(tri3);

Shapes.Add(tra1);
Shapes.Add(tra2);
Shapes.Add(tra3);

Shapes.Add(para1);
Shapes.Add(para1);
Shapes.Add(para1);

var Resultado = Calculador.TotalArea(Shapes);
Console.WriteLine($"La suma de todas las areas es: {Resultado}");
