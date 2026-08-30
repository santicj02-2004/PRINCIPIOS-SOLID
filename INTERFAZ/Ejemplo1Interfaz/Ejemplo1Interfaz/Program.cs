namespace Ejemplo1Interfaz
{
    class Program
    {

        static void Main(string[] args)
        {

            Class1 carro1 = new Class1();
            carro1.Marca = "BMW";
            carro1.Encender();
            carro1.Combustible("Gasolina");
        }
    }

}
