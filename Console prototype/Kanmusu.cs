using System;
using Console_prototype.DB;

//using System.Data.Common;
//using System.Net.Mail;

namespace Console_prototype
{
    public delegate void NormalAttackHandler(int otherHp, int otherArmour);



    public  class Kanmusu:IEquatable<Kanmusu>
    {
        
        public KanmusuClass Class { get; set; }

        public string Name { get; }

        public int Hp { get; set; }

        public int Armour { get; set; }

        public int Speed { get; set; }

        public int FirePower { get; set; }

        public int Torpedo { get; set; }

        public int Aircraft { get; set; }

        public int AttackNum { get; set; }


        private readonly int _hpBase;
        private readonly int _armourBase;
        private readonly int _speedBase;
        private readonly int _firePowerBase;
        private readonly int _torpedoBase;
        private readonly int _aircraftBase;
        private readonly int _attackNumBase;


        public Kanmusu(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(Name));

            //var kanmusuData = new KanmusuData();
            var type = KanmusuData.GetTypeFromName(name);
            Class = KanmusuData.GetClassData(type);

            var stats = KanmusuData.GetStatsFromType(type);
            if (stats != null)  
            {
                _hpBase =  stats.Hp;
                _armourBase = stats.Armour;
                _speedBase = stats.Speed;
                _firePowerBase = stats.FirePower;
                _torpedoBase = stats.Torpedo;
                _aircraftBase = stats.Aircraft;
                _attackNumBase = stats.AttackNum;
            }
  
            ResetStats();
        }


        private void ResetStats()
        {
            Hp = _hpBase;
            Armour = _armourBase;
            Speed = _speedBase;
            FirePower = _firePowerBase;
            Torpedo = _torpedoBase;
            Aircraft = _aircraftBase;
            AttackNum = _attackNumBase;
        }


        public bool Equals(Kanmusu other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name;
        }
        

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Kanmusu) obj);
        }


  

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    
}