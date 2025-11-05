namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    private int _number;
    private List<Node> _children = new List<Node>();

    public int Number {
        get { return this._number; }
        private set { this._number = value; }
    }

    public ReadOnlyCollection<Node> Children {
        get { return this._children.AsReadOnly(); }
    }

    public Node(int number)
    {
        this.Number = number;
    }

    public void AddChildren(Node node)
    {
        this._children.Add(node);
    }
    
    public void Accept(IVisitor<Node> visitor)
    {
        visitor.Visit(this);
        
        foreach (var item in this._children)
        {
            item.Accept(visitor);
        }
    }
}