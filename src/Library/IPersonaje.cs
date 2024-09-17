namespace Library;

public interface IPersonaje
{
    string TipoPersonaje { get; }
    int NivelVida { get; set; }
    int NivelFuerza { get; set; }
    int NivelResistencia { get; set; }
    void Atacar(IPersonaje enemigo);
}