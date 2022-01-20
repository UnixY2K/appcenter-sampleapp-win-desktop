
class Note
{

    public Note()
    {
    }
    public Note(string name, string content)
    {
        this.name = name;
        this.content = content;
    }

    public bool isNew()
    {
        return id == null_id;
    }

    // toString method
    public override string ToString()
    {
        return name;
    }

    private const int null_id = 0;

    private int _id = 0;
    private string _name = "";
    private string _content = "";

    // properties

    public int id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string content
    {
        get { return _content; }
        set { _content = value; }
    }

}
