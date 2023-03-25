using Xunit;
using MaquinadeCafe;


public class TestMaquinaDeCafe
{
    MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe(new Cafetera(50),new Vaso (5,10),new Vaso (5,20),new Vaso (5,30), new Azucarero(20));

    [Fact]
    public void deberiaDevolverUnVasoPequeno()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        Assert.Equal(maquinaDeCafe.vasosPequenos,baso);
    }

    [Fact]
    public void deberiaDevolverUnVasoMediano()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("mediano");

        Assert.Equal(maquinaDeCafe.vasosMedianos,baso);
    }

    [Fact]
    public void deberiaDevolverUnVasoGrande()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("grande");

        Assert.Equal(maquinaDeCafe.vasosGrandes,baso);
    }

    [Fact]
    public void deberiaDevolverNoHayVasos()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        String resultado = maquinaDeCafe.getVasoDeCafe(baso,10,2);

        Assert.Equal("No hay Vasos", resultado);
    }

    [Fact]
    public void deberiaDevolverNoHayCafe()
    {
        Cafetera kafe = new Cafetera(5);
        maquinaDeCafe.cafe = kafe;

        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        String resultado = maquinaDeCafe.getVasoDeCafe(baso,1,2);

        Assert.Equal("No hay Cafe", resultado);
    }

    [Fact]
    public void deberiaDevolverNoHayAzucar()
    {
        Azucarero azukal = new Azucarero(2);

        maquinaDeCafe.azucar = azukal;

        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        String resultado = maquinaDeCafe.getVasoDeCafe(baso,1,3);

        Assert.Equal("No hay Azucar", resultado);
    }

    [Fact]
    public void deberiaRestarCafe()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        maquinaDeCafe.getVasoDeCafe(baso,1,3);

        int resultado = maquinaDeCafe.cafe.getCantidadDeCafe();

        Assert.Equal(40,resultado);
    }

    [Fact]
    public void deberiaRestarVaso()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        maquinaDeCafe.getVasoDeCafe(baso,1,3);

        int resultado = maquinaDeCafe.vasosPequenos.getCantidadDeVasos();

        Assert.Equal(4,resultado);
    }

    [Fact]
    public void deberiaRestarAzucar()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        maquinaDeCafe.getVasoDeCafe(baso,1,3);

        int resultado = maquinaDeCafe.azucar.getCantidadDeAzucar();

        Assert.Equal(17,resultado);
    }


    [Fact]
    public void deberiaDevolverFelicitaciones()
    {
        Vaso baso = maquinaDeCafe.getTipoVaso("pequeno");

        String resultado = maquinaDeCafe.getVasoDeCafe(baso,1,3);
        
        Assert.Equal("Felicitaciones",resultado);
    }
}