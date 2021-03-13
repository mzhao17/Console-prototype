using System;
using System.Collections.Generic;

namespace Console_prototype.DB
{
    public static class KanmusuDatabase
    {
        private  static Dictionary<string,Kanmusu> _nameDict = new ();
        static KanmusuDatabase()
         {
             var names = KanmusuData.GetKanmusuNames();
             foreach (var name in names)
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