using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MinecraftServerHostLib.Tracking {
#nullable disable
    public class Advancements {
        [JsonPropertyName("minecraft:recipes/tools/fishing_rod")]
        public MinecraftRecipesToolsFishingRod MinecraftRecipesToolsFishingRod { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_mutton_from_campfire_cooking")]
        public MinecraftRecipesFoodCookedMuttonFromCampfireCooking MinecraftRecipesFoodCookedMuttonFromCampfireCooking { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/smoker")]
        public MinecraftRecipesDecorationsSmoker MinecraftRecipesDecorationsSmoker { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/purple_wool")]
        public MinecraftRecipesBuildingBlocksPurpleWool MinecraftRecipesBuildingBlocksPurpleWool { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_slab_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileSlabFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTileSlabFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/lever")]
        public MinecraftRecipesRedstoneLever MinecraftRecipesRedstoneLever { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobblestone_stairs_from_cobblestone_stonecutting")]
        public MinecraftRecipesBuildingBlocksCobblestoneStairsFromCobblestoneStonecutting MinecraftRecipesBuildingBlocksCobblestoneStairsFromCobblestoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/magenta_concrete_powder")]
        public MinecraftRecipesBuildingBlocksMagentaConcretePowder MinecraftRecipesBuildingBlocksMagentaConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/iron_sword")]
        public MinecraftRecipesCombatIronSword MinecraftRecipesCombatIronSword { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_bricks")]
        public MinecraftRecipesBuildingBlocksStoneBricks MinecraftRecipesBuildingBlocksStoneBricks { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/writable_book")]
        public MinecraftRecipesMiscWritableBook MinecraftRecipesMiscWritableBook { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslate MinecraftRecipesBuildingBlocksPolishedDeepslate { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/chiseled_deepslate_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksChiseledDeepslateFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksChiseledDeepslateFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_andesite_stairs_from_andesite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedAndesiteStairsFromAndesiteStonecutting MinecraftRecipesBuildingBlocksPolishedAndesiteStairsFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/white_bed")]
        public MinecraftRecipesDecorationsWhiteBed MinecraftRecipesDecorationsWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/lime_concrete_powder")]
        public MinecraftRecipesBuildingBlocksLimeConcretePowder MinecraftRecipesBuildingBlocksLimeConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/iron_pickaxe")]
        public MinecraftRecipesToolsIronPickaxe MinecraftRecipesToolsIronPickaxe { get; set; }

        [JsonPropertyName("minecraft:nether/root")]
        public MinecraftNetherRoot MinecraftNetherRoot { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/yellow_concrete_powder")]
        public MinecraftRecipesBuildingBlocksYellowConcretePowder MinecraftRecipesBuildingBlocksYellowConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/birch_pressure_plate")]
        public MinecraftRecipesRedstoneBirchPressurePlate MinecraftRecipesRedstoneBirchPressurePlate { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/crafting_table")]
        public MinecraftRecipesDecorationsCraftingTable MinecraftRecipesDecorationsCraftingTable { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/campfire")]
        public MinecraftRecipesDecorationsCampfire MinecraftRecipesDecorationsCampfire { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/magenta_wool")]
        public MinecraftRecipesBuildingBlocksMagentaWool MinecraftRecipesBuildingBlocksMagentaWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/candle")]
        public MinecraftRecipesDecorationsCandle MinecraftRecipesDecorationsCandle { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/golden_hoe")]
        public MinecraftRecipesToolsGoldenHoe MinecraftRecipesToolsGoldenHoe { get; set; }

        [JsonPropertyName("minecraft:recipes/food/bread")]
        public MinecraftRecipesFoodBread MinecraftRecipesFoodBread { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/diorite_slab_from_diorite_stonecutting")]
        public MinecraftRecipesBuildingBlocksDioriteSlabFromDioriteStonecutting MinecraftRecipesBuildingBlocksDioriteSlabFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/copper_block")]
        public MinecraftRecipesBuildingBlocksCopperBlock MinecraftRecipesBuildingBlocksCopperBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_brick_wall_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateBrickWallFromPolishedDeepslateStonecutting MinecraftRecipesDecorationsDeepslateBrickWallFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/smooth_stone")]
        public MinecraftRecipesBuildingBlocksSmoothStone MinecraftRecipesBuildingBlocksSmoothStone { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/melon_seeds")]
        public MinecraftRecipesMiscMelonSeeds MinecraftRecipesMiscMelonSeeds { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/magma_block")]
        public MinecraftRecipesBuildingBlocksMagmaBlock MinecraftRecipesBuildingBlocksMagmaBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/ladder")]
        public MinecraftRecipesDecorationsLadder MinecraftRecipesDecorationsLadder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_stairs_from_copper_block_stonecutting")]
        public MinecraftRecipesBuildingBlocksCutCopperStairsFromCopperBlockStonecutting MinecraftRecipesBuildingBlocksCutCopperStairsFromCopperBlockStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_nugget")]
        public MinecraftRecipesMiscIronNugget MinecraftRecipesMiscIronNugget { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/chest")]
        public MinecraftRecipesDecorationsChest MinecraftRecipesDecorationsChest { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/golden_sword")]
        public MinecraftRecipesCombatGoldenSword MinecraftRecipesCombatGoldenSword { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/brown_concrete_powder")]
        public MinecraftRecipesBuildingBlocksBrownConcretePowder MinecraftRecipesBuildingBlocksBrownConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_slab_from_stone_stonecutting")]
        public MinecraftRecipesBuildingBlocksStoneSlabFromStoneStonecutting MinecraftRecipesBuildingBlocksStoneSlabFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/black_bed_from_white_bed")]
        public MinecraftRecipesDecorationsBlackBedFromWhiteBed MinecraftRecipesDecorationsBlackBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobbled_deepslate_slab")]
        public MinecraftRecipesBuildingBlocksCobbledDeepslateSlab MinecraftRecipesBuildingBlocksCobbledDeepslateSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/chiseled_stone_bricks_stone_from_stonecutting")]
        public MinecraftRecipesBuildingBlocksChiseledStoneBricksStoneFromStonecutting MinecraftRecipesBuildingBlocksChiseledStoneBricksStoneFromStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/wooden_shovel")]
        public MinecraftRecipesToolsWoodenShovel MinecraftRecipesToolsWoodenShovel { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_slab_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileSlabFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTileSlabFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/torch")]
        public MinecraftRecipesDecorationsTorch MinecraftRecipesDecorationsTorch { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/diamond_sword")]
        public MinecraftRecipesCombatDiamondSword MinecraftRecipesCombatDiamondSword { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cyan_wool")]
        public MinecraftRecipesBuildingBlocksCyanWool MinecraftRecipesBuildingBlocksCyanWool { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/shears")]
        public MinecraftRecipesToolsShears MinecraftRecipesToolsShears { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/white_dye")]
        public MinecraftRecipesMiscWhiteDye MinecraftRecipesMiscWhiteDye { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/stick")]
        public MinecraftRecipesMiscStick MinecraftRecipesMiscStick { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_brick_slab_from_stone_stonecutting")]
        public MinecraftRecipesBuildingBlocksStoneBrickSlabFromStoneStonecutting MinecraftRecipesBuildingBlocksStoneBrickSlabFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/spruce_boat")]
        public MinecraftRecipesTransportationSpruceBoat MinecraftRecipesTransportationSpruceBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/jukebox")]
        public MinecraftRecipesDecorationsJukebox MinecraftRecipesDecorationsJukebox { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_slab_from_copper_block_stonecutting")]
        public MinecraftRecipesBuildingBlocksCutCopperSlabFromCopperBlockStonecutting MinecraftRecipesBuildingBlocksCutCopperSlabFromCopperBlockStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/firework_rocket_simple")]
        public MinecraftRecipesMiscFireworkRocketSimple MinecraftRecipesMiscFireworkRocketSimple { get; set; }

        [JsonPropertyName("minecraft:recipes/food/mushroom_stew")]
        public MinecraftRecipesFoodMushroomStew MinecraftRecipesFoodMushroomStew { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/emerald_block")]
        public MinecraftRecipesBuildingBlocksEmeraldBlock MinecraftRecipesBuildingBlocksEmeraldBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cake")]
        public MinecraftRecipesFoodCake MinecraftRecipesFoodCake { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/gray_wool")]
        public MinecraftRecipesBuildingBlocksGrayWool MinecraftRecipesBuildingBlocksGrayWool { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_slab_from_cut_copper_stonecutting")]
        public MinecraftRecipesBuildingBlocksCutCopperSlabFromCutCopperStonecutting MinecraftRecipesBuildingBlocksCutCopperSlabFromCutCopperStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_granite_from_granite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedGraniteFromGraniteStonecutting MinecraftRecipesBuildingBlocksPolishedGraniteFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_nugget")]
        public MinecraftRecipesMiscGoldNugget MinecraftRecipesMiscGoldNugget { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/iron_leggings")]
        public MinecraftRecipesCombatIronLeggings MinecraftRecipesCombatIronLeggings { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tiles")]
        public MinecraftRecipesBuildingBlocksDeepslateTiles MinecraftRecipesBuildingBlocksDeepslateTiles { get; set; }

        [JsonPropertyName("minecraft:husbandry/balanced_diet")]
        public MinecraftHusbandryBalancedDiet MinecraftHusbandryBalancedDiet { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/wooden_hoe")]
        public MinecraftRecipesToolsWoodenHoe MinecraftRecipesToolsWoodenHoe { get; set; }

        [JsonPropertyName("minecraft:recipes/brewing/golden_carrot")]
        public MinecraftRecipesBrewingGoldenCarrot MinecraftRecipesBrewingGoldenCarrot { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/shield")]
        public MinecraftRecipesCombatShield MinecraftRecipesCombatShield { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobblestone_slab")]
        public MinecraftRecipesBuildingBlocksCobblestoneSlab MinecraftRecipesBuildingBlocksCobblestoneSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_cod")]
        public MinecraftRecipesFoodCookedCod MinecraftRecipesFoodCookedCod { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/bucket")]
        public MinecraftRecipesMiscBucket MinecraftRecipesMiscBucket { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/diorite_slab")]
        public MinecraftRecipesBuildingBlocksDioriteSlab MinecraftRecipesBuildingBlocksDioriteSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobblestone_stairs")]
        public MinecraftRecipesBuildingBlocksCobblestoneStairs MinecraftRecipesBuildingBlocksCobblestoneStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/food/dried_kelp_from_smoking")]
        public MinecraftRecipesFoodDriedKelpFromSmoking MinecraftRecipesFoodDriedKelpFromSmoking { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/hopper")]
        public MinecraftRecipesRedstoneHopper MinecraftRecipesRedstoneHopper { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/birch_slab")]
        public MinecraftRecipesBuildingBlocksBirchSlab MinecraftRecipesBuildingBlocksBirchSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tiles_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTilesFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTilesFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cobbled_deepslate_wall_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsCobbledDeepslateWallFromCobbledDeepslateStonecutting MinecraftRecipesDecorationsCobbledDeepslateWallFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/yellow_bed_from_white_bed")]
        public MinecraftRecipesDecorationsYellowBedFromWhiteBed MinecraftRecipesDecorationsYellowBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_slab_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/coarse_dirt")]
        public MinecraftRecipesBuildingBlocksCoarseDirt MinecraftRecipesBuildingBlocksCoarseDirt { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tiles_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTilesFromDeepslateBricksStonecutting MinecraftRecipesBuildingBlocksDeepslateTilesFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/granite_wall")]
        public MinecraftRecipesDecorationsGraniteWall MinecraftRecipesDecorationsGraniteWall { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_slab_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/note_block")]
        public MinecraftRecipesRedstoneNoteBlock MinecraftRecipesRedstoneNoteBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/dripstone_block")]
        public MinecraftRecipesBuildingBlocksDripstoneBlock MinecraftRecipesBuildingBlocksDripstoneBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/white_banner")]
        public MinecraftRecipesDecorationsWhiteBanner MinecraftRecipesDecorationsWhiteBanner { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_stairs_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileStairsFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTileStairsFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_diorite_slab_from_diorite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDioriteSlabFromDioriteStonecutting MinecraftRecipesBuildingBlocksPolishedDioriteSlabFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/light_gray_concrete_powder")]
        public MinecraftRecipesBuildingBlocksLightGrayConcretePowder MinecraftRecipesBuildingBlocksLightGrayConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/light_blue_concrete_powder")]
        public MinecraftRecipesBuildingBlocksLightBlueConcretePowder MinecraftRecipesBuildingBlocksLightBlueConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tiles_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTilesFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTilesFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_ingot_from_smelting_raw_gold")]
        public MinecraftRecipesMiscGoldIngotFromSmeltingRawGold MinecraftRecipesMiscGoldIngotFromSmeltingRawGold { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/hay_block")]
        public MinecraftRecipesBuildingBlocksHayBlock MinecraftRecipesBuildingBlocksHayBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/glass")]
        public MinecraftRecipesBuildingBlocksGlass MinecraftRecipesBuildingBlocksGlass { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/iron_helmet")]
        public MinecraftRecipesCombatIronHelmet MinecraftRecipesCombatIronHelmet { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/golden_shovel")]
        public MinecraftRecipesToolsGoldenShovel MinecraftRecipesToolsGoldenShovel { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/pink_concrete_powder")]
        public MinecraftRecipesBuildingBlocksPinkConcretePowder MinecraftRecipesBuildingBlocksPinkConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/bow")]
        public MinecraftRecipesCombatBow MinecraftRecipesCombatBow { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/oak_fence_gate")]
        public MinecraftRecipesRedstoneOakFenceGate MinecraftRecipesRedstoneOakFenceGate { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/tnt")]
        public MinecraftRecipesRedstoneTnt MinecraftRecipesRedstoneTnt { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_chicken_from_smoking")]
        public MinecraftRecipesFoodCookedChickenFromSmoking MinecraftRecipesFoodCookedChickenFromSmoking { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/lectern")]
        public MinecraftRecipesRedstoneLectern MinecraftRecipesRedstoneLectern { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/purple_concrete_powder")]
        public MinecraftRecipesBuildingBlocksPurpleConcretePowder MinecraftRecipesBuildingBlocksPurpleConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_stairs_from_stone_stonecutting")]
        public MinecraftRecipesBuildingBlocksStoneStairsFromStoneStonecutting MinecraftRecipesBuildingBlocksStoneStairsFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/magenta_bed_from_white_bed")]
        public MinecraftRecipesDecorationsMagentaBedFromWhiteBed MinecraftRecipesDecorationsMagentaBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/andesite_stairs_from_andesite_stonecutting")]
        public MinecraftRecipesBuildingBlocksAndesiteStairsFromAndesiteStonecutting MinecraftRecipesBuildingBlocksAndesiteStairsFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/iron_bars")]
        public MinecraftRecipesDecorationsIronBars MinecraftRecipesDecorationsIronBars { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/diorite_wall_from_diorite_stonecutting")]
        public MinecraftRecipesDecorationsDioriteWallFromDioriteStonecutting MinecraftRecipesDecorationsDioriteWallFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/red_dye_from_rose_bush")]
        public MinecraftRecipesMiscRedDyeFromRoseBush MinecraftRecipesMiscRedDyeFromRoseBush { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/orange_bed_from_white_bed")]
        public MinecraftRecipesDecorationsOrangeBedFromWhiteBed MinecraftRecipesDecorationsOrangeBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/gold_block")]
        public MinecraftRecipesBuildingBlocksGoldBlock MinecraftRecipesBuildingBlocksGoldBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/blue_wool")]
        public MinecraftRecipesBuildingBlocksBlueWool MinecraftRecipesBuildingBlocksBlueWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_brick_wall_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateBrickWallFromDeepslateBricksStonecutting MinecraftRecipesDecorationsDeepslateBrickWallFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:story/obtain_armor")]
        public MinecraftStoryObtainArmor MinecraftStoryObtainArmor { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/copper_ingot")]
        public MinecraftRecipesMiscCopperIngot MinecraftRecipesMiscCopperIngot { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/diamond_chestplate")]
        public MinecraftRecipesCombatDiamondChestplate MinecraftRecipesCombatDiamondChestplate { get; set; }

        [JsonPropertyName("minecraft:story/mine_stone")]
        public MinecraftStoryMineStone MinecraftStoryMineStone { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/target")]
        public MinecraftRecipesRedstoneTarget MinecraftRecipesRedstoneTarget { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/furnace")]
        public MinecraftRecipesDecorationsFurnace MinecraftRecipesDecorationsFurnace { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/minecart")]
        public MinecraftRecipesTransportationMinecart MinecraftRecipesTransportationMinecart { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_brick_wall_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateBrickWallFromCobbledDeepslateStonecutting MinecraftRecipesDecorationsDeepslateBrickWallFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/brewing/cauldron")]
        public MinecraftRecipesBrewingCauldron MinecraftRecipesBrewingCauldron { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_stairs_from_deepslate_tiles_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateTilesStonecutting MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateTilesStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/diamond_leggings")]
        public MinecraftRecipesCombatDiamondLeggings MinecraftRecipesCombatDiamondLeggings { get; set; }

        [JsonPropertyName("minecraft:adventure/sleep_in_bed")]
        public MinecraftAdventureSleepInBed MinecraftAdventureSleepInBed { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/charcoal")]
        public MinecraftRecipesMiscCharcoal MinecraftRecipesMiscCharcoal { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/andesite_stairs")]
        public MinecraftRecipesBuildingBlocksAndesiteStairs MinecraftRecipesBuildingBlocksAndesiteStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/sandstone")]
        public MinecraftRecipesBuildingBlocksSandstone MinecraftRecipesBuildingBlocksSandstone { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/orange_wool")]
        public MinecraftRecipesBuildingBlocksOrangeWool MinecraftRecipesBuildingBlocksOrangeWool { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/wooden_pickaxe")]
        public MinecraftRecipesToolsWoodenPickaxe MinecraftRecipesToolsWoodenPickaxe { get; set; }

        [JsonPropertyName("minecraft:story/lava_bucket")]
        public MinecraftStoryLavaBucket MinecraftStoryLavaBucket { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/iron_hoe")]
        public MinecraftRecipesToolsIronHoe MinecraftRecipesToolsIronHoe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobblestone_slab_from_cobblestone_stonecutting")]
        public MinecraftRecipesBuildingBlocksCobblestoneSlabFromCobblestoneStonecutting MinecraftRecipesBuildingBlocksCobblestoneSlabFromCobblestoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_stairs")]
        public MinecraftRecipesBuildingBlocksCutCopperStairs MinecraftRecipesBuildingBlocksCutCopperStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobbled_deepslate_stairs")]
        public MinecraftRecipesBuildingBlocksCobbledDeepslateStairs MinecraftRecipesBuildingBlocksCobbledDeepslateStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/food/dried_kelp_from_smelting")]
        public MinecraftRecipesFoodDriedKelpFromSmelting MinecraftRecipesFoodDriedKelpFromSmelting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_stairs_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileStairsFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateTileStairsFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:husbandry/root")]
        public MinecraftHusbandryRoot MinecraftHusbandryRoot { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/redstone_torch")]
        public MinecraftRecipesRedstoneRedstoneTorch MinecraftRecipesRedstoneRedstoneTorch { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/birch_boat")]
        public MinecraftRecipesTransportationBirchBoat MinecraftRecipesTransportationBirchBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/food/golden_apple")]
        public MinecraftRecipesFoodGoldenApple MinecraftRecipesFoodGoldenApple { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_from_copper_block_stonecutting")]
        public MinecraftRecipesBuildingBlocksCutCopperFromCopperBlockStonecutting MinecraftRecipesBuildingBlocksCutCopperFromCopperBlockStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_ingot_from_blasting_raw_gold")]
        public MinecraftRecipesMiscGoldIngotFromBlastingRawGold MinecraftRecipesMiscGoldIngotFromBlastingRawGold { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/oak_stairs")]
        public MinecraftRecipesBuildingBlocksOakStairs MinecraftRecipesBuildingBlocksOakStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_andesite_slab_from_andesite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedAndesiteSlabFromAndesiteStonecutting MinecraftRecipesBuildingBlocksPolishedAndesiteSlabFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_granite_slab_from_granite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedGraniteSlabFromGraniteStonecutting MinecraftRecipesBuildingBlocksPolishedGraniteSlabFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/green_concrete_powder")]
        public MinecraftRecipesBuildingBlocksGreenConcretePowder MinecraftRecipesBuildingBlocksGreenConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_andesite_from_andesite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedAndesiteFromAndesiteStonecutting MinecraftRecipesBuildingBlocksPolishedAndesiteFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobbled_deepslate_stairs_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksCobbledDeepslateStairsFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksCobbledDeepslateStairsFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/acacia_boat")]
        public MinecraftRecipesTransportationAcaciaBoat MinecraftRecipesTransportationAcaciaBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/iron_shovel")]
        public MinecraftRecipesToolsIronShovel MinecraftRecipesToolsIronShovel { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/copper_ingot_from_blasting_raw_copper")]
        public MinecraftRecipesMiscCopperIngotFromBlastingRawCopper MinecraftRecipesMiscCopperIngotFromBlastingRawCopper { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/iron_trapdoor")]
        public MinecraftRecipesRedstoneIronTrapdoor MinecraftRecipesRedstoneIronTrapdoor { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/birch_sign")]
        public MinecraftRecipesDecorationsBirchSign MinecraftRecipesDecorationsBirchSign { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cyan_bed_from_white_bed")]
        public MinecraftRecipesDecorationsCyanBedFromWhiteBed MinecraftRecipesDecorationsCyanBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:adventure/root")]
        public MinecraftAdventureRoot MinecraftAdventureRoot { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/gray_bed_from_white_bed")]
        public MinecraftRecipesDecorationsGrayBedFromWhiteBed MinecraftRecipesDecorationsGrayBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/white_concrete_powder")]
        public MinecraftRecipesBuildingBlocksWhiteConcretePowder MinecraftRecipesBuildingBlocksWhiteConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/lime_bed_from_white_bed")]
        public MinecraftRecipesDecorationsLimeBedFromWhiteBed MinecraftRecipesDecorationsLimeBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_brick_stairs_from_stone_stonecutting")]
        public MinecraftRecipesBuildingBlocksStoneBrickStairsFromStoneStonecutting MinecraftRecipesBuildingBlocksStoneBrickStairsFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/polished_deepslate_wall")]
        public MinecraftRecipesDecorationsPolishedDeepslateWall MinecraftRecipesDecorationsPolishedDeepslateWall { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/stone_hoe")]
        public MinecraftRecipesToolsStoneHoe MinecraftRecipesToolsStoneHoe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/white_wool_from_string")]
        public MinecraftRecipesBuildingBlocksWhiteWoolFromString MinecraftRecipesBuildingBlocksWhiteWoolFromString { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/clock")]
        public MinecraftRecipesToolsClock MinecraftRecipesToolsClock { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/diamond_pickaxe")]
        public MinecraftRecipesToolsDiamondPickaxe MinecraftRecipesToolsDiamondPickaxe { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/diamond_hoe")]
        public MinecraftRecipesToolsDiamondHoe MinecraftRecipesToolsDiamondHoe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_slab")]
        public MinecraftRecipesBuildingBlocksCutCopperSlab MinecraftRecipesBuildingBlocksCutCopperSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/lightning_rod")]
        public MinecraftRecipesRedstoneLightningRod MinecraftRecipesRedstoneLightningRod { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_slab_from_deepslate_tiles_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateTilesStonecutting MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateTilesStonecutting { get; set; }

        [JsonPropertyName("minecraft:adventure/kill_all_mobs")]
        public MinecraftAdventureKillAllMobs MinecraftAdventureKillAllMobs { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/diamond_shovel")]
        public MinecraftRecipesToolsDiamondShovel MinecraftRecipesToolsDiamondShovel { get; set; }

        [JsonPropertyName("minecraft:story/enter_the_nether")]
        public MinecraftStoryEnterTheNether MinecraftStoryEnterTheNether { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/green_bed_from_white_bed")]
        public MinecraftRecipesDecorationsGreenBedFromWhiteBed MinecraftRecipesDecorationsGreenBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/birch_wood")]
        public MinecraftRecipesBuildingBlocksBirchWood MinecraftRecipesBuildingBlocksBirchWood { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksPolishedDeepslateFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/redstone_block")]
        public MinecraftRecipesRedstoneRedstoneBlock MinecraftRecipesRedstoneRedstoneBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate")]
        public MinecraftRecipesBuildingBlocksDeepslate MinecraftRecipesBuildingBlocksDeepslate { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/granite_slab")]
        public MinecraftRecipesBuildingBlocksGraniteSlab MinecraftRecipesBuildingBlocksGraniteSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/white_carpet")]
        public MinecraftRecipesDecorationsWhiteCarpet MinecraftRecipesDecorationsWhiteCarpet { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/pink_bed_from_white_bed")]
        public MinecraftRecipesDecorationsPinkBedFromWhiteBed MinecraftRecipesDecorationsPinkBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/brewing/glistering_melon_slice")]
        public MinecraftRecipesBrewingGlisteringMelonSlice MinecraftRecipesBrewingGlisteringMelonSlice { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_chicken_from_campfire_cooking")]
        public MinecraftRecipesFoodCookedChickenFromCampfireCooking MinecraftRecipesFoodCookedChickenFromCampfireCooking { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_nugget_from_smelting")]
        public MinecraftRecipesMiscIronNuggetFromSmelting MinecraftRecipesMiscIronNuggetFromSmelting { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_mutton_from_smoking")]
        public MinecraftRecipesFoodCookedMuttonFromSmoking MinecraftRecipesFoodCookedMuttonFromSmoking { get; set; }

        [JsonPropertyName("minecraft:adventure/spyglass_at_ghast")]
        public MinecraftAdventureSpyglassAtGhast MinecraftAdventureSpyglassAtGhast { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_slab_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_bricks")]
        public MinecraftRecipesBuildingBlocksDeepslateBricks MinecraftRecipesBuildingBlocksDeepslateBricks { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_slab")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickSlab MinecraftRecipesBuildingBlocksDeepslateBrickSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/birch_door")]
        public MinecraftRecipesRedstoneBirchDoor MinecraftRecipesRedstoneBirchDoor { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/granite_wall_from_granite_stonecutting")]
        public MinecraftRecipesDecorationsGraniteWallFromGraniteStonecutting MinecraftRecipesDecorationsGraniteWallFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/chain")]
        public MinecraftRecipesDecorationsChain MinecraftRecipesDecorationsChain { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_ingot_from_nuggets")]
        public MinecraftRecipesMiscGoldIngotFromNuggets MinecraftRecipesMiscGoldIngotFromNuggets { get; set; }

        [JsonPropertyName("minecraft:story/mine_diamond")]
        public MinecraftStoryMineDiamond MinecraftStoryMineDiamond { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper_stairs_from_cut_copper_stonecutting")]
        public MinecraftRecipesBuildingBlocksCutCopperStairsFromCutCopperStonecutting MinecraftRecipesBuildingBlocksCutCopperStairsFromCutCopperStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_granite_stairs_from_granite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedGraniteStairsFromGraniteStonecutting MinecraftRecipesBuildingBlocksPolishedGraniteStairsFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/blue_dye")]
        public MinecraftRecipesMiscBlueDye MinecraftRecipesMiscBlueDye { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/diamond_helmet")]
        public MinecraftRecipesCombatDiamondHelmet MinecraftRecipesCombatDiamondHelmet { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/oak_fence")]
        public MinecraftRecipesDecorationsOakFence MinecraftRecipesDecorationsOakFence { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/snow")]
        public MinecraftRecipesDecorationsSnow MinecraftRecipesDecorationsSnow { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/oak_boat")]
        public MinecraftRecipesTransportationOakBoat MinecraftRecipesTransportationOakBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_cod_from_campfire_cooking")]
        public MinecraftRecipesFoodCookedCodFromCampfireCooking MinecraftRecipesFoodCookedCodFromCampfireCooking { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/anvil")]
        public MinecraftRecipesDecorationsAnvil MinecraftRecipesDecorationsAnvil { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/birch_fence")]
        public MinecraftRecipesDecorationsBirchFence MinecraftRecipesDecorationsBirchFence { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/blue_bed_from_white_bed")]
        public MinecraftRecipesDecorationsBlueBedFromWhiteBed MinecraftRecipesDecorationsBlueBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_porkchop")]
        public MinecraftRecipesFoodCookedPorkchop MinecraftRecipesFoodCookedPorkchop { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/orange_concrete_powder")]
        public MinecraftRecipesBuildingBlocksOrangeConcretePowder MinecraftRecipesBuildingBlocksOrangeConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/oak_slab")]
        public MinecraftRecipesBuildingBlocksOakSlab MinecraftRecipesBuildingBlocksOakSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cyan_concrete_powder")]
        public MinecraftRecipesBuildingBlocksCyanConcretePowder MinecraftRecipesBuildingBlocksCyanConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/golden_boots")]
        public MinecraftRecipesCombatGoldenBoots MinecraftRecipesCombatGoldenBoots { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_porkchop_from_campfire_cooking")]
        public MinecraftRecipesFoodCookedPorkchopFromCampfireCooking MinecraftRecipesFoodCookedPorkchopFromCampfireCooking { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/raw_copper_block")]
        public MinecraftRecipesBuildingBlocksRawCopperBlock MinecraftRecipesBuildingBlocksRawCopperBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/wooden_axe")]
        public MinecraftRecipesToolsWoodenAxe MinecraftRecipesToolsWoodenAxe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/lime_wool")]
        public MinecraftRecipesBuildingBlocksLimeWool MinecraftRecipesBuildingBlocksLimeWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_tile_wall_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateTileWallFromPolishedDeepslateStonecutting MinecraftRecipesDecorationsDeepslateTileWallFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_stairs_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromDeepslateBricksStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/granite_stairs")]
        public MinecraftRecipesBuildingBlocksGraniteStairs MinecraftRecipesBuildingBlocksGraniteStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_diorite_stairs_from_diorite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDioriteStairsFromDioriteStonecutting MinecraftRecipesBuildingBlocksPolishedDioriteStairsFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/black_wool")]
        public MinecraftRecipesBuildingBlocksBlackWool MinecraftRecipesBuildingBlocksBlackWool { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_bricks_from_stone_stonecutting")]
        public MinecraftRecipesBuildingBlocksStoneBricksFromStoneStonecutting MinecraftRecipesBuildingBlocksStoneBricksFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/pink_dye_from_peony")]
        public MinecraftRecipesMiscPinkDyeFromPeony MinecraftRecipesMiscPinkDyeFromPeony { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/golden_chestplate")]
        public MinecraftRecipesCombatGoldenChestplate MinecraftRecipesCombatGoldenChestplate { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/polished_deepslate_wall_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsPolishedDeepslateWallFromPolishedDeepslateStonecutting MinecraftRecipesDecorationsPolishedDeepslateWallFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_tile_wall_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateTileWallFromCobbledDeepslateStonecutting MinecraftRecipesDecorationsDeepslateTileWallFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/loom")]
        public MinecraftRecipesDecorationsLoom MinecraftRecipesDecorationsLoom { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/green_wool")]
        public MinecraftRecipesBuildingBlocksGreenWool MinecraftRecipesBuildingBlocksGreenWool { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_ingot_from_blasting_raw_iron")]
        public MinecraftRecipesMiscIronIngotFromBlastingRawIron MinecraftRecipesMiscIronIngotFromBlastingRawIron { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_stairs_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/diamond_axe")]
        public MinecraftRecipesToolsDiamondAxe MinecraftRecipesToolsDiamondAxe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/diorite_stairs_from_diorite_stonecutting")]
        public MinecraftRecipesBuildingBlocksDioriteStairsFromDioriteStonecutting MinecraftRecipesBuildingBlocksDioriteStairsFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/brown_wool")]
        public MinecraftRecipesBuildingBlocksBrownWool MinecraftRecipesBuildingBlocksBrownWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/moss_carpet")]
        public MinecraftRecipesDecorationsMossCarpet MinecraftRecipesDecorationsMossCarpet { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/waxed_copper_block_from_honeycomb")]
        public MinecraftRecipesBuildingBlocksWaxedCopperBlockFromHoneycomb MinecraftRecipesBuildingBlocksWaxedCopperBlockFromHoneycomb { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/birch_button")]
        public MinecraftRecipesRedstoneBirchButton MinecraftRecipesRedstoneBirchButton { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/iron_block")]
        public MinecraftRecipesBuildingBlocksIronBlock MinecraftRecipesBuildingBlocksIronBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/painting")]
        public MinecraftRecipesDecorationsPainting MinecraftRecipesDecorationsPainting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/red_dye_from_poppy")]
        public MinecraftRecipesMiscRedDyeFromPoppy MinecraftRecipesMiscRedDyeFromPoppy { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/mossy_cobblestone_from_moss_block")]
        public MinecraftRecipesBuildingBlocksMossyCobblestoneFromMossBlock MinecraftRecipesBuildingBlocksMossyCobblestoneFromMossBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/andesite_slab_from_andesite_stonecutting")]
        public MinecraftRecipesBuildingBlocksAndesiteSlabFromAndesiteStonecutting MinecraftRecipesBuildingBlocksAndesiteSlabFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_slab")]
        public MinecraftRecipesBuildingBlocksStoneSlab MinecraftRecipesBuildingBlocksStoneSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/arrow")]
        public MinecraftRecipesCombatArrow MinecraftRecipesCombatArrow { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/coal_block")]
        public MinecraftRecipesBuildingBlocksCoalBlock MinecraftRecipesBuildingBlocksCoalBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/yellow_dye_from_dandelion")]
        public MinecraftRecipesMiscYellowDyeFromDandelion MinecraftRecipesMiscYellowDyeFromDandelion { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/light_weighted_pressure_plate")]
        public MinecraftRecipesRedstoneLightWeightedPressurePlate MinecraftRecipesRedstoneLightWeightedPressurePlate { get; set; }

        [JsonPropertyName("minecraft:story/deflect_arrow")]
        public MinecraftStoryDeflectArrow MinecraftStoryDeflectArrow { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_nugget_from_blasting")]
        public MinecraftRecipesMiscGoldNuggetFromBlasting MinecraftRecipesMiscGoldNuggetFromBlasting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/light_blue_wool")]
        public MinecraftRecipesBuildingBlocksLightBlueWool MinecraftRecipesBuildingBlocksLightBlueWool { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/wooden_sword")]
        public MinecraftRecipesCombatWoodenSword MinecraftRecipesCombatWoodenSword { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/stone_shovel")]
        public MinecraftRecipesToolsStoneShovel MinecraftRecipesToolsStoneShovel { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/oak_planks")]
        public MinecraftRecipesBuildingBlocksOakPlanks MinecraftRecipesBuildingBlocksOakPlanks { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/blue_concrete_powder")]
        public MinecraftRecipesBuildingBlocksBlueConcretePowder MinecraftRecipesBuildingBlocksBlueConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/gray_concrete_powder")]
        public MinecraftRecipesBuildingBlocksGrayConcretePowder MinecraftRecipesBuildingBlocksGrayConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/diorite_stairs")]
        public MinecraftRecipesBuildingBlocksDioriteStairs MinecraftRecipesBuildingBlocksDioriteStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/conduit")]
        public MinecraftRecipesMiscConduit MinecraftRecipesMiscConduit { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/granite_slab_from_granite_stonecutting")]
        public MinecraftRecipesBuildingBlocksGraniteSlabFromGraniteStonecutting MinecraftRecipesBuildingBlocksGraniteSlabFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/bookshelf")]
        public MinecraftRecipesBuildingBlocksBookshelf MinecraftRecipesBuildingBlocksBookshelf { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_stairs_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/golden_axe")]
        public MinecraftRecipesToolsGoldenAxe MinecraftRecipesToolsGoldenAxe { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/iron_axe")]
        public MinecraftRecipesToolsIronAxe MinecraftRecipesToolsIronAxe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/andesite")]
        public MinecraftRecipesBuildingBlocksAndesite MinecraftRecipesBuildingBlocksAndesite { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/sea_lantern")]
        public MinecraftRecipesBuildingBlocksSeaLantern MinecraftRecipesBuildingBlocksSeaLantern { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_tile_wall_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateBricksStonecutting MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_bricks_from_polished_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBricksFromPolishedDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBricksFromPolishedDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/golden_helmet")]
        public MinecraftRecipesCombatGoldenHelmet MinecraftRecipesCombatGoldenHelmet { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_tile_wall")]
        public MinecraftRecipesDecorationsDeepslateTileWall MinecraftRecipesDecorationsDeepslateTileWall { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/tripwire_hook")]
        public MinecraftRecipesRedstoneTripwireHook MinecraftRecipesRedstoneTripwireHook { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/oak_pressure_plate")]
        public MinecraftRecipesRedstoneOakPressurePlate MinecraftRecipesRedstoneOakPressurePlate { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/raw_gold_block")]
        public MinecraftRecipesBuildingBlocksRawGoldBlock MinecraftRecipesBuildingBlocksRawGoldBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/iron_boots")]
        public MinecraftRecipesCombatIronBoots MinecraftRecipesCombatIronBoots { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/bone_meal")]
        public MinecraftRecipesMiscBoneMeal MinecraftRecipesMiscBoneMeal { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/birch_planks")]
        public MinecraftRecipesBuildingBlocksBirchPlanks MinecraftRecipesBuildingBlocksBirchPlanks { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_stairs_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/black_concrete_powder")]
        public MinecraftRecipesBuildingBlocksBlackConcretePowder MinecraftRecipesBuildingBlocksBlackConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/mossy_stone_bricks_from_moss_block")]
        public MinecraftRecipesBuildingBlocksMossyStoneBricksFromMossBlock MinecraftRecipesBuildingBlocksMossyStoneBricksFromMossBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_stairs")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateStairs MinecraftRecipesBuildingBlocksPolishedDeepslateStairs { get; set; }

        [JsonPropertyName("minecraft:story/iron_tools")]
        public MinecraftStoryIronTools MinecraftStoryIronTools { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_stairs_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateBricksStonecutting MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cartography_table")]
        public MinecraftRecipesDecorationsCartographyTable MinecraftRecipesDecorationsCartographyTable { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/oak_wood")]
        public MinecraftRecipesBuildingBlocksOakWood MinecraftRecipesBuildingBlocksOakWood { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/birch_fence_gate")]
        public MinecraftRecipesRedstoneBirchFenceGate MinecraftRecipesRedstoneBirchFenceGate { get; set; }

        [JsonPropertyName("minecraft:story/root")]
        public MinecraftStoryRoot MinecraftStoryRoot { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/stone_button")]
        public MinecraftRecipesRedstoneStoneButton MinecraftRecipesRedstoneStoneButton { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/crossbow")]
        public MinecraftRecipesCombatCrossbow MinecraftRecipesCombatCrossbow { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/iron_chestplate")]
        public MinecraftRecipesCombatIronChestplate MinecraftRecipesCombatIronChestplate { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/dropper")]
        public MinecraftRecipesRedstoneDropper MinecraftRecipesRedstoneDropper { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cobbled_deepslate_wall")]
        public MinecraftRecipesDecorationsCobbledDeepslateWall MinecraftRecipesDecorationsCobbledDeepslateWall { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/yellow_wool")]
        public MinecraftRecipesBuildingBlocksYellowWool MinecraftRecipesBuildingBlocksYellowWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/oak_sign")]
        public MinecraftRecipesDecorationsOakSign MinecraftRecipesDecorationsOakSign { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_porkchop_from_smoking")]
        public MinecraftRecipesFoodCookedPorkchopFromSmoking MinecraftRecipesFoodCookedPorkchopFromSmoking { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_slab")]
        public MinecraftRecipesBuildingBlocksDeepslateTileSlab MinecraftRecipesBuildingBlocksDeepslateTileSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/oak_trapdoor")]
        public MinecraftRecipesRedstoneOakTrapdoor MinecraftRecipesRedstoneOakTrapdoor { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_diorite_from_diorite_stonecutting")]
        public MinecraftRecipesBuildingBlocksPolishedDioriteFromDioriteStonecutting MinecraftRecipesBuildingBlocksPolishedDioriteFromDioriteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/granite_stairs_from_granite_stonecutting")]
        public MinecraftRecipesBuildingBlocksGraniteStairsFromGraniteStonecutting MinecraftRecipesBuildingBlocksGraniteStairsFromGraniteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cracked_deepslate_bricks")]
        public MinecraftRecipesBuildingBlocksCrackedDeepslateBricks MinecraftRecipesBuildingBlocksCrackedDeepslateBricks { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/red_concrete_powder")]
        public MinecraftRecipesBuildingBlocksRedConcretePowder MinecraftRecipesBuildingBlocksRedConcretePowder { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/light_blue_bed_from_white_bed")]
        public MinecraftRecipesDecorationsLightBlueBedFromWhiteBed MinecraftRecipesDecorationsLightBlueBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_nugget_from_blasting")]
        public MinecraftRecipesMiscIronNuggetFromBlasting MinecraftRecipesMiscIronNuggetFromBlasting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/polished_deepslate_wall_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesDecorationsPolishedDeepslateWallFromCobbledDeepslateStonecutting MinecraftRecipesDecorationsPolishedDeepslateWallFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/compass")]
        public MinecraftRecipesToolsCompass MinecraftRecipesToolsCompass { get; set; }

        [JsonPropertyName("minecraft:adventure/kill_a_mob")]
        public MinecraftAdventureKillAMob MinecraftAdventureKillAMob { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/oak_button")]
        public MinecraftRecipesRedstoneOakButton MinecraftRecipesRedstoneOakButton { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/golden_pickaxe")]
        public MinecraftRecipesToolsGoldenPickaxe MinecraftRecipesToolsGoldenPickaxe { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/diorite_wall")]
        public MinecraftRecipesDecorationsDioriteWall MinecraftRecipesDecorationsDioriteWall { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone")]
        public MinecraftRecipesBuildingBlocksStone MinecraftRecipesBuildingBlocksStone { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_andesite")]
        public MinecraftRecipesBuildingBlocksPolishedAndesite MinecraftRecipesBuildingBlocksPolishedAndesite { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_bricks_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBricksFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBricksFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/stonecutter")]
        public MinecraftRecipesDecorationsStonecutter MinecraftRecipesDecorationsStonecutter { get; set; }

        [JsonPropertyName("minecraft:adventure/adventuring_time")]
        public MinecraftAdventureAdventuringTime MinecraftAdventureAdventuringTime { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/iron_door")]
        public MinecraftRecipesRedstoneIronDoor MinecraftRecipesRedstoneIronDoor { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_stairs_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/book")]
        public MinecraftRecipesMiscBook MinecraftRecipesMiscBook { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/purple_bed_from_white_bed")]
        public MinecraftRecipesDecorationsPurpleBedFromWhiteBed MinecraftRecipesDecorationsPurpleBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/copper_ingot_from_smelting_raw_copper")]
        public MinecraftRecipesMiscCopperIngotFromSmeltingRawCopper MinecraftRecipesMiscCopperIngotFromSmeltingRawCopper { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/stone_sword")]
        public MinecraftRecipesCombatStoneSword MinecraftRecipesCombatStoneSword { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/barrel")]
        public MinecraftRecipesDecorationsBarrel MinecraftRecipesDecorationsBarrel { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cobblestone_wall")]
        public MinecraftRecipesDecorationsCobblestoneWall MinecraftRecipesDecorationsCobblestoneWall { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/snow_block")]
        public MinecraftRecipesBuildingBlocksSnowBlock MinecraftRecipesBuildingBlocksSnowBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_deepslate_slab")]
        public MinecraftRecipesBuildingBlocksPolishedDeepslateSlab MinecraftRecipesBuildingBlocksPolishedDeepslateSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_ingot_from_smelting_raw_iron")]
        public MinecraftRecipesMiscIronIngotFromSmeltingRawIron MinecraftRecipesMiscIronIngotFromSmeltingRawIron { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/stone_pickaxe")]
        public MinecraftRecipesToolsStonePickaxe MinecraftRecipesToolsStonePickaxe { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/smithing_table")]
        public MinecraftRecipesDecorationsSmithingTable MinecraftRecipesDecorationsSmithingTable { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/oak_door")]
        public MinecraftRecipesRedstoneOakDoor MinecraftRecipesRedstoneOakDoor { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cut_copper")]
        public MinecraftRecipesBuildingBlocksCutCopper MinecraftRecipesBuildingBlocksCutCopper { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_slab_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cracked_deepslate_tiles")]
        public MinecraftRecipesBuildingBlocksCrackedDeepslateTiles MinecraftRecipesBuildingBlocksCrackedDeepslateTiles { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_tile_wall_from_deepslate_tiles_stonecutting")]
        public MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateTilesStonecutting MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateTilesStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/stone_pressure_plate")]
        public MinecraftRecipesRedstoneStonePressurePlate MinecraftRecipesRedstoneStonePressurePlate { get; set; }

        [JsonPropertyName("minecraft:husbandry/plant_seed")]
        public MinecraftHusbandryPlantSeed MinecraftHusbandryPlantSeed { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/deepslate_brick_wall")]
        public MinecraftRecipesDecorationsDeepslateBrickWall MinecraftRecipesDecorationsDeepslateBrickWall { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/jungle_boat")]
        public MinecraftRecipesTransportationJungleBoat MinecraftRecipesTransportationJungleBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/cobblestone_wall_from_cobblestone_stonecutting")]
        public MinecraftRecipesDecorationsCobblestoneWallFromCobblestoneStonecutting MinecraftRecipesDecorationsCobblestoneWallFromCobblestoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/birch_stairs")]
        public MinecraftRecipesBuildingBlocksBirchStairs MinecraftRecipesBuildingBlocksBirchStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/stone_brick_walls_from_stone_stonecutting")]
        public MinecraftRecipesDecorationsStoneBrickWallsFromStoneStonecutting MinecraftRecipesDecorationsStoneBrickWallsFromStoneStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/iron_ingot_from_iron_block")]
        public MinecraftRecipesMiscIronIngotFromIronBlock MinecraftRecipesMiscIronIngotFromIronBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/heavy_weighted_pressure_plate")]
        public MinecraftRecipesRedstoneHeavyWeightedPressurePlate MinecraftRecipesRedstoneHeavyWeightedPressurePlate { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/diamond_block")]
        public MinecraftRecipesBuildingBlocksDiamondBlock MinecraftRecipesBuildingBlocksDiamondBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/dark_oak_boat")]
        public MinecraftRecipesTransportationDarkOakBoat MinecraftRecipesTransportationDarkOakBoat { get; set; }

        [JsonPropertyName("minecraft:recipes/transportation/carrot_on_a_stick")]
        public MinecraftRecipesTransportationCarrotOnAStick MinecraftRecipesTransportationCarrotOnAStick { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/glow_item_frame")]
        public MinecraftRecipesDecorationsGlowItemFrame MinecraftRecipesDecorationsGlowItemFrame { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/andesite_wall_from_andesite_stonecutting")]
        public MinecraftRecipesDecorationsAndesiteWallFromAndesiteStonecutting MinecraftRecipesDecorationsAndesiteWallFromAndesiteStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/pink_wool")]
        public MinecraftRecipesBuildingBlocksPinkWool MinecraftRecipesBuildingBlocksPinkWool { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/dried_kelp_block")]
        public MinecraftRecipesBuildingBlocksDriedKelpBlock MinecraftRecipesBuildingBlocksDriedKelpBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/food/dried_kelp_from_campfire_cooking")]
        public MinecraftRecipesFoodDriedKelpFromCampfireCooking MinecraftRecipesFoodDriedKelpFromCampfireCooking { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/lapis_block")]
        public MinecraftRecipesBuildingBlocksLapisBlock MinecraftRecipesBuildingBlocksLapisBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/waxed_cut_copper_from_honeycomb")]
        public MinecraftRecipesBuildingBlocksWaxedCutCopperFromHoneycomb MinecraftRecipesBuildingBlocksWaxedCutCopperFromHoneycomb { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/brown_bed_from_white_bed")]
        public MinecraftRecipesDecorationsBrownBedFromWhiteBed MinecraftRecipesDecorationsBrownBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_granite")]
        public MinecraftRecipesBuildingBlocksPolishedGranite MinecraftRecipesBuildingBlocksPolishedGranite { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/birch_trapdoor")]
        public MinecraftRecipesRedstoneBirchTrapdoor MinecraftRecipesRedstoneBirchTrapdoor { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/golden_leggings")]
        public MinecraftRecipesCombatGoldenLeggings MinecraftRecipesCombatGoldenLeggings { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_cod_from_smoking")]
        public MinecraftRecipesFoodCookedCodFromSmoking MinecraftRecipesFoodCookedCodFromSmoking { get; set; }

        [JsonPropertyName("minecraft:recipes/redstone/piston")]
        public MinecraftRecipesRedstonePiston MinecraftRecipesRedstonePiston { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_slab_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateBricksStonecutting MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/lantern")]
        public MinecraftRecipesDecorationsLantern MinecraftRecipesDecorationsLantern { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/stone_stairs")]
        public MinecraftRecipesBuildingBlocksStoneStairs MinecraftRecipesBuildingBlocksStoneStairs { get; set; }

        [JsonPropertyName("minecraft:nether/explore_nether")]
        public MinecraftNetherExploreNether MinecraftNetherExploreNether { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_slab_from_deepslate_bricks_stonecutting")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromDeepslateBricksStonecutting MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromDeepslateBricksStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/misc/gold_nugget_from_smelting")]
        public MinecraftRecipesMiscGoldNuggetFromSmelting MinecraftRecipesMiscGoldNuggetFromSmelting { get; set; }

        [JsonPropertyName("minecraft:recipes/combat/diamond_boots")]
        public MinecraftRecipesCombatDiamondBoots MinecraftRecipesCombatDiamondBoots { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/polished_diorite")]
        public MinecraftRecipesBuildingBlocksPolishedDiorite MinecraftRecipesBuildingBlocksPolishedDiorite { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/cobbled_deepslate_slab_from_cobbled_deepslate_stonecutting")]
        public MinecraftRecipesBuildingBlocksCobbledDeepslateSlabFromCobbledDeepslateStonecutting MinecraftRecipesBuildingBlocksCobbledDeepslateSlabFromCobbledDeepslateStonecutting { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/andesite_wall")]
        public MinecraftRecipesDecorationsAndesiteWall MinecraftRecipesDecorationsAndesiteWall { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/light_gray_wool")]
        public MinecraftRecipesBuildingBlocksLightGrayWool MinecraftRecipesBuildingBlocksLightGrayWool { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/andesite_slab")]
        public MinecraftRecipesBuildingBlocksAndesiteSlab MinecraftRecipesBuildingBlocksAndesiteSlab { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/red_bed_from_white_bed")]
        public MinecraftRecipesDecorationsRedBedFromWhiteBed MinecraftRecipesDecorationsRedBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_chicken")]
        public MinecraftRecipesFoodCookedChicken MinecraftRecipesFoodCookedChicken { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/red_wool")]
        public MinecraftRecipesBuildingBlocksRedWool MinecraftRecipesBuildingBlocksRedWool { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/soul_campfire")]
        public MinecraftRecipesDecorationsSoulCampfire MinecraftRecipesDecorationsSoulCampfire { get; set; }

        [JsonPropertyName("minecraft:story/smelt_iron")]
        public MinecraftStorySmeltIron MinecraftStorySmeltIron { get; set; }

        [JsonPropertyName("minecraft:recipes/tools/stone_axe")]
        public MinecraftRecipesToolsStoneAxe MinecraftRecipesToolsStoneAxe { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/melon")]
        public MinecraftRecipesBuildingBlocksMelon MinecraftRecipesBuildingBlocksMelon { get; set; }

        [JsonPropertyName("minecraft:recipes/food/cooked_mutton")]
        public MinecraftRecipesFoodCookedMutton MinecraftRecipesFoodCookedMutton { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/raw_iron_block")]
        public MinecraftRecipesBuildingBlocksRawIronBlock MinecraftRecipesBuildingBlocksRawIronBlock { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_brick_stairs")]
        public MinecraftRecipesBuildingBlocksDeepslateBrickStairs MinecraftRecipesBuildingBlocksDeepslateBrickStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/deepslate_tile_stairs")]
        public MinecraftRecipesBuildingBlocksDeepslateTileStairs MinecraftRecipesBuildingBlocksDeepslateTileStairs { get; set; }

        [JsonPropertyName("minecraft:recipes/decorations/light_gray_bed_from_white_bed")]
        public MinecraftRecipesDecorationsLightGrayBedFromWhiteBed MinecraftRecipesDecorationsLightGrayBedFromWhiteBed { get; set; }

        [JsonPropertyName("minecraft:recipes/building_blocks/bone_block")]
        public MinecraftRecipesBuildingBlocksBoneBlock MinecraftRecipesBuildingBlocksBoneBlock { get; set; }

        [JsonPropertyName("DataVersion")]
        public int DataVersion { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Criteria {
        [JsonPropertyName("has_string")]
        public string HasString { get; set; }

        [JsonPropertyName("has_mutton")]
        public string HasMutton { get; set; }

        [JsonPropertyName("has_furnace")]
        public string HasFurnace { get; set; }

        [JsonPropertyName("has_white_wool")]
        public string HasWhiteWool { get; set; }

        [JsonPropertyName("has_polished_deepslate")]
        public string HasPolishedDeepslate { get; set; }

        [JsonPropertyName("has_cobblestone")]
        public string HasCobblestone { get; set; }

        [JsonPropertyName("has_sand")]
        public string HasSand { get; set; }

        [JsonPropertyName("has_iron_ingot")]
        public string HasIronIngot { get; set; }

        [JsonPropertyName("has_stone")]
        public string HasStone { get; set; }

        [JsonPropertyName("has_book")]
        public string HasBook { get; set; }

        [JsonPropertyName("has_cobbled_deepslate")]
        public string HasCobbledDeepslate { get; set; }

        [JsonPropertyName("has_andesite")]
        public string HasAndesite { get; set; }

        [JsonPropertyName("entered_nether")]
        public string EnteredNether { get; set; }

        [JsonPropertyName("has_planks")]
        public string HasPlanks { get; set; }

        [JsonPropertyName("has_stick")]
        public string HasStick { get; set; }

        [JsonPropertyName("has_gold_ingot")]
        public string HasGoldIngot { get; set; }

        [JsonPropertyName("has_wheat")]
        public string HasWheat { get; set; }

        [JsonPropertyName("has_diorite")]
        public string HasDiorite { get; set; }

        [JsonPropertyName("has_copper_ingot")]
        public string HasCopperIngot { get; set; }

        [JsonPropertyName("has_melon")]
        public string HasMelon { get; set; }

        [JsonPropertyName("has_magma_cream")]
        public string HasMagmaCream { get; set; }

        [JsonPropertyName("has_copper_block")]
        public string HasCopperBlock { get; set; }

        [JsonPropertyName("has_lots_of_items")]
        public string HasLotsOfItems { get; set; }

        [JsonPropertyName("has_bed")]
        public string HasBed { get; set; }

        [JsonPropertyName("has_the_recipe")]
        public string HasTheRecipe { get; set; }

        [JsonPropertyName("has_diamond")]
        public string HasDiamond { get; set; }

        [JsonPropertyName("has_bone_meal")]
        public string HasBoneMeal { get; set; }

        [JsonPropertyName("in_water")]
        public string InWater { get; set; }

        [JsonPropertyName("has_gunpowder")]
        public string HasGunpowder { get; set; }

        [JsonPropertyName("has_bowl")]
        public string HasBowl { get; set; }

        [JsonPropertyName("has_emerald")]
        public string HasEmerald { get; set; }

        [JsonPropertyName("has_egg")]
        public string HasEgg { get; set; }

        [JsonPropertyName("has_cut_copper")]
        public string HasCutCopper { get; set; }

        [JsonPropertyName("has_granite")]
        public string HasGranite { get; set; }

        [JsonPropertyName("has_deepslate_bricks")]
        public string HasDeepslateBricks { get; set; }

        [JsonPropertyName("cooked_porkchop")]
        public string CookedPorkchop { get; set; }

        [JsonPropertyName("chicken")]
        public string Chicken { get; set; }

        [JsonPropertyName("sweet_berries")]
        public string SweetBerries { get; set; }

        [JsonPropertyName("baked_potato")]
        public string BakedPotato { get; set; }

        [JsonPropertyName("porkchop")]
        public string Porkchop { get; set; }

        [JsonPropertyName("apple")]
        public string Apple { get; set; }

        [JsonPropertyName("cooked_cod")]
        public string CookedCod { get; set; }

        [JsonPropertyName("mutton")]
        public string Mutton { get; set; }

        [JsonPropertyName("bread")]
        public string Bread { get; set; }

        [JsonPropertyName("suspicious_stew")]
        public string SuspiciousStew { get; set; }

        [JsonPropertyName("dried_kelp")]
        public string DriedKelp { get; set; }

        [JsonPropertyName("golden_carrot")]
        public string GoldenCarrot { get; set; }

        [JsonPropertyName("cod")]
        public string Cod { get; set; }

        [JsonPropertyName("carrot")]
        public string Carrot { get; set; }

        [JsonPropertyName("has_gold_nugget")]
        public string HasGoldNugget { get; set; }

        [JsonPropertyName("has_cod")]
        public string HasCod { get; set; }

        [JsonPropertyName("has_kelp")]
        public string HasKelp { get; set; }

        [JsonPropertyName("has_gravel")]
        public string HasGravel { get; set; }

        [JsonPropertyName("has_redstone")]
        public string HasRedstone { get; set; }

        [JsonPropertyName("has_pointed_dripstone")]
        public string HasPointedDripstone { get; set; }

        [JsonPropertyName("has_raw_gold")]
        public string HasRawGold { get; set; }

        [JsonPropertyName("has_chicken")]
        public string HasChicken { get; set; }

        [JsonPropertyName("has_rose_bush")]
        public string HasRoseBush { get; set; }

        [JsonPropertyName("iron_chestplate")]
        public string IronChestplate { get; set; }

        [JsonPropertyName("get_stone")]
        public string GetStone { get; set; }

        [JsonPropertyName("has_deepslate_tiles")]
        public string HasDeepslateTiles { get; set; }

        [JsonPropertyName("slept_in_bed")]
        public string SleptInBed { get; set; }

        [JsonPropertyName("has_log")]
        public string HasLog { get; set; }

        [JsonPropertyName("lava_bucket")]
        public string LavaBucket { get; set; }

        [JsonPropertyName("consumed_item")]
        public string ConsumedItem { get; set; }

        [JsonPropertyName("has_raw_copper")]
        public string HasRawCopper { get; set; }

        [JsonPropertyName("killed_by_something")]
        public string KilledBySomething { get; set; }

        [JsonPropertyName("minecraft:pillager")]
        public string MinecraftPillager { get; set; }

        [JsonPropertyName("minecraft:skeleton")]
        public string MinecraftSkeleton { get; set; }

        [JsonPropertyName("minecraft:magma_cube")]
        public string MinecraftMagmaCube { get; set; }

        [JsonPropertyName("minecraft:spider")]
        public string MinecraftSpider { get; set; }

        [JsonPropertyName("minecraft:creeper")]
        public string MinecraftCreeper { get; set; }

        [JsonPropertyName("minecraft:cave_spider")]
        public string MinecraftCaveSpider { get; set; }

        [JsonPropertyName("minecraft:piglin")]
        public string MinecraftPiglin { get; set; }

        [JsonPropertyName("minecraft:silverfish")]
        public string MinecraftSilverfish { get; set; }

        [JsonPropertyName("minecraft:zombie")]
        public string MinecraftZombie { get; set; }

        [JsonPropertyName("has_iron_sword")]
        public string HasIronSword { get; set; }

        [JsonPropertyName("spyglass_at_ghast")]
        public string SpyglassAtGhast { get; set; }

        [JsonPropertyName("diamond")]
        public string Diamond { get; set; }

        [JsonPropertyName("has_lapis_lazuli")]
        public string HasLapisLazuli { get; set; }

        [JsonPropertyName("has_snowball")]
        public string HasSnowball { get; set; }

        [JsonPropertyName("has_iron_block")]
        public string HasIronBlock { get; set; }

        [JsonPropertyName("has_porkchop")]
        public string HasPorkchop { get; set; }

        [JsonPropertyName("has_peony")]
        public string HasPeony { get; set; }

        [JsonPropertyName("has_raw_iron")]
        public string HasRawIron { get; set; }

        [JsonPropertyName("has_moss_block")]
        public string HasMossBlock { get; set; }

        [JsonPropertyName("has_wool")]
        public string HasWool { get; set; }

        [JsonPropertyName("has_poppy")]
        public string HasPoppy { get; set; }

        [JsonPropertyName("has_feather")]
        public string HasFeather { get; set; }

        [JsonPropertyName("has_coal")]
        public string HasCoal { get; set; }

        [JsonPropertyName("has_dandelion")]
        public string HasDandelion { get; set; }

        [JsonPropertyName("deflected_projectile")]
        public string DeflectedProjectile { get; set; }

        [JsonPropertyName("has_golden_boots")]
        public string HasGoldenBoots { get; set; }

        [JsonPropertyName("has_logs")]
        public string HasLogs { get; set; }

        [JsonPropertyName("has_nautilus_core")]
        public string HasNautilusCore { get; set; }

        [JsonPropertyName("has_prismarine_crystals")]
        public string HasPrismarineCrystals { get; set; }

        [JsonPropertyName("has_bone")]
        public string HasBone { get; set; }

        [JsonPropertyName("iron_pickaxe")]
        public string IronPickaxe { get; set; }

        [JsonPropertyName("has_paper")]
        public string HasPaper { get; set; }

        [JsonPropertyName("crafting_table")]
        public string CraftingTable { get; set; }

        [JsonPropertyName("minecraft:cold_ocean")]
        public string MinecraftColdOcean { get; set; }

        [JsonPropertyName("minecraft:forest")]
        public string MinecraftForest { get; set; }

        [JsonPropertyName("minecraft:mountains")]
        public string MinecraftMountains { get; set; }

        [JsonPropertyName("minecraft:taiga")]
        public string MinecraftTaiga { get; set; }

        [JsonPropertyName("minecraft:deep_cold_ocean")]
        public string MinecraftDeepColdOcean { get; set; }

        [JsonPropertyName("minecraft:taiga_hills")]
        public string MinecraftTaigaHills { get; set; }

        [JsonPropertyName("minecraft:birch_forest")]
        public string MinecraftBirchForest { get; set; }

        [JsonPropertyName("minecraft:beach")]
        public string MinecraftBeach { get; set; }

        [JsonPropertyName("minecraft:dark_forest")]
        public string MinecraftDarkForest { get; set; }

        [JsonPropertyName("minecraft:river")]
        public string MinecraftRiver { get; set; }

        [JsonPropertyName("minecraft:lukewarm_ocean")]
        public string MinecraftLukewarmOcean { get; set; }

        [JsonPropertyName("minecraft:birch_forest_hills")]
        public string MinecraftBirchForestHills { get; set; }

        [JsonPropertyName("minecraft:wooded_mountains")]
        public string MinecraftWoodedMountains { get; set; }

        [JsonPropertyName("minecraft:wooded_hills")]
        public string MinecraftWoodedHills { get; set; }

        [JsonPropertyName("minecraft:stone_shore")]
        public string MinecraftStoneShore { get; set; }

        [JsonPropertyName("minecraft:swamp")]
        public string MinecraftSwamp { get; set; }

        [JsonPropertyName("minecraft:plains")]
        public string MinecraftPlains { get; set; }

        [JsonPropertyName("wheat")]
        public string Wheat { get; set; }

        [JsonPropertyName("has_carrot")]
        public string HasCarrot { get; set; }

        [JsonPropertyName("has_glow_ink_sac")]
        public string HasGlowInkSac { get; set; }

        [JsonPropertyName("has_dried_kelp")]
        public string HasDriedKelp { get; set; }

        [JsonPropertyName("minecraft:nether_wastes")]
        public string MinecraftNetherWastes { get; set; }

        [JsonPropertyName("minecraft:basalt_deltas")]
        public string MinecraftBasaltDeltas { get; set; }

        [JsonPropertyName("iron")]
        public string Iron { get; set; }
    }

    public class MinecraftRecipesToolsFishingRod {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedMuttonFromCampfireCooking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsSmoker {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPurpleWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileSlabFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneLever {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobblestoneStairsFromCobblestoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMagentaConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatIronSword {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneBricks {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscWritableBook {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksChiseledDeepslateFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedAndesiteStairsFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLimeConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsIronPickaxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftNetherRoot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksYellowConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneBirchPressurePlate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCraftingTable {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCampfire {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMagentaWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCandle {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsGoldenHoe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodBread {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDioriteSlabFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCopperBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateBrickWallFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksSmoothStone {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscMelonSeeds {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMagmaBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLadder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperStairsFromCopperBlockStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronNugget {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsChest {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatGoldenSword {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBrownConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneSlabFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBlackBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobbledDeepslateSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksChiseledStoneBricksStoneFromStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsWoodenShovel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileSlabFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsTorch {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatDiamondSword {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCyanWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsShears {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscWhiteDye {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscStick {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneBrickSlabFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationSpruceBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsJukebox {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperSlabFromCopperBlockStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscFireworkRocketSimple {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodMushroomStew {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksEmeraldBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCake {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGrayWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperSlabFromCutCopperStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedGraniteFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldNugget {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatIronLeggings {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTiles {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftHusbandryBalancedDiet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsWoodenHoe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBrewingGoldenCarrot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatShield {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobblestoneSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedCod {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscBucket {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDioriteSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobblestoneStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodDriedKelpFromSmoking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneHopper {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBirchSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTilesFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCobbledDeepslateWallFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsYellowBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCoarseDirt {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTilesFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsGraniteWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneNoteBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDripstoneBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsWhiteBanner {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileStairsFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDioriteSlabFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLightGrayConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLightBlueConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTilesFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldIngotFromSmeltingRawGold {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksHayBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGlass {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatIronHelmet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsGoldenShovel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPinkConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatBow {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneOakFenceGate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneTnt {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedChickenFromSmoking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneLectern {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPurpleConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneStairsFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsMagentaBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksAndesiteStairsFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsIronBars {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDioriteWallFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscRedDyeFromRoseBush {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsOrangeBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGoldBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBlueWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateBrickWallFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryObtainArmor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscCopperIngot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatDiamondChestplate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryMineStone {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneTarget {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsFurnace {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationMinecart {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateBrickWallFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBrewingCauldron {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateTilesStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatDiamondLeggings {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureSleepInBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscCharcoal {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksAndesiteStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksSandstone {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOrangeWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsWoodenPickaxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryLavaBucket {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsIronHoe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobblestoneSlabFromCobblestoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobbledDeepslateStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodDriedKelpFromSmelting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileStairsFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftHusbandryRoot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneRedstoneTorch {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationBirchBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodGoldenApple {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperFromCopperBlockStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldIngotFromBlastingRawGold {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOakStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedAndesiteSlabFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedGraniteSlabFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGreenConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedAndesiteFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobbledDeepslateStairsFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationAcaciaBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsIronShovel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscCopperIngotFromBlastingRawCopper {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneIronTrapdoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBirchSign {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCyanBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureRoot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsGrayBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksWhiteConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLimeBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneBrickStairsFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPolishedDeepslateWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsStoneHoe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksWhiteWoolFromString {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsClock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsDiamondPickaxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsDiamondHoe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneLightningRod {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateTilesStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureKillAllMobs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsDiamondShovel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryEnterTheNether {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsGreenBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBirchWood {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneRedstoneBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGraniteSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsWhiteCarpet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPinkBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBrewingGlisteringMelonSlice {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedChickenFromCampfireCooking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronNuggetFromSmelting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedMuttonFromSmoking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureSpyglassAtGhast {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateSlabFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBricks {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneBirchDoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsGraniteWallFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsChain {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldIngotFromNuggets {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryMineDiamond {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopperStairsFromCutCopperStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedGraniteStairsFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscBlueDye {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatDiamondHelmet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsOakFence {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsSnow {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationOakBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedCodFromCampfireCooking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsAnvil {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBirchFence {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBlueBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedPorkchop {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOrangeConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOakSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCyanConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatGoldenBoots {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedPorkchopFromCampfireCooking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksRawCopperBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsWoodenAxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLimeWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateTileWallFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGraniteStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDioriteStairsFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBlackWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneBricksFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscPinkDyeFromPeony {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatGoldenChestplate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPolishedDeepslateWallFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateTileWallFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLoom {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGreenWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronIngotFromBlastingRawIron {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsDiamondAxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDioriteStairsFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBrownWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsMossCarpet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksWaxedCopperBlockFromHoneycomb {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneBirchButton {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksIronBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPainting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscRedDyeFromPoppy {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMossyCobblestoneFromMossBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksAndesiteSlabFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatArrow {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCoalBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscYellowDyeFromDandelion {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneLightWeightedPressurePlate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryDeflectArrow {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldNuggetFromBlasting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLightBlueWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatWoodenSword {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsStoneShovel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOakPlanks {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBlueConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGrayConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDioriteStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscConduit {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGraniteSlabFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBookshelf {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsGoldenAxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsIronAxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksAndesite {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksSeaLantern {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBricksFromPolishedDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatGoldenHelmet {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateTileWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneTripwireHook {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneOakPressurePlate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksRawGoldBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatIronBoots {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscBoneMeal {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBirchPlanks {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateStairsFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBlackConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMossyStoneBricksFromMossBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryIronTools {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileStairsFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCartographyTable {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksOakWood {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneBirchFenceGate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStoryRoot {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneStoneButton {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatCrossbow {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatIronChestplate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneDropper {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCobbledDeepslateWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksYellowWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsOakSign {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedPorkchopFromSmoking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneOakTrapdoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDioriteFromDioriteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksGraniteStairsFromGraniteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCrackedDeepslateBricks {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksRedConcretePowder {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLightBlueBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronNuggetFromBlasting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPolishedDeepslateWallFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsCompass {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureKillAMob {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneOakButton {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsGoldenPickaxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDioriteWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStone {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedAndesite {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBricksFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsStonecutter {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftAdventureAdventuringTime {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneIronDoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickStairsFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscBook {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsPurpleBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscCopperIngotFromSmeltingRawCopper {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatStoneSword {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBarrel {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCobblestoneWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksSnowBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDeepslateSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronIngotFromSmeltingRawIron {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsStonePickaxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsSmithingTable {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneOakDoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCutCopper {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCrackedDeepslateTiles {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateTileWallFromDeepslateTilesStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneStonePressurePlate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftHusbandryPlantSeed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsDeepslateBrickWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationJungleBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsCobblestoneWallFromCobblestoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBirchStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsStoneBrickWallsFromStoneStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscIronIngotFromIronBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneHeavyWeightedPressurePlate {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDiamondBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationDarkOakBoat {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesTransportationCarrotOnAStick {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsGlowItemFrame {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsAndesiteWallFromAndesiteStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPinkWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDriedKelpBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodDriedKelpFromCampfireCooking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLapisBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksWaxedCutCopperFromHoneycomb {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsBrownBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedGranite {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstoneBirchTrapdoor {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatGoldenLeggings {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedCodFromSmoking {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesRedstonePiston {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileSlabFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLantern {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksStoneStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftNetherExploreNether {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickSlabFromDeepslateBricksStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesMiscGoldNuggetFromSmelting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesCombatDiamondBoots {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksPolishedDiorite {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksCobbledDeepslateSlabFromCobbledDeepslateStonecutting {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsAndesiteWall {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksLightGrayWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksAndesiteSlab {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsRedBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedChicken {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksRedWool {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsSoulCampfire {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftStorySmeltIron {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesToolsStoneAxe {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksMelon {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesFoodCookedMutton {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksRawIronBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateBrickStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksDeepslateTileStairs {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesDecorationsLightGrayBedFromWhiteBed {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }

    public class MinecraftRecipesBuildingBlocksBoneBlock {
        [JsonPropertyName("criteria")]
        public Criteria Criteria { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }
}