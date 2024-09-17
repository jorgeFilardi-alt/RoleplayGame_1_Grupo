namespace Library;

public class Armas: IElementos
{ 
    public string NombreElemento { get; }
    public int NivelAtaque { get; set; }

    public Armas(string nombreElemento, int nivelAtaque)
    {
        this.NombreElemento = nombreElemento;
        this.NivelAtaque = nivelAtaque;
    }

    public void UsarElemento()
    {
        
    }
}