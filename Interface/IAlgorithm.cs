using System;
using System.Diagnostics;

namespace Logging.Interface
{
    /// <summary>      
    /// Provides templates for some algorithm calculating.      
    /// </summary>      
    public interface IAlgorithm
    {
        int Calculate(int first, int second);

        int Calculate(out long miliseconds, int first, int second)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int res = Calculate(first, second);
            stopwatch.Stop();
            miliseconds = stopwatch.ElapsedMilliseconds;
            return res;
        }
    }
}
