using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("zip")]
    public int zip { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("rate")]
    public double rate { get; set; }

    [JsonProperty("county")]
    public double county { get; set; }

    [JsonProperty("city")]
    public double city { get; set; }

    [JsonProperty("special")]
    public double special { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
