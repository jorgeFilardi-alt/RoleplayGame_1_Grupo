namespace Library;

public class Ropaje
{ 
    public string NombreElemento { get; }
    public int NivelDefensa { get; set; }

    public Ropaje(string nombreElemento, int nivelDefensa)
    {
        NombreElemento = nombreElemento;
        NivelDefensa = nivelDefensa;
    }

    public int UsarElemento(IPersonaje personaje)
    {
        Console.WriteLine($"{personaje.TipoPersonaje} aumentó su defensa con {NombreElemento}");
        return personaje.NivelResistencia += NivelDefensa;
    }
}