using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent ();
        }

        public Character Character { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                cbProfession.Text = Character.Profession;
                cbRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString ();
                _txtIntelligence.Text = Character.Intelligence.ToString ();
                _txtAgility.Text = Character.Agility.ToString ();
                _txtConstitution.Text = Character.Constitution.ToString ();
                _txtCharisma.Text = Character.Charisma.ToString ();
            }

            ValidateChildren ();
        }

        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var character = new Character ();
            character.Name = _txtName.Text;
            character.Description = _txtDescription.Text;
            character.Profession = cbProfession.Text;
            character.Race = cbRace.Text;
            character.Strength = GetAsInt32 (_txtStrength);
            character.Intelligence = GetAsInt32 (_txtIntelligence);
            character.Agility = GetAsInt32 (_txtAgility);
            character.Constitution = GetAsInt32 (_txtConstitution);
            character.Charisma = GetAsInt32 (_txtCharisma);

            //add validation

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
        }

        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }
    }
}
