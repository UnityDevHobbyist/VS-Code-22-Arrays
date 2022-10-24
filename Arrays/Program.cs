using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weapon = 0;

            string[] weaponName;
            weaponName = new string[5];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shot gun";
            weaponName[2] = "Spreader";
            weaponName[3] = "Laser";
            weaponName[4] = "Rocket Launcher";

            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 25;
            ammo[4] = 10;

            int[] maxAmmo;
            maxAmmo = new int[5];
            maxAmmo[0] = 6;
            maxAmmo[1] = 2;
            maxAmmo[2] = 50;
            maxAmmo[3] = 25;
            maxAmmo[4] = 10;

            Console.WriteLine("Arrays:");
            Console.WriteLine();

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            weapon = 2;
            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);
            Fire(10);

            Console.ReadKey(true);

            void Fire(int shotsFired)
            {
                if (ammo[weapon] - shotsFired >= 0)
                    ammo[weapon] -= shotsFired;
                else
                {
                    Console.WriteLine("The number that was entered is greater than the ammo that's available.");
                    return;
                }
                Console.WriteLine("Player fired " + weaponName[weapon] + ". " + weaponName[weapon] + " has " + ammo[weapon] + " ammo left.");
            }

            void Reload()
            {
                ammo[weapon] = maxAmmo[weapon];
            }
        }
    }
}
