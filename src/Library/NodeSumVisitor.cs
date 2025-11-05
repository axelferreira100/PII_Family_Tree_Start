namespace Library;

public class NodeSumVisitor : IVisitor<Person>
{
    private int _sum = 0;

    public int Sum
    {
        get { return this._sum; }
        private set { this._sum = value; }
    }

    public void Visit(Person person)
    {
        this.Sum += person.Age;
    }
}