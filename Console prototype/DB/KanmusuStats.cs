namespace Console_prototype.DB
{
    public sealed class KanmusuStats
    {
        public int Hp { get;  }

        public int Armour { get;  }

        public int Speed { get;  }

        public int FirePower { get; }

        public int Torpedo { get; }

        public int Aircraft { get; }

        public int AttackNum { get;}

        public KanmusuStats(int hp, int armour, int speed, int firePower, int torpedo, int aircraft, int attackNum)
        {
            Hp = hp;
            Armour = armour;
            Speed = speed;
            FirePower = firePower;
            Torpedo = torpedo;
            Aircraft = aircraft;
            AttackNum = attackNum;
        }
    }
}