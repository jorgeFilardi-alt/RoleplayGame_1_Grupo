namespace Library;

public class LibroHechizos
{
    public string NombreElemento { get; }

    public static List<string> Hechizos;

    public LibroHechizos(string nombreElemento)
    {
        NombreElemento = nombreElemento;
        Hechizos = new List<string>();
    }

    public void UsarElemento(string hechizo, IPersonaje personaje)
    {
        if (Hechizos.Contains(hechizo))
        {
            Console.WriteLine($"El hechizo {hechizo} ha sido lanzado");
            personaje.NivelVida -= personaje.NivelResistencia;
        }
    }

    public void AgregarHechizo(string hechizo)
    {
        if (!Hechizos.Contains(hechizo))
        {
            Hechizos.Add(hechizo);   
        }
        else
        {
            Console.WriteLine($"El hechizo {hechizo} ya está en el libro");
        }
    }
}