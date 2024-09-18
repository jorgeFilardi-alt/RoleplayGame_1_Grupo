namespace Library;
/*
 * Esta clase está diseñada para poder ser utilizada por los personajes, una de sus funciones es poder aumentar los niveles de fuerza
 * del personaje que la utiliza para mejorar su ataque.
 */

public class Armas
{ 
    public string NombreElemento { get; }
    public int NivelAtaque { get; set; }

    public Armas(string nombreElemento, int nivelAtaque)
    {
        NombreElemento = nombreElemento;
        NivelAtaque = nivelAtaque;
    }
    
    //Este método le resta al nivel de vida del enemigo el nivel de ataque del arma implementada por el atacante. 
    public int UsarElemento(IPersonaje personaje)
    {
        return personaje.NivelVida -= NivelAtaque;
        // En caso de que el nivel de vida quede negativo, cambia a nivel=0
        if (personaje.NivelVida < 0)
        {
            personaje.NivelVida = 0;
        }
    }
}