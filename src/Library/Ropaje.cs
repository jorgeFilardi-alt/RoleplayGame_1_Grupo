namespace Library;

public class Ropaje: IElementos
{
    private IElementos _elementosImplementation;
    public string NombreElemento { get; }
    public int NivelDefensa { get; set; }

    public Ropaje(string nombreElemento, int nivelDefensa)
    {
        this.NombreElemento = nombreElemento;
        this.NivelDefensa = nivelDefensa;
    }

    public void UsarElemento()
    {
        
    }
}