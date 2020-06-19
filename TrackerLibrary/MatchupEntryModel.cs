namespace TrackerLibrary
{
    /// <summary>
    /// Class that instantiates a Matchup Entry
    /// </summary>
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public object MyProperty { get; set; }
    }
}