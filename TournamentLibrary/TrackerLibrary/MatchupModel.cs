﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
        /// <summary>
        /// Represents one match in the tournament
        /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams the were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
