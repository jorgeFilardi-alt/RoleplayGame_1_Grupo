public class ArmasTests
    {
        [Test]
        public void EnanoEsAtacadoConEspadaYElfoLoCura()
        {
            // Arrange
            IPersonaje enano = new Enano("Enano", 1200, 150, 300);
            Armas espada = new Armas("Espada", 400);
            IPersonaje elfo = new Elfo("Elfo", 1000, 120, 200, 300);

            // Act
            // El enano es atacado con la espada
            espada.UsarElemento(enano);

            // Assert
            Assert.AreEqual(900, enano.NivelVida); // Después del ataque la vida debería ser 1200 - 400 = 900

            // El elfo lo cura
            elfo.AyudarA(enano);

            // Assert después de que el elfo lo cure
            Assert.AreEqual(1900, enano.NivelVida); // El elfo suma 1000 puntos de vida
        }

        [Test]
        public void MagoAtacaAElfoConEspada()
        {
            // Arrange
            IPersonaje mago = new Mago("Mago", 1200, 150, 200, 500);
            Armas espada = new Armas("Espada", 300);
            IPersonaje elfo = new Elfo("Elfo", 1000, 120, 250, 300);

            // Act
            // El mago ataca al elfo con la espada
            espada.UsarElemento(elfo);

            // Assert
            Assert.AreEqual(700, elfo.NivelVida); // Después del ataque la vida debería ser 1000 - 300 = 700
        }
    }
}
}