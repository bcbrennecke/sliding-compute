using System.Collections.Generic;
using System.Linq;

namespace SlidingCompute
{
    public class MovingAverage : SlidingCompute<double>
    {

        public override double[] SlidingComputeImplementation(int WindowSize, double[] ArrayVals)
        {
            var numArrayVals = ArrayVals.Count();
            var answer = new double[numArrayVals];
            for (int i = 0; i < numArrayVals; i++)
            {
                fifoPush(ArrayVals[i]);

                answer[i] = _fifo.Average();               
            }

            return answer;
        }
    }
}