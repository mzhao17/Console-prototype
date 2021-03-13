using System;
using System.Collections.Generic;
using Console_prototype.DB;


namespace Console_prototype
{
    internal static class Program
    {
        static void Main()
        {
            KanmusuAttack attack;
            DisplayShip display;
            
            attack = new KanmusuAttack(); 
            display = new DisplayShip();
            var shipList = new List<string>{KanmusuNames.Akagi, KanmusuNames.Chikuma};
            

            attack.AirAttack(KanmusuNames.Akagi, KanmusuNames.Chikuma);
            Console.Out.WriteLine(display.PrintActionDebug());
            Console.Out.WriteLine(display.PrintShipDebug());
            
            
            attack.TorpedoAttack(KanmusuNames.Chikuma, KanmusuNames.Akagi);
            Console.Out.WriteLine(display.PrintActionDebug());
            Console.Out.WriteLine(display.PrintShipDebug());
            attack = new KanmusuAttack();
            display = new DisplayShip();
            attack.TorpedoAttack(KanmusuNames.Akagi, KanmusuNames.Chikuma);
            Console.Out.WriteLine(display.PrintActionDebug());
            Console.Out.WriteLine(display.PrintShipDebug());
            attack.AirAttack(KanmusuNames.Chikuma, KanmusuNames.Akagi);
            Console.Out.WriteLine(display.PrintActionDebug());
            Console.Out.WriteLine(display.PrintShipDebug());
            

        }
    }
}