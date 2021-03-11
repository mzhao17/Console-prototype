namespace Console_prototype
{
    public sealed class KanmusuStats
    {
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

        public KanmusuClass Class
        {
            get => _class;
            set => _class = value;
        }

        public int AttackNum
        {
            get => _attackNum;
            set => _attackNum = value;
        }

        private int _hp;
        private int _armour;
        private int _speed;
        private int _firePower;
        private int _torpedo;
        private int _aircraft;
        private KanmusuClass _class;
        private int _attackNum;
        public KanmusuStats(int hp, int armour, int speed, int firePower, int torpedo, int aircraft, KanmusuClass @class, int attackNum)
        {
            _hp = hp;
            _armour = armour;
            _speed = speed;
            _firePower = firePower;
            _torpedo = torpedo;
            _aircraft = aircraft;
            _class = @class;
            _attackNum = attackNum;
        }
    }
}