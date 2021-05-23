using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class IteratorAggregate : IEnumerator
    {
        public abstract object Current { get; }

        // Returns an Iterator or another IteratorAggregate for the implementing
        // object.
        public abstract IEnumerator GetEnumerator();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}
