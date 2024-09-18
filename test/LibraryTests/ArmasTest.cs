namespace LibraryTests;

using NUnit.Framework;

public class ArmasTests{
    [Test]
    public void UsarElemento()
    {
        IPersonaje mago = new Mago("Mago", 1000, 100, 200, 500);
        Armas espada = new Armas("Espada", 400);

        espada.UsarElemento(mago);

        Assert.AreEqual(600, mago.NivelVida);
    }
}
