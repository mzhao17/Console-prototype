using System;

using Console_prototype.DB;


namespace Console_prototype
{
    internal static class Program
    {
        static void Main()
        {
            
            Console.Out.WriteLine(DisplayShip.PrintShip());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            KanmusuAttack.AirAttack(KanmusuNames.Ashigara,KanmusuNames.Chikuma);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            KanmusuAttack.TorpedoAttack(KanmusuNames.Chikuma,KanmusuNames.Ashigara);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            KanmusuAttack.TorpedoAttack(KanmusuNames.Ashigara,KanmusuNames.Chikuma);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());
            KanmusuAttack.AirAttack(KanmusuNames.Chikuma,KanmusuNames.Ashigara);
            Console.Out.WriteLine(DisplayShip.PrintAction());
            Console.Out.WriteLine(DisplayShip.PrintShip());

        }
    }
}