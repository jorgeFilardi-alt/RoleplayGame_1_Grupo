namespace Library;

public class Armas
{ 
    public string NombreElemento { get; }
    public int NivelAtaque { get; set; }

    public Armas(string nombreElemento, int nivelAtaque)
    {
        NombreElemento = nombreElemento;
        NivelAtaque = nivelAtaque;
    }

    public int UsarElemento(IPersonaje personaje)
    {
        return personaje.NivelVida -= NivelAtaque;
    }
}