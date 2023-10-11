using System; 
namespace RoleplayGame
{
    public class EquiparItem
    {
        public static void Equipar(IPersonaje personaje, ConstructorItem items)
        {
            if (personaje != null && items != null)
            {
                EquiparArma (personaje, items);
                EquiparArmadura (personaje, items);
            }
        }

        private static void EquiparArma (IPersonaje personaje, ConstructorItem items)
        {
            if (items is Armas && personaje is Enano)
            {
                var arma = (Armas) items;
                var enano = (Enano) personaje;

                if (arma.NombreItem == "Espada")
                {
                    enano.ValorAtaque += arma.ValorAtaque;
                    Console.WriteLine($"\n{enano.NombrePersonaje} ha equipado una {arma.NombreItem} (+{arma.ValorAtaque} Valor de ataque).");
                }
            } 
            else if (items is Armas && (personaje is Mago || personaje is Elfo))
            {
                var arma = (Armas)items;
                var hechizo = (IPersonaje) personaje;

                if (arma.NombreItem == "Bastón Mágico")
                {
                    hechizo.ValorAtaque += arma.ValorAtaque;
                    Console.WriteLine($"\n{hechizo.NombrePersonaje} ha equipado un {arma.NombreItem} (+{arma.ValorAtaque} valor de ataque).");
                }
            }
        }

        private static void EquiparArmadura (IPersonaje personaje, ConstructorItem items)
        {
            if (items is Armaduras)
            {
                var armaduras = (Armaduras) items; 

                personaje.ValorDefensa += armaduras.ValorDefensa; 
                Console.WriteLine($"\n{personaje.NombrePersonaje} ha equipado una {armaduras.NombreItem} (+{armaduras.ValorDefensa} valor defensa).");
            }
        }
    }
}
