using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Abuelo", 80);
            Person p2 = new Person("Padre", 58);
            Person p3 = new Person("Madre", 55);
            Person p4 = new Person("Nieto", 22);
            Person p5 = new Person("Nieto Pedro", 18);
            Person p6 = new Person("p6", 20);
            Person p7 = new Person("p7", 19);
            
            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p2);
            Node<Person> n3 = new Node<Person>(p3);
            Node<Person> n4 = new Node<Person>(p4);
            Node<Person> n5 = new Node<Person>(p5);
            Node<Person> n6 = new Node<Person>(p6);
            Node<Person> n7 = new Node<Person>(p7);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            
            AgeSumVisitor visitor2 = new AgeSumVisitor();
            n1.Accept(visitor2, false);
            Console.WriteLine(visitor2.Sum);

            OldestChildVisitor visitor3 = new OldestChildVisitor();
            n1.Accept(visitor3, true);
            Console.WriteLine(visitor3.OldestChildAge);

            LargestNameVisitor visitor4 = new LargestNameVisitor();
            n1.Accept(visitor4, false);
            Console.WriteLine(visitor4.LargestName);
        }
    }
}