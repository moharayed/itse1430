using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>
    /// Represents character information
    /// </summary>
    public class Character
    {

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Description
        {
           get { return _description ?? ""; }
           set { _description = value; }
        }

        //Combo Box
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        //Combo Box
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int Strength { get; set; } = 100;

        public int Intelligence { get; set; } = 100;

        public int Agility { get; set; } = 100;

        public int Constitution { get; set; } = 100;

        public int Charisma { get; set; } = 100;
        
        private string _name = "";
        private string _profession = "";
        private string _race = "";
        private string _description = "";
        //private string _strength = "";
        //private string _intelligence = "";
        //private string _agility = "";
        //private string _constitution = "";
        //private string _charisma = "";

    }
}
