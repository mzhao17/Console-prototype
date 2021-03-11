using System;
using System.Collections.Generic;
using System.Linq;

//using System.Diagnostics;

namespace Console_prototype
{


    public static class KanmusuData
    {
        private static Dictionary<KanmusuDataClass, KanmusuStats> Data { get; } = new();
        private static Dictionary<string, KanmusuDataClass> NameData { get; } = new();

        public static KanmusuDataClass GetTypeFromName(string name)
        {
            return NameData[name];
            
        }

        public static KanmusuStats GetStatsFromType(KanmusuDataClass type)
        {
            return Data[type];
        }


        static KanmusuData()
        {
            AddKanmusuClass();
            AddKanmusuNameToClass();
   
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
            Data.Add(KanmusuDataClass.IseClass, new KanmusuStats(77, 74, 36, 63, 0, 47, KanmusuClass.AviationBattleship, 1));
            Data.Add(KanmusuDataClass.FusouClass, new KanmusuStats(75, 72, 33, 63, 0, 40, KanmusuClass.AviationBattleship, 1));
            Data.Add(KanmusuDataClass.KongouClass, new KanmusuStats(75, 67, 35, 72, 0, 12, KanmusuClass.BattleShip, 1));
            Data.Add(KanmusuDataClass.ShiratsuyuClass, new KanmusuStats(30, 14, 45, 12, 28, 0, KanmusuClass.Destroyer, 3));
            Data.Add(KanmusuDataClass.MyoukouClass, new KanmusuStats(55, 42, 39, 48, 24, 8, KanmusuClass.HeavyCruiser, 2));
            Data.Add(KanmusuDataClass.TakaoClass, new KanmusuStats(57, 45, 40, 48, 24, 8, KanmusuClass.HeavyCruiser, 2));
            Data.Add(KanmusuDataClass.MayaClass, new KanmusuStats(55, 45, 40, 43, 24, 8, KanmusuClass.HeavyCruiser, 2));
            Data.Add(KanmusuDataClass.MogamiClass, new KanmusuStats(50, 37, 34, 24, 18, 22, KanmusuClass.AviationCruiser, 3));
            Data.Add(KanmusuDataClass.ToneClass, new KanmusuStats(56, 46, 41, 42, 24, 16, KanmusuClass.AviationCruiser, 2));
            Data.Add(KanmusuDataClass.AdmiralHipperClass,
                new KanmusuStats(63, 48, 40, 48, 40, 12, KanmusuClass.HeavyCruiser, 1));
            Data.Add(KanmusuDataClass.AkagiClass, new KanmusuStats(77, 40, 28, 0, 0, 82, KanmusuClass.AircraftCarrier, 1));
            Data.Add(KanmusuDataClass.KagaClass, new KanmusuStats(79, 40, 27, 0, 0, 98, KanmusuClass.AircraftCarrier, 1));
            Data.Add(KanmusuDataClass.ShimakazeClass, new KanmusuStats(36, 14, 55, 14, 48, 0, KanmusuClass.Destroyer, 1));
            Data.Add(KanmusuDataClass.TenryuuClass, new KanmusuStats(40, 28, 42, 20, 24, 0, KanmusuClass.LightCruiser, 3));
            Data.Add(KanmusuDataClass.SendaiClass, new KanmusuStats(44, 29, 40, 20, 24, 3, KanmusuClass.LightCruiser, 3));
            Data.Add(KanmusuDataClass.NagatoClass, new KanmusuStats(90, 85, 24, 90, 0, 12, KanmusuClass.BattleShip, 1));
        }
    }
}