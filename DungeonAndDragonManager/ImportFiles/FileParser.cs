using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonAndDragonManager.Data;
using Escape;

namespace DungeonAndDragonManager.ImportFiles
{
    public class FileParser
    {
        private readonly FullDbContext _db;
        private JavaScriptParser parser = new JavaScriptParser();

        public FileParser(FullDbContext db)
        {
            _db = db;
        }

        public void ImportAll()
        {
            var sourceFile = ParseFile("SourceList.js");

            var x = 0;
        }
        
        private Escape.Ast.Program ParseFile(string fileName)
        {
            return parser.Parse(System.IO.File.ReadAllText($@"..\DungeonAndDragonManager\ImportFiles\{fileName}"));
        }
    }
}
