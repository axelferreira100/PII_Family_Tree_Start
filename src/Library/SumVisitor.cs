namespace Library;

public class SumVisitor: IVisitor
{
    private int _sum = 0;

    public int Sum
    {
        get { return this._sum; }
        private set { this._sum = value; }
    }

    public void Visit(Node node)
    {
        this.Sum += node.Number;
    }
}
