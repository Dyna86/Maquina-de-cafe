namespace MaquinadeCafe
{
    class MaquinaDeCafe
    {
        public Cafetera cafe;
        public Vaso vasosPequenos;
        public Vaso vasosMedianos;
        public Vaso vasosGrandes;
        public Azucarero azucar;

        public MaquinaDeCafe( Cafetera kafe, Vaso vasoP, Vaso vasoM, Vaso vasoG, Azucarero azucal) 
        {
            this.cafe = kafe;
            this.vasosPequenos = vasoP;
            this.vasosMedianos = vasoM;
            this.vasosGrandes = vasoG;
            this.azucar = azucal;
        }
        
        public Vaso getTipoVaso(string tipVaso)
        {
            Vaso baso = new Vaso(0,0);
            if(tipVaso.ToLower().Equals("pequeno"))
            {
                baso = this.vasosPequenos;
            }
            else if(tipVaso.ToLower().Equals("mediano"))
            {
                baso = this.vasosMedianos;
            }
            else if(tipVaso.ToLower().Equals("grande"))
            {
                baso = this.vasosGrandes;
            }

            return baso;
        }

        public string getVasoDeCafe(Vaso baso, int cantBaso, int cantAzu)
        {
            int cantCaf = baso.getContenido() * cantBaso;
            int cantAzukal = cantAzu * cantBaso;

            if(baso.getCantidadDeVasos() - cantBaso < 0)
            {
                return "No hay Vasos";
            }
            if(cafe.getCantidadDeCafe() - cantCaf < 0)
            {
                return "No hay Cafe";
            }
            if(azucar.getCantidadDeAzucar() - cantAzukal < 0)
            {
                return "No hay Azucar";
            }

            
            cafe.giveCafe(cantCaf);
            azucar.giveAzucar(cantAzukal);
            baso.giveVaso(cantBaso);

            return "Felicitaciones";
            
        }


    }

    public class Vaso
    {
        int cantidadVaso;
        int contenido;

        public Vaso(int cantidadV, int tamano)
        {
            this.cantidadVaso = cantidadV;
            this.contenido = tamano;
        }

        public Vaso() { }

        public void setCantidadDeVasos(int cantidad)
        {
            this.cantidadVaso = cantidad;
            return;
        }

        public int getCantidadDeVasos()
        {
            return this.cantidadVaso;
        }

        public void setContenido(int cantidad)
        {
            this.contenido = cantidad;
            return;
        }

        public int getContenido()
        {
            return this.contenido;
        }

        public bool hasVaso(int cantidad)
        {
            if(this.cantidadVaso >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int giveVaso(int cantidad)
        {
            if(hasVaso(cantidad))
            {
                this.cantidadVaso-= cantidad;
                return cantidad;
            }
            else
                return -1;
        }

        

    }

    public class Cafetera
    {
        int cantidadCafe;

        public Cafetera( int cantidad)
        {
            this.cantidadCafe = cantidad;
        }

        public Cafetera() { }

        public void setCantidadDeCafe(int cantidad)
        {
            this.cantidadCafe = cantidad;
            return;
        }

        public int getCantidadDeCafe()
        {
            return this.cantidadCafe;
        }

        public bool hasCafe(int cantidad)
        {
            if(this.cantidadCafe >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int giveCafe(int cantidad)
        {
            if(hasCafe(cantidad))
            {
                this.cantidadCafe-= cantidad;
                return cantidad;
            }
            else
                return -1;
        }



    }

    public class Azucarero
    {
        int cantidadDeAzucar;

        public Azucarero(int cAzuk)
        {
            cantidadDeAzucar = cAzuk;
        }

        public Azucarero() { }

        public void setCantidadDeAzucar(int cantidad)
        {
            this.cantidadDeAzucar = cantidad;
            return;
        }

        public int getCantidadDeAzucar()
        {
            return this.cantidadDeAzucar;
        }

        public bool hasAzucar(int cantidad)
        {
            if(this.cantidadDeAzucar >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int giveAzucar(int cantidad)
        {
            if(this.cantidadDeAzucar >= cantidad)
            {
                this.cantidadDeAzucar -= cantidad;
                return cantidad;
            }
            else
            {
                return -1;
            }
        }
    }
}