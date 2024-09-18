namespace Library;

public class Enano: IPersonaje
{
    public string TipoPersonaje { get;  }

    public int NivelVida { get; set; }

    public int NivelFuerza { get; set; }

    public int NivelResistencia { get; set; }
    
    public int NivelMagia { get; set; }

    public Enano(string tipoPersonaje, int nivelVida, int nivelFuerza, int nivelResistencia)
    {
        TipoPersonaje = tipoPersonaje;
        NivelVida = nivelVida;
        NivelFuerza = nivelFuerza;
        NivelResistencia = nivelResistencia;
    }

    public void Atacar(IPersonaje enemigo)
    {
        int dano = NivelFuerza;
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
    
    public int AyudarA(IPersonaje enano)
    {
        enano.NivelVida += 1000;
        Console.WriteLine($"{TipoPersonaje} ayudó a {enano.TipoPersonaje}");
        return enano.NivelVida;
    }
}