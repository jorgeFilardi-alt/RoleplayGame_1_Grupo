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
        enemigo.NivelVida -= NivelFuerza;
    }

    public void DefenderseDe(IPersonaje personaje)
    {
        
    }

    public void AyudarA(IPersonaje amigo)
    {
        amigo.NivelVida = 1000;
    }
}