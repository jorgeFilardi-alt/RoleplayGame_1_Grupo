namespace Library;

public class Mago: IPersonaje
{
    public string TipoPersonaje { get;  }

    public int NivelVida { get; set; }

    public int NivelFuerza { get; set; }

    public int NivelResistencia { get; set; }
    public int NivelMagia { get; set; }

    public Mago(string tipoPersonaje, int nivelVida, int nivelFuerza, int nivelResistencia, int nivelMagia)
    {
        TipoPersonaje = tipoPersonaje;
        NivelVida = nivelVida;
        NivelFuerza = nivelFuerza;
        NivelResistencia = nivelResistencia;
        NivelMagia = nivelMagia;
    }

    public void Atacar(IPersonaje enemigo)
    {
        int dano = NivelFuerza + NivelMagia;
        if (enemigo.NivelResistencia > dano)
        {
            enemigo.NivelVida -= (enemigo.NivelResistencia - dano);
        }
        else
        {
            enemigo.NivelVida -= dano;
        }
        Console.WriteLine($"{TipoPersonaje} ataca a {enemigo.TipoPersonaje}");
    }
    
    public void LeerHechizo(string hechizo)
    {
        if (!LibroHechizos.Hechizos.Contains(hechizo))
        {
            LibroHechizos.Hechizos.Add(hechizo);   
        }
        else
        {
            Console.WriteLine($"El hechizo {hechizo} ya está en el libro");
        }
    }
}