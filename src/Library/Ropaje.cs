namespace Library;
/*
 * Esta función será utilizada por los personajes para poder aumentar su nivel de defensa, entre otras cosas.
 */
public class Ropaje
{ 
    public string NombreElemento { get; }
    public int NivelDefensa { get; set; }

    public Ropaje(string nombreElemento, int nivelDefensa)
    {
        NombreElemento = nombreElemento;
        NivelDefensa = nivelDefensa;
    }

    //Este método aumenta el nivel de defensa al personaje que la implemente. 
    public int UsarElemento(IPersonaje personaje)
    {
        Console.WriteLine($"{personaje.TipoPersonaje} aumentó su defensa con {NombreElemento}");
        return personaje.NivelResistencia += NivelDefensa;
    }
}