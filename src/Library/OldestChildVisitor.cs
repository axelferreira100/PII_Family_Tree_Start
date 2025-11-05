namespace Library;

public class OldestChildVisitor : IVisitor<Person>
{
    private int _oldestChildAge = 0;

    public int OldestChildAge
    {
        get { return this._oldestChildAge; }
        private set { this._oldestChildAge = value; }
    }

    public void Visit(Person person)
    {
        if (person.Children.Count != 0)
        {
            foreach (Person child in person.Children)
            {
                this.Visit(child);
            }
        }
        else if (person.Age > this.OldestChildAge)
        {
            this.OldestChildAge = person.Age;
        }
    }
}