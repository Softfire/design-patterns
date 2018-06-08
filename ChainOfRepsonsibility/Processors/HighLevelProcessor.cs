using System;

namespace ChainOfRepsonsibility.Processors
{
    public class HighLevelProcessor : Processor
    {
        /// <summary>
        /// Process Request.
        /// </summary>
        /// <param name="request">The request to process.</param>
        public override void ProcessRequest(Request request)
        {
            if (request.Cost < 25000000.00d)
            {
                request.IsApproved = true;

                Console.WriteLine($"The request, {request.Title} ID:{request.Id}, was processed by the {nameof(HighLevelProcessor)}.{Environment.NewLine}" +
                                  $"Approved: {request.IsApproved}{Environment.NewLine}");
            }
            else if (BackupProcessor != null)
            {
                Console.WriteLine($"The request, {request.Title} ID:{request.Id}, is too costly to be approved by the {nameof(HighLevelProcessor)} and was passed to the backup processor.");

                BackupProcessor.ProcessRequest(request);
            }
            else
            {
                Console.WriteLine($"The request, {request.Title} ID:{request.Id}, seems to have a very high cost and cannot be approved by a single processor.{Environment.NewLine}" +
                                  $"All right stop, collaborate and listen.");
            }
        }
    }
}