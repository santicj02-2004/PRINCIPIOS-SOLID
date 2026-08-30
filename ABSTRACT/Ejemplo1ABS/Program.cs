using Ejemplo1ABS;
using System.Drawing;

class Program
{
    static void Main()
    {
        // CORRECTO: Instancias la clase concreta
        Class1 rectangulo = new Class1
        {
            Color = "Azul",
            Base = 5,
            Altura = 10,
            Magn="Metros cuadrados",
        };
        
        Console.WriteLine($"El rectangulo es de color {rectangulo.MostrarColor()} y tiene un Área de: {rectangulo.CalcularArea()} {rectangulo.magnitud()}"); 
    }
}