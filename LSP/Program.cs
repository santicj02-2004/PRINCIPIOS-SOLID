using LSP;

PERRO perro = new PERRO("DANTE");
SPARROW gorrion = new SPARROW("JACK");
EAGLE aguila = new EAGLE("LIE");

List<Animal> animales = new List<Animal>();
animales.Add(perro);
animales.Add(gorrion);
animales.Add(aguila);

foreach (var animal in animales)
{
    animal.HacerSonido();
}

Console.WriteLine("");

List<IVolar> voladores = new List<IVolar>();

voladores.Add(gorrion);
voladores.Add(aguila);

foreach (var volador in voladores)
{
    volador.FLY();
}


