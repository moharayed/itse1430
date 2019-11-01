using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public static class CharacterDatabaseExtentions
    {
        public static void Seed ( this ICharacterDatabase source)
        {
            source.Add (new Character () {Name = "Ant"      , Profession = "Fighter"    , Race = "Dwarf"        , Strength = 69, Intelligence = 46, Agility = 78, Constitution = 32, Charisma = 20, });
            source.Add (new Character () {Name = "Hawk"     , Profession = "Hunter"     , Race = "Half Elf"     , Strength = 67, Intelligence = 42, Agility = 77, Constitution = 30, Charisma = 25,});
            source.Add (new Character () {Name = "Intel"    , Profession = "Priest"     , Race = "Half Elf"     , Strength = 65, Intelligence = 95, Agility = 74, Constitution = 60, Charisma = 30,});
            source.Add (new Character () {Name = "Hero"     , Profession = "Fighter"    , Race = "Human"        , Strength = 62, Intelligence = 49, Agility = 72, Constitution = 34, Charisma = 36,});
            source.Add (new Character () {Name = "Olimar"   , Profession = "Fighter"    , Race = "Human"        , Strength = 99, Intelligence = 99, Agility = 99, Constitution = 99, Charisma = 99,});
        }
    }
}
