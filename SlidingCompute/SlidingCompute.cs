using System.Collections.Generic;
namespace SlidingCompute
{
    public abstract class SlidingCompute<T>
    {
        
        protected List<T> _fifo;

        public SlidingCompute()
        {
            _fifo = new List<T>();
        }
        public T[] Compute(int WindowSize, T[] ArrayVals)
        {
            _fifo = new List<T>();
            var a = SlidingComputeImplementation(WindowSize, ArrayVals);
            return a;
        }
        public abstract T[] SlidingComputeImplementation(int WindowSize, T[] ArrayVals);

    }
}