using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Student
    {
        private int _id;
        private string _name;
        private string _sex;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }

        public Student(int id, string name, string sex)
        {
            Id = id;
            Name = name;
            Sex = sex;
        }

        public void printStudentInfo()
        {
            Console.WriteLine("MSSV: {0}\tHo va ten: {1}\t Gioi tinh: {2}\n", Id, Name, Sex);
        }
    }
}
