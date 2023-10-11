using System;
namespace RoleplayGame
{
    public class Elfo : ConstructorPersonajes
    {
        public Elfo (string nombrepersonaje)
        {
            NombrePersonaje = nombrepersonaje;

            InicializarPersonaje();

            Console.WriteLine($"\nSe ha creado un elfo llamado {NombrePersonaje}");
        }

        private void InicializarPersonaje()
        {
            ValorAtaque = 5;
            ValorDefensa = 10;
        }

        public new void Ataque (IPersonaje objetivo)
        {
            if (objetivo is Elfo)
            {
                Curar(objetivo);
            }
            else
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
        }

        public new void Curar(IPersonaje objetivo)
        {
            objetivo.ValorDefensa += 6;
            Console.WriteLine($"\n{NombrePersonaje} cura a {objetivo.NombrePersonaje}");
        }

        public void Hechizo(IPersonaje objetivo, TipoHechizo hechizo)
        {
             Console.WriteLine($"\n{NombrePersonaje} no puede lanzar hechizos ya que no es un mago.");
            //Incluimos un método vacío para cumplir con la interfaz ya que los elfos no pueden lanzar hechizos
        }
    }
}