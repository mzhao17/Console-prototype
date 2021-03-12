using System;
using System.Collections.Generic;

namespace Console_prototype.DB
{
    public static class KanmusuDatabase
    {
        //private static readonly Lazy<KanmusuDatabase> Lazy = new Lazy<KanmusuDatabase>(() => new KanmusuDatabase());
        //public static KanmusuDatabase Instance => Lazy.Value;
        private static readonly List<string> Names = KanmusuData.GetKanmusuNames();
        public static readonly Dictionary<string,Kanmusu> NameDict = new ();
        
        
         static KanmusuDatabase()
        {
            foreach (var name in Names)
            {
                NameDict.Add(name,new Kanmusu(name));
            }
            
        }
         
         


        
        
    }
}