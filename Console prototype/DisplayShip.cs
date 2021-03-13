//using System;
//using Console_prototype.DB;

namespace Console_prototype
{
    public static class DisplayShip
    {
        public static string Name
        {
            get => _name;
            set => _name = value;
        }

        public static int Hp
        {
            get => _hp;
            set => _hp = value;
        }

        public static int Armour
        {
            get => _armour;
            set => _armour = value;
        }

        public static int Turns
        {
            get => _turns;
            set => _turns = value;
        }

        public static string OtherName
        {
            get => _otherName;
            set => _otherName = value;
        }

        public static int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public static string AttackType
        {
            get => _attackType;
            set => _attackType = value;
        }

        private static string _name;
        private static int _hp;
        private static int _armour;
        private static int _turns;
        private static string _otherName;
        private static int _damage;
        private static string _attackType;

        static DisplayShip()
        {

            KanmusuMediator.Instance.KanmusuDisplayChanged += (_, e) =>
            {
                _hp = e.Hp;
                _armour = e.Armour;
                _otherName = e.TargetName;
                _damage = e.Damage;
                _attackType = e.AttackType;
                _turns = e.Turns;
                _name = e.SelfName;
            };
        }
        
        public static string PrintShip () => _name + " " + _hp + "/" + _armour + " :" + _turns;
        public static string PrintAction () => _name + " did " + _damage + " " + _attackType + " attack to " + _otherName;
        

    }
}