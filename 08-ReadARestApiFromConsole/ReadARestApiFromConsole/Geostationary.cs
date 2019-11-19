using Newtonsoft.Json;

//Geo
//making sure to put in verbose properties and then using JsonPropety to bind
public class Geostationary{
    [JsonProperty(PropertyName = "lat")]
    public double Latitude { get; set; }
    [JsonProperty(PropertyName = "lng")]
    public double Longitude { get; set; }
}