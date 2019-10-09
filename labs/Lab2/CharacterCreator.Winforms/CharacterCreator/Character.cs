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

        private string _name = "";
        private string _profession = "";
        private string _race = "";
        private string _attributes = "";
        private string _description = "";
        //private string _strength = "";
        //private string _intelligence = "";
        //private string _agility = "";
        //private string _constitution = "";
        //private string _charisma = "";

    }
}
