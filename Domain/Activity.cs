namespace Domain
{
    /// <summary>
    /// Activity Class
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Activity ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Activity title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Activity details
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Activity Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Activity category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Activity city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Activity venue
        /// </summary>
        public string Venue { get; set; }
    }
}