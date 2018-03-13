using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.ImportFiles;

namespace DungeonAndDragonManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FullDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Sources.Any())
            {
                var parser = new FileParser(context);
                parser.ImportAll();
            }
        }
    }
}
