namespace Library;

public class Elfo: IPersonaje
{
    public string TipoPersonaje { get;  }

    public int NivelVida { get; set; }

    public int NivelFuerza { get; set; }

    public int NivelResistencia { get; set; }
    
    public int NivelMagia { get; set; }

    public Elfo(string tipoPersonaje, int nivelVida, int nivelFuerza, int nivelResistencia, int nivelMagia)
    {
        TipoPersonaje = tipoPersonaje;
        NivelVida = nivelVida;
        NivelFuerza = nivelFuerza;
        NivelResistencia = nivelResistencia;
        NivelMagia = nivelMagia;
    }

    public void Atacar(IPersonaje enemigo)
    {
        if (enemigo.NivelResistencia > NivelFuerza)
        {
            enemigo.NivelVida -= enemigo.NivelResistencia - NivelFuerza;
        }
        else
        {
            enemigo.NivelVida += enemigo.NivelResistencia - NivelFuerza;
        }
        Console.WriteLine($"{TipoPersonaje} ataca a {enemigo.TipoPersonaje}");
    }
    
    public int AyudarA(IPersonaje amigo)
    {
        return amigo.NivelVida = 1000;
    }
}