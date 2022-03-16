using System;
using System.Collections.Generic;
using System.Text;

namespace weapon.Models
{
    class weapon
    {
        private int _bulletCapacity;
        private int _numberOfBullet;
        private double _secondsOfCombDischarge;
        private bool _sootingMode;

        public int bulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                value = _bulletCapacity;
            }
        }
        public int numberOfBullet
        {
            get
            {
                return _numberOfBullet;
            }
            set
            {
                value = _numberOfBullet;
            }
        }
        public double secondsOfCombDischarge
        {
            get
            {
                return _secondsOfCombDischarge;
            }
            set
            {
                value = _secondsOfCombDischarge;
            }
        }
        public bool sootingMode
        {
            get
            {
                return _sootingMode;
            }
            set
            {
                value = _sootingMode;
            }
        }




        public weapon(int bulletCapacity, int numberOfBullet, double secondsOfCombDischarge, bool sootingMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.numberOfBullet = numberOfBullet;
            this.secondsOfCombDischarge = secondsOfCombDischarge;
            this.sootingMode = sootingMode;
        }

        public void Shoot()
        {
            if (numberOfBullet>0)
            {
                numberOfBullet = numberOfBullet - 1;
                Console.WriteLine($"pew pew {numberOfBullet}");
            }
            else
                Console.WriteLine("There are no bullets in the comb");
        }

        public void Fire()
        {
            if (bulletCapacity>0)
            {
                secondsOfCombDischarge = numberOfBullet * secondsOfCombDischarge;
                Console.WriteLine($"seconds of comb discharge:{secondsOfCombDischarge}");
            }
            else
                Console.WriteLine("There are no bullets in the comb");
        }

        public void GetRemainBulletCount()
        {
            if (bulletCapacity>numberOfBullet)
            {
                bulletCapacity = bulletCapacity - numberOfBullet;
                Console.WriteLine($"The number of bullets needed to fill the comb:{bulletCapacity}");
            }
            else
                Console.WriteLine("Enter the numbers correctly");
            
        }
         
        public void Reload()
        {
            if (bulletCapacity>numberOfBullet)
            {
                int Empty = bulletCapacity - numberOfBullet;
                bulletCapacity = Empty + numberOfBullet;
                Console.WriteLine("The comb is full");
            }
           

        }
         
        public void ChangeFireMode()
        {
            if (sootingMode == true )
            {

                Console.WriteLine("Single shot was fired");
            }
            else if (sootingMode == false)
            {
                Console.WriteLine("Automatic firing");
            }
        }
         
        public void Getinfo()
        {
            Console.WriteLine("1 Shoot ");
            Console.WriteLine("2 Fire ");
            Console.WriteLine("3 GetRemainBulletCount ");
            Console.WriteLine("4 Reload ");
            Console.WriteLine("5 ChangeFireMode ");
            Console.WriteLine("6 Exit");
            Console.WriteLine("7 Edit");
        }
            
            



    }   


}
