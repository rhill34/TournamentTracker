using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Class to instantiate a Matchup
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entries of this Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of this Matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the Round of this Matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
