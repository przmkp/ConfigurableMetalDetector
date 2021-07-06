using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

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
            Main.tileValue[28] = (short)PotValue;
            Main.tileValue[7] = (short)CopperValue;
            Main.tileValue[166] = (short)TinValue;
            Main.tileValue[6] = (short)IronValue;
            Main.tileValue[167] = (short)LeadValue;
            Main.tileValue[9] = (short)SilverValue;
            Main.tileValue[168] = (short)TungstenValue;
            Main.tileValue[37] = (short)MeteoriteValue;
            Main.tileValue[22] = (short)DemoniteValue;
            Main.tileValue[204] = (short)CrimtaneValue;
            Main.tileValue[407] = (short)SturdyFossilValue;
            Main.tileValue[8] = (short)GoldValue;
            Main.tileValue[169] = (short)PlatinumValue;
            Main.tileValue[21] = (short)ChestValue;
            Main.tileValue[467] = (short)ChestValue;
            Main.tileValue[441] = (short)ChestValue;
            Main.tileValue[468] = (short)ChestValue;
            Main.tileValue[107] = (short)CobaltValue;
            Main.tileValue[221] = (short)PalladiumValue;
            Main.tileValue[108] = (short)MythrilValue;
            Main.tileValue[222] = (short)OrichalcumValue;
            Main.tileValue[111] = (short)AdamantiteValue;
            Main.tileValue[223] = (short)TitaniumValue;
            Main.tileValue[211] = (short)ChlorophyteValue;
            Main.tileValue[12] = (short)LifeCrystalValue;
            Main.tileValue[236] = (short)LifeFruitValue;

            if (GemsEnabled)
            {
                Main.tileValue[67] = (short)AmethystValue;
                Main.tileValue[66] = (short)TopazValue;
                Main.tileValue[63] = (short)SapphireValue;
                Main.tileValue[65] = (short)EmeraldValue;
                Main.tileValue[64] = (short)RubyValue;
                Main.tileValue[68] = (short)DiamondValue;
            }
            else
            {
                for (int i = 63; i <= 68; i++)
                    Main.tileValue[i] = 0;
            }
        }
    }
}
