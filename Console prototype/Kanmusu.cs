using System;
//using System.Data.Common;
//using System.Net.Mail;

namespace Console_prototype
{
    public  class Kanmusu
    {
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
        


        protected Kanmusu(string name)
        {
            _name = name;
            var type = KanmusuData.GetTypeFromName(name);
            var stats = KanmusuData.GetStatsFromType(type);
            _hpBase = stats.Hp;
            _armourBase = stats.Armour;
            _speedBase = stats.Speed;
            _firePowerBase = stats.FirePower;
            _torpedoBase = stats.Torpedo;
            _aircraftBase = stats.Aircraft;
            _class = stats.Class;
            _attackNumBase = stats.AttackNum;
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

        protected virtual void NormalAttack(Kanmusu other)
        {
            var damage = Math.Clamp(_firePower,1, _firePower);
            if (_armour > 0)
            {
                other._armour -= damage;
            }
            else
            {
                other._hp -= damage;
            }
        }

        protected virtual void TorpedoAttack(Kanmusu other)
        {
            other._hp -= Math.Clamp(_torpedo,1, _torpedo);
        }

        protected virtual void AirAttack(Kanmusu other)
        {
            var random = new Random();
            var damage = random.Next(_aircraft / 2, _aircraft);
            other._hp -= Math.Clamp(damage,1, damage);
            
        }
        
        
    }
    
}