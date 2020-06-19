using System;
namespace TrackerLibrary
{
    /// <summary>
    /// Class that instantiates a Person 
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the First name of this Person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the Last Name of this Person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the Email of this Person
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Represents the Cell Phone Number of this Person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
