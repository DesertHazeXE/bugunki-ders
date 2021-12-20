// See https://aka.ms/new-console-template for more information
namespace SpaceStation
{class Program
    {
        static void Main(string[] args)
        {
            DeathStar deathStar = new DeathStar();
            SpaceStation[] spaceStation = { deathStar };
            foreach (var item in spaceStation)
            {
                item.FireLaser();
            }

        }
    }

}
