using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Class that instantiates a Tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Name of this Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee for this Tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the List of entered Teams of this Tournament
        /// and creates a new List for Teams 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the List of Prizes for this Tournament
        /// and creates a new List for the Prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the list of listed Matchup for this Tournament
        /// and creates a new List of Listed Matchup
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
