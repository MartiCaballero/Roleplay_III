using System;

namespace RoleplayGame
{
    public interface IPersonaje
    {
        string NombrePersonaje {get;}
        int ValorAtaque {get;set;}
        int ValorDefensa {get; set;}
        bool LibroHechizos {get;set;}

        void Ataque (IPersonaje objetivo);
        void Hechizo (IPersonaje objetivo, TipoHechizo hechizo);
        void Curar (IPersonaje objetivo);
    }

    //Defino los tipos de hechizo (con enum)

    public enum TipoHechizo
    {
        None, 
        LlamasArdientes,
        CirculoDeProteccion,
    }
}