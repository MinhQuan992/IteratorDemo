using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteAggregate : Aggregate
    {
        List<Student> _collection = new List<Student>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<Student> getItems()
        {
            return _collection;
        }

        public void AddItem(Student student)
        {
            _collection.Add(student);
        }

        public override object Current => throw new NotImplementedException();

        public override IEnumerator GetEnumerator()
        {
            return new ConcreteIterator(this, _direction);
        }

        public override bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
