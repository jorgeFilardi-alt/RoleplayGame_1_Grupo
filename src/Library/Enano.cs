namespace Library;
/*
 * Clase Enano que implementa interface IPersonaje con su estado y métodos correspondiente.
 * Además, realiza la función de Ayudar() a solamente personajes de su misma clase.
 */
public class Enano: IPersonaje
{
    public string TipoPersonaje { get;  }

    public int NivelVida { get; set; }

    public int NivelFuerza { get; set; }

    public int NivelResistencia { get; set; }
    

    public Enano(string tipoPersonaje, int nivelVida, int nivelFuerza, int nivelResistencia)
    {
        TipoPersonaje = tipoPersonaje;
        NivelVida = nivelVida;
        NivelFuerza = nivelFuerza;
        NivelResistencia = nivelResistencia;
    }

    public void Atacar(IPersonaje enemigo)
    {
        // Calcula el nivel de daño que se le adjudicará al personaje enemigo
        int dano = NivelFuerza;
        //En lo posible, se le resta al nivel de vida enemiga el daño posible con respecto a la resistencia del otro.
        // El nivel de resistencia, en otras palabras, forma parte de la defensa del personaje atacado.
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
    
    //Tal como lo indica la letra, los enanos son leales entre sí, por lo que se ayudan:
    public int AyudarA(IPersonaje enano)
    {
        enano.NivelVida += 1000; //Al ayudar a un enano amigo, le suma 1000 puntos de vida, el cual no es un valor fijo.
        Console.WriteLine($"{TipoPersonaje} ayudó a {enano.TipoPersonaje}");
        return enano.NivelVida;
    }
}