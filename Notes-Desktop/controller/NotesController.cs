
class NotesController
{
    private NotesController() { }


    public bool addNote(Note note)
    {
        return NoteDAO.instance.addNote(note);
    }

    public Note? getNote(int id)
    {
        return NoteDAO.instance.getNote(id);
    }

    public List<Note> getAllNotes()
    {
        return NoteDAO.instance.getNotes();
    }

    static NotesController? _instance = null;
    public static NotesController instance
    {
        get
        {
            // singleton
            if (_instance == null)
            {
                _instance = new NotesController();
            }

            return _instance;
        }
    }

}

