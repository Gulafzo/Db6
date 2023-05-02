using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Characters
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int CharactersClassId { get; private set; }

        public Characters(int id, string name, int classId)
        {
            Id = id;
            Name = name;
            CharactersClassId = classId;
        }
    }
}
