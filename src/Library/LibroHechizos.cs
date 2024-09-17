namespace Library;

public class LibroHechizos: IElementos
{
    public string NombreElemento { get; }
    public List<string> Hechizos = new List<string>();

    public LibroHechizos(string nombreElemento, List<string> hechizos)
    {
        this.NombreElemento = nombreElemento;
        this.Hechizos = hechizos;
    }

    public void UsarElemento()
    {
        
    }

    public void AgregarHechizo(string hechizo)
    {
        Hechizos.Add(hechizo);
    }
}