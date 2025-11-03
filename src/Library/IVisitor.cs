namespace Library;

public interface IVisitor
{
    void Visit(Node node);
    void Visit(Person person);
}