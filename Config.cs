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
    }
}
