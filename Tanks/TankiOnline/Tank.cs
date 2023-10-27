using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksLib.TankiOnline
{
    public class Tank
    {
        private string tankName;
        private int ammunitionLevel;
        private int armorLevel;
        private int mobilityLevel;

        public Tank(string name)
        {
            tankName = name;
            Random random = new Random();


            ammunitionLevel = random.Next(101);
            armorLevel = random.Next(101);
            mobilityLevel = random.Next(101);
        }


        public string GetTankParameters()// Метод для получения параметров танка в виде строки
        {
            return $"Tank: {tankName}\nAmmunition Level: {ammunitionLevel}%\nArmor Level: {armorLevel}%\nMobility Level: {mobilityLevel}%";
        }


        public static bool operator ^(Tank tank1, Tank tank2)// Перегрузка оператора "^" для проверки победы в бою
        {
            int winCriteria = 0;

            if (tank1.ammunitionLevel > tank2.ammunitionLevel) winCriteria++;
            if (tank1.armorLevel > tank2.armorLevel) winCriteria++;
            if (tank1.mobilityLevel > tank2.mobilityLevel) winCriteria++;

            return winCriteria >= 2;
        }
        public static bool operator ==(Tank tank1, Tank tank2)
        {
            if (ReferenceEquals(tank1, null) && ReferenceEquals(tank2, null))
            {
                return true;
            }
            if (ReferenceEquals(tank1, null) || ReferenceEquals(tank2, null))
            {
                return false;
            }

            return tank1.tankName == tank2.tankName && tank1.ammunitionLevel == tank2.ammunitionLevel && tank1.armorLevel == tank2.armorLevel && tank1.mobilityLevel == tank2.mobilityLevel;
        }


        public static bool operator !=(Tank tank1, Tank tank2)// Перегрузка оператора !=
        {
            return !(tank1 == tank2);
        }


        public override bool Equals(object obj)// Переопределение метода Equals
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Tank other = (Tank)obj;
            return tankName == other.tankName && ammunitionLevel == other.ammunitionLevel && armorLevel == other.armorLevel && mobilityLevel == other.mobilityLevel;
        }


        public override int GetHashCode()// Переопределение метода GetHashCode (рекомендуется при переопределении Equals)
        {
            return tankName.GetHashCode() ^ ammunitionLevel.GetHashCode() ^ armorLevel.GetHashCode() ^ mobilityLevel.GetHashCode();
        }
    }

}

