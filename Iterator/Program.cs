using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            Student studentA = new Student(18110278, "Nguyen Ngoc Hai", "Nam");
            Student studentB = new Student(18110289, "Tran Van Hoang", "Nam");
            Student studentC = new Student(18110298, "Ta Thi Mai Huong", "Nu");
            Student studentD = new Student(18110344, "Vo Tran Minh Quan", "Nam");

            var myCollection = new ConcreteAggregate();

            myCollection.AddItem(studentA);
            myCollection.AddItem(studentB);
            myCollection.AddItem(studentC);
            myCollection.AddItem(studentD);

            Console.WriteLine("Straight traversal:\n");

            foreach (Student student in myCollection)
            {
                student.printStudentInfo();
            }

            Console.WriteLine("\nReverse traversal:\n");

            myCollection.ReverseDirection();

            foreach (Student student in myCollection)
            {
                student.printStudentInfo();
            }
        }
    }
}
