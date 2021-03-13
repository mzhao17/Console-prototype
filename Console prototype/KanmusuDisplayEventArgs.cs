using System;

namespace Console_prototype
{
    public class KanmusuDisplayEventArgs: EventArgs
    {
        public int Hp { get; set; }
        public int Armour { get; set; }
        
        public int Damage { get; set; }
        
        public string TargetName { get; set; }
        
        public  string SelfName { get; set; }
        
        public string AttackType { get; set; }
        
        public int Turns { get; set; }
    }
}