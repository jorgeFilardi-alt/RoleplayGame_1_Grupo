using Library;

public class Program
{
    public static void Main(string[] args)
    {
        IPersonaje mago = new Mago("Mago", 1000, 100, 200, 500);
        IPersonaje enano = new Enano("Enano", 1000, 300, 500);
        
        Console.WriteLine($"Personaje: {mago.TipoPersonaje} \t Nivel de vida: {mago.NivelVida}");
        Console.WriteLine($"Personaje: {enano.TipoPersonaje} \t Nivel de vida: {enano.NivelVida} \n");

        mago.Atacar(enano);
        Console.WriteLine($"Nivel de vida de {enano.TipoPersonaje}: {enano.NivelVida} \n");
        enano.Atacar(mago);
        Console.WriteLine($"Nivel de vida de {mago.TipoPersonaje}: {mago.NivelVida} \n");;

        Enano enano2 = new Enano("Enano2", 1000, 200, 400);
        Console.WriteLine($"Personaje: {enano2.TipoPersonaje} \t Nivel de vida: {enano2.NivelVida} \n");

        enano2.AyudarA(enano);
        Console.WriteLine($"Nivel de vida de {enano.TipoPersonaje}: {enano.NivelVida} \n");;

        Armas espada = new Armas("espada", 400);
        espada.UsarElemento(mago);
        Console.WriteLine($"{mago.TipoPersonaje} usa {espada.NombreElemento} con nivel de ataque de: {espada.NivelAtaque}");
        mago.Atacar(enano);
        Console.WriteLine($"Nivel de vida de {enano.TipoPersonaje}: {enano.NivelVida} \n");;

        LibroHechizos libro = new LibroHechizos("Bastón Mágico");
        libro.AgregarHechizo("Bastón Mágico");
        libro.UsarElemento("Bastón mágico", enano);
        Console.WriteLine($"Se ha utilizado {libro.NombreElemento} en {enano.TipoPersonaje}");
        Console.WriteLine($"Nivel de vida de {enano.TipoPersonaje}: {enano.NivelVida}");;
    }
}