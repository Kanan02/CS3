
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyClassLib.WordOfTanks
{
    
    class Tank
    {
     
        
        public string Name { get; set; }
       
        public int AmmunitionLevel { get; set; }
        public int Armor { get; set; }
        public int Maneuverability { get; set; }
        
        
        public Tank(string name)
        {
            Random random = new Random();
            AmmunitionLevel =random.Next(0,100);
            Armor = random.Next(0, 100);
            Maneuverability = random.Next(0, 100);
            Thread.Sleep(10);
            Name = name;
            
        }

        public static string operator *(Tank t1,Tank t2)
        {
            
            string str = "\t\tBattle!\n";

            str += $"   {t1.Name}                       {t2.Name}\n";
            str += $"AmmunitionLevel:{t1.AmmunitionLevel}        AmmunitonLevel:{t2.AmmunitionLevel}\n";
            str += $"Armor:{t1.Armor}                  Armor:{t2.Armor}\n";
            str += $"Maneuverability:{t1.Maneuverability}        Maneuverability:{t2.Maneuverability}\n";
           
            if (t1.AmmunitionLevel > t2.AmmunitionLevel && t1.Armor > t2.Armor) str += $"\t\t{t1.Name} wins.\n";
            else if (t1.AmmunitionLevel > t2.AmmunitionLevel && t1.Maneuverability > t2.Maneuverability) str += $"\t\t{t1.Name} wins.\n";
            else if (t1.Maneuverability > t2.Maneuverability && t1.Armor > t2.Armor) str += $"\t\t{t1.Name} wins.\n";
            else if (t1.AmmunitionLevel < t2.AmmunitionLevel && t1.Armor < t2.Armor) str += $"\t\t{t2.Name} wins.\n";
            else if (t1.AmmunitionLevel < t2.AmmunitionLevel && t1.Maneuverability < t2.Maneuverability) str += $"\t\t{t2.Name} wins.\n";
            else if (t1.Maneuverability < t2.Maneuverability && t1.Armor < t2.Armor) str += $"\t\t{t2.Name} wins.\n";
            else str+= "\t\tDraw!\n";
            str += "------------------------------------\n";
            return str;

        }
        public override string ToString()
        {
            return $"Name: {Name}\nAmmunition Level: {AmmunitionLevel}\nArmor: {Armor}\nManeuverability: {Maneuverability}\n"; ;
        }


    }
}
