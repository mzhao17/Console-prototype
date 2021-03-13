//using System;
//using Console_prototype.DB;

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
            };
        }
        
        public string PrintShipDebug () => OtherName + " " + Hp + "/" + Armour + " :" + Turns;
        public string PrintActionDebug () => Name + " did " + Damage + " " + AttackType + " attack to " + OtherName;
        

    }
}