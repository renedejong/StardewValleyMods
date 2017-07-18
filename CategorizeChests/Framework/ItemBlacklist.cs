﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewValleyMods.CategorizeChests.Framework
{
    static class ItemBlacklist
    {
        public static bool Includes(ItemKey itemKey) => BlacklistedItemKeys.Contains(itemKey);

        private static readonly HashSet<ItemKey> BlacklistedItemKeys = new HashSet<ItemKey>()
        {
            // stones
            new ItemKey(ItemType.Object, 2),
            new ItemKey(ItemType.Object, 4),
            new ItemKey(ItemType.Object, 75),
            new ItemKey(ItemType.Object, 76),
            new ItemKey(ItemType.Object, 77),
            new ItemKey(ItemType.Object, 290),
            new ItemKey(ItemType.Object, 343),
            new ItemKey(ItemType.Object, 450),
            new ItemKey(ItemType.Object, 668),
            new ItemKey(ItemType.Object, 670),
            new ItemKey(ItemType.Object, 751),
            new ItemKey(ItemType.Object, 760),
            new ItemKey(ItemType.Object, 762),
            new ItemKey(ItemType.Object, 764),
            new ItemKey(ItemType.Object, 765),

            // weeds
            new ItemKey(ItemType.Object, 0),
            new ItemKey(ItemType.Object, 313),
            new ItemKey(ItemType.Object, 314),
            new ItemKey(ItemType.Object, 315),
            new ItemKey(ItemType.Object, 316),
            new ItemKey(ItemType.Object, 317),
            new ItemKey(ItemType.Object, 318),
            new ItemKey(ItemType.Object, 319),
            new ItemKey(ItemType.Object, 320),
            new ItemKey(ItemType.Object, 321),
            new ItemKey(ItemType.Object, 452),
            new ItemKey(ItemType.Object, 674),
            new ItemKey(ItemType.Object, 675),
            new ItemKey(ItemType.Object, 676),
            new ItemKey(ItemType.Object, 677),
            new ItemKey(ItemType.Object, 678),
            new ItemKey(ItemType.Object, 679),
            new ItemKey(ItemType.Object, 750),
            new ItemKey(ItemType.Object, 784),
            new ItemKey(ItemType.Object, 785),
            new ItemKey(ItemType.Object, 786),
            new ItemKey(ItemType.Object, 792),
            new ItemKey(ItemType.Object, 793),
            new ItemKey(ItemType.Object, 794),

            // twigs
            new ItemKey(ItemType.Object, 294),
            new ItemKey(ItemType.Object, 295),

            new ItemKey(ItemType.Object, 30), // Lumber
            new ItemKey(ItemType.Object, 94), // Spirit Torch
            new ItemKey(ItemType.Object, 102), // Lost Book
            new ItemKey(ItemType.Object, 449), // Stone Base
            new ItemKey(ItemType.Object, 461), // Decorative Pot
            new ItemKey(ItemType.Object, 590), // Artifact Spot
            new ItemKey(ItemType.Object, 788), // Lost Axe
            new ItemKey(ItemType.Object, 789), // Lucky Purple Shorts
            new ItemKey(ItemType.Object, 790), // Berry Basket
        };
    }
}