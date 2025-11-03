using System.Collections.ObjectModel;

namespace Library;

public class Person
{
    private string _name;
    private int _age;
    private List<Person> _children = new List<Person>();

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
    
    public ReadOnlyCollection<Person> Children {
        get { return this._children.AsReadOnly(); }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void AddChildren(Person person)
    {
        this._children.Add(person);
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        
        foreach (var item in this._children)
        {
            item.Accept(visitor);
        }
    }
}