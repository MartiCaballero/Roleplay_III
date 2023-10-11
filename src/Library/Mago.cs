using System;

namespace RoleplayGame
{
    public class Mago: IPersonaje
    {
        public string NombrePersonaje {get;}
        public int ValorAtaque {get; set;}
        public int ValorDefensa {get;set;}
        public bool LibroHechizos {get; set;}

        public Mago(string nombrepersonaje, bool librohechizos= false)
        {
            NombrePersonaje = nombrepersonaje;
            LibroHechizos = librohechizos;

            IniciarPersonaje();
            
            if (LibroHechizos)
            {
                Console.WriteLine($"\nSe ha creado un mago llamado {NombrePersonaje} equipado con un libro de hechizos.");
            }
            else
            {
                Console.WriteLine($"\nSe ha creado un mago llamado {NombrePersonaje}");
            }
        }

        private void IniciarPersonaje()
        {
            ValorAtaque = 4;
            ValorDefensa = 10;
        }

        public void Ataque (IPersonaje objetivo)
        {
            if (LibroHechizos)
            {
                Console.WriteLine($"\n{NombrePersonaje} lanza un hechizo sobre {objetivo.NombrePersonaje}");

                Hechizo(objetivo, TipoHechizo.LlamasArdientes);
                Hechizo(objetivo, TipoHechizo.CirculoDeProteccion);
            }
            else
            {
                int daño = ValorAtaque; 
                if (daño>0)
                {
                    Console.WriteLine($"\n{NombrePersonaje} ataca a {objetivo.NombrePersonaje} y le causa {daño} puntos de daño");
                    objetivo.ValorDefensa = objetivo.ValorDefensa-daño;

                    if (objetivo.ValorDefensa <= 0 )
                    {
                        Console.WriteLine($"\n{objetivo.NombrePersonaje} ha sido derrotado");
                    }
                }
            }
        }

        public void Hechizo (IPersonaje objetivo, TipoHechizo hechizo)
        {
            int dañohechizo = 0;
            string nombrehechizo = "";

            switch (hechizo)
            {
                case TipoHechizo.LlamasArdientes:
                    dañohechizo= 5;
                    nombrehechizo= "Llamas ardientes";
                    break;
                case TipoHechizo.CirculoDeProteccion:
                    dañohechizo=3;
                    nombrehechizo= "Circulo de Protección";
                    break;
                default:
                    break;
            }

            if (dañohechizo>0)
            {
                Console.WriteLine($"\n{NombrePersonaje} lanza {nombrehechizo} sobre {objetivo.NombrePersonaje} y le causa {dañohechizo} puntos de daño");
                objetivo.ValorDefensa = objetivo.ValorDefensa - dañohechizo;

                if (objetivo.ValorDefensa <= 0)
                {
                    Console.WriteLine($"\n{NombrePersonaje} ha sido derrotado");
                }
            }
        }

        public void Curar (IPersonaje objetivo)
        {
            Console.WriteLine($"\n{NombrePersonaje} no puede curar ya que no es un elfo.");
            //Incluimos un método vacío para cumplir con la interfaz ya que los magos no pueden curar
        }
    }
}