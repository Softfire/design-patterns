namespace ChainOfRepsonsibility
{
    /// <summary>
    /// Processor.
    /// Adds ability to process requests and provides access to a backup processor.
    /// </summary>
    public abstract class Processor
    {
        /// <summary>
        /// Backup Processor.
        /// </summary>
        protected Processor BackupProcessor { get; set; }
        
        /// <summary>
        /// Set Backup Processor.
        /// </summary>
        /// <param name="backupProcessor">This processor's backup processor.</param>
        public void SetBackupSuccessor(Processor backupProcessor)
        {
            BackupProcessor = backupProcessor;
        }

        /// <summary>
        /// Process Request.
        /// </summary>
        /// <param name="request">The request to process.</param>
        /// <remarks>Requests that are not able to be processed should be passed to the backup processor.</remarks>
        public abstract void ProcessRequest(Request request);
    }
}