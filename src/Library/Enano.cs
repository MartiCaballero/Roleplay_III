using System;
namespace RoleplayGame
{
    public class Enano : ConstructorPersonajes
    {
        public Enano (string nombrepersonaje)
        {
            NombrePersonaje = nombrepersonaje;

            InicializarPersonaje();

            Console.WriteLine($"\nSe ha creado un enano llamado {NombrePersonaje}");
        }

        private void InicializarPersonaje()
        {
            ValorAtaque = 5;
            ValorDefensa = 10;
        }

        public void Ataque(ConstructorPersonajes objetivo)
        {
            int daño = ValorAtaque;
            if (daño >0)
            {
                Console.WriteLine($"\n{NombrePersonaje} ataca a {objetivo.NombrePersonaje} y le causa {daño} puntos de daño.");
                objetivo.ValorDefensa = objetivo.ValorDefensa - daño;

                if (objetivo.ValorDefensa <=0)
                {
                    Console.WriteLine ($"\n{objetivo.NombrePersonaje} ha sido derrotado");
                }
            }
        }

        public new void Curar(IPersonaje objetivo)
        {
            Console.WriteLine($"\n{NombrePersonaje} no puede curar ya que no es un elfo.");
        }

        public void Hechizo(IPersonaje objetivo, TipoHechizo hechizo)
        {
             Console.WriteLine($"\n{NombrePersonaje} no puede lanzar hechizos ya que no es un mago.");
            //Incluimos un método vacío para cumplir con la interfaz ya que los enanos no pueden lanzar hechizos
        }
    }
}