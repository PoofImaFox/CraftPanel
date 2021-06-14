using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MinecraftServerHostLib.Tracking {
#nullable disable
    public class PlayerStats {
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("DataVersion")]
        public int DataVersion { get; set; }
    }

    public class MinecraftKilled {
        [JsonPropertyName("minecraft:cave_spider")]
        public int MinecraftCaveSpider { get; set; }

        [JsonPropertyName("minecraft:spider")]
        public int MinecraftSpider { get; set; }

        [JsonPropertyName("minecraft:skeleton")]
        public int MinecraftSkeleton { get; set; }

        [JsonPropertyName("minecraft:chicken")]
        public int MinecraftChicken { get; set; }

        [JsonPropertyName("minecraft:axolotl")]
        public int MinecraftAxolotl { get; set; }

        [JsonPropertyName("minecraft:silverfish")]
        public int MinecraftSilverfish { get; set; }

        [JsonPropertyName("minecraft:magma_cube")]
        public int MinecraftMagmaCube { get; set; }

        [JsonPropertyName("minecraft:piglin")]
        public int MinecraftPiglin { get; set; }

        [JsonPropertyName("minecraft:pig")]
        public int MinecraftPig { get; set; }

        [JsonPropertyName("minecraft:creeper")]
        public int MinecraftCreeper { get; set; }

        [JsonPropertyName("minecraft:sheep")]
        public int MinecraftSheep { get; set; }

        [JsonPropertyName("minecraft:pillager")]
        public int MinecraftPillager { get; set; }

        [JsonPropertyName("minecraft:zombie")]
        public int MinecraftZombie { get; set; }

        [JsonPropertyName("minecraft:glow_squid")]
        public int MinecraftGlowSquid { get; set; }
    }

    public class MinecraftPickedUp {
        [JsonPropertyName("minecraft:chiseled_deepslate")]
        public int MinecraftChiseledDeepslate { get; set; }

        [JsonPropertyName("minecraft:crafting_table")]
        public int MinecraftCraftingTable { get; set; }

        [JsonPropertyName("minecraft:iron_chestplate")]
        public int MinecraftIronChestplate { get; set; }

        [JsonPropertyName("minecraft:wheat")]
        public int MinecraftWheat { get; set; }

        [JsonPropertyName("minecraft:chicken")]
        public int MinecraftChicken { get; set; }

        [JsonPropertyName("minecraft:shield")]
        public int MinecraftShield { get; set; }

        [JsonPropertyName("minecraft:music_disc_cat")]
        public int MinecraftMusicDiscCat { get; set; }

        [JsonPropertyName("minecraft:string")]
        public int MinecraftString { get; set; }

        [JsonPropertyName("minecraft:dark_oak_trapdoor")]
        public int MinecraftDarkOakTrapdoor { get; set; }

        [JsonPropertyName("minecraft:raw_copper")]
        public int MinecraftRawCopper { get; set; }

        [JsonPropertyName("minecraft:wooden_sword")]
        public int MinecraftWoodenSword { get; set; }

        [JsonPropertyName("minecraft:iron_leggings")]
        public int MinecraftIronLeggings { get; set; }

        [JsonPropertyName("minecraft:iron_shovel")]
        public int MinecraftIronShovel { get; set; }

        [JsonPropertyName("minecraft:gold_nugget")]
        public int MinecraftGoldNugget { get; set; }

        [JsonPropertyName("minecraft:cobbled_deepslate")]
        public int MinecraftCobbledDeepslate { get; set; }

        [JsonPropertyName("minecraft:oak_boat")]
        public int MinecraftOakBoat { get; set; }

        [JsonPropertyName("minecraft:rose_bush")]
        public int MinecraftRoseBush { get; set; }

        [JsonPropertyName("minecraft:poppy")]
        public int MinecraftPoppy { get; set; }

        [JsonPropertyName("minecraft:iron_pickaxe")]
        public int MinecraftIronPickaxe { get; set; }

        [JsonPropertyName("minecraft:chest")]
        public int MinecraftChest { get; set; }

        [JsonPropertyName("minecraft:furnace")]
        public int MinecraftFurnace { get; set; }

        [JsonPropertyName("minecraft:iron_boots")]
        public int MinecraftIronBoots { get; set; }

        [JsonPropertyName("minecraft:egg")]
        public int MinecraftEgg { get; set; }

        [JsonPropertyName("minecraft:golden_helmet")]
        public int MinecraftGoldenHelmet { get; set; }

        [JsonPropertyName("minecraft:raw_iron")]
        public int MinecraftRawIron { get; set; }

        [JsonPropertyName("minecraft:oak_fence")]
        public int MinecraftOakFence { get; set; }

        [JsonPropertyName("minecraft:torch")]
        public int MinecraftTorch { get; set; }

        [JsonPropertyName("minecraft:porkchop")]
        public int MinecraftPorkchop { get; set; }

        [JsonPropertyName("minecraft:pointed_dripstone")]
        public int MinecraftPointedDripstone { get; set; }

        [JsonPropertyName("minecraft:diorite")]
        public int MinecraftDiorite { get; set; }

        [JsonPropertyName("minecraft:carrot")]
        public int MinecraftCarrot { get; set; }

        [JsonPropertyName("minecraft:redstone")]
        public int MinecraftRedstone { get; set; }

        [JsonPropertyName("minecraft:cauldron")]
        public int MinecraftCauldron { get; set; }

        [JsonPropertyName("minecraft:arrow")]
        public int MinecraftArrow { get; set; }

        [JsonPropertyName("minecraft:rotten_flesh")]
        public int MinecraftRottenFlesh { get; set; }

        [JsonPropertyName("minecraft:peony")]
        public int MinecraftPeony { get; set; }

        [JsonPropertyName("minecraft:music_disc_wait")]
        public int MinecraftMusicDiscWait { get; set; }

        [JsonPropertyName("minecraft:mutton")]
        public int MinecraftMutton { get; set; }

        [JsonPropertyName("minecraft:cod")]
        public int MinecraftCod { get; set; }

        [JsonPropertyName("minecraft:snowball")]
        public int MinecraftSnowball { get; set; }

        [JsonPropertyName("minecraft:white_wool")]
        public int MinecraftWhiteWool { get; set; }

        [JsonPropertyName("minecraft:cobblestone")]
        public int MinecraftCobblestone { get; set; }

        [JsonPropertyName("minecraft:birch_log")]
        public int MinecraftBirchLog { get; set; }

        [JsonPropertyName("minecraft:feather")]
        public int MinecraftFeather { get; set; }

        [JsonPropertyName("minecraft:magma_cream")]
        public int MinecraftMagmaCream { get; set; }

        [JsonPropertyName("minecraft:golden_carrot")]
        public int MinecraftGoldenCarrot { get; set; }

        [JsonPropertyName("minecraft:glow_ink_sac")]
        public int MinecraftGlowInkSac { get; set; }

        [JsonPropertyName("minecraft:andesite")]
        public int MinecraftAndesite { get; set; }

        [JsonPropertyName("minecraft:copper_block")]
        public int MinecraftCopperBlock { get; set; }

        [JsonPropertyName("minecraft:tuff")]
        public int MinecraftTuff { get; set; }

        [JsonPropertyName("minecraft:oak_log")]
        public int MinecraftOakLog { get; set; }

        [JsonPropertyName("minecraft:lily_pad")]
        public int MinecraftLilyPad { get; set; }

        [JsonPropertyName("minecraft:golden_boots")]
        public int MinecraftGoldenBoots { get; set; }

        [JsonPropertyName("minecraft:gunpowder")]
        public int MinecraftGunpowder { get; set; }

        [JsonPropertyName("minecraft:lapis_lazuli")]
        public int MinecraftLapisLazuli { get; set; }

        [JsonPropertyName("minecraft:dirt")]
        public int MinecraftDirt { get; set; }

        [JsonPropertyName("minecraft:bone")]
        public int MinecraftBone { get; set; }

        [JsonPropertyName("minecraft:apple")]
        public int MinecraftApple { get; set; }

        [JsonPropertyName("minecraft:kelp")]
        public int MinecraftKelp { get; set; }

        [JsonPropertyName("minecraft:wheat_seeds")]
        public int MinecraftWheatSeeds { get; set; }

        [JsonPropertyName("minecraft:raw_gold")]
        public int MinecraftRawGold { get; set; }

        [JsonPropertyName("minecraft:iron_sword")]
        public int MinecraftIronSword { get; set; }

        [JsonPropertyName("minecraft:oak_planks")]
        public int MinecraftOakPlanks { get; set; }

        [JsonPropertyName("minecraft:cooked_porkchop")]
        public int MinecraftCookedPorkchop { get; set; }

        [JsonPropertyName("minecraft:music_disc_13")]
        public int MinecraftMusicDisc13 { get; set; }

        [JsonPropertyName("minecraft:sweet_berries")]
        public int MinecraftSweetBerries { get; set; }

        [JsonPropertyName("minecraft:lava_bucket")]
        public int MinecraftLavaBucket { get; set; }

        [JsonPropertyName("minecraft:dandelion")]
        public int MinecraftDandelion { get; set; }

        [JsonPropertyName("minecraft:spyglass")]
        public int MinecraftSpyglass { get; set; }

        [JsonPropertyName("minecraft:dripstone_block")]
        public int MinecraftDripstoneBlock { get; set; }

        [JsonPropertyName("minecraft:gravel")]
        public int MinecraftGravel { get; set; }

        [JsonPropertyName("minecraft:sand")]
        public int MinecraftSand { get; set; }

        [JsonPropertyName("minecraft:iron_hoe")]
        public int MinecraftIronHoe { get; set; }

        [JsonPropertyName("minecraft:diamond")]
        public int MinecraftDiamond { get; set; }

        [JsonPropertyName("minecraft:stone_axe")]
        public int MinecraftStoneAxe { get; set; }

        [JsonPropertyName("minecraft:granite")]
        public int MinecraftGranite { get; set; }

        [JsonPropertyName("minecraft:emerald")]
        public int MinecraftEmerald { get; set; }

        [JsonPropertyName("minecraft:baked_potato")]
        public int MinecraftBakedPotato { get; set; }

        [JsonPropertyName("minecraft:oak_sapling")]
        public int MinecraftOakSapling { get; set; }

        [JsonPropertyName("minecraft:coal")]
        public int MinecraftCoal { get; set; }
    }

    public class MinecraftBroken {
        [JsonPropertyName("minecraft:iron_shovel")]
        public int MinecraftIronShovel { get; set; }

        [JsonPropertyName("minecraft:golden_boots")]
        public int MinecraftGoldenBoots { get; set; }

        [JsonPropertyName("minecraft:wooden_shovel")]
        public int MinecraftWoodenShovel { get; set; }

        [JsonPropertyName("minecraft:iron_pickaxe")]
        public int MinecraftIronPickaxe { get; set; }
    }

    public class MinecraftUsed {
        [JsonPropertyName("minecraft:peony")]
        public int MinecraftPeony { get; set; }

        [JsonPropertyName("minecraft:rose_bush")]
        public int MinecraftRoseBush { get; set; }

        [JsonPropertyName("minecraft:iron_shovel")]
        public int MinecraftIronShovel { get; set; }

        [JsonPropertyName("minecraft:dried_kelp")]
        public int MinecraftDriedKelp { get; set; }

        [JsonPropertyName("minecraft:poppy")]
        public int MinecraftPoppy { get; set; }

        [JsonPropertyName("minecraft:oak_sign")]
        public int MinecraftOakSign { get; set; }

        [JsonPropertyName("minecraft:chest")]
        public int MinecraftChest { get; set; }

        [JsonPropertyName("minecraft:shield")]
        public int MinecraftShield { get; set; }

        [JsonPropertyName("minecraft:iron_sword")]
        public int MinecraftIronSword { get; set; }

        [JsonPropertyName("minecraft:wooden_shovel")]
        public int MinecraftWoodenShovel { get; set; }

        [JsonPropertyName("minecraft:iron_chestplate")]
        public int MinecraftIronChestplate { get; set; }

        [JsonPropertyName("minecraft:torch")]
        public int MinecraftTorch { get; set; }

        [JsonPropertyName("minecraft:spyglass")]
        public int MinecraftSpyglass { get; set; }

        [JsonPropertyName("minecraft:dirt")]
        public int MinecraftDirt { get; set; }

        [JsonPropertyName("minecraft:mutton")]
        public int MinecraftMutton { get; set; }

        [JsonPropertyName("minecraft:anvil")]
        public int MinecraftAnvil { get; set; }

        [JsonPropertyName("minecraft:cut_copper")]
        public int MinecraftCutCopper { get; set; }

        [JsonPropertyName("minecraft:carrot")]
        public int MinecraftCarrot { get; set; }

        [JsonPropertyName("minecraft:tuff")]
        public int MinecraftTuff { get; set; }

        [JsonPropertyName("minecraft:music_disc_13")]
        public int MinecraftMusicDisc13 { get; set; }

        [JsonPropertyName("minecraft:granite")]
        public int MinecraftGranite { get; set; }

        [JsonPropertyName("minecraft:snowball")]
        public int MinecraftSnowball { get; set; }

        [JsonPropertyName("minecraft:iron_hoe")]
        public int MinecraftIronHoe { get; set; }

        [JsonPropertyName("minecraft:lava_bucket")]
        public int MinecraftLavaBucket { get; set; }

        [JsonPropertyName("minecraft:iron_helmet")]
        public int MinecraftIronHelmet { get; set; }

        [JsonPropertyName("minecraft:iron_boots")]
        public int MinecraftIronBoots { get; set; }

        [JsonPropertyName("minecraft:music_disc_wait")]
        public int MinecraftMusicDiscWait { get; set; }

        [JsonPropertyName("minecraft:golden_carrot")]
        public int MinecraftGoldenCarrot { get; set; }

        [JsonPropertyName("minecraft:sweet_berries")]
        public int MinecraftSweetBerries { get; set; }

        [JsonPropertyName("minecraft:oak_sapling")]
        public int MinecraftOakSapling { get; set; }

        [JsonPropertyName("minecraft:furnace")]
        public int MinecraftFurnace { get; set; }

        [JsonPropertyName("minecraft:cooked_cod")]
        public int MinecraftCookedCod { get; set; }

        [JsonPropertyName("minecraft:egg")]
        public int MinecraftEgg { get; set; }

        [JsonPropertyName("minecraft:cobbled_deepslate")]
        public int MinecraftCobbledDeepslate { get; set; }

        [JsonPropertyName("minecraft:pointed_dripstone")]
        public int MinecraftPointedDripstone { get; set; }

        [JsonPropertyName("minecraft:iron_leggings")]
        public int MinecraftIronLeggings { get; set; }

        [JsonPropertyName("minecraft:wheat_seeds")]
        public int MinecraftWheatSeeds { get; set; }

        [JsonPropertyName("minecraft:water_bucket")]
        public int MinecraftWaterBucket { get; set; }

        [JsonPropertyName("minecraft:diorite")]
        public int MinecraftDiorite { get; set; }

        [JsonPropertyName("minecraft:snow_block")]
        public int MinecraftSnowBlock { get; set; }

        [JsonPropertyName("minecraft:baked_potato")]
        public int MinecraftBakedPotato { get; set; }

        [JsonPropertyName("minecraft:oak_planks")]
        public int MinecraftOakPlanks { get; set; }

        [JsonPropertyName("minecraft:copper_block")]
        public int MinecraftCopperBlock { get; set; }

        [JsonPropertyName("minecraft:wooden_pickaxe")]
        public int MinecraftWoodenPickaxe { get; set; }

        [JsonPropertyName("minecraft:cauldron")]
        public int MinecraftCauldron { get; set; }

        [JsonPropertyName("minecraft:stonecutter")]
        public int MinecraftStonecutter { get; set; }

        [JsonPropertyName("minecraft:dark_oak_trapdoor")]
        public int MinecraftDarkOakTrapdoor { get; set; }

        [JsonPropertyName("minecraft:sand")]
        public int MinecraftSand { get; set; }

        [JsonPropertyName("minecraft:crafting_table")]
        public int MinecraftCraftingTable { get; set; }

        [JsonPropertyName("minecraft:cod")]
        public int MinecraftCod { get; set; }

        [JsonPropertyName("minecraft:white_bed")]
        public int MinecraftWhiteBed { get; set; }

        [JsonPropertyName("minecraft:dripstone_block")]
        public int MinecraftDripstoneBlock { get; set; }

        [JsonPropertyName("minecraft:chicken")]
        public int MinecraftChicken { get; set; }

        [JsonPropertyName("minecraft:diamond_pickaxe")]
        public int MinecraftDiamondPickaxe { get; set; }

        [JsonPropertyName("minecraft:apple")]
        public int MinecraftApple { get; set; }

        [JsonPropertyName("minecraft:iron_pickaxe")]
        public int MinecraftIronPickaxe { get; set; }

        [JsonPropertyName("minecraft:string")]
        public int MinecraftString { get; set; }

        [JsonPropertyName("minecraft:suspicious_stew")]
        public int MinecraftSuspiciousStew { get; set; }

        [JsonPropertyName("minecraft:bread")]
        public int MinecraftBread { get; set; }

        [JsonPropertyName("minecraft:stone_axe")]
        public int MinecraftStoneAxe { get; set; }

        [JsonPropertyName("minecraft:golden_helmet")]
        public int MinecraftGoldenHelmet { get; set; }

        [JsonPropertyName("minecraft:wooden_sword")]
        public int MinecraftWoodenSword { get; set; }

        [JsonPropertyName("minecraft:cobblestone")]
        public int MinecraftCobblestone { get; set; }

        [JsonPropertyName("minecraft:porkchop")]
        public int MinecraftPorkchop { get; set; }

        [JsonPropertyName("minecraft:cooked_porkchop")]
        public int MinecraftCookedPorkchop { get; set; }

        [JsonPropertyName("minecraft:smithing_table")]
        public int MinecraftSmithingTable { get; set; }

        [JsonPropertyName("minecraft:andesite")]
        public int MinecraftAndesite { get; set; }

        [JsonPropertyName("minecraft:bucket")]
        public int MinecraftBucket { get; set; }

        [JsonPropertyName("minecraft:oak_boat")]
        public int MinecraftOakBoat { get; set; }

        [JsonPropertyName("minecraft:dandelion")]
        public int MinecraftDandelion { get; set; }

        [JsonPropertyName("minecraft:bone_meal")]
        public int MinecraftBoneMeal { get; set; }

        [JsonPropertyName("minecraft:oak_fence")]
        public int MinecraftOakFence { get; set; }
    }

    public class MinecraftMined {
        [JsonPropertyName("minecraft:nether_gold_ore")]
        public int MinecraftNetherGoldOre { get; set; }

        [JsonPropertyName("minecraft:diamond_ore")]
        public int MinecraftDiamondOre { get; set; }

        [JsonPropertyName("minecraft:tuff")]
        public int MinecraftTuff { get; set; }

        [JsonPropertyName("minecraft:glow_lichen")]
        public int MinecraftGlowLichen { get; set; }

        [JsonPropertyName("minecraft:granite")]
        public int MinecraftGranite { get; set; }

        [JsonPropertyName("minecraft:grass_block")]
        public int MinecraftGrassBlock { get; set; }

        [JsonPropertyName("minecraft:brown_mushroom_block")]
        public int MinecraftBrownMushroomBlock { get; set; }

        [JsonPropertyName("minecraft:kelp")]
        public int MinecraftKelp { get; set; }

        [JsonPropertyName("minecraft:large_fern")]
        public int MinecraftLargeFern { get; set; }

        [JsonPropertyName("minecraft:tall_seagrass")]
        public int MinecraftTallSeagrass { get; set; }

        [JsonPropertyName("minecraft:redstone_ore")]
        public int MinecraftRedstoneOre { get; set; }

        [JsonPropertyName("minecraft:furnace")]
        public int MinecraftFurnace { get; set; }

        [JsonPropertyName("minecraft:carrots")]
        public int MinecraftCarrots { get; set; }

        [JsonPropertyName("minecraft:dark_oak_trapdoor")]
        public int MinecraftDarkOakTrapdoor { get; set; }

        [JsonPropertyName("minecraft:iron_ore")]
        public int MinecraftIronOre { get; set; }

        [JsonPropertyName("minecraft:fire")]
        public int MinecraftFire { get; set; }

        [JsonPropertyName("minecraft:snow")]
        public int MinecraftSnow { get; set; }

        [JsonPropertyName("minecraft:andesite")]
        public int MinecraftAndesite { get; set; }

        [JsonPropertyName("minecraft:peony")]
        public int MinecraftPeony { get; set; }

        [JsonPropertyName("minecraft:pointed_dripstone")]
        public int MinecraftPointedDripstone { get; set; }

        [JsonPropertyName("minecraft:deepslate_iron_ore")]
        public int MinecraftDeepslateIronOre { get; set; }

        [JsonPropertyName("minecraft:stone")]
        public int MinecraftStone { get; set; }

        [JsonPropertyName("minecraft:deepslate_redstone_ore")]
        public int MinecraftDeepslateRedstoneOre { get; set; }

        [JsonPropertyName("minecraft:kelp_plant")]
        public int MinecraftKelpPlant { get; set; }

        [JsonPropertyName("minecraft:snow_block")]
        public int MinecraftSnowBlock { get; set; }

        [JsonPropertyName("minecraft:oak_fence")]
        public int MinecraftOakFence { get; set; }

        [JsonPropertyName("minecraft:crafting_table")]
        public int MinecraftCraftingTable { get; set; }

        [JsonPropertyName("minecraft:torch")]
        public int MinecraftTorch { get; set; }

        [JsonPropertyName("minecraft:emerald_ore")]
        public int MinecraftEmeraldOre { get; set; }

        [JsonPropertyName("minecraft:chest")]
        public int MinecraftChest { get; set; }

        [JsonPropertyName("minecraft:rose_bush")]
        public int MinecraftRoseBush { get; set; }

        [JsonPropertyName("minecraft:copper_ore")]
        public int MinecraftCopperOre { get; set; }

        [JsonPropertyName("minecraft:tall_grass")]
        public int MinecraftTallGrass { get; set; }

        [JsonPropertyName("minecraft:cobblestone")]
        public int MinecraftCobblestone { get; set; }

        [JsonPropertyName("minecraft:deepslate_coal_ore")]
        public int MinecraftDeepslateCoalOre { get; set; }

        [JsonPropertyName("minecraft:deepslate_gold_ore")]
        public int MinecraftDeepslateGoldOre { get; set; }

        [JsonPropertyName("minecraft:lapis_ore")]
        public int MinecraftLapisOre { get; set; }

        [JsonPropertyName("minecraft:oak_planks")]
        public int MinecraftOakPlanks { get; set; }

        [JsonPropertyName("minecraft:diorite")]
        public int MinecraftDiorite { get; set; }

        [JsonPropertyName("minecraft:wall_torch")]
        public int MinecraftWallTorch { get; set; }

        [JsonPropertyName("minecraft:cauldron")]
        public int MinecraftCauldron { get; set; }

        [JsonPropertyName("minecraft:seagrass")]
        public int MinecraftSeagrass { get; set; }

        [JsonPropertyName("minecraft:sweet_berry_bush")]
        public int MinecraftSweetBerryBush { get; set; }

        [JsonPropertyName("minecraft:birch_log")]
        public int MinecraftBirchLog { get; set; }

        [JsonPropertyName("minecraft:ice")]
        public int MinecraftIce { get; set; }

        [JsonPropertyName("minecraft:wheat")]
        public int MinecraftWheat { get; set; }

        [JsonPropertyName("minecraft:birch_leaves")]
        public int MinecraftBirchLeaves { get; set; }

        [JsonPropertyName("minecraft:copper_block")]
        public int MinecraftCopperBlock { get; set; }

        [JsonPropertyName("minecraft:grass")]
        public int MinecraftGrass { get; set; }

        [JsonPropertyName("minecraft:oak_log")]
        public int MinecraftOakLog { get; set; }

        [JsonPropertyName("minecraft:coal_ore")]
        public int MinecraftCoalOre { get; set; }

        [JsonPropertyName("minecraft:gravel")]
        public int MinecraftGravel { get; set; }

        [JsonPropertyName("minecraft:dripstone_block")]
        public int MinecraftDripstoneBlock { get; set; }

        [JsonPropertyName("minecraft:sand")]
        public int MinecraftSand { get; set; }

        [JsonPropertyName("minecraft:dirt")]
        public int MinecraftDirt { get; set; }

        [JsonPropertyName("minecraft:netherrack")]
        public int MinecraftNetherrack { get; set; }

        [JsonPropertyName("minecraft:gold_ore")]
        public int MinecraftGoldOre { get; set; }

        [JsonPropertyName("minecraft:oak_leaves")]
        public int MinecraftOakLeaves { get; set; }

        [JsonPropertyName("minecraft:deepslate")]
        public int MinecraftDeepslate { get; set; }

        [JsonPropertyName("minecraft:infested_stone")]
        public int MinecraftInfestedStone { get; set; }
    }

    public class MinecraftKilledBy {
        [JsonPropertyName("minecraft:player")]
        public int MinecraftPlayer { get; set; }

        [JsonPropertyName("minecraft:creeper")]
        public int MinecraftCreeper { get; set; }

        [JsonPropertyName("minecraft:skeleton")]
        public int MinecraftSkeleton { get; set; }

        [JsonPropertyName("minecraft:zombie")]
        public int MinecraftZombie { get; set; }
    }

    public class MinecraftCrafted {
        [JsonPropertyName("minecraft:golden_carrot")]
        public int MinecraftGoldenCarrot { get; set; }

        [JsonPropertyName("minecraft:wooden_sword")]
        public int MinecraftWoodenSword { get; set; }

        [JsonPropertyName("minecraft:oak_planks")]
        public int MinecraftOakPlanks { get; set; }

        [JsonPropertyName("minecraft:oak_sign")]
        public int MinecraftOakSign { get; set; }

        [JsonPropertyName("minecraft:furnace")]
        public int MinecraftFurnace { get; set; }

        [JsonPropertyName("minecraft:stone")]
        public int MinecraftStone { get; set; }

        [JsonPropertyName("minecraft:bone_meal")]
        public int MinecraftBoneMeal { get; set; }

        [JsonPropertyName("minecraft:iron_boots")]
        public int MinecraftIronBoots { get; set; }

        [JsonPropertyName("minecraft:polished_deepslate")]
        public int MinecraftPolishedDeepslate { get; set; }

        [JsonPropertyName("minecraft:iron_axe")]
        public int MinecraftIronAxe { get; set; }

        [JsonPropertyName("minecraft:iron_hoe")]
        public int MinecraftIronHoe { get; set; }

        [JsonPropertyName("minecraft:chest")]
        public int MinecraftChest { get; set; }

        [JsonPropertyName("minecraft:copper_block")]
        public int MinecraftCopperBlock { get; set; }

        [JsonPropertyName("minecraft:oak_fence")]
        public int MinecraftOakFence { get; set; }

        [JsonPropertyName("minecraft:wooden_shovel")]
        public int MinecraftWoodenShovel { get; set; }

        [JsonPropertyName("minecraft:cauldron")]
        public int MinecraftCauldron { get; set; }

        [JsonPropertyName("minecraft:cooked_porkchop")]
        public int MinecraftCookedPorkchop { get; set; }

        [JsonPropertyName("minecraft:crafting_table")]
        public int MinecraftCraftingTable { get; set; }

        [JsonPropertyName("minecraft:wooden_pickaxe")]
        public int MinecraftWoodenPickaxe { get; set; }

        [JsonPropertyName("minecraft:iron_helmet")]
        public int MinecraftIronHelmet { get; set; }

        [JsonPropertyName("minecraft:smithing_table")]
        public int MinecraftSmithingTable { get; set; }

        [JsonPropertyName("minecraft:copper_ingot")]
        public int MinecraftCopperIngot { get; set; }

        [JsonPropertyName("minecraft:bucket")]
        public int MinecraftBucket { get; set; }

        [JsonPropertyName("minecraft:birch_planks")]
        public int MinecraftBirchPlanks { get; set; }

        [JsonPropertyName("minecraft:deepslate_tiles")]
        public int MinecraftDeepslateTiles { get; set; }

        [JsonPropertyName("minecraft:stone_axe")]
        public int MinecraftStoneAxe { get; set; }

        [JsonPropertyName("minecraft:bread")]
        public int MinecraftBread { get; set; }

        [JsonPropertyName("minecraft:air")]
        public int MinecraftAir { get; set; }

        [JsonPropertyName("minecraft:oak_boat")]
        public int MinecraftOakBoat { get; set; }

        [JsonPropertyName("minecraft:iron_chestplate")]
        public int MinecraftIronChestplate { get; set; }

        [JsonPropertyName("minecraft:diamond_pickaxe")]
        public int MinecraftDiamondPickaxe { get; set; }

        [JsonPropertyName("minecraft:chiseled_deepslate")]
        public int MinecraftChiseledDeepslate { get; set; }

        [JsonPropertyName("minecraft:gold_nugget")]
        public int MinecraftGoldNugget { get; set; }

        [JsonPropertyName("minecraft:shield")]
        public int MinecraftShield { get; set; }

        [JsonPropertyName("minecraft:stick")]
        public int MinecraftStick { get; set; }

        [JsonPropertyName("minecraft:iron_ingot")]
        public int MinecraftIronIngot { get; set; }

        [JsonPropertyName("minecraft:iron_pickaxe")]
        public int MinecraftIronPickaxe { get; set; }

        [JsonPropertyName("minecraft:snow_block")]
        public int MinecraftSnowBlock { get; set; }

        [JsonPropertyName("minecraft:iron_block")]
        public int MinecraftIronBlock { get; set; }

        [JsonPropertyName("minecraft:iron_leggings")]
        public int MinecraftIronLeggings { get; set; }

        [JsonPropertyName("minecraft:iron_shovel")]
        public int MinecraftIronShovel { get; set; }

        [JsonPropertyName("minecraft:gold_ingot")]
        public int MinecraftGoldIngot { get; set; }

        [JsonPropertyName("minecraft:stonecutter")]
        public int MinecraftStonecutter { get; set; }

        [JsonPropertyName("minecraft:anvil")]
        public int MinecraftAnvil { get; set; }

        [JsonPropertyName("minecraft:white_bed")]
        public int MinecraftWhiteBed { get; set; }

        [JsonPropertyName("minecraft:torch")]
        public int MinecraftTorch { get; set; }

        [JsonPropertyName("minecraft:deepslate_bricks")]
        public int MinecraftDeepslateBricks { get; set; }

        [JsonPropertyName("minecraft:shears")]
        public int MinecraftShears { get; set; }
    }

    public class MinecraftCustom {
        [JsonPropertyName("minecraft:interact_with_smithing_table")]
        public int MinecraftInteractWithSmithingTable { get; set; }

        [JsonPropertyName("minecraft:interact_with_anvil")]
        public int MinecraftInteractWithAnvil { get; set; }

        [JsonPropertyName("minecraft:mob_kills")]
        public int MinecraftMobKills { get; set; }

        [JsonPropertyName("minecraft:inspect_hopper")]
        public int MinecraftInspectHopper { get; set; }

        [JsonPropertyName("minecraft:interact_with_crafting_table")]
        public int MinecraftInteractWithCraftingTable { get; set; }

        [JsonPropertyName("minecraft:open_barrel")]
        public int MinecraftOpenBarrel { get; set; }

        [JsonPropertyName("minecraft:bell_ring")]
        public int MinecraftBellRing { get; set; }

        [JsonPropertyName("minecraft:leave_game")]
        public int MinecraftLeaveGame { get; set; }

        [JsonPropertyName("minecraft:time_since_death")]
        public int MinecraftTimeSinceDeath { get; set; }

        [JsonPropertyName("minecraft:climb_one_cm")]
        public int MinecraftClimbOneCm { get; set; }

        [JsonPropertyName("minecraft:sprint_one_cm")]
        public int MinecraftSprintOneCm { get; set; }

        [JsonPropertyName("minecraft:walk_one_cm")]
        public int MinecraftWalkOneCm { get; set; }

        [JsonPropertyName("minecraft:damage_blocked_by_shield")]
        public int MinecraftDamageBlockedByShield { get; set; }

        [JsonPropertyName("minecraft:drop")]
        public int MinecraftDrop { get; set; }

        [JsonPropertyName("minecraft:talked_to_villager")]
        public int MinecraftTalkedToVillager { get; set; }

        [JsonPropertyName("minecraft:play_time")]
        public int MinecraftPlayTime { get; set; }

        [JsonPropertyName("minecraft:sneak_time")]
        public int MinecraftSneakTime { get; set; }

        [JsonPropertyName("minecraft:deaths")]
        public int MinecraftDeaths { get; set; }

        [JsonPropertyName("minecraft:walk_under_water_one_cm")]
        public int MinecraftWalkUnderWaterOneCm { get; set; }

        [JsonPropertyName("minecraft:boat_one_cm")]
        public int MinecraftBoatOneCm { get; set; }

        [JsonPropertyName("minecraft:interact_with_lectern")]
        public int MinecraftInteractWithLectern { get; set; }

        [JsonPropertyName("minecraft:jump")]
        public int MinecraftJump { get; set; }

        [JsonPropertyName("minecraft:interact_with_brewingstand")]
        public int MinecraftInteractWithBrewingstand { get; set; }

        [JsonPropertyName("minecraft:walk_on_water_one_cm")]
        public int MinecraftWalkOnWaterOneCm { get; set; }

        [JsonPropertyName("minecraft:total_world_time")]
        public int MinecraftTotalWorldTime { get; set; }

        [JsonPropertyName("minecraft:interact_with_furnace")]
        public int MinecraftInteractWithFurnace { get; set; }

        [JsonPropertyName("minecraft:play_record")]
        public int MinecraftPlayRecord { get; set; }

        [JsonPropertyName("minecraft:interact_with_grindstone")]
        public int MinecraftInteractWithGrindstone { get; set; }

        [JsonPropertyName("minecraft:interact_with_stonecutter")]
        public int MinecraftInteractWithStonecutter { get; set; }

        [JsonPropertyName("minecraft:sleep_in_bed")]
        public int MinecraftSleepInBed { get; set; }

        [JsonPropertyName("minecraft:time_since_rest")]
        public int MinecraftTimeSinceRest { get; set; }

        [JsonPropertyName("minecraft:open_enderchest")]
        public int MinecraftOpenEnderchest { get; set; }

        [JsonPropertyName("minecraft:damage_taken")]
        public int MinecraftDamageTaken { get; set; }

        [JsonPropertyName("minecraft:damage_dealt")]
        public int MinecraftDamageDealt { get; set; }

        [JsonPropertyName("minecraft:swim_one_cm")]
        public int MinecraftSwimOneCm { get; set; }

        [JsonPropertyName("minecraft:fly_one_cm")]
        public int MinecraftFlyOneCm { get; set; }

        [JsonPropertyName("minecraft:open_chest")]
        public int MinecraftOpenChest { get; set; }

        [JsonPropertyName("minecraft:crouch_one_cm")]
        public int MinecraftCrouchOneCm { get; set; }

        [JsonPropertyName("minecraft:fall_one_cm")]
        public int MinecraftFallOneCm { get; set; }

        [JsonPropertyName("minecraft:use_cauldron")]
        public int MinecraftUseCauldron { get; set; }
    }

    public class MinecraftDropped {
        [JsonPropertyName("minecraft:cobblestone")]
        public int MinecraftCobblestone { get; set; }

        [JsonPropertyName("minecraft:dirt")]
        public int MinecraftDirt { get; set; }

        [JsonPropertyName("minecraft:diorite")]
        public int MinecraftDiorite { get; set; }

        [JsonPropertyName("minecraft:snowball")]
        public int MinecraftSnowball { get; set; }

        [JsonPropertyName("minecraft:wooden_sword")]
        public int MinecraftWoodenSword { get; set; }

        [JsonPropertyName("minecraft:lily_pad")]
        public int MinecraftLilyPad { get; set; }

        [JsonPropertyName("minecraft:kelp")]
        public int MinecraftKelp { get; set; }

        [JsonPropertyName("minecraft:tuff")]
        public int MinecraftTuff { get; set; }

        [JsonPropertyName("minecraft:rotten_flesh")]
        public int MinecraftRottenFlesh { get; set; }

        [JsonPropertyName("minecraft:iron_boots")]
        public int MinecraftIronBoots { get; set; }

        [JsonPropertyName("minecraft:oak_planks")]
        public int MinecraftOakPlanks { get; set; }

        [JsonPropertyName("minecraft:carrot")]
        public int MinecraftCarrot { get; set; }

        [JsonPropertyName("minecraft:filled_map")]
        public int MinecraftFilledMap { get; set; }

        [JsonPropertyName("minecraft:wooden_shovel")]
        public int MinecraftWoodenShovel { get; set; }
    }

    public class Stats {
        [JsonPropertyName("minecraft:killed")]
        public MinecraftKilled MinecraftKilled { get; set; }

        [JsonPropertyName("minecraft:picked_up")]
        public MinecraftPickedUp MinecraftPickedUp { get; set; }

        [JsonPropertyName("minecraft:broken")]
        public MinecraftBroken MinecraftBroken { get; set; }

        [JsonPropertyName("minecraft:used")]
        public MinecraftUsed MinecraftUsed { get; set; }

        [JsonPropertyName("minecraft:mined")]
        public MinecraftMined MinecraftMined { get; set; }

        [JsonPropertyName("minecraft:killed_by")]
        public MinecraftKilledBy MinecraftKilledBy { get; set; }

        [JsonPropertyName("minecraft:crafted")]
        public MinecraftCrafted MinecraftCrafted { get; set; }

        [JsonPropertyName("minecraft:custom")]
        public MinecraftCustom MinecraftCustom { get; set; }

        [JsonPropertyName("minecraft:dropped")]
        public MinecraftDropped MinecraftDropped { get; set; }
    }
}
