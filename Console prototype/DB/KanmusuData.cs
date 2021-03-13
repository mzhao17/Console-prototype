using System;
using System.Collections.Generic;


//using System.Diagnostics;

namespace Console_prototype.DB
{


    public sealed class KanmusuData
    {
        private static readonly Lazy<KanmusuData> Lazy = new Lazy<KanmusuData>(() => new KanmusuData());
        public static KanmusuData Instance => Lazy.Value;
        
        private readonly Dictionary<KanmusuDataClass, KanmusuStats> _data  = new();
        private readonly Dictionary<string, KanmusuDataClass> _nameData = new();

        private readonly Dictionary<KanmusuDataClass, KanmusuClass> ClassData = new();

        public KanmusuDataClass GetTypeFromName(string name)
        {
            return _nameData[name];
            
        }

        public KanmusuStats GetStatsFromType(KanmusuDataClass type)
        {
            return _data[type];
        }

        public KanmusuClass GetClassData(KanmusuDataClass cl)
        {
            return ClassData[cl];
        }

        public List<string> GetKanmusuNames()
        {
            var nameList = new List<string>(_nameData.Keys);
            return nameList;
        }

        private KanmusuData()
        {
            AddKanmusuClass();
            AddKanmusuNameToClass();
            AddKanmusuType();
   
        }

        private void AddKanmusuNameToClass()
        {
            _nameData.Add(KanmusuNames.Ise, KanmusuDataClass.IseClass);
            _nameData.Add(KanmusuNames.Hyuuga, KanmusuDataClass.IseClass);
            _nameData.Add(KanmusuNames.Fusou, KanmusuDataClass.FusouClass);
            _nameData.Add(KanmusuNames.Yamashiro, KanmusuDataClass.FusouClass);
            _nameData.Add(KanmusuNames.Kongou, KanmusuDataClass.KongouClass);
            _nameData.Add(KanmusuNames.Haruna, KanmusuDataClass.KongouClass);
            _nameData.Add(KanmusuNames.Hiei, KanmusuDataClass.KongouClass);
            _nameData.Add(KanmusuNames.Kirishima, KanmusuDataClass.KongouClass);
            _nameData.Add(KanmusuNames.Yuudachi, KanmusuDataClass.ShiratsuyuClass);  
            _nameData.Add(KanmusuNames.Shigure, KanmusuDataClass.ShiratsuyuClass);
            _nameData.Add(KanmusuNames.Nagato, KanmusuDataClass.NagatoClass);
            _nameData.Add(KanmusuNames.Mutsu, KanmusuDataClass.NagatoClass);
            _nameData.Add(KanmusuNames.Akagi, KanmusuDataClass.AkagiClass);
            _nameData.Add(KanmusuNames.Kaga, KanmusuDataClass.KagaClass);
            _nameData.Add(KanmusuNames.Shimakaze, KanmusuDataClass.ShimakazeClass);
            _nameData.Add(KanmusuNames.Sendai, KanmusuDataClass.SendaiClass);
            _nameData.Add(KanmusuNames.Naka, KanmusuDataClass.SendaiClass);
            _nameData.Add(KanmusuNames.Jintsuu, KanmusuDataClass.SendaiClass);
            _nameData.Add(KanmusuNames.Tenryuu, KanmusuDataClass.TenryuuClass);
            _nameData.Add(KanmusuNames.Ashigara, KanmusuDataClass.MyoukouClass);
            _nameData.Add(KanmusuNames.Nachi, KanmusuDataClass.MyoukouClass);
            _nameData.Add(KanmusuNames.Haguro, KanmusuDataClass.MyoukouClass);
            _nameData.Add(KanmusuNames.Takao, KanmusuDataClass.TakaoClass);
            _nameData.Add(KanmusuNames.Atago, KanmusuDataClass.TakaoClass);
            _nameData.Add(KanmusuNames.Maya, KanmusuDataClass.MayaClass);
            _nameData.Add(KanmusuNames.Choukai, KanmusuDataClass.TakaoClass);
            _nameData.Add(KanmusuNames.Suzuya, KanmusuDataClass.MogamiClass);
            _nameData.Add(KanmusuNames.Kumano, KanmusuDataClass.MogamiClass);
            _nameData.Add(KanmusuNames.Tone, KanmusuDataClass.ToneClass);
            _nameData.Add(KanmusuNames.Chikuma, KanmusuDataClass.ToneClass);
            _nameData.Add(KanmusuNames.PrinzEugen, KanmusuDataClass.AdmiralHipperClass);
        }

        private void AddKanmusuClass()
        {
            _data.Add(KanmusuDataClass.IseClass, new KanmusuStats(77, 74, 36, 63, 0, 47, 1));
            _data.Add(KanmusuDataClass.FusouClass, new KanmusuStats(75, 72, 33, 63, 0, 40,  1));
            _data.Add(KanmusuDataClass.KongouClass, new KanmusuStats(75, 67, 35, 72, 0, 12,  1));
            _data.Add(KanmusuDataClass.ShiratsuyuClass, new KanmusuStats(30, 14, 45, 12, 28, 0,  3));
            _data.Add(KanmusuDataClass.TakaoClass, new KanmusuStats(57, 45, 40, 48, 24, 8,  2));
            _data.Add(KanmusuDataClass.MayaClass, new KanmusuStats(55, 45, 40, 43, 24, 8,  2));
            _data.Add(KanmusuDataClass.MogamiClass, new KanmusuStats(50, 37, 34, 24, 18, 22, 3));
            _data.Add(KanmusuDataClass.ToneClass, new KanmusuStats(56, 46, 41, 42, 24, 16,  2));
            _data.Add(KanmusuDataClass.AdmiralHipperClass,
                new KanmusuStats(63, 48, 40, 48, 40, 12,  1));
            _data.Add(KanmusuDataClass.AkagiClass, new KanmusuStats(77, 40, 28, 0, 0, 82,  1));
            _data.Add(KanmusuDataClass.KagaClass, new KanmusuStats(79, 40, 27, 0, 0, 98,  1));
            _data.Add(KanmusuDataClass.ShimakazeClass, new KanmusuStats(36, 14, 55, 14, 48, 0,  1));
            _data.Add(KanmusuDataClass.TenryuuClass, new KanmusuStats(40, 28, 42, 20, 24, 0,  3));
            _data.Add(KanmusuDataClass.SendaiClass, new KanmusuStats(44, 29, 40, 20, 24, 3,  3));
            _data.Add(KanmusuDataClass.NagatoClass, new KanmusuStats(90, 85, 24, 90, 0, 12,  1));
            _data.Add(KanmusuDataClass.MyoukouClass, new KanmusuStats(55,42,39,48,24,8,2));
        }

        private void AddKanmusuType()
        {
            ClassData.Add(KanmusuDataClass.IseClass,KanmusuClass.AviationBattleship);
            ClassData.Add(KanmusuDataClass.FusouClass,KanmusuClass.AviationBattleship);
            ClassData.Add(KanmusuDataClass.KongouClass,KanmusuClass.BattleShip);
            ClassData.Add(KanmusuDataClass.ShiratsuyuClass,KanmusuClass.Destroyer);
            ClassData.Add(KanmusuDataClass.TakaoClass,KanmusuClass.HeavyCruiser);
            ClassData.Add(KanmusuDataClass.MayaClass,KanmusuClass.HeavyCruiser);
            ClassData.Add(KanmusuDataClass.MogamiClass,KanmusuClass.AviationCruiser);
            ClassData.Add(KanmusuDataClass.ToneClass,KanmusuClass.AviationCruiser);
            ClassData.Add(KanmusuDataClass.AdmiralHipperClass,KanmusuClass.HeavyCruiser);
            ClassData.Add(KanmusuDataClass.AkagiClass,KanmusuClass.AircraftCarrier);
            ClassData.Add(KanmusuDataClass.KagaClass,KanmusuClass.AircraftCarrier);
            ClassData.Add(KanmusuDataClass.ShimakazeClass,KanmusuClass.Destroyer);
            ClassData.Add(KanmusuDataClass.TenryuuClass,KanmusuClass.LightCruiser);
            ClassData.Add(KanmusuDataClass.SendaiClass,KanmusuClass.LightCruiser);
            ClassData.Add(KanmusuDataClass.NagatoClass,KanmusuClass.BattleShip);
            ClassData.Add(KanmusuDataClass.MyoukouClass,KanmusuClass.HeavyCruiser);
        }
    }
}