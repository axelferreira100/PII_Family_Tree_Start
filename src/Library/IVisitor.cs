namespace Library;

public interface IVisitor<T>
{
    int Sum { get; }
    void Visit(T node);
}