using System;
using System.Linq;


namespace Console_prototype
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var battleField = BattleField.Instance;
            BattleField.AddFront(new Kanmusu(KanmusuNames.Akagi));
            BattleField.AddBack(new Kanmusu(KanmusuNames.Kaga));
            
            BattleField.EnemyAddFront(new Kanmusu(KanmusuNames.Ashigara));
            BattleField.EnemyAddBack(new Kanmusu(KanmusuNames.Chikuma));
    
            BattleField.PlayTurn();
        }
    }
}