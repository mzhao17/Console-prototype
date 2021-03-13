using System;

namespace Console_prototype
{
    public sealed class KanmusuMediator
    {
        private static readonly Lazy<KanmusuMediator> Lazy = new Lazy<KanmusuMediator>(() => new KanmusuMediator());
        public static KanmusuMediator Instance => Lazy.Value;

        private KanmusuMediator()
        {
            
        }

        public event EventHandler<KanmusuDisplayEventArgs> KanmusuDisplayChanged;

        public void OnKanmusuDisplayChanged(object sender, int hp, int armour, string name, int damage,
            string attackType, int turns, string selfName, KanmusuStatus flag)
        {
            var kanmusuDisplayDelegate = KanmusuDisplayChanged;
            kanmusuDisplayDelegate?.Invoke(sender, new KanmusuDisplayEventArgs
            {
                Hp = hp, 
                Armour = armour,
                TargetName = name,
                Damage = damage,
                AttackType = attackType,
                Turns = turns,
                SelfName = selfName,
                Flag = flag
            });
        }
    }
}