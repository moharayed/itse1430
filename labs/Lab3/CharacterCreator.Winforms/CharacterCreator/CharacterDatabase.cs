using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        public Character Add ( Character character )
        {
            character.Id = ++_id;
            _characters.Add (character);
            return character;
        }

        public void Remove ( int id )
        {
            var character = FindCharacter (id);
            if (character != null)
                _characters.Remove (character);
        }

        public Character Get ( int id )
        {
            return FindCharacter (id);
        }

        public Character[] GetAll ()
        {
            var index = 0;
            var characters = new Character[_characters.Count];
            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;

            return characters;
        }

        public void Update ( int id, Character newCharacter )
        {
            var existing = FindCharacter (id);
            if (existing == null)
                return;

            existing.Description = newCharacter.Description;
            existing.Name = newCharacter.Name;
            existing.Profession = newCharacter.Profession;
            existing.Race = newCharacter.Race;
            existing.Strength = newCharacter.Strength;
            existing.Intelligence = newCharacter.Intelligence;
            existing.Agility = newCharacter.Agility;
            existing.Constitution = newCharacter.Constitution;
            existing.Charisma = newCharacter.Charisma;

        }
        private Character FindCharacter ( int id )
        {
            foreach (var character in _characters)
                if (character.Id == id)
                    return character;

            return null;
        }

        private List<Character> _characters = new List<Character> ();
        private int _id = 0;
    }    
}
