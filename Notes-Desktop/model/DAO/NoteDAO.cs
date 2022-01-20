
class NoteDAO
{

    private NoteDAO()
    {
        initTable();
    }


    // inits the table if it doesn't exist
    private void initTable()
    {
        DatabaseController.instance.initTable(QUERY_INIT_TABLE);
    }

    public Note? getNote(int id)
    {
        using (var conn = DatabaseController.instance.connection)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM notes WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var note = new Note();
                    note.id = reader.GetInt32(0);
                    note.name = reader.GetString(1);
                    note.content = reader.GetString(2);
                    return note;
                }
            }
        }

        return null;
    }

    public List<Note> getNotes()
    {
        var notes = new List<Note>();
        using (var conn = DatabaseController.instance.connection)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM notes";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var note = new Note();
                    note.id = reader.GetInt32(0);
                    note.name = reader.GetString(1);
                    note.content = reader.GetString(2);
                    notes.Add(note);
                }
            }
        }
        return notes;
    }

    public bool addNote(Note note)
    {
        using (var conn = DatabaseController.instance.connection)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO notes (name, content) VALUES (@name, @content)";
            command.Parameters.AddWithValue("@name", note.name);
            command.Parameters.AddWithValue("@content", note.content);

            return command.ExecuteNonQuery() > 0;
        }
    }

    public bool updateNote(Note note)
    {
        using (var conn = DatabaseController.instance.connection)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "UPDATE notes SET name = @name, content = @content WHERE id = @id";
            command.Parameters.AddWithValue("@id", note.id);
            command.Parameters.AddWithValue("@name", note.name);
            command.Parameters.AddWithValue("@content", note.content);

            return command.ExecuteNonQuery() > 0;
        }
    }

    public bool saveNote(Note note)
    {
        if (note.id == 0)
        {
            return addNote(note);
        }
        else
        {
            return updateNote(note);
        }
    }

    public bool deleteNote(int id)
    {
        using (var conn = DatabaseController.instance.connection)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "DELETE FROM notes WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            return command.ExecuteNonQuery() > 0;
        }
    }


    private const string QUERY_INIT_TABLE =
                @"notes (
                    id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    name TEXT, 
                    content TEXT)";


    private static NoteDAO? _instance = null;
    public static NoteDAO instance
    {
        get
        {
            // singleton
            if (_instance == null)
            {
                _instance = new NoteDAO();
            }

            return _instance;
        }
    }
}