using System;
using System.Collections.Generic;

namespace Console_prototype.DB
{
    public sealed class KanmusuDatabase
    {
        private static readonly Lazy<KanmusuDatabase> Lazy = new Lazy<KanmusuDatabase>(() => new KanmusuDatabase());
        public static KanmusuDatabase Instance => Lazy.Value;
        
        private readonly KanmusuData _kanmusuData = KanmusuData.Instance;

        private readonly List<string> _names;
        
        private  Dictionary<string,Kanmusu> _nameDict = new ();
        
        
         private KanmusuDatabase()
        {
            foreach (var name in _names)
            {
                _nameDict.Add(name,new Kanmusu(name));
            }

            _names = _kanmusuData.GetKanmusuNames();

        }

         public  ref Dictionary<string,Kanmusu> GetKanmusu()
         {

             return ref _nameDict; 
         }
            
         
         


        
        
    }
}