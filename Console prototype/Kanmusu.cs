using System;
using Console_prototype.DB;

//using System.Data.Common;
//using System.Net.Mail;

namespace Console_prototype
{
    public  class Kanmusu:IEquatable<Kanmusu>
    {
        public KanmusuClass Class => _class;
        

        public string Name => _name;

        public int Hp
        {
            get => _hp;
            set => _hp = value;
        }

        public int Armour
        {
            get => _armour;
            set => _armour = value;
        }

        public int Speed
        {
            get => _speed;
            set => _speed = value;
        }

        public int FirePower
        {
            get => _firePower;
            set => _firePower = value;
        }

        public int Torpedo
        {
            get => _torpedo;
            set => _torpedo = value;
        }

        public int Aircraft
        {
            get => _aircraft;
            set => _aircraft = value;
        }

        public int AttackNum
        {
            get => _attackNum;
            set => _attackNum = value;
        }

        private readonly int _hpBase;
        private readonly int _armourBase;
        private readonly int _speedBase;
        private readonly int _firePowerBase;
        private readonly int _torpedoBase;
        private readonly int _aircraftBase;
        private readonly KanmusuClass _class;
        private readonly int _attackNumBase;
        private readonly string _name;

        private int _hp;
        private int _armour;
        private int _speed;
        private int _firePower;
        private int _torpedo;
        private int _aircraft;
        private int _attackNum;
        
        private const int MinAttack = 1;


        public Kanmusu(string name)
        {
            _name = name;
            var type = KanmusuData.GetTypeFromName(name);
            var stats = KanmusuData.GetStatsFromType(type);
            if (stats != null)
            {
                _hpBase =  stats.Hp;
                _armourBase = stats.Armour;
                _speedBase = stats.Speed;
                _firePowerBase = stats.FirePower;
                _torpedoBase = stats.Torpedo;
                _aircraftBase = stats.Aircraft;
                _class = KanmusuData.GetClassData(type);
                _attackNumBase = stats.AttackNum;
            }
  
            ResetStats();
        }

        private void ResetStats()
        {
            _hp = _hpBase;
            _armour = _armourBase;
            _speed = _speedBase;
            _firePower = _firePowerBase;
            _torpedo = _torpedoBase;
            _aircraft = _aircraftBase;
            _attackNum = _attackNumBase;
        }

        public void NormalAttack(Kanmusu other)
        {
            var damage = Math.Clamp(_firePower,MinAttack, _firePower);
            if (_armour > 0)
            {
                other._armour -= damage;
                if (other._armour < 0)
                {
                    other._armour = 0;
                }
            }
            else
            {
                other._hp -= damage;
                if (other._hp < 0)
                {
                    other._hp = 0;
                }
            }
        }

        public  void TorpedoAttack(Kanmusu other)
        {
            other._hp -= Math.Clamp(_torpedo,MinAttack, _torpedo);
            if (other._hp < 0)
            {
                other._hp = 0;
            }
        }

        public  void AirAttack(Kanmusu other)
        {
            var random = new Random();
            var damage = random.Next(_aircraft / 2, _aircraft);
            other._hp -= Math.Clamp(damage,MinAttack, damage);
            if (other._hp < 0)
            {
                other._hp = 0;
            }
            
        }


        public bool Equals(Kanmusu other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Kanmusu) obj);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }
    }
    
}