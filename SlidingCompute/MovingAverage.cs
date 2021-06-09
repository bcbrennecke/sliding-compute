using System.Collections.Generic;
using System.Linq;

namespace SlidingCompute
{
    public class MovingAverage : SlidingCompute<double>
    {


        public override double[] SlidingComputeImplementation(int WindowSize, double[] ArrayVals)
        {

            
            var answer = new double[ArrayVals.Count()];
            for (int i = 0; i < ArrayVals.Count(); i++)
            {
                fifoPush(ArrayVals[i]);

                answer[i] = _fifo.Average();               
            }


            return answer;
        }
    }
}