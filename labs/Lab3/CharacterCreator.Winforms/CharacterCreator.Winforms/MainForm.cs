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
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm ();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _characters.Add (form.Character);
                UpdateUI ();
            }
        }

        private Character GetSelectedCharacter()
        {
            var item = _lstCharacters.SelectedItem;

            return item as Character;
        }

        private void UpdateUI ()
        {
            var characters = _characters.GetAll ();

            _lstCharacters.DataSource = characters.ToArray ();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;
 
            var form = new CharacterForm ();
            form.Character = character;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _characters.Update (character.Id, form.Character);
                UpdateUI ();
            }
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            _characters.Remove (character.Id);
            UpdateUI ();
        }

        private CharacterDatabase _characters = new CharacterDatabase ();
    }
}
