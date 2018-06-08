using System;
using System.Collections.Generic;
using ChainOfRepsonsibility.Processors;

namespace ChainOfRepsonsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create processors.
            var hLp = new HighLevelProcessor();
            var mLp = new MidLevelProcessor();
            var lLp = new LowLevelProcessor();

            // Set backup processors.
            lLp.SetBackupSuccessor(mLp);
            mLp.SetBackupSuccessor(hLp);

            var requests = new List<Request>
            {
                new Request(1, "An Apple", 1),
                new Request(2, "A Hot Tub", 6500),
                new Request(3, "A Boat.", 34000),
                new Request(4, "A House.", 450000),
                new Request(5, "An Asteroid", 10000000),
                new Request(6, "A Planet.", 890000000)
            };

            // Process requests starting from the lowest processor.
            foreach (var request in requests)
            {
                lLp.ProcessRequest(request);
            }

            // Pause... for effect.
            Console.ReadKey();
        }
    }
}