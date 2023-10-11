using System;
namespace RoleplayGame
{
    public class Armaduras : ConstructorItem
    {
        public string NombreItem {get;}
        public int ValorAtaque {get;}
        public int ValorDefensa {get;}

        public Armaduras(string nombrearmadura, int valordefensa)
        {
            NombreItem = nombrearmadura;
            ValorDefensa = valordefensa;
        }

        public static Armaduras CrearArmaduraBronce()
        {
            return new Armaduras("Armadura de Bronce", 2);
            //La armadura de bronce agrega 2 de valor de defensa
        }
        public static Armaduras CrearArmaduraPlata()
        {
            return new Armaduras("Armadura de Plata", 4);
            //La armadura de plata agrega 4 de valor de defensa
        }
        public static Armaduras CrearTunica()
        {
            return new Armaduras("Tunica", 1);
            //La tunica agrega 1 de valor de defensa
        }
    }
}