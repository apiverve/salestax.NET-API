using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public int Zip { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("county")]
        public double County { get; set; }

        [JsonProperty("city")]
        public double City { get; set; }

        [JsonProperty("special")]
        public double Special { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
