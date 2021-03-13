using System;
using System.Collections.Generic;
//using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
//using System.Runtime.InteropServices.ComTypes;
using Console_prototype.DB;


namespace Console_prototype
{
    internal static class Program
    {
        private static readonly Random Rand = new ();

        static void Main()
        {
            var attack = new KanmusuAttack(); 
            var display = new DisplayShip();
            
            Console.WriteLine("Enter your team:");
            var yourShip = Console.ReadLine();
            Debug.Assert(yourShip != null, nameof(yourShip) + " != null");
            var myShips = yourShip.Split(" ");
            
            Console.WriteLine("Enter their team:");
            var theirShip = Console.ReadLine();
            Debug.Assert(theirShip != null, nameof(theirShip) + " != null");

            var theirShips = theirShip.Split(" ");
            var allShips = myShips.Concat(theirShips);
            var orderList = allShips.OrderByDescending(s => KanmusuDatabase.GetKanmusu()[s].Speed);
            var actions = new List<string> {"n", "t", "a"};
            
            var yourHp = myShips.Sum(ship => KanmusuDatabase.GetKanmusu()[ship].Hp);
            var theirHp = theirShips.Sum(ship => KanmusuDatabase.GetKanmusu()[ship].Hp);
            Console.Out.WriteLine("initial score: " + (yourHp*100)/(yourHp+theirHp));
            
            var turnNumber = 3;
            while (turnNumber >0)
            {
                Console.Out.WriteLine("==========================================================================");
                Console.Out.WriteLine(turnNumber + " ROUNDS LEFT");
                ExecuteTurn(orderList: orderList, myShips.ToList(), theirShips: theirShips.ToList(), actions: actions,  attack: attack, display: display, isPlayerMode: true);
                turnNumber--;
            }

            PrintTeams(myShips.ToList(),theirShips.ToList());
            yourHp = myShips.Sum(ship => KanmusuDatabase.GetKanmusu()[ship].Hp);
            theirHp = theirShips.Sum(ship => KanmusuDatabase.GetKanmusu()[ship].Hp);
            Console.Out.WriteLine("final score: " + (yourHp*100)/(yourHp+theirHp));
        }

        private static void ExecuteTurn(IOrderedEnumerable<string> orderList, List<string> myShips,
            List<string> theirShips, List<string> actions, 
            KanmusuAttack attack, DisplayShip display, bool isPlayerMode)
        {
            foreach (var ship in orderList)
            {
                var isAlly = myShips.Contains(ship);
                Console.Out.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Out.WriteLine(ship + "'s turn");
                var target = isAlly ? theirShips : myShips;
                var isDead = KanmusuDatabase.GetKanmusu()[ship].Hp <= 0;
                var noAttack = KanmusuDatabase.GetKanmusu()[ship].AttackNum <= 0;
                var passCond = isDead || noAttack;
                if (passCond)
                {
                    switch (isAlly)
                    {
                        case true when isDead:
                            myShips.Remove(ship);
                            break;
                        case false when isDead:
                            theirShips.Remove(ship);
                            break;
                    }

                    if (noAttack)
                    {
                        Console.Out.WriteLine("Passed this turn");
                    }
                    continue;
                }

                if (myShips.Count == 0 || theirShips.Count == 0)
                {
                    break;
                }

                string second;
                var first = (isAlly && isPlayerMode)
                    ? MyMove(myShips, theirShips, actions, out second)
                    : TheirMove(myShips, theirShips, out second);
                DoAttack(first, attack, ship, target, second, display);
            }
        }

        private static string TheirMove(List<string> myShips, List<string> theirShips, out string second)
        {
            PrintTeams(myShips, theirShips);
            var firstNum = Rand.Next(1, 3);
            var first = firstNum switch
            {
                1 => "n",
                2 => "t",
                3 => "a",
                _ => throw new ArgumentException("invalid input")
            };
            var secondNum = Rand.Next(1, myShips.Count);
            second = secondNum.ToString();
            return first;
        }

        private static string MyMove(List<string> myShips, List<string> theirShips, List<string> actions, out string second)
        {
            PrintTeams(myShips, theirShips);
            Console.Out.WriteLine("Enter your Command:");
            var command = Console.ReadLine()?.Split();
            var first = command?[0];
            second = command?[1];
            Debug.Assert(actions.Contains(first));
            Debug.Assert(1 <= int.Parse(second ?? throw new InvalidOperationException()) && int.Parse(second) <= 6);
            return first;
        }

        private static void DoAttack(string first, KanmusuAttack attack, string ship, List<string> target, string second,
            DisplayShip display)
        {
            switch (first)
            {
                case "n":
                    attack.NormalAttack(ship, target[int.Parse(second) - 1]);
                    Console.Out.WriteLine(display.PrintActionDebug());
                    Console.Out.WriteLine(display.PrintShipDebug());

                    break;
                case "t":
                    attack.TorpedoAttack(ship, target[int.Parse(second) - 1]);
                    Console.Out.WriteLine(display.PrintActionDebug());
                    Console.Out.WriteLine(display.PrintShipDebug());
                    break;
                case "a":
                    attack.AirAttack(ship, target[int.Parse(second) - 1]);
                    Console.Out.WriteLine(display.PrintActionDebug());
                    Console.Out.WriteLine(display.PrintShipDebug());
                    break;
                default:
                    throw new ArgumentException("invalid input");
            }
        }

        private static void PrintTeams(List<string> myShips, List<string> theirShips)
        {
            Console.Out.WriteLine("Team 1:");
            Console.Out.WriteLine(PrintAll(myShips));
            Console.Out.WriteLine("Team 2:");
            Console.Out.WriteLine(PrintAll(theirShips));
            Console.Out.WriteLine("\n");
        }


        private static string PrintAll(IEnumerable<string> ships)
        {
            var stringResult = "";
            
            foreach (var ship in ships)
            {
                var hp = KanmusuDatabase.GetKanmusu()[ship].Hp;
                var maxHp = KanmusuDatabase.GetKanmusu()[ship].HpBase;
                var armour = KanmusuDatabase.GetKanmusu()[ship].Armour;
                var turn = KanmusuDatabase.GetKanmusu()[ship].AttackNum;
                var maxArmour = KanmusuDatabase.GetKanmusu()[ship].ArmourBase;
                stringResult += ship + " [ HP " + hp + "/" + maxHp + " | Armour " +  armour + "/" + maxArmour + " | Turns " + turn + " ]";
                //[ HP 40/40 | Armor 27 | Turns 0 ]
            }

            return stringResult;

        }
    }
}