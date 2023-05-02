using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Database
    {
        public List<Characters> Characters { get; private set; }
        public List<CharactersClass> CharactersClass { get; private set; }
        public List<Spell> Spell { get; private set; }
        public List<CharacterClassBuild> CharacterClassBuild { get; private set; }
       
        public Database()
        {
            Characters = new List<Characters>();
            CharactersClass = new List<CharactersClass>();
            Spell = new List<Spell>();
            CharacterClassBuild = new List<CharacterClassBuild>();
            
        }

        public void InitializeStatic()
        {
            Characters.Add(new Characters(1, "первый ", 2));
            Characters.Add(new Characters(2, "второй ", 4));
            Characters.Add(new Characters(5, "пятый ", 3));
            Spell.Add(new Spell(4, "Волшебный удар", 9));
            Spell.Add(new Spell(1, "Удар", 6));
            CharacterClassBuild.Add(new CharacterClassBuild(4, 8, 3));
            Characters.Add(new Characters(1, "Первый", 1));
            Characters.Add(new Characters(2, "Втрой", 2));
            CharactersClass.Add(new CharactersClass(1, "Лучник"));
            CharactersClass.Add(new CharactersClass(2, "Маг"));          
            CharacterClassBuild.Add(new CharacterClassBuild(1, 1, 1));         
            CharacterClassBuild.Add(new CharacterClassBuild(2, 2, 2));

        }

    }
}
