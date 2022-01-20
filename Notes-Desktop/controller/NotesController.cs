
class NotesController
{
    private NotesController() { }


    public bool addNote(Note note)
    {
        return true;
    }

    public Note? getNote(int id)
    {
        return null;
    }

    public List<Note> getAllNotes()
    {
        return new List<Note>();
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

