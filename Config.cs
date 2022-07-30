using System;
using System.ComponentModel;
using Terraria;
using Terraria.ModLoader.Config;

namespace ConfigurableMetalDetector
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("[i:474] Pot")]
        [DefaultValue(100)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PotValue;

        [Label("[i:12] Copper Ore")]
        [DefaultValue(200)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CopperValue;

        [Label("[i:699] Tin Ore")]
        [DefaultValue(210)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TinValue;

        [Label("[i:11] Iron Ore")]
        [DefaultValue(220)]
        [Range(0, 5000)]
        [Increment(10)]
        public int IronValue;

        [Label("[i:700] Lead Ore")]
        [DefaultValue(230)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LeadValue;

        [Label("[i:14] Silver Ore")]
        [DefaultValue(240)]
        [Range(0, 5000)]
        [Increment(10)]
        public int SilverValue;

        [Label("[i:701] Tungsten Ore")]
        [DefaultValue(250)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TungstenValue;

        [Label("[i:116] Meteorite")]
        [DefaultValue(300)]
        [Range(0, 5000)]
        [Increment(10)]
        public int MeteoriteValue;

        [Label("[i:56] Demonite Ore")]
        [DefaultValue(310)]
        [Range(0, 5000)]
        [Increment(10)]
        public int DemoniteValue;

        [Label("[i:880] Crimtane Ore")]
        [DefaultValue(320)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CrimtaneValue;

        [Label("[i:3380] Sturdy Fossil")]
        [DefaultValue(350)]
        [Range(0, 5000)]
        [Increment(10)]
        public int SturdyFossilValue;

        [Label("[i:13] Gold Ore")]
        [DefaultValue(400)]
        [Range(0, 5000)]
        [Increment(10)]
        public int GoldValue;

        [Label("[i:702] Platinum Ore")]
        [DefaultValue(410)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PlatinumValue;

        [Label("[i:48] Chest")]
        [DefaultValue(500)]
        [Range(0, 5000)]
        [Increment(10)]
        public int ChestValue;

        [Label("[i:364] Cobalt Ore")]
        [DefaultValue(600)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CobaltValue;

        [Label("[i:1104] Palladium Ore")]
        [DefaultValue(610)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PalladiumValue;

        [Label("[i:365] Mythril Ore")]
        [DefaultValue(620)]
        [Range(0, 5000)]
        [Increment(10)]
        public int MythrilValue;

        [Label("[i:1105] Orichalcum Ore")]
        [DefaultValue(630)]
        [Range(0, 5000)]
        [Increment(10)]
        public int OrichalcumValue;

        [Label("[i:366] Adamantite Ore")]
        [DefaultValue(640)]
        [Range(0, 5000)]
        [Increment(10)]
        public int AdamantiteValue;

        [Label("[i:1106] Titanium Ore")]
        [DefaultValue(650)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TitaniumValue;

        [Label("[i:947] Chlorophyte Ore")]
        [DefaultValue(700)]
        [Range(0, 5000)]
        [Increment(10)]
        public int ChlorophyteValue;

        [Label("[i:29] Life Crystal")]
        [DefaultValue(510)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LifeCrystalValue;

        [Label("[i:1291] Life Fruit")]
        [DefaultValue(810)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LifeFruitValue;

        [Header("Gems")]
        [Label("Enable gem detection")]
        [DefaultValue(false)]
        public bool GemsEnabled;

        [Label("[i:181] Amethyst")]
        [DefaultValue(420)]
        [Range(0, 5000)]
        [Increment(10)]
        public int AmethystValue;

        [Label("[i:180] Topaz")]
        [DefaultValue(430)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TopazValue;

        [Label("[i:177] Sapphire")]
        [DefaultValue(440)]
        [Range(0, 5000)]
        [Increment(10)]
        public int SapphireValue;

        [Label("[i:179] Emerald")]
        [DefaultValue(450)]
        [Range(0, 5000)]
        [Increment(10)]
        public int EmeraldValue;

        [Label("[i:178] Ruby")]
        [DefaultValue(460)]
        [Range(0, 5000)]
        [Increment(10)]
        public int RubyValue;

        [Label("[i:182] Diamond")]
        [DefaultValue(470)]
        [Range(0, 5000)]
        [Increment(10)]
        public int DiamondValue;

        public override void OnChanged()
        {
            Main.tileOreFinderPriority[28] = (short)PotValue;
            Main.tileOreFinderPriority[7] = (short)CopperValue;
            Main.tileOreFinderPriority[166] = (short)TinValue;
            Main.tileOreFinderPriority[6] = (short)IronValue;
            Main.tileOreFinderPriority[167] = (short)LeadValue;
            Main.tileOreFinderPriority[9] = (short)SilverValue;
            Main.tileOreFinderPriority[168] = (short)TungstenValue;
            Main.tileOreFinderPriority[37] = (short)MeteoriteValue;
            Main.tileOreFinderPriority[22] = (short)DemoniteValue;
            Main.tileOreFinderPriority[204] = (short)CrimtaneValue;
            Main.tileOreFinderPriority[407] = (short)SturdyFossilValue;
            Main.tileOreFinderPriority[8] = (short)GoldValue;
            Main.tileOreFinderPriority[169] = (short)PlatinumValue;
            Main.tileOreFinderPriority[21] = (short)ChestValue;
            Main.tileOreFinderPriority[467] = (short)ChestValue;
            Main.tileOreFinderPriority[441] = (short)ChestValue;
            Main.tileOreFinderPriority[468] = (short)ChestValue;
            Main.tileOreFinderPriority[107] = (short)CobaltValue;
            Main.tileOreFinderPriority[221] = (short)PalladiumValue;
            Main.tileOreFinderPriority[108] = (short)MythrilValue;
            Main.tileOreFinderPriority[222] = (short)OrichalcumValue;
            Main.tileOreFinderPriority[111] = (short)AdamantiteValue;
            Main.tileOreFinderPriority[223] = (short)TitaniumValue;
            Main.tileOreFinderPriority[211] = (short)ChlorophyteValue;
            Main.tileOreFinderPriority[12] = (short)LifeCrystalValue;
            Main.tileOreFinderPriority[236] = (short)LifeFruitValue;

            if (GemsEnabled)
            {
                Main.tileOreFinderPriority[67] = (short)AmethystValue;
                Main.tileOreFinderPriority[66] = (short)TopazValue;
                Main.tileOreFinderPriority[63] = (short)SapphireValue;
                Main.tileOreFinderPriority[65] = (short)EmeraldValue;
                Main.tileOreFinderPriority[64] = (short)RubyValue;
                Main.tileOreFinderPriority[68] = (short)DiamondValue;
            }
            else
            {
                for (int i = 63; i <= 68; i++)
                    Main.tileOreFinderPriority[i] = 0;
            }
        }
    }
}
