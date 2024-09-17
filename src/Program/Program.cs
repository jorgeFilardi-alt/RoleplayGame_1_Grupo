using Library;

public class Program
{
    public static void Main(string[] args)
    {
        IPersonaje mago = new Mago("Mago", 1000, 100, 200, 500);
        IPersonaje enano = new Enano("Enano", 1000, 300, 500);

        mago.Atacar(enano);
        Console.WriteLine(enano.NivelVida);
        enano.Atacar(mago);
        Console.WriteLine(mago.NivelVida);

        Enano enano2 = new Enano("Enano2", 1000, 200, 400);
        enano2.AyudarA(enano);
        Console.WriteLine(enano.NivelVida);

        Armas espada = new Armas("espada", 400);
        espada.UsarElemento(mago);
        mago.Atacar(enano);
        Console.WriteLine(enano.NivelVida);

        LibroHechizos libro = new LibroHechizos("bastón mágico");
        libro.AgregarHechizo("bastón mágico");
        libro.UsarElemento("bastón mágico", enano);
        Console.WriteLine(enano.NivelVida);
    }
}