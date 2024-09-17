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
        enemigo.NivelVida -= NivelFuerza;
    }

    public void DefenderseDe(IPersonaje personaje)
    {
        
    }

    public void AyudarA(IPersonaje enano)
    {
        enano.NivelVida = 1000;
    }
}