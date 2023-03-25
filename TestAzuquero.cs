using Xunit;
using MaquinadeCafe;

public class TestAzuquero
{
    Azucarero azuquero = new Azucarero(10);
    [Fact]
    public void deberiadevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
    {
        bool resultado = azuquero.hasAzucar(5);

        Assert.Equal(true,resultado);

        resultado = azuquero.hasAzucar(10);

        Assert.True(resultado);
    }

    [Fact]
    public void deberiadevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
    {
        bool resultado = azuquero.hasAzucar(15);

        Assert.False(resultado);

    }  

    [Fact]
    public void deberiaRestarAzucarAlAzuquero()
    {
        azuquero.giveAzucar(5);
        Assert.Equal(5, azuquero.getCantidadDeAzucar());

        azuquero.giveAzucar(2);

        Assert.Equal(3,azuquero.getCantidadDeAzucar());
    }
}