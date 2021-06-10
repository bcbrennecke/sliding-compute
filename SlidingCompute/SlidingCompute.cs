using System.Collections.Generic;
using System.Linq;
namespace SlidingCompute
{
    public abstract class SlidingCompute<T>
    {
        
        protected List<T> _fifo;
        protected int _fifoLength;

        ///
        /// This class handles the overhead work of dealing with a FIFO when performing sliding compute problems
        /// To create another implementation, please inherit the SlidingCompute class with the appropriate types,
        /// and then override the SlidingComputeImpelementation() method with the new compute logic.
        /// See SlidingCompute/MovingAverage for an implmentation example.
        ///
        public abstract T[] SlidingComputeImplementation(int WindowSize, T[] ArrayVals);

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
            
            var implementationReturn = SlidingComputeImplementation(WindowSize, ArrayVals);
            return implementationReturn;
        }

        protected void fifoPush(T value)
        {
            _fifo.Add(value);
            if(_fifo.Count() > _fifoLength)
            {
                _fifo.RemoveAt(0);
            }
        }

    }
}