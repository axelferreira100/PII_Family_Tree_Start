namespace Library;

public class LargestNameVisitor : IVisitor<Person>
{
    private string _largestName = "";

    public string LargestName
    {
        get { return this._largestName; }
        private set { this._largestName = value; }
    }

    public void Visit(Person person)
    {
        if (person.Name.Length > this.LargestName.Length)
        {
            this.LargestName = person.Name;
        }
    }
}