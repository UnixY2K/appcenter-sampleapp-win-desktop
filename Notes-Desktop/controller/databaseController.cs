using Microsoft.Data.Sqlite;


class DatabaseController
{
    private DatabaseController()
    {

    }

    public void initTable(string query)
    {
        using (var conn = connection)
        {
            conn.Open();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS " + query;
                command.ExecuteNonQuery();
            }
        }
    }

    public SqliteConnection connection
    {
        get
        {
            return new SqliteConnection("Data Source=" + DB_NAME);
        }
    }
    private const string DB_NAME = "Notes.db";

    private static DatabaseController? _instance = null;

    public static DatabaseController instance
    {
        get
        {
            // singleton
            if (_instance == null)
            {
                _instance = new DatabaseController();
            }

            return _instance;
        }
    }

}