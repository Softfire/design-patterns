namespace ChainOfRepsonsibility
{
    /// <summary>
    /// Request.
    /// Used by processors.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Request Id.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Request Title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Request Cost.
        /// </summary>
        public double Cost { get; }

        /// <summary>
        /// Is Approved?
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Request.
        /// </summary>
        /// <param name="id">The request id. Intaken as an int.</param>
        /// <param name="title">The request title. Intaken as a string.</param>
        /// <param name="cost">the request's cost. Instaken as a double.</param>
        public Request(int id, string title, double cost)
        {
            Id = id;
            Title = title;
            Cost = cost;
        }
    }
}