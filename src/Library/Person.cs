using System.Collections.ObjectModel;

namespace Library;

public class Person
{
    private string _name;
    private int _age, _number;
    private List<Person> children = new List<Person>();

    public string Name
    {
        get { return this._name; }
        private set { this._name = value; }
    }

    public int Age
    {
        get { return this._age; }
        private set { this._age = value; }
    }
    
    public int Number {
        get { return this._number; }
        private set { this._number = value; }
    }
    
    public ReadOnlyCollection<Person> Children {
        get { return this.children.AsReadOnly(); }
    }
}