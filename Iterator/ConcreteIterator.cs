using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _collection;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        private bool _reverse = false;

        public ConcreteIterator(ConcreteAggregate collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.getItems().Count;
            }
        }

        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return _collection.getItems()[_position];
        }


        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.getItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            
            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.getItems().Count - 1 : 0;
        }
    }
}
