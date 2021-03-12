using System;
using System.Collections.Generic;
using System.Linq;
using Console_prototype.DB;

namespace Console_prototype
{
    public sealed class BattleField
    {
        private static readonly Lazy<BattleField> Lazy = new Lazy<BattleField>(() => new BattleField());
        public static BattleField Instance => Lazy.Value;

        private BattleField()
        {
            
        }
    }
}