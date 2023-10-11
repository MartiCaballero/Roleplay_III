using System;
namespace RoleplayGame
{
    public class ConstructorPersonajes
    {
        public string NombrePersonaje {get; set;}
        public int ValorAtaque {get; set;}
        public int ValorDefensa {get; set;}
        public bool LibroHechizos {get; set;}

        public ConstructorPersonajes(string nombrepersonaje,int valorataque, int valordefensa, bool librohechizos)
        {
            NombrePersonaje = nombrepersonaje;
            ValorAtaque= valorataque;
            ValorDefensa = valordefensa;
            LibroHechizos = librohechizos;
        }

        public void Ataque (IPersonaje objetivo)
        {
            objetivo.ValorDefensa -= ValorAtaque;
        }

        public void Defensa(IPersonaje objetivo)
        {
            objetivo.ValorDefensa += ValorDefensa;
        }

        public void Curar(IPersonaje objetivo)
        {
            objetivo.ValorDefensa += 5;
        }
    }
}