namespace Library;
/*
 * Clase Mago que implementa la interfaz IPersonaje. Por lo tanto algunos de sus atributos son tipo de personaje, nivel de vida
 * nivel de fuerza, resistencia y además nivel de magia. Este último depende del método de LeerHechizo, y forma parte de las características
 * de ataque que presenta este personaje
 */
public class Mago: IPersonaje
{
    //Estado:
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
    //Métodos:
    public void Atacar(IPersonaje enemigo)
    {
        // Calcula el nivel de daño que se le adjudicará al personaje enemigo
        int dano = NivelFuerza + NivelMagia;
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
    
    //Mediante esta función, el mago agrega un hechizo leído a su lista y adquiere más magia
    public void LeerHechizo(string hechizo)
    {
        int valorHechizo = 100;
        if (!LibroHechizos.Hechizos.Contains(hechizo))
        {
            LibroHechizos.Hechizos.Add(hechizo);
            NivelMagia += valorHechizo; //El valorHechizo es arbitrario, no es un nivel fijo. 
        }
        else
        {
            Console.WriteLine($"El hechizo {hechizo} ya está en el libro");
        }
    }
}