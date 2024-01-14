using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyucununKulesi
{
    //Base inheritence for mobs
    public interface IMobs
    {
        string Name { get; set; }
        double AttackPower { get; set; }
        double Health { get; set; }

        double Defense { get; set; }

        bool IsAlive { get; }
        string WeaponName { get;}

        void Attack(IMobs target);
    }
   
    //Player
    public class Player : IMobs
    {
        private string name;
        private double attackPower = 10;
        private double health = 100;
        private double defense = 12;
        private Random random;
        private IronSword sword;

        //Generator for accessing other classes
        public Player(string name)
        {
            Name = name;
            this.random = new Random();
            this.sword = new IronSword();
            
        }
        public string Name { get { return name; } set { name = value; } }
        public double AttackPower { get { return attackPower; } set { attackPower = value; } }
        public double Health { get { return health; } set { health = value; } }

        
        public double Defense { get { return defense; } set { defense = value; } }
        public bool IsAlive { get { return health > 0; } }

        public int Sword { get { return sword.Damage; } }

        public string WeaponName { get { return sword.Name; } }

        


        //General attack move
        public void Attack(IMobs target)
        {
            Console.WriteLine("{0} elinde {1} ile saldırıyor.", Name, WeaponName);
            double randfactor = random.NextDouble();//To create random value for attack power. So that not every damage is the same
            randfactor = randfactor * 2 / 0.5f;
            //Damage that mobs do.
            double damage = Convert.ToInt32(randfactor*AttackPower) + Sword - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                
                Console.WriteLine("{0} saldırısı sonucu {1} {2} can kaybetti", Name, target.Name, damage);
            }
            else
            {
                Console.WriteLine("{0} saldırısı başarısız oldu.", Name);
            }
        }

    }
    //First level mob
    public class Goblin : IMobs
    {
        
        private double attackPower = 10;
        private double health = 80;
        private double defense = 15;
        private Random random;
        private Club club;

        public Goblin()
        {
            this.random = new Random();
            this.club = new Club();
        }
        public string Name { get; set; } = "Goblin";
        public double AttackPower { get { return attackPower; } set { attackPower = value; } }
        public double Health { get { return health; } set { health = value; } }

        public double Defense { get { return defense; } set { defense = value; } }
        public bool IsAlive { get { return health > 0; } }

        public int Club { get { return club.Damage; } }
        public string WeaponName { get { return club.Name; } }



        public void Attack(IMobs target)
        {
            Console.WriteLine("{0} elinde {1} ile saldırıyor.", Name, WeaponName);
            double randfactor = random.NextDouble();
            randfactor = randfactor * 2 / 0.5f;
            double damage = (Convert.ToInt32(randfactor * AttackPower) / 10) + Club - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                
                Console.WriteLine("{0} saldırısı sonucu {1} {2} can kaybetti", Name, target.Name, damage);
            }
            else
            {
                Console.WriteLine("{0} saldırısı başarısız oldu.", Name);
            }
        }

    }
    //Second level mob
    public class Skeloton : IMobs
    {

        private double attackPower = 10;
        private double health = 90;
        private double defense = 17;
        private Random random;
        private RustySword rustysword;

        public Skeloton()
        {
            this.random = new Random();
            this.rustysword = new RustySword();
        }
        public string Name { get; set; } = "İskelet";
        public double AttackPower { get { return attackPower; } set { attackPower = value; } }
        public double Health { get { return health; } set { health = value; } }

        public double Defense { get { return defense; } set { defense = value; } }
        public bool IsAlive { get { return health > 0; } }

        public int RustySword { get { return rustysword.Damage; } }
        public string WeaponName { get { return rustysword.Name; } }



        public void Attack(IMobs target)
        {
            Console.WriteLine("{0} elinde {1} ile saldırıyor.", Name, WeaponName);
            double randfactor = random.NextDouble();
            randfactor = randfactor * 2 / 0.5f;
            double damage = (Convert.ToInt32(randfactor * AttackPower) / 5) + RustySword - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                
                Console.WriteLine("{0} saldırısı sonucu {1} {2} can kaybetti", Name, target.Name, damage);
            }
            else
            {
                Console.WriteLine("{0} saldırısı başarısız oldu.", Name);
            }
        }

    }
    //This is the boss mob
    public class Wizard : IMobs
    {

        private double attackPower = 10;
        private double health = 75;
        private double defense = 20;
        private Random random;
        private Staff staff;

        public Wizard()
        {
            this.random = new Random();
            this.staff = new Staff();
        }
        public string Name { get; set; } = "Büyücü";
        public double AttackPower { get { return attackPower; } set { attackPower = value; } }
        public double Health { get { return health; } set { health = value; } }

        public double Defense { get { return defense; } set { defense = value; } }
        public bool IsAlive { get { return health > 0; } }

        public int Staff { get { return staff.Damage; } }

        public string WeaponName { get { return staff.Name; } }



        public void Attack(IMobs target)
        {
            Console.WriteLine("{0} elinde {1} ile saldırıyor.", Name, WeaponName);
            double randfactor = random.NextDouble();
            randfactor = randfactor * 2 / 0.75f;
            double damage = Convert.ToInt32(randfactor * AttackPower) + Staff - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                
                Console.WriteLine("{0} saldırısı sonucu {1} {2} can kaybetti", Name, target.Name, damage);
            }
            else
            {
                Console.WriteLine("{0} saldırısı başarısız oldu.", Name);
            }
        }

    }
}

