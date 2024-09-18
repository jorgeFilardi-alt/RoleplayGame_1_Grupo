namespace Library;

/*
 * IPersonaje es una interfaz utilizada por las clases Mago, Enano y Elfo.
 * Indica el tipo de personaje (es decir, su nombre), el nivel de vida y nivel de fuerza y resistencia para un posible ataque.
 * Como métodos está la función Atacar, la cual toma como parámetro a otro personaje para afectarle el nivel de vida.
 */
public interface IPersonaje
{
    //Estado:
    string TipoPersonaje { get; }
    int NivelVida { get; set; }
    int NivelFuerza { get; set; }
    int NivelResistencia { get; set; }
    
    //Métodos:
    void Atacar(IPersonaje enemigo);
}