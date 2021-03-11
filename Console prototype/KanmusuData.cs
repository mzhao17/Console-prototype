using System.Collections.Generic;
//using System.Diagnostics;

namespace Console_prototype
{
    public sealed class KanmusuData
    {
        private static Dictionary<KanmusuDataClass, KanmusuStats> Data { get; } = new();
        private static Dictionary<string, KanmusuDataClass> NameData { get; } = new();

        public static KanmusuDataClass GetTypeFromName(string name)
        {
            return NameData.GetValueOrDefault(name);
            
        }

        public static KanmusuStats GetStatsFromType(KanmusuDataClass type)
        {
            return Data.GetValueOrDefault(type);
        }
        
        private static readonly string Ise = "Ise";
        private static readonly string Hyuuga = "Hyuuga";
        private static readonly string Fusou = "Fusou";
        private static readonly string Yamashiro = "Yamashiro";
        private static readonly string Kongou = "Kongou";
        private static readonly string Haruna = "Haruna";
        private static readonly string Hiei = "Hiei";
        private static readonly string Kirishima = "Kirishima";
        private static readonly string Yuudachi = "Yuudachi";
        private static readonly string Shigure = "Shigure";
        private static readonly string Nagato = "Nagato";
        private static readonly string Mutsu = "Mutsu";
        private static readonly string Akagi = "Akagi";
        private static readonly string Kaga = "Kaga";
        private static readonly string Shimakaze = "Shimakaze";
        private static readonly string Sendai = "Sendai";
        private static readonly string Naka = "Naka";
        private static readonly string Jintsuu = "Jintsuu";
        private static readonly string Tenryuu = "Tenryuu";
        private static readonly string Nachi = "Nachi";
        private static readonly string Ashigara = "Ashigara";
        private static readonly string Haguro = "Haguro";
        private static readonly string Takao = "Takao";
        private static readonly string Atago = "Atago";
        private static readonly string Maya = "Maya";
        private static readonly string Choukai = "Choukai";
        private static readonly string Suzuya = "Suzuya";
        private static readonly string Kumano = "Kumano";
        private static readonly string Tone = "Tone";
        private static readonly string Chikuma = "Chikuma";
        private static readonly string PrinzEugen = "Prinz Eugen";
        



        public KanmusuData()
        {
            Data.Add(KanmusuDataClass.IseClass,new KanmusuStats(77,74,36,63,0,47,KanmusuClass.AviationBattleship,1));
            Data.Add(KanmusuDataClass.FusouClass,new KanmusuStats(75,72,33,63,0,40,KanmusuClass.AviationBattleship,1));
            Data.Add(KanmusuDataClass.KongouClass,new KanmusuStats(75,67,35,72,0,12,KanmusuClass.BattleShip,1));
            Data.Add(KanmusuDataClass.ShiratsuyuClass,new KanmusuStats(30,14,45,12,28,0,KanmusuClass.Destroyer,3));
            Data.Add(KanmusuDataClass.MyoukouClass,new KanmusuStats(55,42,39,48,24,8,KanmusuClass.HeavyCruiser,2));
            Data.Add(KanmusuDataClass.TakaoClass,new KanmusuStats(57,45,40,48,24,8,KanmusuClass.HeavyCruiser,2));
            Data.Add(KanmusuDataClass.MayaClass,new KanmusuStats(55,45,40,43,24,8,KanmusuClass.HeavyCruiser,2));
            Data.Add(KanmusuDataClass.MogamiClass,new KanmusuStats(50,37,34,24,18,22,KanmusuClass.AviationCruiser,3));
            Data.Add(KanmusuDataClass.ToneClass,new KanmusuStats(56,46,41,42,24,16,KanmusuClass.AviationCruiser,2));
            Data.Add(KanmusuDataClass.AdmiralHipperClass,new KanmusuStats(63,48,40,48,40,12,KanmusuClass.HeavyCruiser,1));
            Data.Add(KanmusuDataClass.AkagiClass,new KanmusuStats(77,40,28,0,0,82,KanmusuClass.AircraftCarrier,1));
            Data.Add(KanmusuDataClass.KagaClass, new KanmusuStats(79, 40, 27, 0, 0, 98, KanmusuClass.AircraftCarrier,1));
            Data.Add(KanmusuDataClass.ShimakazeClass,new KanmusuStats(36,14,55,14,48,0,KanmusuClass.Destroyer,1));
            Data.Add(KanmusuDataClass.TenryuuClass,new KanmusuStats(40,28,42,20,24,0,KanmusuClass.LightCruiser,3));
            Data.Add(KanmusuDataClass.SendaiClass,new KanmusuStats(44,29,40,20,24,3,KanmusuClass.LightCruiser,3));
            Data.Add(KanmusuDataClass.NagatoClass,new KanmusuStats(90,85,24,90,0,12,KanmusuClass.BattleShip,1));
            
            NameData.Add(Ise,KanmusuDataClass.IseClass);
            NameData.Add(Hyuuga,KanmusuDataClass.IseClass);
            NameData.Add(Fusou,KanmusuDataClass.FusouClass);
            NameData.Add(Yamashiro,KanmusuDataClass.FusouClass);
            NameData.Add(Kongou,KanmusuDataClass.KongouClass);
            NameData.Add(Haruna,KanmusuDataClass.KongouClass);
            NameData.Add(Hiei,KanmusuDataClass.KongouClass);
            NameData.Add(Kirishima,KanmusuDataClass.KongouClass);
            NameData.Add(Yuudachi,KanmusuDataClass.ShiratsuyuClass);
            NameData.Add(Shigure,KanmusuDataClass.ShiratsuyuClass);
            NameData.Add(Nagato,KanmusuDataClass.NagatoClass);
            NameData.Add(Mutsu,KanmusuDataClass.NagatoClass);
            NameData.Add(Akagi,KanmusuDataClass.AkagiClass);
            NameData.Add(Kaga,KanmusuDataClass.KagaClass);
            NameData.Add(Shimakaze,KanmusuDataClass.ShimakazeClass);
            NameData.Add(Sendai,KanmusuDataClass.SendaiClass);
            NameData.Add(Naka,KanmusuDataClass.SendaiClass);
            NameData.Add(Jintsuu,KanmusuDataClass.SendaiClass);
            NameData.Add(Tenryuu,KanmusuDataClass.TenryuuClass);
            NameData.Add(Ashigara,KanmusuDataClass.MyoukouClass);
            NameData.Add(Nachi,KanmusuDataClass.MyoukouClass);
            NameData.Add(Haguro,KanmusuDataClass.MyoukouClass);
            NameData.Add(Takao,KanmusuDataClass.TakaoClass);
            NameData.Add(Atago,KanmusuDataClass.TakaoClass);
            NameData.Add(Maya,KanmusuDataClass.MayaClass);
            NameData.Add(Choukai,KanmusuDataClass.TakaoClass);
            NameData.Add(Suzuya,KanmusuDataClass.MogamiClass);
            NameData.Add(Kumano,KanmusuDataClass.MogamiClass);
            NameData.Add(Tone,KanmusuDataClass.ToneClass);
            NameData.Add(Chikuma,KanmusuDataClass.ToneClass);
            NameData.Add(PrinzEugen,KanmusuDataClass.AdmiralHipperClass);
        

        }
        

    }
}