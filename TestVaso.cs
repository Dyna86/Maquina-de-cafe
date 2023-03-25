using Xunit;
using MaquinadeCafe;

public class TestVaso
{
    [Fact]
    public void deberiaDevolverVerdaderoSiExistenVasos()
    {
        Vaso vasosPequenos = new Vaso(2,10);

        bool resultado = vasosPequenos.hasVaso(1);

        Assert.True(resultado);
    }

    [Fact]
    public void deberiaDevolverFalsoSiNoExistenVasos()
    {
        Vaso vasosPequenos = new Vaso(1,10);

        bool resultado = vasosPequenos.hasVaso(2);

        Assert.False(resultado);
    }

    [Fact]
    public void deberiaRestarCantidadDeVaso()
    {
        Vaso vasosPequenos = new Vaso(5,10);

        vasosPequenos.giveVaso(1);

        Assert.Equal(4,vasosPequenos.getCantidadDeVasos());
    }

}