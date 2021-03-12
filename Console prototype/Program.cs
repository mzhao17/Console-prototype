using System;
using System.Linq;
using Console_prototype.DB;


namespace Console_prototype
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var battleField = BattleField.Instance;
            Console.Out.WriteLine(KanmusuDatabase.NameDict[KanmusuNames.Akagi].Name);
            
        }
    }
}