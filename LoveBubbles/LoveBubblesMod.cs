using StardewModdingAPI;
using StardewValley;
using System.Collections.Generic;
using System.Linq;

namespace StardewValleyMods.LoveBubbles
{
    public class LoveBubblesMod : Mod
    {
        private static readonly string[] harvestTools = new [] { "Milk Pail", "Shears" };

        public override void Entry(IModHelper helper)
        {
            if (HasSupercedingModLoaded())
            {
                // Abort loading the mod if another mod is present that adds the same functionality
                return;
            }
            
            Helper.Events.Display.RenderingHud += (sender, e) => DrawAllBubbles();
        }

        /// <summary>
        /// Determine if the player has any mods loaded that offer the same functionality as this mod
        /// </summary>
        /// <returns>true if there is a superceding mod, otherwise false</returns>
        private bool HasSupercedingModLoaded()
        {
            return Helper.ModRegistry.IsLoaded("BetterRanching");
        }

        /// <summary>
        /// Determine which animals need some love and draw a heart bubble above them
        /// </summary>
        private void DrawAllBubbles()
        {
            if (!Game1.hasLoadedGame || !Game1.currentLocation.IsFarm)
            {
                return;
            }

            var pettableAnimals = GetNearbyAnimals().Where(a => !a.wasPet.Value && !HasProduct(a));

            foreach (var animal in pettableAnimals)
            {
                Renderer.DrawBubble(animal);
            }
        }

        /// <summary>
        /// Determine whether an animal has product that can be collected by the player
        /// </summary>
        /// <param name="animal">the animal</param>
        /// <returns>true if the animal has collectible product, otherwise false</returns>
        private static bool HasProduct(FarmAnimal animal)
        {
            return harvestTools.Contains(animal.toolUsedForHarvest.Value) && animal.currentProduce.Value > 0;
        }

        /// <summary>
        /// Get a collection of nearby animals
        /// </summary>
        /// <returns>a collection of animals</returns>
        private static IEnumerable<FarmAnimal> GetNearbyAnimals()
        {
            switch (Game1.currentLocation)
            {
                case AnimalHouse house:
                    return house.animals.Values;
         
                case Farm farm:
                    return farm.animals.Values;
                
                default:
                    return Enumerable.Empty<FarmAnimal>();
            }
        }
    }
}
