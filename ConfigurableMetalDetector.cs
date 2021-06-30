using Terraria.ModLoader;
using Terraria;


namespace ConfigurableMetalDetector
{
	public class ConfigurableMetalDetector : Mod
	{
        public override void Load()
        {
			Main.tileValue[28] = (short)ModContent.GetInstance<Config>().PotValue;
			Main.tileValue[7] = (short)ModContent.GetInstance<Config>().CopperValue;
			Main.tileValue[166] = (short)ModContent.GetInstance<Config>().TinValue;
			Main.tileValue[6] = (short)ModContent.GetInstance<Config>().IronValue;
			Main.tileValue[167] = (short)ModContent.GetInstance<Config>().LeadValue;
			Main.tileValue[9] = (short)ModContent.GetInstance<Config>().SilverValue;
			Main.tileValue[168] = (short)ModContent.GetInstance<Config>().TungstenValue;
			Main.tileValue[37] = (short)ModContent.GetInstance<Config>().MeteoriteValue;
			Main.tileValue[22] = (short)ModContent.GetInstance<Config>().DemoniteValue;
			Main.tileValue[204] = (short)ModContent.GetInstance<Config>().CrimtaneValue;
			Main.tileValue[407] = (short)ModContent.GetInstance<Config>().SturdyFossilValue;
			Main.tileValue[8] = (short)ModContent.GetInstance<Config>().GoldValue;
			Main.tileValue[169] = (short)ModContent.GetInstance<Config>().PlatinumValue;
			Main.tileValue[21] = (short)ModContent.GetInstance<Config>().ChestValue;
			Main.tileValue[467] = (short)ModContent.GetInstance<Config>().ChestValue;
			Main.tileValue[441] = (short)ModContent.GetInstance<Config>().ChestValue;
			Main.tileValue[468] = (short)ModContent.GetInstance<Config>().ChestValue;
			Main.tileValue[107] = (short)ModContent.GetInstance<Config>().CobaltValue;
			Main.tileValue[221] = (short)ModContent.GetInstance<Config>().PalladiumValue;
			Main.tileValue[108] = (short)ModContent.GetInstance<Config>().MythrilValue;
			Main.tileValue[222] = (short)ModContent.GetInstance<Config>().OrichalcumValue;
			Main.tileValue[111] = (short)ModContent.GetInstance<Config>().AdamantiteValue;
			Main.tileValue[223] = (short)ModContent.GetInstance<Config>().TitaniumValue;
			Main.tileValue[211] = (short)ModContent.GetInstance<Config>().ChlorophyteValue;
			Main.tileValue[12] = (short)ModContent.GetInstance<Config>().LifeCrystalValue;
			Main.tileValue[236] = (short)ModContent.GetInstance<Config>().LifeFruitValue;
		}
    }
}