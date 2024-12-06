namespace Weapon
{
   internal class Program
   {
        static void Main(string[] args)
        {
           
            Weapon myWeapon = new Weapon(30, 10, "Single");

            
            while (true)
            {
                Console.WriteLine("\nQısayollar:");
                Console.WriteLine("0 - İnformasiya almaq");
                Console.WriteLine("1 - Shoot metodu ucun");
                Console.WriteLine("2 - Fire metodu ucun");
                Console.WriteLine("3 - GetRemainBulletCount metodu ucun");
                Console.WriteLine("4 - Reload metodu ucun");
                Console.WriteLine("5 - ChangeFireMode metodu ucun");
                Console.WriteLine("6 - Proqramdan cıxmaq ucun");

                Console.Write("Secim edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine($"Tutum: {myWeapon.MagazineCapacity}, Cari gulle sayı: {myWeapon.CurrentBulletCount}, Mod: {myWeapon.FireMode}");
                        break;
                    case "1":
                        myWeapon.Shoot();
                        break;
                    case "2":
                        myWeapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine($"Tam dolması ucun lazım olan gulle sayı: {myWeapon.GetRemainBulletCount()}");
                        break;
                    case "4":
                        myWeapon.Reload();
                        break;
                    case "5":
                        myWeapon.ChangeFireMode();
                        break;
                    case "6":
                        Console.WriteLine("Proqram bitdi.");
                        return;
                    default:
                        Console.WriteLine("Yanlış secim! Yenidən cehd edin.");
                        break;
                }
            }
        }
   }
}