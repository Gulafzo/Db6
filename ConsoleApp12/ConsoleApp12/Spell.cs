using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Spell
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int ExpirienceId { get; private set; }
        public Spell(int id, string name, int expirienceId)
        {
            Id = id;
            Name = name;
            ExpirienceId = expirienceId;
        }
    }
}
