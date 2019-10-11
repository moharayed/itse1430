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
        public string Validate()
        {
            if (String.IsNullOrEmpty (this.Name))
                return "Name is required";

            if (String.IsNullOrEmpty (Profession))
                return "Profession is required";

            if (String.IsNullOrEmpty (Race))
                return "Race is required";

            if (Strength < 0)
            {
                return "Attribute must be between 0 to 100";
            }else if (Strength > 100)
            {
                return "Attribute must be between 0 to 100";
            }

            if (Intelligence < 0)
            {
                return "Attribute must be between 0 to 100";
            } else if (Intelligence > 100)
            {
                return "Attribute must be between 0 to 100";
            }

            if (Agility < 0)
            {
                return "Attribute must be between 0 to 100";
            } else if (Agility > 100)
            {
                return "Attribute must be between 0 to 100";
            }

            if (Constitution < 0)
            {
                return "Attribute must be between 0 to 100";
            } else if (Constitution > 100)
            {
                return "Attribute must be between 0 to 100";
            }

            if (Charisma < 0)
            {
                return "Attribute must be between 0 to 100";
            } else if (Charisma > 100)
            {
                return "Attribute must be between 0 to 100";
            }
            return "";
        }
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
    }
}
