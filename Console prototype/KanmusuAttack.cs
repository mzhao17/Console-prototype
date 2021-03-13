using System;
using Console_prototype.DB;

namespace Console_prototype
{
    public sealed class KanmusuAttack
    {
        private const int MinAttack = 1;
        private  readonly Random _random = new ();
        private KanmusuStatus _flag;
        public KanmusuAttack()
        {
            ResetFlag();
        }
        private void ResetFlag()
        {
            _flag = KanmusuStatus.Combat;
        }
        public  void NormalAttack(string self, string other)
        {
            var ship1 = InitializeKanmusu(self, other, out var ship2);
            var damage = ship1.FirePower == 0 ? MinAttack : ship1.FirePower;
            var canAttack = _flag == KanmusuStatus.Fainted || _flag == KanmusuStatus.NoTurnsLeft;
            if (canAttack)
            {
                damage = 0;
            }
            else if (ship2.Armour > 0)
            {
                ship2.Armour -= damage;
                CheckArmour(ship2);
                ship1.AttackNum -= 1;
            }
            else
            {
                UpdateShip2(ship2, damage, ship1);
            }
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,damage,"Normal",ship2.AttackNum,self,_flag);
            ResetFlag();
        }



        public  void TorpedoAttack(string self, string other)
        {
            var ship1 = InitializeKanmusu(self, other, out var ship2);
            var damage = ship1.Torpedo == 0 ? MinAttack : ship1.Torpedo;
            var canAttack = _flag == KanmusuStatus.Fainted || _flag == KanmusuStatus.NoTurnsLeft;
            if (canAttack)
            {
                damage = 0;
            }
            else
            {
                UpdateShip2(ship2, damage, ship1);
            }
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,damage,"Torpedo",ship2.AttackNum,self,_flag);
            ResetFlag();
        }

        public   void AirAttack(string self, string other)
        {
            var ship1 = InitializeKanmusu(self, other, out var ship2);
            var damage = _random.Next(ship1.Aircraft / 2, ship1.Aircraft);
            damage = damage == 0 ? MinAttack : damage;
            var canAttack = _flag == KanmusuStatus.Fainted || _flag == KanmusuStatus.NoTurnsLeft;
            if (canAttack)
            {
                damage = 0;
            }
            else
            {
                UpdateShip2(ship2, damage, ship1);
            }
            KanmusuMediator.Instance.OnKanmusuDisplayChanged(ship1,ship2.Hp,ship2.Armour,other,damage,"Air",ship2.AttackNum,self,_flag);
            ResetFlag();
        }

        private void SetStatus(Kanmusu ship1)
        {
            if (ship1.AttackNum <= 0)
            {
                _flag = KanmusuStatus.NoTurnsLeft;
            }

            if (ship1.Hp <= 0)
            {
                _flag = KanmusuStatus.Fainted;
            }
        }
        
        private static void UpdateShip2(Kanmusu ship2, int damage, Kanmusu ship1)
        {
            ship2.Hp -= damage;
            CheckHp(ship2);
            ship1.AttackNum -= 1;
        }

        private static void CheckArmour(Kanmusu ship2)
        {
            if (ship2.Armour < 0)
            {
                ship2.Armour = 0;
            }
        }

        private static void CheckHp(Kanmusu ship2)
        {
            if (ship2.Hp < 0)
            {
                ship2.Hp = 0;
            }
        }
        private Kanmusu InitializeKanmusu(string self, string other, out Kanmusu ship2)
        {
            var ship1 = KanmusuDatabase.GetKanmusu()[self];
            ship2 = KanmusuDatabase.GetKanmusu()[other];
            SetStatus(ship1);
            return ship1;
        }
    }
}