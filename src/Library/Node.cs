namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node<T>
{
    private T _value;
    private List<Node<T>> _children = new List<Node<T>>();

    public T Value
    {
        get { return this._value; }
        private set { this._value = value; }
    }

    public ReadOnlyCollection<Node<T>> Children {
        get { return this._children.AsReadOnly(); }
    }
    
    public Node(T value)
    {
        this.Value = value;
    }

    public void AddChildren(Node<T> node)
    {
        this._children.Add(node);
    }
    
    private bool IsLeaf()
    {
        return this.Children.Count == 0;
    }
    
    public void Accept(IVisitor<T> visitor, bool withOnlyLeaves)
    {
        if (withOnlyLeaves)
        {
            if (this.IsLeaf())
            {
                visitor.Visit(this.Value);
            }
        }
        else
        {
            visitor.Visit(this.Value);
        }
        
        foreach (Node<T> item in this._children)
        {
            item.Accept(visitor, withOnlyLeaves);
        }
    }
}