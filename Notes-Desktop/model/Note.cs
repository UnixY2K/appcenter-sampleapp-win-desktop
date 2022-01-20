

class Note
{

    public Note()
    {
    }

    private string _name = "";
    private string _content = "";

    // properties
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
