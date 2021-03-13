using System;
using Console_prototype.DB;

namespace Console_prototype
{
    public sealed class KanmusuAttack
    {
        private static readonly Lazy<KanmusuAttack> Lazy = new Lazy<KanmusuAttack> (() => new KanmusuAttack());
        public static KanmusuAttack Instance => Lazy.Value;


        private const int MinAttack = 1;
       // private Kanmusu _kanmusu;
        private  readonly Random _random = new ();
        private  readonly KanmusuDatabase _kanmusuDatabase = KanmusuDatabase.Instance;

        private KanmusuAttack()
        {
            
        }

        public  void NormalAttack(string self, string other)
        {
            var ship1 = _kanmusuDatabase.GetKanmusu()[self];
            var ship2 = _kanmusuDatabase.GetKanmusu()[other];
            
            var damage = Math.Clamp(ship1.FirePower,MinAttack,ship1.FirePower);
            
            if (ship2.Armour > 0)
            {
                ship2.Armour -= damage;
                if (ship2.Armour < 0)
                {
                    ship2.Armour = 0;
                }
            }
            else
            {
                ship2.Hp -= damage;
                if (ship2.Hp < 0)
                {
                    ship2.Hp = 0;
                }
            }

            ship1.AttackNum -= 1;
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,ship1.FirePower,"Normal",ship1.AttackNum,self);
        }

        public  void TorpedoAttack(string self, string other)
        {
            var ship1 = _kanmusuDatabase.GetKanmusu()[self];
            var ship2 = _kanmusuDatabase.GetKanmusu()[other];

            ship2.Hp -= Math.Clamp(ship1.Torpedo,MinAttack, ship1.Torpedo);
            if (ship2.Hp < 0)
            {
                ship2.Hp = 0;
            }
            //KanmusuMediator.Instance.OnKanmusuDisplayChanged(this,other._hp,other._armour);
            ship1.AttackNum -= 1;
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,ship1.Torpedo,"Torpedo",ship1.AttackNum,self);
            
        }

        public   void AirAttack(string self, string other)
        {
            var ship1 = _kanmusuDatabase.GetKanmusu()[self];
            var ship2 = _kanmusuDatabase.GetKanmusu()[other];
            
            var damage = _random.Next(ship1.Aircraft / 2, ship1.Aircraft);
            ship2.Hp -= Math.Clamp(damage,MinAttack, damage);
            if (ship2.Hp < 0)
            {
                ship2.Hp = 0;
            }
            ship1.AttackNum -= 1;
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,damage,"Air",ship1.AttackNum,self);
            
        }
    }
}