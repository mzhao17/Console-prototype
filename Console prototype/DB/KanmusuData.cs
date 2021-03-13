using System;
using System.Collections.Generic;


//using System.Diagnostics;

namespace Console_prototype.DB
{
    public static class KanmusuData
    {
        private static readonly Dictionary<KanmusuDataClass, KanmusuStats> Data  = new();
        private static readonly Dictionary<string, KanmusuDataClass> NameData = new();
        private static readonly Dictionary<KanmusuDataClass, KanmusuClass> ClassData = new();
        public static KanmusuDataClass GetTypeFromName(string name)
        {
            return NameData[name];
        }

        public static KanmusuStats GetStatsFromType(KanmusuDataClass type)
        {
            return Data[type];
        }

        public static KanmusuClass GetClassData(KanmusuDataClass cl)
        {
            return ClassData[cl];
        }

        public static List<string> GetKanmusuNames()
        {
            return new(NameData.Keys);
        }

        static KanmusuData()
        {
            AddKanmusuClass();
            AddKanmusuNameToClass();
            AddKanmusuType();
        }

        private static void AddKanmusuNameToClass()
        {
            NameData.Add(KanmusuNames.Ise, KanmusuDataClass.IseClass);
            NameData.Add(KanmusuNames.Hyuuga, KanmusuDataClass.IseClass);
            NameData.Add(KanmusuNames.Fusou, KanmusuDataClass.FusouClass);
            NameData.Add(KanmusuNames.Yamashiro, KanmusuDataClass.FusouClass);
            NameData.Add(KanmusuNames.Kongou, KanmusuDataClass.KongouClass);
            NameData.Add(KanmusuNames.Haruna, KanmusuDataClass.KongouClass);
            NameData.Add(KanmusuNames.Hiei, KanmusuDataClass.KongouClass);
            NameData.Add(KanmusuNames.Kirishima, KanmusuDataClass.KongouClass);
            NameData.Add(KanmusuNames.Yuudachi, KanmusuDataClass.ShiratsuyuClass);  
            NameData.Add(KanmusuNames.Shigure, KanmusuDataClass.ShiratsuyuClass);
            NameData.Add(KanmusuNames.Nagato, KanmusuDataClass.NagatoClass);
            NameData.Add(KanmusuNames.Mutsu, KanmusuDataClass.NagatoClass);
            NameData.Add(KanmusuNames.Akagi, KanmusuDataClass.AkagiClass);
            NameData.Add(KanmusuNames.Kaga, KanmusuDataClass.KagaClass);
            NameData.Add(KanmusuNames.Shimakaze, KanmusuDataClass.ShimakazeClass);
            NameData.Add(KanmusuNames.Sendai, KanmusuDataClass.SendaiClass);
            NameData.Add(KanmusuNames.Naka, KanmusuDataClass.SendaiClass);
            NameData.Add(KanmusuNames.Jintsuu, KanmusuDataClass.SendaiClass);
            NameData.Add(KanmusuNames.Tenryuu, KanmusuDataClass.TenryuuClass);
            NameData.Add(KanmusuNames.Ashigara, KanmusuDataClass.MyoukouClass);
            NameData.Add(KanmusuNames.Nachi, KanmusuDataClass.MyoukouClass);
            NameData.Add(KanmusuNames.Haguro, KanmusuDataClass.MyoukouClass);
            NameData.Add(KanmusuNames.Takao, KanmusuDataClass.TakaoClass);
            NameData.Add(KanmusuNames.Atago, KanmusuDataClass.TakaoClass);
            NameData.Add(KanmusuNames.Maya, KanmusuDataClass.MayaClass);
            NameData.Add(KanmusuNames.Choukai, KanmusuDataClass.TakaoClass);
            NameData.Add(KanmusuNames.Suzuya, KanmusuDataClass.MogamiClass);
            NameData.Add(KanmusuNames.Kumano, KanmusuDataClass.MogamiClass);
            NameData.Add(KanmusuNames.Tone, KanmusuDataClass.ToneClass);
            NameData.Add(KanmusuNames.Chikuma, KanmusuDataClass.ToneClass);
            NameData.Add(KanmusuNames.PrinzEugen, KanmusuDataClass.AdmiralHipperClass);
        }

        private static void AddKanmusuClass()
        {
            Data.Add(KanmusuDataClass.IseClass, new KanmusuStats(77, 74, 36, 63, 0, 47, 1));
            Data.Add(KanmusuDataClass.FusouClass, new KanmusuStats(75, 72, 33, 63, 0, 40,  1));
            Data.Add(KanmusuDataClass.KongouClass, new KanmusuStats(75, 67, 35, 72, 0, 12,  1));
            Data.Add(KanmusuDataClass.ShiratsuyuClass, new KanmusuStats(30, 14, 45, 12, 28, 0,  3));
            Data.Add(KanmusuDataClass.TakaoClass, new KanmusuStats(57, 45, 40, 48, 24, 8,  2));
            Data.Add(KanmusuDataClass.MayaClass, new KanmusuStats(55, 45, 40, 43, 24, 8,  2));
            Data.Add(KanmusuDataClass.MogamiClass, new KanmusuStats(50, 37, 34, 24, 18, 22, 3));
            Data.Add(KanmusuDataClass.ToneClass, new KanmusuStats(56, 46, 41, 42, 24, 16,  2));
            Data.Add(KanmusuDataClass.AdmiralHipperClass,
                new KanmusuStats(63, 48, 40, 48, 40, 12,  1));
            Data.Add(KanmusuDataClass.AkagiClass, new KanmusuStats(77, 40, 28, 0, 0, 82,  1));
            Data.Add(KanmusuDataClass.KagaClass, new KanmusuStats(79, 40, 27, 0, 0, 98,  1));
            Data.Add(KanmusuDataClass.ShimakazeClass, new KanmusuStats(36, 14, 55, 14, 48, 0,  1));
            Data.Add(KanmusuDataClass.TenryuuClass, new KanmusuStats(40, 28, 42, 20, 24, 0,  3));
            Data.Add(KanmusuDataClass.SendaiClass, new KanmusuStats(44, 29, 40, 20, 24, 3,  3));
            Data.Add(KanmusuDataClass.NagatoClass, new KanmusuStats(90, 85, 24, 90, 0, 12,  1));
            Data.Add(KanmusuDataClass.MyoukouClass, new KanmusuStats(55,42,39,48,24,8,2));
        }

        private static void AddKanmusuType()
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