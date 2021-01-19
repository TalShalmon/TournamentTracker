using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary.Models
{
    /// <summary>
    /// Represent one team in a matchup
    /// </summary>

    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the matchup entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the team.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for this particular team
        /// </summary>
        public double score { get; set; }

        /// <summary>
        /// The unique identifier for the parent matchup (team)
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// represent the matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel parentMatchup { get; set; }
    }
}
