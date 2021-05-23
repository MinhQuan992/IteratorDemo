using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection collection;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int position = -1;

        private bool reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this.collection = collection;
            this.reverse = reverse;

            if (reverse)
            {
                this.position = collection.getItems().Count;
            }
        }

        public override int Key()
        {
            return this.position;
        }

        public override object Current()
        {
            return this.collection.getItems()[position];
        }


        public override bool MoveNext()
        {
            int updatedPosition = this.position + (this.reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            
            return false;
        }

        public override void Reset()
        {
            this.position = this.reverse ? this.collection.getItems().Count - 1 : 0;
        }
    }
}
