using System.Collections.Generic;
using System.Linq;
namespace SlidingCompute
{
    public abstract class SlidingCompute<T>
    {
        
        protected List<T> _fifo;
        protected int _fifoLength;

        private void initializeFifo(int fifoLength)
        {
 
            _fifoLength = fifoLength;
            _fifo = new List<T>();
        }
        public T[] Compute(int WindowSize, T[] ArrayVals)
        {
            if(WindowSize < 1)
            {
                throw new System.Exception("Window Size may not be less than 1!");
            }
            initializeFifo(WindowSize);
            
            var a = SlidingComputeImplementation(WindowSize, ArrayVals);
            return a;
        }

        protected void fifoPush(T value)
        {
            _fifo.Add(value);
            if(_fifo.Count() > _fifoLength)
            {
                _fifo.RemoveAt(0);
            }
        }

        public abstract T[] SlidingComputeImplementation(int WindowSize, T[] ArrayVals);

    }
}