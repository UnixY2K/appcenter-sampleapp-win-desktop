namespace Notes_Desktop
{
    public partial class Form1 : Form
    {
        int ultimaNota = -1;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            loadNotes();
        }

        void loadNotes()
        {
            List<Note> notes = NoteDAO.instance.getNotes();
            foreach (Note note in notes)
            {
                // add note to combobox
                cmbNota.Items.Add(note);
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
            if (ultimaNota == -1)
            {
                return null;
            }
            else
            {
                return cmbNota.Items[ultimaNota] as Note;
            }
        }
        private void newNoteItem_Click(object sender, EventArgs e)
        {
            cmbNota.Enabled = true;
            txtContenido.Enabled = true;
            cmbNota.SelectedIndex = -1;
            cmbNota.DropDownStyle = ComboBoxStyle.DropDown;
            txtContenido.Text = "";
            ultimaNota = -1;
        }

        private void deleteNoteItem_Click(object sender, EventArgs e)
        {
            Note? note = getNote();
            if (note != null)
            {
                NoteDAO.instance.deleteNote(note.id);
                cmbNota.Items.Remove(note);
                cmbNota.SelectedIndex = 0;
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
            ultimaNota = cmbNota.SelectedIndex;
            Note? note = getNote();
            if (note != null)
            {
                txtContenido.Text = note.content;
                txtContenido.Enabled = true;
            }
        }
    }
}