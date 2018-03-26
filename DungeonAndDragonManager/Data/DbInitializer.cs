using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data.Seed;
using DungeonAndDragonManager.ImportFiles;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace DungeonAndDragonManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            if (!context.Sources.Any())
            {
                SourceSeed.Seed(context);

                var file = System.IO.File.ReadAllText($@"..\DungeonAndDragonManager\ImportFiles\ImportFile.json");
                var json = JObject.Parse(file);
                RaceSeed.Seed(context, json["Classes"]);
            }
        }
    }
}
