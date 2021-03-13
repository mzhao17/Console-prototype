//using System;
//using Console_prototype.DB;

using System;

namespace Console_prototype
{
    public class DisplayShip
    {
        public  string Name { get; set; }

        public  int Hp { get; set; }

        public  int Armour { get; set; }

        public  int Turns { get; set; }

        public  string OtherName { get; set; }

        public  int Damage { get; set; }

        public  string AttackType { get; set; }
        
        public KanmusuStatus Status { get; set; }

        public DisplayShip()
        {
            KanmusuMediator.Instance.KanmusuDisplayChanged += (_, e) =>
            {
                Hp = e.Hp;
                Armour = e.Armour;
                OtherName = e.TargetName;
                Damage = e.Damage;
                AttackType = e.AttackType;
                Turns = e.Turns;
                Name = e.SelfName;
                Status = e.Flag;
            };
        }
        public string PrintShipDebug() => OtherName + " has " + Hp + " hp, " + Armour + " armour, " + Turns + " turns left";



        public string PrintActionDebug()
        {
            var debugString = "";
            debugString += Status switch
            {
                KanmusuStatus.Combat => Name + " did " + Damage + " " + AttackType + " attack to " + OtherName,
                KanmusuStatus.Fainted => Name + " has fainted",
                KanmusuStatus.NoTurnsLeft => Name + " has no turns left",
                _ => throw new ArgumentOutOfRangeException()
            };
            return debugString;
        } //
        

    }
}