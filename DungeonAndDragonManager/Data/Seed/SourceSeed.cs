using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data.Models;

namespace DungeonAndDragonManager.Data.Seed
{
    public class SourceSeed
    {
        private const string PrimarySource = "Primary Sources";
        private const string AdventureSource = "Adventure Books";

        public static void Seed(FullDbContext db)
        {
            var sources = new List<DbSource>
            {
                new DbSource("Player's Handbook", "PHB", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/rpg_playershandbook", new DateTime(2014, 8, 19)),
                new DbSource("Dungeon Master's Guide", "DMG", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/dungeon-masters-guide", new DateTime(2014, 12, 09)),
                new DbSource("Monster Manual", "MM", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/monster-manual", new DateTime(2014, 9, 30)),
                new DbSource("Elemental Evil Player's Companion", "EE", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/player%E2%80%99s-companion",
                    new DateTime(2015, 4, 16)),
                new DbSource("Sword Coast Adventurer's Guide", "SCAG", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/sc-adventurers-guide", new DateTime(2015, 11, 03)),
                new DbSource("Volo's Guide to Monsters", "VGtM", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/volos-guide-to-monsters", new DateTime(2016, 11, 15)),
                new DbSource("Xanathar's Guide to Everything", "XGtE", PrimarySource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/xanathars-guide-everything",
                    new DateTime(2017, 11, 21)),
                new DbSource("Hoard of the Dragon Queen", "HotDQ", AdventureSource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/hoard-dragon-queen", new DateTime(2014, 8, 19)),
                new DbSource("Out of the Abyss", "OotA", AdventureSource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/outoftheabyss", new DateTime(2015, 9, 15)),
                new DbSource("Curse of Strahd", "CoS", AdventureSource, "http://media.wizards.com/2016/downloads/DND/CoS_Character_Options.pdf", new DateTime(2016, 3, 15)),
                new DbSource("Storm King's Thunder", "SKT", AdventureSource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/storm-kings-thunder", new DateTime(2016, 9, 6)),
                new DbSource("Tales of the Yawning Portal", "TotYP", AdventureSource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/tales-yawning-portal", new DateTime(2017, 4, 4)),
                new DbSource("Tomb of Annihilation", "ToA", AdventureSource, "http://dnd.wizards.com/products/tabletop-games/rpg-products/tomb-annihilation", new DateTime(2017, 9, 13)),
            };
            foreach (var dbSource in sources)
            {
                if (db.Sources.SingleOrDefault(s => s.Name == dbSource.Name) == null)
                {
                    db.Sources.Add(dbSource);
                }
            }

            db.SaveChanges();
        }
    }
}
