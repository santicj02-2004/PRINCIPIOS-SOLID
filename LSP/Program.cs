using LSP;
List<Animal> animales = new List<Animal>
{
new PERRO("DANTE"),
new SPARROW("JACK"),
new EAGLE("LIE")};

foreach (var animal in animales)
{
    animal.HacerSonido();
}

// LSP 
List<IVolar> voladores = new List<IVolar>
            {
                new SPARROW("Pepe"),
                new EAGLE("Majestuosa")
            };
foreach (var volador in voladores)
{
    volador.FLY();
}


