namespace Notes_Desktop
{
    public partial class Form1 : Form
    {
        List<Note> notes = new List<Note>();
        public Form1()
        {
            InitializeComponent();
        }

        void loadNotes()
        {
            notes = NoteDAO.instance.getNotes();
            foreach (Note note in notes)
            {
                // add note to combobox
                cmbNota.Items.Add(note.id);
            }
            if (cmbNota.Items.Count > 0)
            {
                cmbNota.SelectedIndex = 0;
                cmbNota.Enabled = true;
            }
        }


        // recovers the selected note
        Note? getNote()
        {
            if (cmbNota.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                return cmbNota.SelectedItem as Note;
            }
        }
        private void newNoteItem_Click(object sender, EventArgs e)
        {
            cmbNota.Enabled = true;
            txtContenido.Enabled = true;
            cmbNota.SelectedIndex = -1;
            cmbNota.DropDownStyle = ComboBoxStyle.DropDown;
            txtContenido.Text = "";
        }

        private void deleteNoteItem_Click(object sender, EventArgs e)
        {
            Note? note = getNote();
            if (note != null)
            {
                NoteDAO.instance.deleteNote(note.id);
                cmbNota.Items.Remove(note);
                cmbNota.SelectedIndex = -1;
                txtContenido.Text = "";
            }

        }

        private void saveNoteItem_Click(object sender, EventArgs e)
        {
            Note? note = getNote();
            if (note is null)
            {
                note = new Note();
            }
            note.name = cmbNota.Text;
            note.content = txtContenido.Text;
            if (note.name != "" && NoteDAO.instance.saveNote(note))
            {
                if (note.isNew())
                {
                    cmbNota.Items.Add(note);
                    cmbNota.SelectedIndex = cmbNota.Items.Count - 1;
                }
            }
        }

        private void cmbNota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}