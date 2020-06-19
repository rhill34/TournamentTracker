namespace TrackerLibrary
{
    /// <summary>
    /// Class that instantiates a Prize 
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the Place number for this Prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the Place name for this Place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the Prize amount for this Prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the Prize percentage for this Prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
