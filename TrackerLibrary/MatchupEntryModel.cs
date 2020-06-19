namespace TrackerLibrary
{
    /// <summary>
    /// Class that instantiates a Matchup Entry
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the one team in the this matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score of this team in the mathcup
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this
        /// team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}