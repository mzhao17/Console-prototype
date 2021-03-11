using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_prototype
{
    public sealed class BattleField
    {
        private static readonly Lazy<BattleField> Lazy = new Lazy<BattleField>(() => new BattleField());
        public static BattleField Instance => Lazy.Value;
        private static readonly List<Kanmusu> FrontRoll = new (3);
        private static readonly List<Kanmusu> BackRoll = new(3);

        private static readonly List<Kanmusu> EnemyFrontRoll = new (3);
        private static readonly List<Kanmusu> EnemyBackRoll = new(3);
        private static readonly List<Kanmusu> Everyone = new();
        
        private static  List<Kanmusu> _playerUnits = new();
        private static  List<Kanmusu> _enemyUnits = new();

        private static int _turnNumber;
        
        public static void AddFront(Kanmusu kanmusu)
        {
            Everyone.Add(kanmusu);
            FrontRoll.Add(kanmusu);
        }
        
        public static void AddBack(Kanmusu kanmusu)
        {
            Everyone.Add(kanmusu);
            BackRoll.Add(kanmusu);
        }
        
        public static void EnemyAddFront(Kanmusu kanmusu)
        {
            Everyone.Add(kanmusu);
            EnemyFrontRoll.Add(kanmusu);
        }
        
        public static void EnemyAddBack(Kanmusu kanmusu)
        {
            Everyone.Add(kanmusu);
            EnemyBackRoll.Add(kanmusu);
        }

        public static void PlayTurn()
        {
            var orderedEnumerable = Everyone.OrderByDescending(x => x.Speed).ToList();
            _playerUnits = FrontRoll.Concat(BackRoll).ToList();
            _enemyUnits = EnemyFrontRoll.Concat(EnemyBackRoll).ToList();

            for (var i = 0; i < 2; ++i)
            {
                Console.Out.WriteLine($" This is turn: {_turnNumber}");

                foreach (var variable in orderedEnumerable)
                {
                    Console.Out.WriteLine(PrintBattleField());
                    Console.Out.WriteLine($"Its {variable.Name}'s turn");
                    var action = Console.ReadLine();
                    if (action == null) continue;
                    var input = action.Split();
                    var first = input[0];
                    var second = input[1];

                    var target = _playerUnits.Contains<Kanmusu>(variable)
                        ? _enemyUnits[int.Parse(second)]
                        : _playerUnits[int.Parse(second)];



                    switch (first)
                    {
                        case "n":
                            variable.NormalAttack(target);
                            Console.Out.WriteLine(
                                $"{variable.Name} normal attacked {target.Name} with {variable.FirePower} Damage");
                            break;
                        case "t":
                            variable.TorpedoAttack(target);
                            Console.Out.WriteLine(
                                $"{variable.Name} torpedo attacked {target.Name}  with {variable.Torpedo} Damage");
                            break;
                        case "a":
                            variable.AirAttack(target);
                            Console.Out.WriteLine(
                                $"{variable.Name} air attacked {target.Name} with {variable.Aircraft} Damage");

                            break;

                    }


                }
            }

            _turnNumber += 1;

        }


        private static string PrintBattleField()
        {
            var output = "";
            output += "Your Army: \n";
            output = FrontRoll.Aggregate(output, (current, i) => current + ($"front line: {i.Name} {i.Hp}/{i.Armour}\n"));
            output = BackRoll.Aggregate(output, (current, j) => current + ($"back line: {j.Name} {j.Hp}/{j.Armour}\n"));
            output += "Enemy: \n";
            output = EnemyFrontRoll.Aggregate(output, (current, j) => current + ($"front line: {j.Name} {j.Hp}/{j.Armour}\n"));
            output = EnemyBackRoll.Aggregate(output, (current, j) => current + ($"back line: {j.Name} {j.Hp}/{j.Armour}\n"));
            return output;
        }
        
        
        private BattleField()
        {
            
            
        }
    }
}