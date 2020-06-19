using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Class to instantiate a Team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents a group of persons on a team
        /// and creates a new List of Persons for a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the Team
        /// </summary>
        public string TeamName { get; set; }
    }
}
