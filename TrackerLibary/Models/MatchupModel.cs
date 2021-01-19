using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary.Models
{
    /// <summary>
    /// Represent one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that where involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The id from the database that will be used to identify the winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
