using System;

using Console_prototype.DB;


namespace Console_prototype
{
    internal static class Program
    {
        static void Main()
        {
            var attack = KanmusuAttack.Instance;

            attack.AirAttack(KanmusuNames.Ashigara,KanmusuNames.Chikuma);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            attack.TorpedoAttack(KanmusuNames.Chikuma,KanmusuNames.Ashigara);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            attack.TorpedoAttack(KanmusuNames.Ashigara,KanmusuNames.Chikuma);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            attack.AirAttack(KanmusuNames.Chikuma,KanmusuNames.Ashigara);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());

        }
    }
}