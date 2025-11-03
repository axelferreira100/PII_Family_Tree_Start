namespace Library;

public class SumVisitor : IVisitor
{
    private int _numberSum = 0, _ageSum = 0;

    public int NumberSum
    {
        get { return this._numberSum; }
        private set { this._numberSum = value; }
    }

    public int AgeSum
    {
        get { return this._ageSum; }
        private set { this._ageSum = value; }
    }

    public void Visit(Node node)
    {
        this.NumberSum += node.Number;
    }

    public void Visit(Person person)
    {
        this.AgeSum += person.Age;
    }
}