using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp12;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database dbContext = new Database();
            dbContext.InitializeStatic(); 
              //список персонажей
            List<Characters> characters = dbContext.Characters.ToList();
            
            foreach (var character in characters)
            {
                Console.WriteLine($"Name: {character.Name}");
            }

            // список персонажей с их классами
            List<(string, string)> charactersWithClasses = dbContext.Characters.Select(x => (x.Name,
                    dbContext.CharactersClass.FirstOrDefault(y => y.Id == x.CharactersClassId)?.Name)).ToList();
            

             foreach (var character in charactersWithClasses)
             {
                 Console.WriteLine($"Name: {character.Item1}, Class: {character.Item2}");
             }

            
            //список заклинаний для каждого класса
            List<(string, string)> spellsByClass = dbContext.CharacterClassBuild
                  .Select(x => (
                      dbContext.Characters.FirstOrDefault(z => z.CharactersClassId == dbContext.CharactersClass.FirstOrDefault(y => x.CharacterClassId == y.Id)?.Id)?.Name,
                      dbContext.Spell.FirstOrDefault(y => y.Id == x.SpellId)?.Name))
                  .ToList();
             foreach (var spell in spellsByClass)
             {
                 Console.WriteLine($"Class: {spell.Item1}, Spell: {spell.Item2}");
             }
           
            // список заклинаний для каждого персонажа
            List<(string, string, string)>  spellsByCharacter = dbContext.CharacterClassBuild
                 .Select(x => (
                     dbContext.CharactersClass.FirstOrDefault(y => x.CharacterClassId == y.Id)?.Name,
                     dbContext.Spell.FirstOrDefault(y => y.Id == x.SpellId)?.Name,
                     dbContext.Characters.FirstOrDefault(z => z.Id == x.CharacterClassId)?.Name))
                 .ToList();
             foreach (var spell in spellsByCharacter)
             {
                 Console.WriteLine($"Character: {spell.Item3}, Class: {spell.Item1}, Spell: {spell.Item2}");
             }
        }
    }
}

