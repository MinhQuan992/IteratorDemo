using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class WordsCollection : IteratorAggregate
    {
        List<string> collection = new List<string>();

        bool direction = false;

        public void ReverseDirection()
        {
            direction = !direction;
        }

        public List<string> getItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            this.collection.Add(item);
        }

        public override object Current => throw new NotImplementedException();

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, direction);
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
