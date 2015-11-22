﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWebAPI2.Models.DOTA2
{
    public class LiveLeagueGameTeamRadiantInfo
    {
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }
        [JsonProperty(PropertyName = "team_id")]
        public int TeamId { get; set; }
        [JsonProperty(PropertyName = "team_logo")]
        public long TeamLogo { get; set; }
        public bool Complete { get; set; }
    }
}