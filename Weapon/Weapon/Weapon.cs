using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
   public class Weapon
    {
        
    public int MagazineCapacity { get; private set; } 
        public int CurrentBulletCount { get; private set; } 
        public string FireMode { get; private set; } 

        public Weapon(int magazineCapacity, int currentBulletCount, string fireMode)
        {
            MagazineCapacity = magazineCapacity;
            CurrentBulletCount = currentBulletCount;
            FireMode = fireMode;
        }

        public void Shoot()
        {
            if (CurrentBulletCount > 0)
            {
                CurrentBulletCount--;
                Console.WriteLine("Bir gulle atıldı! Qalan gulle sayı: " + CurrentBulletCount);
            }
            else
            {
                Console.WriteLine("Gulle yoxdur! Yeniden doldurun.");
            }
        }

        public void Fire()
        {
            if (CurrentBulletCount > 0)
            {
                Console.WriteLine("Avtomatik atıs basladı:");
                while (CurrentBulletCount > 0)
                {
                    Shoot();
                }
            }
            else
            {
                Console.WriteLine("Daraqda gulle yoxdur!");
            }
        }

        public int GetRemainBulletCount()
        {
            return MagazineCapacity - CurrentBulletCount;
        }

        public void Reload()
        {
            int bulletsToReload = GetRemainBulletCount();
            CurrentBulletCount += bulletsToReload;
            Console.WriteLine("Daraq tamamile dolduruldu! Cari gulle sayı: " + CurrentBulletCount);
        }

        public void ChangeFireMode()
        {
            FireMode = FireMode == "Single" ? "Auto" : "Single";
            Console.WriteLine("Atıs modu deyisdirildi. Yeni mod: " + FireMode);
        }
    }

}

