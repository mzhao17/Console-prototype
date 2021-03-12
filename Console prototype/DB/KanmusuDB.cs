using System;
using System.Collections.Generic;

namespace Console_prototype.DB
{
    public static class KanmusuDatabase
    {
        //private static readonly Lazy<KanmusuDatabase> Lazy = new Lazy<KanmusuDatabase>(() => new KanmusuDatabase());
        //public static KanmusuDatabase Instance => Lazy.Value;
        private static readonly List<string> Names = KanmusuData.GetKanmusuNames();
        private static  Dictionary<string,Kanmusu> _nameDict = new ();
        
        
         static KanmusuDatabase()
        {
            foreach (var name in Names)
            {
                _nameDict.Add(name,new Kanmusu(name));
            }
            
        }

         public static ref Dictionary<string,Kanmusu> GetKanmusu()
         {

             return ref _nameDict; 
         }
            
         
         


        
        
    }
}