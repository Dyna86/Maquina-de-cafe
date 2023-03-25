using Xunit;
using MaquinadeCafe;

public class TestCafetera
{
    [Fact]
    public void deberiaDevolverVerdaderoSiExisteCafe()
    {
        Cafetera cafetera =new Cafetera(10);

        bool resultado = cafetera.hasCafe(5);

        Assert.True(resultado);
    }

    [Fact]
    public void deberiaDevolverFalsoSiNoExisteCafe()
    {
        Cafetera cafetera =new Cafetera(10);

        bool resultado = cafetera.hasCafe(11);

        Assert.False(resultado);
    }

    [Fact]
    public void deberiaRestarcafeAlaCafetera()
    {
        Cafetera cafetera = new Cafetera(10);
        cafetera.giveCafe(7);

        Assert.Equal(3, cafetera.getCantidadDeCafe());
    }
}