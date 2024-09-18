namespace Library;
/*
 * Clase Elfo que implementa interface IPersonaje, con su estado y métodos correspondientes.
 * Además, posee características mágicas como nivelMagia, y funciones como AyudarA sus propios compañeros de la misma clase.
 */
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
    
    public int AyudarA(IPersonaje amigo)
    {
        amigo.NivelVida += 1000; //Al ayudar a su compañero le suma ciertos puntos de vida.
        Console.WriteLine($"{TipoPersonaje} ayudó a {amigo.TipoPersonaje}");
        return amigo.NivelVida;
    }
}