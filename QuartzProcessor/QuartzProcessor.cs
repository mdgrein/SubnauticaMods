using System;
using System.Collections.Generic;

using UnityEngine;

using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;

namespace MDMods.QuartzProcessor.Craftables
{
    public class QuartzProcessor : Craftable
    {
        public QuartzProcessor() : base("", "", "") { }

        public override string AssetsFolder => $"QuartzProcessor/Assets";

        protected override TechData GetBlueprintRecipe()
        {
            // Create and associate recipe to the new TechType
            var customFabRecipe = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient(TechType.Quartz, 10),
                },
                LinkedItems = new List<TechType>()
                {
                    TechType.ComputerChip
                }
            };

            return customFabRecipe;
        }
        public override GameObject GetGameObject()
        {
            GameObject prefab = GameObject.Instantiate(CraftData.GetPrefabForTechType(TechType.ComputerChip));

            return prefab;
        }

        public override TechGroup GroupForPDA { get; } = TechGroup.Resources;

        public override TechCategory CategoryForPDA { get; } = TechCategory.Electronics;

        public override CraftTree.Type FabricatorType { get; } = CraftTree.Type.Fabricator;
    }
}
