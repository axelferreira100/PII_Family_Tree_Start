using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.NumberSum);
            
            Person p1 = new Person("p1", 80);
            Person p2 = new Person("p2", 58);
            Person p3 = new Person("p3", 55);
            Person p4 = new Person("p4", 22);
            Person p5 = new Person("p5", 18);
            Person p6 = new Person("p6", 20);
            Person p7 = new Person("p7", 19);
            
            p1.AddChildren(p2);
            p1.AddChildren(p3);

            p2.AddChildren(p4);
            p2.AddChildren(p5);

            p3.AddChildren(p6);
            p3.AddChildren(p7);

            SumVisitor visitor2 = new SumVisitor();
            p1.Accept(visitor2);
            Console.WriteLine(visitor2.AgeSum);
        }
    }
}