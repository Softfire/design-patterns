using System;

namespace ChainOfRepsonsibility.Processors
{
    public class MidLevelProcessor : Processor
    {
        /// <summary>
        /// Process Request.
        /// </summary>
        /// <param name="request">The request to process.</param>
        public override void ProcessRequest(Request request)
        {
            if (request.Cost < 50000.00d)
            {
                request.IsApproved = true;

                Console.WriteLine($"The request, {request.Title} ID:{request.Id}, was processed by the {nameof(MidLevelProcessor)}.{Environment.NewLine}" +
                                  $"Approved: {request.IsApproved}{Environment.NewLine}");
            }
            else if (BackupProcessor != null)
            {
                Console.WriteLine($"The request, {request.Title} ID:{request.Id}, is too costly to be approved by the {nameof(MidLevelProcessor)} and was passed to the backup processor.");

                BackupProcessor.ProcessRequest(request);
            }
        }
    }
}