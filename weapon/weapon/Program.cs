using System;
using weapon.Models;

namespace weapon.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Note the capacity of the comb:");
            //int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Record the number of bullets in the comb:");
            //int numberOfBullet = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Record the seconds of a bullet's release:");
            //double secondsOfCombDischarge = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Note the type of shot:");
            //bool sootingMode = Convert.ToBoolean(Console.ReadLine());

            weapon W1 = new weapon(30,23,1,true);

            int key = 0;
            do
            {
                Console.WriteLine("Enter the number: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        W1.ChangeFireMode();
                        break;
                    case 2:
                        W1.Shoot();
                        break;
                    case 3:
                        W1.Fire();
                        break;
                    case 4:
                        W1.GetRemainBulletCount();
                        break;
                    case 5:
                        W1.Reload();
                        break;
                    case 6:
                        Console.WriteLine("END");
                        break;
                    case 7:
                        do
                        {
                            Console.WriteLine("Deyismek istediyiniz varianti secin");
                            Console.WriteLine("T-Gulle tutumunu deyis");
                            Console.WriteLine("S-Gulle sayini deyis");
                            Console.WriteLine("D-Sifirlanma saniyesini deyisdeyis");
                            string Letter = Console.ReadLine();

                            switch (Letter)
                            {
                                case "T":
                                    do
                                    {
                                        Console.WriteLine("Gulle tutumunu qeyd et");
                                        W1.bulletCapacity = Convert.ToInt32(Console.ReadLine());
                                        if (W1.bulletCapacity <= 0 || W1.bulletCapacity < W1.numberOfBullet)
                                        
                                            Console.WriteLine("reqemleri duzgun daxil edin");
                                        
                                        break;

                                    } while (W1.bulletCapacity <= 0 || W1.bulletCapacity < W1.numberOfBullet);
                                   
                                    break;
                                case "S":
                                        Console.WriteLine("Gulle sayini qeyd et");
                                        W1.numberOfBullet = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case "D":
                                        Console.WriteLine("Sifirlanma saniyesini qeyd et");
                                        W1.secondsOfCombDischarge = Convert.ToInt32(Console.ReadLine());
                                    break;
                                default: Console.WriteLine("Entered incorrectly");
                                    break;
                            }
                        } while (true);
                    case 0:
                        W1.Getinfo();
                        break;
                    default:
                        Console.WriteLine("Entered incorrectly");
                        break;
                }
            } while (key != 7);


        }
    }
}
