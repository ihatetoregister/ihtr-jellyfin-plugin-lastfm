﻿namespace Jellyfin.Plugin.Lastfm.Models
{
    using System.Text.Json.Serialization;

    //Wow what a bad response object!
    public class Scrobbles
    {
        [JsonPropertyName("@attr")]
        public ScrobbleAttributes Attributes { get; set; }
    }

    public class ScrobbleAttributes
    {
        [JsonPropertyName("accepted")]
        public bool Accepted { get; set; }

        [JsonPropertyName("ignored")]
        public bool Ignored { get; set; }
    }
}
