namespace PROJEKTv2
{

    public partial class Form1 : Form
    {
        private BattleTank tank;
        private TankEquipmentChangeDecorator tankequipmentDecorator;
        private GunChangeDecorator gunDecorator;
        private CrewEquipmentChangeDecorator crewequipmentDecorator;
        private ArmourChangeDecorator armourDecorator;
        private TrackChangeDecorator trackDecorator;
        public Form1()
        {
            InitializeComponent();
            //t3485 = new BattleTank(T3485GUN1, T3485ARM1, T3485TE1, T3485CE1, T3485TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);
            tank = new BattleTank(T3485GUN1, T3485ARM1, T3485TE1, T3485CE1, T3485TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);
            tankequipmentDecorator = new TankEquipmentChangeDecorator(tank);
            gunDecorator = new GunChangeDecorator(tank);
            crewequipmentDecorator = new CrewEquipmentChangeDecorator(tank);
            armourDecorator = new ArmourChangeDecorator(tank);
            trackDecorator = new TrackChangeDecorator(tank);
        }

        
        


        Gunner gunner = new Gunner("john", 75, false);
        Commander commander = new Commander("marcin", 75, false, false, false);
        Reloader reloader = new Reloader("mecenas", 75);
        HighExplosiveShell highExplosiveShell = new HighExplosiveShell("BT-5HESH", 5, 30, 800, 1000, 0);
        ArmorPiercing armorPiercing = new ArmorPiercing(25, 70, 900, 600, 0, "BT-5AP");



        Gun BT5GUN1 = new Gun(55, 45, 46, 250, "BT5GUN1");
        TankEquipment BT5TE1 = new TankEquipment(410, "BT5TE1", 80);
        CrewEquipment BT5CE1 = new CrewEquipment(100, "BT5CE1", 80);
        Track BT5TRACK1 = new Track(3300, "BT5TRACK1", 11800);
        Armour BT5ARM1 = new Armour(35, 40, 15, 5000, "BT5ARM1");
        //BattleTank tank = new BattleTank(BT5GUN1, BT5ARM1, BT5TE1, BT5CE1, BT5TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);
        //BT5
        Gun BT5GUN2 = new Gun(65, 55, 43, 250, "BT5GUN2");
        TankEquipment BT5TE2 = new TankEquipment(410, "BT5TE2", 90);
        CrewEquipment BT5CE2 = new CrewEquipment(100, "BT5CE2", 90);
        Track BT5TRACK2 = new Track(3300, "BT5TRACK2", 11800);
        Armour BT5ARM2 = new Armour(45, 60, 20, 5000, "BT5ARM2");



        Gun BT7GUN1 = new Gun(65, 55, 43, 250, "BT7GUN1");
        TankEquipment BT7TE1 = new TankEquipment(410, "BT7TE1", 80);
        CrewEquipment BT7CE1 = new CrewEquipment(100, "BT7CE1", 80);
        Track BT7TRACK1 = new Track(3300, "BT5TRACK1", 11800);
        Armour BT7ARM1 = new Armour(45, 60, 20, 5000, "BT7ARM1");
        //BT7
        Gun BT7GUN2 = new Gun(75, 65, 41, 250, "BT7GUN2");
        TankEquipment BT7TE2 = new TankEquipment(410, "BT7TE2", 90);
        CrewEquipment BT7CE2 = new CrewEquipment(100, "BT7CE2", 90);
        Track BT7TRACK2 = new Track(3300, "BT7TRACK2", 11800);
        Armour BT7ARM2 = new Armour(55, 70, 25, 5000, "BT7ARM2");



        Gun T28GUN1 = new Gun(75, 65, 43, 250, "T28GUN1");
        TankEquipment T28TE1 = new TankEquipment(410, "T28TE1", 80);
        CrewEquipment T28CE1 = new CrewEquipment(100, "T28CE1", 80);
        Track T28TRACK1 = new Track(3300, "T28TRACK1", 11800);
        Armour T28ARM1 = new Armour(55, 60, 25, 5000, "T28ARM1");
        //T28
        Gun T28GUN2 = new Gun(80, 70, 41, 250, "T28GUN2");
        TankEquipment T28TE2 = new TankEquipment(410, "T28TE2", 80);
        CrewEquipment T28CE2 = new CrewEquipment(100, "T28CE2", 80);
        Track T28TRACK2 = new Track(3300, "T28TRACK2", 11800);
        Armour T28ARM2 = new Armour(60, 70, 30, 5000, "T28ARM2");



        Gun KV1GUN1 = new Gun(80, 70, 46, 250, "KV1GUN1");
        TankEquipment KV1TE1 = new TankEquipment(410, "KV1TE1", 80);
        CrewEquipment KV1CE1 = new CrewEquipment(100, "KV1CE1", 80);
        Track KV1TRACK1 = new Track(3300, "T28TRACK1", 11800);
        Armour KV1ARM1 = new Armour(70, 80, 40, 5000, "KV1ARM1");
        //KV1 
        Gun KV1GUN2 = new Gun(85, 74, 45, 250, "KV1GUN2");
        TankEquipment KV1TE2 = new TankEquipment(410, "KV1TE2", 80);
        CrewEquipment KV1CE2 = new CrewEquipment(100, "KV1CE2", 80);
        Track KV1TRACK2 = new Track(3300, "KV1TRACK2", 11800);
        Armour KV1ARM2 = new Armour(100, 100, 45, 5000, "KV1ARM2");



        Gun KV1SGUN1 = new Gun(100, 105, 46, 250, "KV1SGUN1");
        TankEquipment KV1STE1 = new TankEquipment(410, "KV1STE1", 80);
        CrewEquipment KV1SCE1 = new CrewEquipment(100, "KV1SCE1", 80);
        Track KV1STRACK1 = new Track(3300, "KV1STRACK1", 11800);
        Armour KV1SARM1 = new Armour(120, 110, 50, 5000, "KV1SARM1");
        //KV1S
        Gun KV1SGUN2 = new Gun(120, 115, 43, 250, "KV1SGUN2");
        TankEquipment KV1STE2 = new TankEquipment(410, "KV1STE2", 80);
        CrewEquipment KV1SCE2 = new CrewEquipment(100, "KV1SCE2", 80);
        Track KV1STRACK2 = new Track(3300, "KV1STRACK2", 11800);
        Armour KV1SARM2 = new Armour(130, 130, 55, 5000, "KV1SARM2");



        Gun T150GUN1 = new Gun(120, 105, 44, 250, "T150GUN1");
        TankEquipment T150TE1 = new TankEquipment(410, "T150TE1", 80);
        CrewEquipment T150CE1 = new CrewEquipment(100, "T150CE1", 80);
        Track T150TRACK1 = new Track(3300, "T150TRACK1", 11800);
        Armour T150ARM1 = new Armour(110, 110, 40, 5000, "T150ARM1");
        //T150
        Gun T150GUN2 = new Gun(130, 110, 42, 250, "T150GUN2");
        TankEquipment T150TE2 = new TankEquipment(410, "T150TE2", 80);
        CrewEquipment T150CE2 = new CrewEquipment(100, "T150CE2", 80);
        Track T150TRACK2 = new Track(3300, "T150TRACK2", 11800);
        Armour T150ARM2 = new Armour(120, 120, 45, 5000, "T150ARM2");



        Gun T34GUN1 = new Gun(140, 100, 46, 250, "T34GUN1");
        TankEquipment T34TE1 = new TankEquipment(410, "T34TE1", 80);
        CrewEquipment T34CE1 = new CrewEquipment(100, "T34CE1", 80);
        Track T34TRACK1 = new Track(3300, "T34TRACK1", 11800);
        Armour T34ARM1 = new Armour(50, 60, 25, 5000, "T34ARM1");
        //T34
        Gun T34GUN2 = new Gun(150, 110, 41, 250, "T34GUN2");
        TankEquipment T34TE2 = new TankEquipment(410, "T34TE2", 80);
        CrewEquipment T34CE2 = new CrewEquipment(100, "T34CE2", 80);
        Track T34TRACK2 = new Track(3300, "T34TRACK2", 11800);
        Armour T34ARM2 = new Armour(60, 80, 30, 5000, "T34ARM2");



        Gun T3485GUN1 = new Gun(160, 110, 41, 250, "T3485GUN1");
        TankEquipment T3485TE1 = new TankEquipment(410, "T3485TE1", 80);
        CrewEquipment T3485CE1 = new CrewEquipment(100, "T3485CE1", 80);
        Track T3485TRACK1 = new Track(3300, "T28TRACK1", 11800);
        Armour T3485ARM1 = new Armour(70, 80, 40, 5000, "T3485ARM1");
        //T3485
        Gun T3485GUN2 = new Gun(180000, 120, 42, 250, "T3485GUN2");
        TankEquipment T3485TE2 = new TankEquipment(410, "T3485TE2", 120);
        CrewEquipment T3485CE2 = new CrewEquipment(100, "T3485CE2", 105);
        Track T3485TRACK2 = new Track(3300, "T3485TRACK2", 11800);
        Armour T3485ARM2 = new Armour(80, 90, 35, 5000, "T3485ARM2");

        //BattleTank tank = new BattleTank(BT5GUN1, BT5ARM1, BT5TE1, BT5CE1, BT5TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);

        public class BattleTank
        {

            private Gun gun;
            private Armour arm;
            private TankEquipment tankequipment;
            private CrewEquipment crewequipment;
            private Track track;
            private ArmorPiercing armor_piercing;
            private HighExplosiveShell high_Explosive_Shell;
            private Gunner gunner;
            private Commander commander;
            private Reloader reloader;
            private int hp;
            private float  Damage;

            //private int penetr
            public int calculateHP()
            {
                hp = arm.HullThickness * 20 + arm.TowerThickness * 30 + arm.LowerPlateThickness * 10;
                return hp;
            }
            public float calculateDamage()
            {
                Damage = (Gun.Gun_damage+tankequipment.Quality + crewequipment.Quality+ Gun.Gun_penetration)/4 +(Gunner.Experience +Commander.Experience+reloader.Experience);
                return Damage;
            }

            public BattleTank()
            {

            }
            public BattleTank(Gun gun, Armour arm, TankEquipment tankequipment, CrewEquipment crewequipment, Track track, ArmorPiercing armor_piercing, HighExplosiveShell high_Explosive_Shell, Gunner gunner, Commander commander, Reloader reloader)
            {
                this.gun = gun;
                this.arm = arm;
                this.tankequipment = tankequipment;
                this.crewequipment = crewequipment;
                this.track = track;
                this.armor_piercing = armor_piercing;
                this.high_Explosive_Shell = high_Explosive_Shell;
                this.gunner = gunner;
                this.commander = commander;
                this.reloader = reloader;
            }
            public Gun Gun
            {
                get { return gun; }
                set { gun = value; }
            }

            public Armour Arm
            {
                get { return arm; }
                set { arm = value; }
            }

            public TankEquipment Tankequipment
            {
                get { return tankequipment; }
                set { tankequipment = value; }
            }

            public CrewEquipment Crewequipment
            {
                get { return crewequipment; }
                set { crewequipment = value; }
            }

            public Track Track
            {
                get { return track; }
                set { track = value; }
            }

            public ArmorPiercing Armor_piercing
            {
                get { return armor_piercing; }
                set { armor_piercing = value; }
            }

            public HighExplosiveShell High_Explosive_Shell
            {
                get { return high_Explosive_Shell; }
                set { high_Explosive_Shell = value; }
            }

            public Gunner Gunner
            {
                get { return gunner; }
                set { gunner = value; }
            }

            public Commander Commander
            {
                get { return commander; }
                set { commander = value; }
            }

            public Reloader Reloader
            {
                get { return reloader; }
                set { reloader = value; }
            }
        }
        public static class TankFactory
        {
            public static BattleTank CreateBattleTank()
            {
                // Tworzenie obiektów dla pól BattleTank
                Random random = new Random();

                Gunner gunner = new Gunner("john", random.Next(50,70), false);
                Commander commander = new Commander("marcin", random.Next(50, 70), false, false, false);
                Reloader reloader = new Reloader("mecenas", random.Next(50, 70));
                HighExplosiveShell highExplosiveShell = new HighExplosiveShell("BT-5HESH", 5, random.Next(20, 70), 800, 1000, 0);
                ArmorPiercing armorPiercing = new ArmorPiercing(25, random.Next(30, 70), 900, 600, 0, "BT-5AP");
                Gun gun = new Gun(random.Next(30, 100), random.Next(20,100), random.Next(35,50), 250, "BT5GUN1");
                TankEquipment tankequipment = new TankEquipment(410, "BT5TE1", random.Next(50, 70));
                CrewEquipment crewequipment = new CrewEquipment(100, "BT5CE1", random.Next(50, 70));
                Track track = new Track(3300, "BT5TRACK1", 11800);
                Armour arm = new Armour(random.Next(25,80), random.Next(40, 100), random.Next(25, 40), 5000, "BT5ARM1");

                // Tworzenie obiektu BattleTank i ustawianie pól
                BattleTank tank = new BattleTank();
                tank.Gunner = gunner;
                tank.Commander = commander;
                tank.Reloader = reloader;
                tank.High_Explosive_Shell = highExplosiveShell;
                tank.Armor_piercing = armorPiercing;
                tank.Gun = gun;
                tank.Tankequipment = tankequipment;
                tank.Crewequipment = crewequipment;
                tank.Track = track;
                tank.Arm = arm;

                return tank;
            }
            public static BattleTank Create(Gun gun, Armour arm, TankEquipment tankequipment, CrewEquipment crewequipment, Track track, ArmorPiercing armor_piercing, HighExplosiveShell high_Explosive_Shell, Gunner gunner, Commander commander, Reloader reloader)
            {
                BattleTank tank = new BattleTank();
                tank.Gun = gun;
                tank.Arm = arm;
                tank.Tankequipment = tankequipment;
                tank.Crewequipment = crewequipment;
                tank.Track = track;
                tank.Armor_piercing = armor_piercing;
                tank.High_Explosive_Shell = high_Explosive_Shell;
                tank.Gunner = gunner;
                tank.Commander = commander;
                tank.Reloader = reloader;

                return tank;
            }
        }
        //BattleTank tank=TankFactory.Create(BT5GUN1, BT5ARM1, BT5TE1, BT5CE1, BT5TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);
        public abstract class CrewMember
        {
            // Pola
            protected string name;
            protected float experience;

            // Konstruktor
            public CrewMember(string name, float experience)
            {
                this.name = name;
                this.experience = experience;
            }

            // W³aœciwoœci
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public float Experience
            {
                get { return experience; }
                set { experience = value; }
            }

            // Metody abstrakcyjne

            // Metody niemalowane

        }
        public class Reloader : CrewMember
        {
            // Konstruktor
            public Reloader(string name, int experience) : base(name, experience)
            {
            }



            public int PrepareAmmunition(Ammunition ammo)
            {
                return 0;
            }

            public int Reload(BattleTank tank)
            {
                return 0;
            }
        }
        public class Commander : CrewMember
        {
            // Pola
            private bool boostMorale;
            private bool replaceCrew;
            private bool scouting;

            // Konstruktor
            public Commander(string name, int experience, bool boostMorale, bool replaceCrew, bool scouting)
                : base(name, experience)
            {
                this.boostMorale = boostMorale;
                this.replaceCrew = replaceCrew;
                this.scouting = scouting;
            }


            // Dodatkowe metody specyficzne dla klasy Commander
            public void BoostMorale()
            {

            }


        }
        public class Gunner : CrewMember
        {
            // Pola
            private bool canFocus;

            // Konstruktor
            public Gunner(string name, int experience, bool canFocus) : base(name, experience)
            {
                this.canFocus = canFocus;
            }

            public bool Desperation(int tankHP)
            {
                if (tankHP < 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Ammunition : Equipment
        {
            //private string name;
            private int quantity;
            private int penetration;
            private int shellSpeed;
            private int cost;
            public Ammunition(int quantity, int penetration, int shellSpeed, int cost, int weight, string name) : base(weight, name)
            {

                Quantity = quantity;
                Penetration = penetration;
                ShellSpeed = shellSpeed;
                Cost = cost;
            }



            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

            public int Penetration
            {
                get { return penetration; }
                set { penetration = value; }
            }

            public int ShellSpeed
            {
                get { return shellSpeed; }
                set { shellSpeed = value; }
            }

            public int Cost
            {
                get { return cost; }
                set { cost = value; }
            }


            public void DecreaseQuantity()
            {
                if (quantity > 0)
                {
                    quantity--;
                }
            }

            public virtual int Penetrate()
            {
                return penetration;
            }
        }
        public class ArmorPiercing : Ammunition
        {
            public ArmorPiercing(int quantity, int penetration, int shellSpeed, int cost, int weight, string name) : base(quantity, penetration, shellSpeed, cost, weight, name)
            {
            }
            public override int Penetrate()
            {
                return this.Penetration;
            }
        }

        public class HighExplosiveShell : Ammunition
        {
            public int ExplosiveRadius { get; set; }

            public HighExplosiveShell(string name, int quantity, int penetration, int shellSpeed, int cost, int weight) : base(quantity, penetration, shellSpeed, cost, weight, name)
            {
            }
            public override int Penetrate()
            {



                return ExplosiveRadius*Penetration;
            }
        }
        public class Track : Equipment
        {
            private int maxCapacity;

            public Track(int weight, string name, int maxCapacity) : base(weight, name)
            {
                this.maxCapacity = maxCapacity;
            }

            public bool Lift()
            {
                return true;
            }

            public override string GetInfo()
            {
                return $"Name:{Name}\nWeight:{Weight}\nMaxCapacity:{maxCapacity}";
            }
        }
        public class Armour : Equipment
        {
            private int hullThickness;
            private int towerThickness;
            private int lowerPlateThickness;
            public Armour(int hullThickness, int towerThickness, int lowerPlateThickness, int weight, string name) : base(weight, name)
            {
                HullThickness = hullThickness;
                TowerThickness = towerThickness;
                LowerPlateThickness = lowerPlateThickness;
            }
            public override string GetInfo()
            {
                return $"Name:{this.Name}\nWeight:{this.Weight}\nhullThickness{this.hullThickness}\ntowerThickness:{this.towerThickness}\nlowerPlateThickness:{this.lowerPlateThickness}";
            }
            public int HullThickness
            {
                get { return hullThickness; }
                set { hullThickness = value; }
            }

            public int TowerThickness
            {
                get { return towerThickness; }
                set { towerThickness = value; }
            }

            public int LowerPlateThickness
            {
                get { return lowerPlateThickness; }
                set { lowerPlateThickness = value; }
            }

            public int EffectiveArmour(int projectileHullThickness, int projectileTowerThickness, int projectileLowerPlateThickness, int penetration)
            {
                int effectiveHullThickness = hullThickness - projectileHullThickness;
                int effectiveTowerThickness = towerThickness - projectileTowerThickness;
                int effectiveLowerPlateThickness = lowerPlateThickness - projectileLowerPlateThickness;

                if (effectiveHullThickness < 0)
                {
                    effectiveHullThickness = 0;
                }

                if (effectiveTowerThickness < 0)
                {
                    effectiveTowerThickness = 0;
                }

                if (effectiveLowerPlateThickness < 0)
                {
                    effectiveLowerPlateThickness = 0;
                }

                int effectiveArmour = effectiveHullThickness + effectiveTowerThickness + effectiveLowerPlateThickness;
                int reducedPenetration = penetration - effectiveArmour;

                if (reducedPenetration < 0)
                {
                    reducedPenetration = 0;
                }

                return reducedPenetration;
            }
        }
        public class TankEquipment : Equipment
        {
            private int quality;
            public int Quality
            {
                get { return quality; }
                set { quality = value; }
            }
            public TankEquipment(int weight, string name, int quality) : base(weight, name)
            {
                this.quality = quality;
            }

            private bool Repair()
            {
                return true;
            }

            public override string GetInfo()
            {
                return "Name:" + Name + "\nWeight:" + Weight + "\nQuality:" + quality;
            }
        }
        public class CrewEquipment : Equipment
        {
            private int quality;
            public int Quality
            {
                get { return quality; }
                set { quality = value; }
            }
            public CrewEquipment(int weight, string name, int quality) : base(weight, name)
            {
                this.quality = quality;
            }

            private bool Heal()
            {

                return true;
            }

            public override string GetInfo()
            {

                return "Name:" + Name + "\nWeight: " + Weight + "\nQuality: " + quality;
            }
        }

        public class Gun : Equipment
        {
            private int gun_damage;
            private int gun_penetration;
            private int accuracy;
            public Gun(int gun_damage, int gun_penetration, int accuracy, int weight, string name) : base(weight, name)
            {
                this.gun_damage = gun_damage;
                this.gun_penetration = gun_penetration;
                this.accuracy = accuracy;
            }
            public int Gun_damage
            {
                get { return gun_damage; }
                set { gun_damage = value; }
            }

            public int Gun_penetration
            {
                get { return gun_penetration; }
                set { gun_penetration = value; }
            }

            public int Accuracy
            {
                get { return accuracy; }
                set { accuracy = value; }
            }
            public override string GetInfo()
            {
                return $"Gun:{this.Name}\nWeight:{this.Weight}\nGun damage:{this.Gun_damage}\nGun penetratios:{this.Gun_penetration}\nAccuracy:{this.Accuracy}";
            }
            public bool Fire()
            {
                return true;
            }

            public bool SwapAmmunition()
            {
                return true;
            }
            public override void Destroy()
            {
                accuracy = accuracy / 2;
            }
        }
        public class Equipment
        {
            private int weight;
            private string name;
            public Equipment(int weight, string name)
            {
                this.weight = weight;
                this.name = name;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }

            public virtual string GetInfo()
            {
                return "";
            }

            public virtual void Destroy()
            {

            }
        }

        public abstract class TankDecorator 
        {
            protected BattleTank decoratedTank;

            public TankDecorator(BattleTank tank)
            {
                decoratedTank = tank;
            }

            public virtual void ChangeGun(Gun newGun)
            {
                decoratedTank.Gun = newGun;
            }

            public virtual void ChangeTankEquipment(TankEquipment newEquipment)
            {
                decoratedTank.Tankequipment = newEquipment;
            }

            public virtual void ChangeCrewEquipment(CrewEquipment newEquipment)
            {
                decoratedTank.Crewequipment = newEquipment;
            }
            public virtual void ChangeArmour(Armour newArmour)
            {
                decoratedTank.Arm = newArmour;
            }
            public virtual void ChangeTrack(Track newTrack)
            {
                decoratedTank.Track = newTrack;
            }
        }
        public class TrackChangeDecorator : TankDecorator
        {

            public TrackChangeDecorator(BattleTank tank) : base(tank)
            {
            }

            public override void ChangeTrack(Track newTrack)
            {
                decoratedTank.Track = newTrack;
            }
        }
        public class GunChangeDecorator : TankDecorator
        {
            public GunChangeDecorator(BattleTank tank) : base(tank)
            {
            }

            public override void ChangeGun(Gun newGun)
            {
                decoratedTank.Gun = newGun;
            }
        }

        public class TankEquipmentChangeDecorator : TankDecorator
        {

            public TankEquipmentChangeDecorator(BattleTank tank) : base(tank)
            {
            }

            public override void ChangeTankEquipment(TankEquipment newEquipment)
            {
                decoratedTank.Tankequipment = newEquipment;
            }
        }
        public class CrewEquipmentChangeDecorator : TankDecorator
        {

            public CrewEquipmentChangeDecorator(BattleTank tank) : base(tank)
            {
            }
            public override void ChangeCrewEquipment(CrewEquipment newEquipment)
            {
                decoratedTank.Crewequipment = newEquipment;
            }
        }
        public class ArmourChangeDecorator : TankDecorator
        {

            public ArmourChangeDecorator(BattleTank tank) : base(tank)
            {
            }

            public override void ChangeArmour(Armour newArmour)
            {
                decoratedTank.Arm = newArmour;
            }
        }
        public class UpgradesManager
        {
            private int credits;
            private int Experience;
            private int gold;

            public int Credits
            {
                get { return credits; }
                set { credits = value; }
            }

            public int experience
            {
                get { return Experience; }
                set { Experience = value; }
            }

            public int Gold
            {
                get { return gold; }
                set { gold = value; }
            }

            public bool Examine(BattleTank tank)
            {
                
                return true;
            }

            public bool BuyTank(BattleTank tank)
            {

                return true; // Placeholder return value
            }
        }

        UpgradesManager UM = new UpgradesManager();

        






        int creditFlag_T28 = 0;
        int creditFlag_KV1 = 0;
        int creditFlag_KV1S = 0;
        int creditFlag_T150 = 0;
        int creditFlag_BT7 = 0;
        int creditFlag_T34 = 0;
        int creditFlag_T3485 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_garage.Visible = true;
            groupBox_battle.Visible = false;
            button_T150.Visible = false;
            checkBox_T150.Visible = false;
            button_KV1S.Visible = false;
            checkBox_KV1S.Visible = false;
            button_KV1.Visible = false;
            checkBox_KV1.Visible = false;
            button_T3485.Visible = false;
            checkBox_T3485.Visible = false;
            button_T34.Visible = false;
            checkBox_T34.Visible = false;

            button_at_T28.Visible = false;
            checkBox_at_T28.Visible = false;
            button_at_BT7.Visible = false;
            checkBox_at_BT7.Visible = false;
            button_at_T34.Visible = false;
            checkBox_at_T34.Visible = false;
            button_at_T3485.Visible = false;
            checkBox_at_T3485.Visible = false;
            button_at_KV1.Visible = false;
            checkBox_at_KV1.Visible = false;
            button_at_KV1S.Visible = false;
            checkBox_at_KV1S.Visible = false;
            button_at_T150.Visible = false;
            checkBox_at_T150.Visible = false;


            groupBox_BT5.Visible = true;
            groupBox_T28.Visible = false;
            groupBox_KV1.Visible = false;
            groupBox_KV1S.Visible = false;
            groupBox_T34.Visible = false;
            groupBox_T3485.Visible = false;
            groupBox_T150.Visible = false;
            groupBox_BT7.Visible = false;



            UM.Credits = 10000000;
            UM.Gold = 10000000;
            UM.experience = 10000000;
            textBox_credits.Text = Convert.ToString(UM.Credits);
            textBox_experience.Text = Convert.ToString(UM.experience);
            //textBox_gold.Text = Convert.ToString(UM.Gold);


            buttonBT7_arm2.Visible = false;
            buttonBT7_CE2.Visible = false;
            buttonBT7_TE2.Visible = false;
            buttonBT7_track2.Visible = false;
            button10.Visible = false;
            button7.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;

            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;

            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;

            button57.Visible = false;
            button56.Visible = false;
            button55.Visible = false;
            button54.Visible = false;
            button53.Visible = false;

            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button65.Visible = false;

            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;

            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;

        }
        private void button_research_Click(object sender, EventArgs e)
        {
            groupBox_research.Visible = true;
            groupBox_garage.Visible = false;
        }

        private void button_garage_Click(object sender, EventArgs e)
        {
            groupBox_research.Visible = false;
            groupBox_garage.Visible = true;
        }

        

        private void button_T28_Click(object sender, EventArgs e)
        {
            //int creditFlag = 0;
            if ((creditFlag_T28 == 1) && (UM.Credits > 135000))
            {
                UM.Credits = UM.Credits - 135000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_T28.Checked = true;
            }
            if ((creditFlag_T28 == 0) && (UM.experience > 3200))
            {
                UM.experience = UM.experience - 3200;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_T28.Text= Convert.ToString(135000)+" Cred";
                creditFlag_T28++;
            }
        }

        private void button_T150_Click(object sender, EventArgs e)
        {
            if ((creditFlag_T150 == 1) && (UM.Credits > 880000))
            {
                UM.Credits = UM.Credits - 880000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_T150.Checked = true;
            }
            if ((creditFlag_T150 == 0) && (UM.experience > 24500))
            {
                UM.experience = UM.experience - 24500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_T150.Text = Convert.ToString(880000) + " Cred";
                creditFlag_T150++;
            }
        }

        private void checkBox_KV1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_KV1.Checked)
            {
                button_T150.Visible = true;
                checkBox_T150.Visible = true;
                button_KV1S.Visible = true;
                checkBox_KV1S.Visible = true;
                button_KV1.Visible = false;

                button_at_KV1.Visible = true;
                checkBox_at_KV1.Visible = true;
            }
            else
            {
                button_T150.Visible = false;
                checkBox_T150.Visible = false;
                button_KV1S.Visible = false;
                checkBox_KV1S.Visible = false;

                button_at_KV1.Visible = false;
                checkBox_at_KV1.Visible = false;
            }
        }
        
        private void checkBox_T28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T28.Checked)
            {
                button_KV1.Visible = true;
                checkBox_KV1.Visible = true;
                button_T28.Visible = false;

                button_at_T28.Visible = true;
                checkBox_at_T28.Visible = true;
            }
            else
            {

                button_KV1.Visible = false;
                checkBox_KV1.Visible = false;


                button_at_T28.Visible = false;
                checkBox_at_T28.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T34.Checked)
            {
                button_T3485.Visible = true;
                checkBox_T3485.Visible = true;
                button_T34.Visible = false;

                button_at_T34.Visible = true;
                checkBox_at_T34.Visible = true;
            }
            else
            {
                button_T3485.Visible = false;
                checkBox_T3485.Visible = false;

                button_at_T34.Visible = false;
                checkBox_at_T34.Visible = false;
            }
        }

        private void checkBox_BT7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BT7.Checked)
            {
                button_T34.Visible = true;
                checkBox_T34.Visible = true;
                button_BT7.Visible = false;

                button_at_BT7.Visible = true;
                checkBox_at_BT7.Visible = true;
            }
            else
            {
                button_T34.Visible = false;
                checkBox_T34.Visible = false;

                button_at_BT7.Visible = false;
                checkBox_at_BT7.Visible = false;
            }
        }

        private void checkBox_KV1S_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox_KV1S.Checked)
            {
                button_KV1S.Visible = false;
                button_at_KV1S.Visible = true;
                checkBox_at_KV1S.Visible = true;

            }
            else
            {
                button_at_KV1S.Visible = false;
                checkBox_at_KV1S.Visible = false;

            }
        }

        private void checkBox_T150_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T150.Checked)
            {
                button_T150.Visible = false;
                button_at_T150.Visible = true;
                checkBox_at_T150.Visible = true;
            }
            else
            {
                button_at_T150.Visible = false;
                checkBox_at_T150.Visible = false;
            }
        }

        private void checkBox_at_T34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_T34.Checked)
                HideAllBut(groupBox_T34);
        }
        private void checkBox_T3485_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T3485.Checked)
            {
                button_T3485.Visible = false;
                button_at_T3485.Visible = true;
                checkBox_at_T3485.Visible = true;


            }
            else
            {
                button_at_T3485.Visible = false;
                checkBox_at_T3485.Visible = false;
            }
        }

        private void button_KV1_Click(object sender, EventArgs e)
        {
            if ((creditFlag_KV1 == 1) && (UM.Credits > 390000))
            {
                UM.Credits = UM.Credits - 390000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_KV1.Checked = true;
            }
            if ((creditFlag_KV1 == 0) && (UM.experience > 13500))
            {
                UM.experience = UM.experience - 13500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_KV1.Text = Convert.ToString(390000) + " Cred";
                creditFlag_KV1++;
            }
        }

        private void button_KV1S_Click(object sender, EventArgs e)
        {
            if ((creditFlag_KV1S == 1) && (UM.Credits > 910000))
            {
                UM.Credits = UM.Credits - 910000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_KV1S.Checked = true;
            }
            if ((creditFlag_KV1S == 0) && (UM.experience > 25650))
            {
                UM.experience = UM.experience - 25650;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_KV1S.Text = Convert.ToString(910000) + " Cred";
                creditFlag_KV1S++;
            }
        }

        private void button_BT7_Click(object sender, EventArgs e)
        {
            if ((creditFlag_BT7 == 1) && (UM.Credits > 137000))
            {
                UM.Credits = UM.Credits - 137000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_BT7.Checked = true;
            }
            if ((creditFlag_BT7 == 0) && (UM.experience > 3200))
            {
                UM.experience = UM.experience - 3200;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_BT7.Text = Convert.ToString(137000) + " Cred";
                creditFlag_BT7++;
            }
        }
        private void button_T34_Click(object sender, EventArgs e)
        {
            if ((creditFlag_T34 == 1) && (UM.Credits > 356700))
            {
                UM.Credits = UM.Credits - 3567000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_T34.Checked = true;
            }
            if ((creditFlag_T34 == 0) && (UM.experience > 11500))
            {
                UM.experience = UM.experience - 11500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_T34.Text = Convert.ToString(3567000) + " Cred";
                creditFlag_T34++;
            }
        }
        private void button_T3485_Click(object sender, EventArgs e)
        {
            if ((creditFlag_T3485 == 1) && (UM.Credits > 457500))
            {
                UM.Credits = UM.Credits - 457500;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                checkBox_T3485.Checked = true;
            }
            if ((creditFlag_T3485 == 0) && (UM.experience > 27825))
            {
                UM.experience = UM.experience - 27825;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_T3485.Text = Convert.ToString(457500) + " Cred";
                creditFlag_T3485++;
            }
        }

        private void button_at_BT5_Click(object sender, EventArgs e)
        {
            
            checkBox_at_BT5.Checked = true;
            checkBox_at_T28.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_T150.Checked = false;

        }
        private void button8_Click(object sender, EventArgs e)
        {

            checkBox_at_T150.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_BT5.Checked = false;
        }
        private void button_at_T28_Click(object sender, EventArgs e)
        {

            checkBox_at_T28.Checked = true;

            checkBox_at_BT5.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_T150.Checked = false;
            
        }

        private void button_at_BT7_Click(object sender, EventArgs e)
        {

            checkBox_at_BT7.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT5.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_T150.Checked = false;

            
        }

        private void button_at_KV1_Click(object sender, EventArgs e)
        {

            checkBox_at_KV1.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT5.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_T150.Checked = false;
        }

        private void button_at_T34_Click(object sender, EventArgs e)
        {

            checkBox_at_T34.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT5.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_T150.Checked = false;
        }

        private void button_at_KV1S_Click(object sender, EventArgs e)
        {


            checkBox_at_KV1S.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT5.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_T3485.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T150.Checked = false;
        }

        private void button_at_T3485_Click(object sender, EventArgs e)
        {

            
            checkBox_at_T3485.Checked = true;

            checkBox_at_T28.Checked = false;
            checkBox_at_BT5.Checked = false;
            checkBox_at_KV1.Checked = false;
            checkBox_at_KV1S.Checked = false;
            checkBox_at_BT7.Checked = false;
            checkBox_at_T34.Checked = false;
            checkBox_at_T150.Checked = false;
            
        }

        private void checkBox_at_BT7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_BT7.Checked)
            HideAllBut(groupBox_BT7);
        }

        private void checkBox_at_BT5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_BT5.Checked) {
                HideAllBut(groupBox_BT5);
            }
            
        }
        private void checkBox_at_T28_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_at_T28.Checked)
            HideAllBut(groupBox_T28);
        }
        private void HideAllBut(GroupBox groupToShow)
        {
            var groups = new[] { groupBox_BT5, groupBox_T28, groupBox_KV1, groupBox_KV1S, groupBox_T150, groupBox_T3485,groupBox_T34 , groupBox_BT7};

            foreach (var gb in groups)
            {
                gb.Visible = (gb == groupToShow);
            }
        }

        private void checkBox_at_KV1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_KV1.Checked)
                HideAllBut(groupBox_KV1);
        }

        private void checkBox_at_KV1S_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_KV1S.Checked)
                HideAllBut(groupBox_KV1S);
        }

        private void checkBox_at_T150_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_T150.Checked)
                HideAllBut(groupBox_T150);
        }

        private void checkBox_at_T3485_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at_T3485.Checked)
                HideAllBut(groupBox_T3485);
        }

        private void button45mm_20K_MouseHover(object sender, EventArgs e)
        {

        }


        int BT7ARMFLAG = 0;

        private void button_BT7ARM_Click(object sender, EventArgs e)
        {
            if ((BT7ARMFLAG == 1) && (UM.Credits > 3700))
            {
                UM.Credits = UM.Credits - 3700;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                buttonBT7_arm.Visible = false;
                buttonBT7_arm2.Visible = true;
                button_BT7ARM.Visible = false;

                armourDecorator.ChangeArmour(BT7ARM2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((BT7ARMFLAG == 0) && (UM.experience > 900))
            {
                UM.experience = UM.experience - 900;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_BT7ARM.Text = Convert.ToString(3700) + "Cred";
                BT7ARMFLAG++;
                
            }
        }
        int BT7CEFLAG = 0;
        private void button_BT7CE_Click(object sender, EventArgs e)
        {
            if ((BT7CEFLAG == 1) && (UM.Credits > 32000))
            {
                UM.Credits = UM.Credits - 32000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button_BT7CE.Visible = false;
                buttonBT7_CE2.Visible = true;
                buttonBT7_CE.Visible = false;
                crewequipmentDecorator.ChangeCrewEquipment(BT7CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((BT7CEFLAG == 0) && (UM.experience > 1500))
            {
                UM.experience = UM.experience - 1500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_BT7CE.Text = Convert.ToString(32000) + "Cred";
                BT7CEFLAG++;

            }
        }
        int BT7TEFLAG = 0;
        private void button_BT7TE_Click(object sender, EventArgs e)
        {
            if ((BT7TEFLAG == 1) && (UM.Credits > 15000))
            {
                UM.Credits = UM.Credits - 15000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                buttonBT7_TE.Visible = false;
                button_BT7TE.Visible = false;
                buttonBT7_TE2.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(BT7TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((BT7TEFLAG == 0) && (UM.experience > 900))
            {
                UM.experience = UM.experience - 900;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_BT7CE.Text = Convert.ToString(15000) + "Cred";
                BT7TEFLAG++;

            }
        }
        int BT7TRACKFLAG = 0;
        private void button_BT7TRACK_Click(object sender, EventArgs e)
        {
            if ((BT7TRACKFLAG == 1) && (UM.Credits > 15000))
            {
                UM.Credits = UM.Credits - 15000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                buttonBT7_track.Visible = false;
                button_BT7TRACK.Visible = false;
                buttonBT7_track2.Visible = true;


                trackDecorator.ChangeTrack(BT7TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((BT7TRACKFLAG == 0) && (UM.experience > 700))
            {
                UM.experience = UM.experience - 700;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button_BT7CE.Text = Convert.ToString(15000) + "Cred";
                BT7TRACKFLAG++;
            }
        }
        int T3485GUNFLAG = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((T3485GUNFLAG == 1) && (UM.Credits > 62000))
            {
                UM.Credits = UM.Credits - 62000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button5.Visible = false;
                button1.Visible = false;
                button10.Visible = true;
                gunDecorator.ChangeGun(T3485GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
                //textBox1.Text = "jestem tu";


            }
            if ((T3485GUNFLAG == 0) && (UM.experience > 4800))
            {
                UM.experience = UM.experience - 4800;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button1.Text = Convert.ToString(62000) + "Cred";
                T3485GUNFLAG++;
            }
        }
        int T3485CEFLAG = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if ((T3485CEFLAG == 1) && (UM.Credits > 25000))
            {
                UM.Credits = UM.Credits - 25000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button2.Visible = false;
                button7.Visible = false;
                button11.Visible = true;
                crewequipmentDecorator.ChangeCrewEquipment(T3485CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T3485CEFLAG == 0) && (UM.experience > 4000))
            {
                UM.experience = UM.experience - 4000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button2.Text = Convert.ToString(25000) + "Cred";
                T3485CEFLAG++;
            }
        }
        int T3485TEFLAG = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if ((T3485TEFLAG == 1) && (UM.Credits > 30000))
            {
                UM.Credits = UM.Credits - 30000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button3.Visible = false;
                button8.Visible = false;
                button12.Visible = true;
                tankequipmentDecorator.ChangeTankEquipment(T3485TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((T3485TEFLAG == 0) && (UM.experience > 6200))
            {
                UM.experience = UM.experience - 6200;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button3.Text = Convert.ToString(30000) + "Cred";
                T3485TEFLAG++;
            }
        }
        int T3485TRACKFLAG = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if ((T3485TRACKFLAG == 1) && (UM.Credits > 12000))
            {
                UM.Credits = UM.Credits - 12000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button4.Visible = false;
                button9.Visible = false;
                button13.Visible = true;
                trackDecorator.ChangeTrack(T3485TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);


            }
            if ((T3485TRACKFLAG == 0) && (UM.experience > 3000))
            {
                UM.experience = UM.experience - 3000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button4.Text = Convert.ToString(12000) + "Cred";
                T3485TRACKFLAG++;
            }
        }
        int T34GUNFLAG = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            if ((T34GUNFLAG == 1) && (UM.Credits > 30000))
            {
                UM.Credits = UM.Credits - 30000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button14.Visible = false;
                button23.Visible = false;
                button24.Visible = true;

                gunDecorator.ChangeGun(T34GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((T34GUNFLAG == 0) && (UM.experience > 2000))
            {
                UM.experience = UM.experience - 2000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button14.Text = Convert.ToString(30000) + "Cred";
                T34GUNFLAG++;
            }
        }
        int T34CEFLAG = 0;
        private void button15_Click(object sender, EventArgs e)
        {

            if ((T34CEFLAG == 1) && (UM.Credits > 25000))
            {
                UM.Credits = UM.Credits - 25000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button15.Visible = false;
                button21.Visible = false;
                button25.Visible = true;

                crewequipmentDecorator.ChangeCrewEquipment(T34CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T34CEFLAG == 0) && (UM.experience > 4000))
            {
                UM.experience = UM.experience - 4000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button15.Text = Convert.ToString(25000) + "Cred";
                T34CEFLAG++;
            }
        }
        int T34TEFLAG = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            if ((T34TEFLAG == 1) && (UM.Credits > 30000))
            {
                UM.Credits = UM.Credits - 30000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button19.Visible = false;
                button16.Visible = false;
                button26.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(T3485TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T34TEFLAG == 0) && (UM.experience > 5000))
            {
                UM.experience = UM.experience - 5000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button16.Text = Convert.ToString(30000) + "Cred";
                T34TEFLAG++;
            }
        }
        int T34TRACKFLAG = 0;
        private void button17_Click(object sender, EventArgs e)
        {
            if ((T34TRACKFLAG == 1) && (UM.Credits > 8000))
            {
                UM.Credits = UM.Credits - 8000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button20.Visible = false;
                button17.Visible = false;
                button27.Visible = true;

                trackDecorator.ChangeTrack(T34TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T34TRACKFLAG == 0) && (UM.experience > 2000))
            {
                UM.experience = UM.experience - 2000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button17.Text = Convert.ToString(8000) + "Cred";
                T34TRACKFLAG++;
            }
        }
        int BT5GUNFLAG = 0;
        private void button18_Click(object sender, EventArgs e)
        {
            if ((BT5GUNFLAG == 1) && (UM.Credits > 4000))
            {
                UM.Credits = UM.Credits - 4000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button18.Visible = false;
                button33.Visible = false;
                button42.Visible = true;

                gunDecorator.ChangeGun(BT5GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((BT5GUNFLAG == 0) && (UM.experience > 100))
            {
                UM.experience = UM.experience - 100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button18.Text = Convert.ToString(4000) + "Cred";
                BT5GUNFLAG++;
            }
        }
        int BT5ARMNFLAG = 0;
        private void button28_Click(object sender, EventArgs e)
        {
            if ((BT5ARMNFLAG == 1) && (UM.Credits > 5000))
            {
                UM.Credits = UM.Credits - 5000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button28.Visible = false;
                button34.Visible = false;
                button41.Visible = true;
                armourDecorator.ChangeArmour(BT5ARM2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((BT5ARMNFLAG == 0) && (UM.experience > 300))
            {
                UM.experience = UM.experience - 300;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button28.Text = Convert.ToString(5000) + "Cred";
                BT5ARMNFLAG++;
            }
        }
        int BT5CEFLAG = 0;
        private void button29_Click(object sender, EventArgs e)
        {
            if ((BT5CEFLAG == 1) && (UM.Credits > 6000))
            {
                UM.Credits = UM.Credits - 6000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button29.Visible = false;
                button35.Visible = false;
                button40.Visible = true;

                crewequipmentDecorator.ChangeCrewEquipment(BT5CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((BT5CEFLAG == 0) && (UM.experience > 400))
            {
                UM.experience = UM.experience - 400;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button29.Text = Convert.ToString(6000) + "Cred";
                BT5CEFLAG++;
            }
        }
        int BT5TEFLAG = 0;
        private void button30_Click(object sender, EventArgs e)
        {
            if ((BT5TEFLAG == 1) && (UM.Credits > 5000))
            {
                UM.Credits = UM.Credits - 5000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button30.Visible = false;
                button36.Visible = false;
                button39.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(BT5TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((BT5TEFLAG == 0) && (UM.experience > 500))
            {
                UM.experience = UM.experience - 500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button30.Text = Convert.ToString(5000) + "Cred";
                BT5TEFLAG++;
            }
        }
        int BT5TRACKFLAG = 0;
        private void button31_Click(object sender, EventArgs e)
        {
            if ((BT5TRACKFLAG == 1) && (UM.Credits > 2000))
            {
                UM.Credits = UM.Credits - 2000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button37.Visible = false;
                button31.Visible = false;
                button38.Visible = true;

                trackDecorator.ChangeTrack(BT5TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((BT5TRACKFLAG == 0) && (UM.experience > 100))
            {
                UM.experience = UM.experience - 100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button31.Text = Convert.ToString(5000) + "Cred";
                BT5TRACKFLAG++;
            }
        }
        int T28GUNFLAG = 0;
        private void button32_Click(object sender, EventArgs e)
        {
            if ((T28GUNFLAG == 1) && (UM.Credits > 11000))
            {
                UM.Credits = UM.Credits - 11000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button51.Visible = false;
                button32.Visible = false;
                button57.Visible = true;

                gunDecorator.ChangeGun(T28GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T28GUNFLAG == 0) && (UM.experience > 1500))
            {
                UM.experience = UM.experience - 1500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button32.Text = Convert.ToString(11000) + "Cred";
                T28GUNFLAG++;
            }
        }
        int T28ARMFLAG = 0;
        private void button43_Click(object sender, EventArgs e)
        {
            if ((T28ARMFLAG == 1) && (UM.Credits > 13000))
            {
                UM.Credits = UM.Credits - 13000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button50.Visible = false;
                button43.Visible = false;
                button56.Visible = true;

                armourDecorator.ChangeArmour(T28ARM2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T28ARMFLAG == 0) && (UM.experience > 1200))
            {
                UM.experience = UM.experience - 1200;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button43.Text = Convert.ToString(13000) + "Cred";
                T28ARMFLAG++;
            }
        }
        int T28CEFLAG = 0;
        private void button44_Click(object sender, EventArgs e)
        {
            if ((T28CEFLAG == 1) && (UM.Credits > 14000))
            {
                UM.Credits = UM.Credits - 14000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button49.Visible = false;
                button44.Visible = false;
                button55.Visible = true;

                crewequipmentDecorator.ChangeCrewEquipment(T28CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T28CEFLAG == 0) && (UM.experience > 1300))
            {
                UM.experience = UM.experience - 1300;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button44.Text = Convert.ToString(14000) + "Cred";
                T28CEFLAG++;
            }
        }
        int T28TEFLAG = 0;
        private void button45_Click(object sender, EventArgs e)
        {
            if ((T28TEFLAG == 1) && (UM.Credits > 16000))
            {
                UM.Credits = UM.Credits - 16000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button48.Visible = false;
                button45.Visible = false;
                button54.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(T28TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);

            }
            if ((T28TEFLAG == 0) && (UM.experience > 1700))
            {
                UM.experience = UM.experience - 1700;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button45.Text = Convert.ToString(16000) + "Cred";
                T28TEFLAG++;
            }
        }
        int T28TRACKFLAG = 0;
        private void button46_Click(object sender, EventArgs e)
        {
            if ((T28TRACKFLAG == 1) && (UM.Credits > 16000))
            {
                UM.Credits = UM.Credits - 16000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button52.Visible = false;
                button46.Visible = false;
                button53.Visible = true;

                trackDecorator.ChangeTrack(T28TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T28TRACKFLAG == 0) && (UM.experience > 900))
            {
                UM.experience = UM.experience - 900;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button46.Text = Convert.ToString(16000) + "Cred";
                T28TRACKFLAG++;
            }
        }
        int T150GUNFLAG = 0;
        private void button66_Click(object sender, EventArgs e)
        {
            if ((T150GUNFLAG == 1) && (UM.Credits > 49000))
            {
                UM.Credits = UM.Credits - 49000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button60.Visible = false;
                button66.Visible = false;
                button61.Visible = true;

                gunDecorator.ChangeGun(T150GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T150GUNFLAG == 0) && (UM.experience > 4500))
            {
                UM.experience = UM.experience - 4500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button66.Text = Convert.ToString(49000) + "Cred";
                T150GUNFLAG++;
            }
        }
        int T150CEFLAG = 0;
        private void button67_Click(object sender, EventArgs e)
        {
            if ((T150CEFLAG == 1) && (UM.Credits > 35000))
            {
                UM.Credits = UM.Credits - 35000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button47.Visible = false;
                button67.Visible = false;
                button62.Visible = true;

                crewequipmentDecorator.ChangeCrewEquipment(T150CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T150CEFLAG == 0) && (UM.experience > 3200))
            {
                UM.experience = UM.experience - 3200;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button67.Text = Convert.ToString(35000) + "Cred";
                T150CEFLAG++;
            }
        }
        int T150TEFLAG = 0;
        private void button68_Click(object sender, EventArgs e)
        {
            if ((T150TEFLAG == 1) && (UM.Credits > 38000))
            {
                UM.Credits = UM.Credits - 38000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button58.Visible = false;
                button68.Visible = false;
                button63.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(T150TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T150TEFLAG == 0) && (UM.experience > 5500))
            {
                UM.experience = UM.experience - 5500;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button68.Text = Convert.ToString(38000) + "Cred";
                T150TEFLAG++;
            }
        }
        int T150TRACKFLAG = 0;
        private void button69_Click(object sender, EventArgs e)
        {
            if ((T150TRACKFLAG == 1) && (UM.Credits > 24000))
            {
                UM.Credits = UM.Credits - 24000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button64.Visible = false;
                button69.Visible = false;
                button65.Visible = true;

                trackDecorator.ChangeTrack(T150TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((T150TRACKFLAG == 0) && (UM.experience > 2600))
            {
                UM.experience = UM.experience - 2600;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button69.Text = Convert.ToString(24000) + "Cred";
                T150TRACKFLAG++;
            }
        }
        int KV1GUNFLAG = 0;
        private void button70_Click(object sender, EventArgs e)
        {
            if ((KV1GUNFLAG == 1) && (UM.Credits > 24000))
            {
                UM.Credits = UM.Credits - 24000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button74.Visible = false;
                button70.Visible = false;
                button76.Visible = true;

                gunDecorator.ChangeGun(KV1GUN2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((KV1GUNFLAG == 0) && (UM.experience > 2300))
            {
                UM.experience = UM.experience - 2300;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button70.Text = Convert.ToString(24000) + "Cred";
                KV1GUNFLAG++;
            }
        }
        int KV1ARMFLAG = 0;
        private void button90_Click(object sender, EventArgs e)
        {
            if ((KV1ARMFLAG == 1) && (UM.Credits > 28000))
            {
                UM.Credits = UM.Credits - 28000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button73.Visible = false;
                button90.Visible = false;
                button77.Visible = true;


                armourDecorator.ChangeArmour(KV1ARM2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((KV1ARMFLAG == 0) && (UM.experience > 2600))
            {
                UM.experience = UM.experience - 2600;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button90.Text = Convert.ToString(28000) + "Cred";
                KV1ARMFLAG++;
            }
        }
        int KV1CEFLAG = 0;
        private void button91_Click(object sender, EventArgs e)
        {
            if ((KV1CEFLAG == 1) && (UM.Credits > 32000))
            {
                UM.Credits = UM.Credits - 32000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button72.Visible = false;
                button91.Visible = false;
                button78.Visible = true;

                crewequipmentDecorator.ChangeCrewEquipment(KV1CE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((KV1CEFLAG == 0) && (UM.experience > 3100))
            {
                UM.experience = UM.experience - 3100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button91.Text = Convert.ToString(32000) + "Cred";
                KV1CEFLAG++;
            }
        }
        int KV1TEFLAG = 0;
        private void button92_Click(object sender, EventArgs e)
        {
            if ((KV1TEFLAG == 1) && (UM.Credits > 26000))
            {
                UM.Credits = UM.Credits - 26000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button71.Visible = false;
                button92.Visible = false;
                button79.Visible = true;

                tankequipmentDecorator.ChangeTankEquipment(KV1TE2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((KV1TEFLAG == 0) && (UM.experience > 1900))
            {
                UM.experience = UM.experience - 1900;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button92.Text = Convert.ToString(26000) + "Cred";
                KV1TEFLAG++;
            }
        }
        int KV1TRACKFLAG = 0;
        private void button98_Click(object sender, EventArgs e)
        {
            if ((KV1TRACKFLAG == 1) && (UM.Credits > 18000))
            {
                UM.Credits = UM.Credits - 18000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button98.Visible = false;
                button99.Visible = false;
                button80.Visible = true;

                trackDecorator.ChangeTrack(KV1TRACK2);
                textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
                textBox_Hp.Text = Convert.ToString(tank.calculateHP());
                textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            }
            if ((KV1TRACKFLAG == 0) && (UM.experience > 1100))
            {
                UM.experience = UM.experience - 1100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button98.Text = Convert.ToString(18000) + "Cred";
                KV1TRACKFLAG++;
            }
        }
        int KVS1GUNFLAG = 0;
        private void button97_Click(object sender, EventArgs e)
        {
            if ((KVS1GUNFLAG == 1) && (UM.Credits > 37000))
            {
                UM.Credits = UM.Credits - 37000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button97.Visible = false;
                button81.Visible = false;
                button85.Visible = true;

            }
            if ((KVS1GUNFLAG == 0) && (UM.experience > 4300))
            {
                UM.experience = UM.experience - 4300;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button97.Text = Convert.ToString(37000) + "Cred";
                KVS1GUNFLAG++;
            }
        }
        int KVS1ARMFLAG = 0;
        private void button93_Click(object sender, EventArgs e)
        {
            if ((KVS1ARMFLAG == 1) && (UM.Credits > 39000))
            {
                UM.Credits = UM.Credits - 39000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button82.Visible = false;
                button93.Visible = false;
                button86.Visible = true;
            }
            if ((KVS1ARMFLAG == 0) && (UM.experience > 4100))
            {
                UM.experience = UM.experience - 4100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button93.Text = Convert.ToString(39000) + "Cred";
                KVS1ARMFLAG++;
            }
        }
        
        int KVS1CEFLAG = 0;
        private void button94_Click(object sender, EventArgs e)
        {
            if ((KVS1CEFLAG == 1) && (UM.Credits > 43000))
            {
                UM.Credits = UM.Credits - 43000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button83.Visible = false;
                button94.Visible = false;
                button87.Visible = true;
            }
            if ((KVS1CEFLAG == 0) && (UM.experience > 4000))
            {
                UM.experience = UM.experience - 4000;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button94.Text = Convert.ToString(43000) + "Cred";
                KVS1CEFLAG++;
            }
        }
        int KVS1TEFLAG = 0;
        private void button95_Click(object sender, EventArgs e)
        {
            if ((KVS1TEFLAG == 1) && (UM.Credits > 34000))
            {
                UM.Credits = UM.Credits - 34000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button75.Visible = false;
                button95.Visible = false;
                button88.Visible = true;
            }
            if ((KVS1TEFLAG == 0) && (UM.experience > 3300))
            {
                UM.experience = UM.experience - 3300;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button95.Text = Convert.ToString(34000) + "Cred";
                KVS1TEFLAG++;
            }
        }
        int KVS1TRACKFLAG = 0;
        private void button96_Click(object sender, EventArgs e)
        {
            if ((KVS1TRACKFLAG == 1) && (UM.Credits > 32000))
            {
                UM.Credits = UM.Credits - 32000;
                textBox_credits.Text = Convert.ToString(UM.Credits);
                button84.Visible = false;
                button96.Visible = false;
                button89.Visible = true;
            }
            if ((KVS1TRACKFLAG == 0) && (UM.experience > 3100))
            {
                UM.experience = UM.experience - 3100;
                textBox_experience.Text = Convert.ToString(UM.experience);
                button96.Text = Convert.ToString(32000) + "Cred";
                KVS1TRACKFLAG++;
            }
        }

        private void Battle_button_Click(object sender, EventArgs e)
        {
            BattleTank opponent = TankFactory.CreateBattleTank();
            groupBox_garage.Visible = false;
            groupBox_research.Visible = false;
            groupBox_battle.Visible = true;
            textBox3.Text = Convert.ToString(opponent.calculateHP());
            textBox2.Text = Convert.ToString(tank.calculateHP());

        }

        private void button100_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button100_Click_1(object sender, EventArgs e)
        {
            textBox_Damage.Text = Convert.ToString(Math.Round(tank.calculateDamage(), 0));
            textBox_Hp.Text = Convert.ToString(tank.calculateHP());
            textBox_CrewExp.Text = Convert.ToString(gunner.Experience);
            //textBox1.Text = tank.Gun.GetInfo();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            
        }

        private void button_tower_Click(object sender, EventArgs e)
        {

        }

        private void buttongarage_Click(object sender, EventArgs e)
        {
            groupBox_garage.Visible = true;
            groupBox_battle.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttongarage_Click_1(object sender, EventArgs e)
        {

        }

        private void button_research_Click_1(object sender, EventArgs e)
        {

        }

        private void button_BT7ARM_Click_1(object sender, EventArgs e)
        {

        }

        private void button_at_BT7_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
//Gunner gunner = new Gunner("john", 75, false);
//Commander commander = new Commander("marcin", 75, false, false, false);
//Reloader reloader = new Reloader("mecenas", 75);
//HighExplosiveShell highExplosiveShell = new HighExplosiveShell("BT-5HESH", 5, 30, 800, 1000, 0);
//ArmorPiercing armorPiercing = new ArmorPiercing(25, 70, 900, 600, 0, "BT-5AP");




//Gun BT5GUN1 = new Gun(55, 45, 46, 250, "BT5GUN1");
//TankEquipment BT5TE1 = new TankEquipment(410, "BT5TE1", 80);
//CrewEquipment BT5CE1 = new CrewEquipment(100, "BT5CE1", 80);
//Track BT5TRACK1 = new Track(3300, "BT5TRACK1", 11800);
//Armour BT5ARM1 = new Armour(35, 40, 15, 5000, "BT5ARM1");
////BT5
//Gun BT5GUN2 = new Gun(65, 55, 43, 250, "BT5GUN2");
//TankEquipment BT5TE2 = new TankEquipment(410, "BT5TE2", 90);
//CrewEquipment BT5CE2 = new CrewEquipment(100, "BT5CE2", 90);
//Track BT5TRACK2 = new Track(3300, "BT5TRACK2", 11800);
//Armour BT5ARM2 = new Armour(45, 60, 20, 5000, "BT5ARM2");



//Gun BT7GUN1 = new Gun(65, 55, 43, 250, "BT7GUN1");
//TankEquipment BT7TE1 = new TankEquipment(410, "BT7TE1", 80);
//CrewEquipment BT7CE1 = new CrewEquipment(100, "BT7CE1", 80);
//Track BT7TRACK1 = new Track(3300, "BT5TRACK1", 11800);
//Armour BT7ARM1 = new Armour(45, 60, 20, 5000, "BT7ARM1");
////BT7
//Gun BT7GUN2 = new Gun(75, 65, 41, 250, "BT7GUN2");
//TankEquipment BT7TE2 = new TankEquipment(410, "BT7TE2", 90);
//CrewEquipment BT7CE2 = new CrewEquipment(100, "BT7CE2", 90);
//Track BT7TRACK2 = new Track(3300, "BT7TRACK2", 11800);
//Armour BT7ARM2 = new Armour(55, 70, 25, 5000, "BT7ARM2");



//Gun T28GUN1 = new Gun(75, 65, 43, 250, "T28GUN1");
//TankEquipment T28TE1 = new TankEquipment(410, "T28TE1", 80);
//CrewEquipment T28CE1 = new CrewEquipment(100, "T28CE1", 80);
//Track T28TRACK1 = new Track(3300, "T28TRACK1", 11800);
//Armour T28ARM1 = new Armour(55, 60, 25, 5000, "T28ARM1");
////T28
//Gun T28GUN2 = new Gun(80, 70, 41, 250, "T28GUN2");
//TankEquipment T28TE2 = new TankEquipment(410, "T28TE2", 80);
//CrewEquipment T28CE2 = new CrewEquipment(100, "T28CE2", 80);
//Track T28TRACK2 = new Track(3300, "T28TRACK2", 11800);
//Armour T28ARM2 = new Armour(60, 70, 30, 5000, "T28ARM2");



//Gun KV1GUN1 = new Gun(80, 70, 46, 250, "KV1GUN1");
//TankEquipment KV1TE1 = new TankEquipment(410, "KV1TE1", 80);
//CrewEquipment KV1CE1 = new CrewEquipment(100, "KV1CE1", 80);
//Track KV1TRACK1 = new Track(3300, "T28TRACK1", 11800);
//Armour KV1ARM1 = new Armour(70, 80, 40, 5000, "KV1ARM1");
////KV1 
//Gun KV1GUN2 = new Gun(85, 74, 45, 250, "KV1GUN2");
//TankEquipment KV1TE2 = new TankEquipment(410, "KV1TE2", 80);
//CrewEquipment KV1CE2 = new CrewEquipment(100, "KV1CE2", 80);
//Track KV1TRACK2 = new Track(3300, "KV1TRACK2", 11800);
//Armour KV1ARM2 = new Armour(100, 100, 45, 5000, "KV1ARM2");



//Gun KV1SGUN1 = new Gun(100, 105, 46, 250, "KV1SGUN1");
//TankEquipment KV1STE1 = new TankEquipment(410, "KV1STE1", 80);
//CrewEquipment KV1SCE1 = new CrewEquipment(100, "KV1SCE1", 80);
//Track KV1STRACK1 = new Track(3300, "KV1STRACK1", 11800);
//Armour KV1SARM1 = new Armour(120, 110, 50, 5000, "KV1SARM1");
////KV1S
//Gun KV1SGUN2 = new Gun(120, 115, 43, 250, "KV1SGUN2");
//TankEquipment KV1STE2 = new TankEquipment(410, "KV1STE2", 80);
//CrewEquipment KV1SCE2 = new CrewEquipment(100, "KV1SCE2", 80);
//Track KV1STRACK2 = new Track(3300, "KV1STRACK2", 11800);
//Armour KV1SARM2 = new Armour(130, 130, 55, 5000, "KV1SARM2");



//Gun T150GUN1 = new Gun(120, 105, 44, 250, "T150GUN1");
//TankEquipment T150TE1 = new TankEquipment(410, "T150TE1", 80);
//CrewEquipment T150CE1 = new CrewEquipment(100, "T150CE1", 80);
//Track T150TRACK1 = new Track(3300, "T150TRACK1", 11800);
//Armour T150ARM1 = new Armour(110, 110, 40, 5000, "T150ARM1");
////T150
//Gun T150GUN2 = new Gun(130, 110, 42, 250, "T150GUN2");
//TankEquipment T150TE2 = new TankEquipment(410, "T150TE2", 80);
//CrewEquipment T150CE2 = new CrewEquipment(100, "T150CE2", 80);
//Track T150TRACK2 = new Track(3300, "T150TRACK2", 11800);
//Armour T150ARM2 = new Armour(120, 120, 45, 5000, "T150ARM2");



//Gun T34GUN1 = new Gun(140, 100, 46, 250, "T34GUN1");
//TankEquipment T34TE1 = new TankEquipment(410, "T34TE1", 80);
//CrewEquipment T34CE1 = new CrewEquipment(100, "T34CE1", 80);
//Track T34TRACK1 = new Track(3300, "T34TRACK1", 11800);
//Armour T34ARM1 = new Armour(50, 60, 25, 5000, "T34ARM1");
////T34
//Gun T34GUN2 = new Gun(150, 110, 41, 250, "T34GUN2");
//TankEquipment T34TE2 = new TankEquipment(410, "T34TE2", 80);
//CrewEquipment T34CE2 = new CrewEquipment(100, "T34CE2", 80);
//Track T34TRACK2 = new Track(3300, "T34TRACK2", 11800);
//Armour T34ARM2 = new Armour(60, 80, 30, 5000, "T34ARM2");



//Gun T3485GUN1 = new Gun(55, 45, 46, 250, "T3485GUN1");
//TankEquipment T3485TE1 = new TankEquipment(410, "T3485TE1", 80);
//CrewEquipment T3485CE1 = new CrewEquipment(100, "T3485CE1", 80);
//Track T3485TRACK1 = new Track(3300, "T28TRACK1", 11800);
//Armour T3485ARM1 = new Armour(35, 40, 15, 5000, "T3485ARM1");
////T3485
//Gun T3485GUN2 = new Gun(55, 45, 46, 250, "T3485GUN2");
//TankEquipment T3485TE2 = new TankEquipment(410, "T3485TE2", 80);
//CrewEquipment T3485CE2 = new CrewEquipment(100, "T3485CE2", 80);
//Track T3485TRACK2 = new Track(3300, "T3485TRACK2", 11800);
//Armour T3485ARM2 = new Armour(35, 40, 15, 5000, "T3485ARM2");





//BattleTank tank = new BattleTank(BT5GUN1, BT5ARM1, BT5TE1, BT5CE1, BT5TRACK1, armorPiercing, highExplosiveShell, gunner, commander, reloader);
//TankEquipmentChangeDecorator tankequipmentDecorator = new TankEquipmentChangeDecorator(tank);
//GunChangeDecorator gunDecorator = new GunChangeDecorator(tank);
//CrewEquipmentChangeDecorator crewequipmentDecorator = new CrewEquipmentChangeDecorator(tank);
//ArmourChangeDecorator armourDecorator = new ArmourChangeDecorator(tank);
//TrackChangeDecorator trackDecorator = new TrackChangeDecorator(tank);