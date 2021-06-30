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

        [Label("Pot")]
        [DefaultValue(100)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PotValue;

        [Label("Copper Ore")]
        [DefaultValue(200)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CopperValue;

        [Label("Tin Ore")]
        [DefaultValue(210)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TinValue;

        [Label("Iron Ore")]
        [DefaultValue(220)]
        [Range(0, 5000)]
        [Increment(10)]
        public int IronValue;

        [Label("Lead Ore")]
        [DefaultValue(230)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LeadValue;

        [Label("Silver Ore")]
        [DefaultValue(240)]
        [Range(0, 5000)]
        [Increment(10)]
        public int SilverValue;

        [Label("Tungsten Ore")]
        [DefaultValue(250)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TungstenValue;

        [Label("Meteorite")]
        [DefaultValue(300)]
        [Range(0, 5000)]
        [Increment(10)]
        public int MeteoriteValue;

        [Label("Demonite Ore")]
        [DefaultValue(310)]
        [Range(0, 5000)]
        [Increment(10)]
        public int DemoniteValue;

        [Label("Crimtane Ore")]
        [DefaultValue(320)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CrimtaneValue;

        [Label("Sturdy Fossil")]
        [DefaultValue(350)]
        [Range(0, 5000)]
        [Increment(10)]
        public int FossilValue;

        [Label("Gold Ore")]
        [DefaultValue(400)]
        [Range(0, 5000)]
        [Increment(10)]
        public int GoldValue;

        [Label("Platinum Ore")]
        [DefaultValue(410)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PlatinumValue;

        [Label("Chest")]
        [DefaultValue(500)]
        [Range(0, 5000)]
        [Increment(10)]
        public int ChestValue;

        [Label("Cobalt Ore")]
        [DefaultValue(600)]
        [Range(0, 5000)]
        [Increment(10)]
        public int CobaltValue;

        [Label("Palladium Ore")]
        [DefaultValue(610)]
        [Range(0, 5000)]
        [Increment(10)]
        public int PalladiumValue;

        [Label("Mythril Ore")]
        [DefaultValue(620)]
        [Range(0, 5000)]
        [Increment(10)]
        public int MythrilValue;

        [Label("Orichalcum Ore")]
        [DefaultValue(630)]
        [Range(0, 5000)]
        [Increment(10)]
        public int OrichalcumValue;

        [Label("Adamantite Ore")]
        [DefaultValue(640)]
        [Range(0, 5000)]
        [Increment(10)]
        public int AdamantiteValue;

        [Label("Titanium Ore")]
        [DefaultValue(650)]
        [Range(0, 5000)]
        [Increment(10)]
        public int TitaniumValue;

        [Label("Chlorophyte Ore")]
        [DefaultValue(700)]
        [Range(0, 5000)]
        [Increment(10)]
        public int ChlorophyteValue;

        [Label("Life Crystal")]
        [DefaultValue(510)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LifeCrystalValue;

        [Label("Life Fruit")]
        [DefaultValue(810)]
        [Range(0, 5000)]
        [Increment(10)]
        public int LifeFruitValue;
    }
}
