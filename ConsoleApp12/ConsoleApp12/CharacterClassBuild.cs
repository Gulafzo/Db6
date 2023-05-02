using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class CharacterClassBuild
    {
        public int Id { get; private set; }
        public int CharacterClassId { get; private set; }
        public int SpellId { get; private set; }
        public CharacterClassBuild(int id, int ChClId, int spellId)
        {
            Id = id;
            CharacterClassId = ChClId;
            SpellId = spellId;
        }

    }
}
